using System;
using System.Collections.Generic;
using System.Linq;
using Lumina.Data;
using Lumina.Data.Files.Excel;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel
{
    public class ExcelSheet< T > : ExcelSheetImpl where T : IExcelRow
    {
        public ExcelSheet() : base()
        {
        }

        public ExcelSheet( ExcelHeaderFile headerFile, string name ) :
            base( headerFile, name )
        {
        }

        public ExcelSheet( ExcelHeaderFile headerFile, string name, Lumina lumina ) :
            base( headerFile, name, lumina )
        {
        }

        public T GetRow( int row )
        {
            return GetRow( row, Lumina.Options.DefaultExcelLanguage );
        }

        public T GetRow( int row, int subRow )
        {
            return GetRowInternal( row, subRow, Lumina.Options.DefaultExcelLanguage );
        }

        public T GetRow( int row, Language lang )
        {
            return GetRowInternal( row, Int32.MaxValue, lang );
        }

        internal T GetRowInternal( int row, int subRow, Language lang )
        {
            var segments = GetLangSegments( lang );

            var data = segments.FirstOrDefault( s => row >= s.StartId && row < s.StartId + s.RowCount );

            if( data == null )
            {
                throw new KeyNotFoundException( $"row {row} not found in sheet {Name}!" );
            }

            var rowObj = Activator.CreateInstance< T >();

            RowParser parser;

            if( subRow != Int32.MaxValue )
            {
                parser = new RowParser( this, data.File, row, subRow );
            }
            else
            {
                parser = new RowParser( this, data.File, row );
            }

            rowObj.PopulateData( parser );

            return rowObj;
        }

        public List< T > GetRows()
        {
            return GetRows( Lumina.Options.DefaultExcelLanguage );
        }

        public List< T > GetRows( Language lang )
        {
            var rows = new List< T >();
            var segments = GetLangSegments( lang );

            foreach( var segment in segments )
            {
                var file = segment.File;
                var rowPtrs = file.RowData;

                var parser = new RowParser( this, file );

                foreach( var rowPtr in rowPtrs )
                {
                    parser.SeekToRow( (int)rowPtr.RowId );

                    if( Header.Variant == ExcelVariant.Subrows )
                    {
                        // read subrows
                        for( int i = 0; i < parser.RowCount; i++ )
                        {
                            parser.SeekToRow( (int)rowPtr.RowId, i );
                            var obj = Activator.CreateInstance< T >();

                            obj.PopulateData( parser );

                            rows.Add( obj );
                        }
                    }
                    else
                    {
                        parser.SeekToRow( (int)rowPtr.RowId );
                        var obj = Activator.CreateInstance< T >();
                        
                        obj.PopulateData( parser );

                        rows.Add( obj );
                    }
                }
            }

            return rows;
        }
    }
}