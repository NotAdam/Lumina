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
        // protected Dictionary< Tuple< int, int >, T > RowCache = new Dictionary< Tuple< int, int >, T >();
        
        public ExcelSheet() : base()
        {
        }

        public ExcelSheet( ExcelHeaderFile headerFile, string name ) :
            base( headerFile, name )
        {
        }

        public ExcelSheet( ExcelHeaderFile headerFile, string name, Language requestedLanguage ) :
            base( headerFile, name, requestedLanguage )
        {
            
        }

        public ExcelSheet( ExcelHeaderFile headerFile, string name, Language requestedLanguage, Lumina lumina ) :
            base( headerFile, name, requestedLanguage, lumina )
        {
        }

        public T GetRow( uint row )
        {
            return GetRow( row, _Lumina.Options.DefaultExcelLanguage );
        }

        public T GetRow( uint row, uint subRow )
        {
            return GetRowInternal( row, subRow );
        }

        public T GetRow( uint row, Language lang )
        {
            return GetRowInternal( row, UInt32.MaxValue );
        }

        internal ExcelPage GetSegmentForRow( uint row )
        {
            var data = DataPages.FirstOrDefault( s => s.RowData.ContainsKey( (uint)row ) );

            if( data == null )
            {
                throw new KeyNotFoundException( $"row {row} not found in sheet {Name}!" );
            }

            return data;
        }
        
        public RowParser GetRowParser( uint row )
        {
            var data = GetSegmentForRow( row );
            
            return new RowParser( this, data.File, row );
        }

        internal T GetRowInternal( uint row, uint subRow )
        {
            // var id = GetRowCacheKey( row, subRow );

            // if( RowCache.TryGetValue( id, out var cachedRow ) )
            // {
                // return cachedRow;
            // }
            
            var data = GetSegmentForRow( row );

            var rowObj = Activator.CreateInstance< T >();

            RowParser parser;

            if( subRow != UInt32.MaxValue )
            {
                parser = new RowParser( this, data.File, row, subRow );
            }
            else
            {
                parser = new RowParser( this, data.File, row );
            }

            rowObj.PopulateData( parser, _Lumina );
            
            // RowCache[ id ] = rowObj;

            return rowObj;
        }

        // private Tuple< int, int > GetRowCacheKey( int row )
        // {
        //     return GetRowCacheKey( row, 0 );
        // }
        //
        // private Tuple< int, int > GetRowCacheKey( int row, int subRow )
        // {
        //     return Tuple.Create( row, subRow );
        // }

        public List< T > GetRows()
        {
            var rows = new List< T >();

            foreach( var page in DataPages )
            {
                var file = page.File;
                var rowPtrs = file.RowData;

                var parser = new RowParser( this, file );

                foreach( var rowPtr in rowPtrs.Values )
                {
                    parser.SeekToRow( rowPtr.RowId );

                    if( Header.Variant == ExcelVariant.Subrows )
                    {
                        // read subrows
                        for( uint i = 0; i < parser.RowCount; i++ )
                        {
                            // var id = GetRowCacheKey( (int)rowPtr.RowId, i );

                            // if( RowCache.TryGetValue( id, out var cachedRow ) )
                            // {
                            //     rows.Add( cachedRow );
                            //     continue;
                            // }

                            parser.SeekToRow( rowPtr.RowId, i );
                            var obj = Activator.CreateInstance< T >();

                            obj.PopulateData( parser, _Lumina );

                            rows.Add( obj );
                        }
                    }
                    else
                    {
                        // var id = GetRowCacheKey( (int)rowPtr.RowId );

                        // if( RowCache.TryGetValue( id, out var cachedRow ) )
                        // {
                        //     rows.Add( cachedRow );
                        //     continue;
                        // }
                        
                        parser.SeekToRow( rowPtr.RowId );
                        var obj = Activator.CreateInstance< T >();
                        
                        obj.PopulateData( parser, _Lumina );

                        rows.Add( obj );
                    }
                }
            }

            return rows;
        }
    }
}