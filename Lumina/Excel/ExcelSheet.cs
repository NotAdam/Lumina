using System;
using System.Collections.Generic;
using System.Linq;
using Lumina.Data;
using Lumina.Data.Files.Excel;

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
        
        public T GetRow( uint row )
        {
            return GetRow( row, Lumina.Options.DefaultExcelLanguage );
        }

        public T GetRow( uint row, Language lang )
        {
            var segments = GetLangSegments( lang );

            var data = segments.FirstOrDefault( s => row >= s.StartId && row < s.StartId + s.RowCount );

            if( data == null )
            {
                throw new KeyNotFoundException( $"row {row} not found in sheet {Name}!" );
            }

            var rowObj = Activator.CreateInstance< T >();
            var parser = new RowParser( this, data.File, row );

            rowObj.PopulateData( parser );

            return rowObj;
        }
    }
}