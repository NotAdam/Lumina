using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Lumina.Data;
using Lumina.Data.Files.Excel;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel
{
    public class ExcelSheet< T > : ExcelSheetImpl, IEnumerable< T > where T : ExcelRow
    {
        private readonly Dictionary< UInt64, T > _rowCache = new Dictionary< UInt64, T >();

        public ExcelSheet( ExcelHeaderFile headerFile, string name, Language requestedLanguage, GameData gameData ) :
            base( headerFile, name, requestedLanguage, gameData )
        {
        }

        public T? GetRow( uint row )
        {
            return GetRow( row, UInt32.MaxValue );
        }

        public T? GetRow( uint row, uint subRow )
        {
            return GetRowInternal( row, subRow );
        }

        internal T? GetRowInternal( uint row, uint subRow )
        {
            var cacheKey = GetCacheKey( row, subRow );

            if( _rowCache.TryGetValue( cacheKey, out var cachedRow ) )
            {
                return cachedRow;
            }

            var parser = GetRowParser( row, subRow );
            if( parser == null )
            {
                return null;
            }
            
            var rowObj = Activator.CreateInstance< T >();
            rowObj.PopulateData( parser, GameData, RequestedLanguage );

            _rowCache[ cacheKey ] = rowObj;

            return rowObj;
        }

        private T ReadRowObj( RowParser parser, uint rowId )
        {
            parser.SeekToRow( rowId );
            
            var obj = Activator.CreateInstance< T >();
                        
            obj.PopulateData( parser, GameData, RequestedLanguage );

            return obj;
        }

        private T ReadSubRowObj( RowParser parser, uint rowId, uint subRowId )
        {
            parser.SeekToRow( rowId, subRowId );
            var obj = Activator.CreateInstance< T >();

            obj.PopulateData( parser, GameData, RequestedLanguage );

            return obj;
        }
        
        public IEnumerator< T > GetEnumerator()
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
                        var cacheKey = GetCacheKey( rowPtr.RowId, i );
                        if( _rowCache.TryGetValue( cacheKey, out var cachedRow ) )
                        {
                            yield return cachedRow;
                            continue;
                        }

                        var obj = ReadSubRowObj( parser, rowPtr.RowId, i );
                        _rowCache.Add( cacheKey, obj );
                        yield return obj;
                    }
                }
                else
                {
                    var cacheKey = GetCacheKey( rowPtr.RowId );
                    if( _rowCache.TryGetValue( cacheKey, out var cachedRow ) )
                    {
                        yield return cachedRow;
                        continue;
                    }
                        
                    var obj = ReadRowObj( parser, rowPtr.RowId );
                    _rowCache.Add( cacheKey, obj );
                    yield return obj;
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}