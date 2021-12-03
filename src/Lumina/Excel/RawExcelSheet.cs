using System.Collections;
using System.Collections.Generic;
using Lumina.Data;
using Lumina.Data.Files.Excel;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel
{
    public class RawExcelSheet : ExcelSheetImpl, IEnumerable< RowParser >
    {
        internal RawExcelSheet( ExcelHeaderFile headerFile, string name, Language requestedLanguage, GameData gameData ) : 
            base( headerFile, name, requestedLanguage, gameData )
        {
        }

        public RowParser? GetRow( uint rowId )
        {
            var page = GetPageForRow( rowId );
            if( page == null )
            {
                return null;
            }

            return new RowParser( this, page.File, rowId );
        }
        
        public RowParser? GetRow( uint rowId, uint subRowId )
        {
            var page = GetPageForRow( rowId );
            if( page == null )
            {
                return null;
            }

            return new RowParser( this, page.File, rowId, subRowId );
        }

        public IEnumerator< RowParser > GetEnumerator()
        {
            ExcelDataFile file = null!;
            RowParser parser = null!;
            
            foreach( var offset in GetRowDataOffsets() )
            {
                var rowPtr = offset.RowOffset;
                if( file != offset.SheetPage )
                {
                    parser = new RowParser( this, offset.SheetPage );
                }

                if( Header.Variant == ExcelVariant.Subrows )
                {
                    // required to read the row header out and know how many subrows there is
                    parser.SeekToRow( rowPtr.RowId );
                        
                    // read subrows
                    for( uint i = 0; i < parser.RowCount; i++ )
                    {
                        parser.SeekToRow( rowPtr.RowId, i );
                        yield return parser;
                    }
                }
                else
                {
                    parser.SeekToRow( rowPtr.RowId );

                    yield return parser;
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}