using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Lumina.Data;
using Lumina.Data.Files.Excel;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel
{
    public class ExcelSheet< T > : ExcelSheetImpl, IEnumerable< T > where T : class, IExcelRow
    {
        private readonly Dictionary< UInt64, T > _rowCache = new Dictionary< UInt64, T >();

        public ExcelSheet( ExcelHeaderFile headerFile, string name, Language requestedLanguage, Lumina lumina ) :
            base( headerFile, name, requestedLanguage, lumina )
        {
        }

        public T GetRow( uint row )
        {
            return GetRow( row, UInt32.MaxValue );
        }

        public T GetRow( uint row, uint subRow )
        {
            return GetRowInternal( row, subRow );
        }

        internal ExcelPage GetPageForRow( uint row )
        {
            var data = DataPages.FirstOrDefault( s => s.RowData.ContainsKey( row ) );

            // if( data == null )
            // {
            //     throw new KeyNotFoundException( $"row {row} not found in sheet {Name}!" );
            // }

            return data;
        }
        
        internal T GetRowInternal( uint row, uint subRow )
        {
            var cacheKey = GetCacheKey( row, subRow );

            if( _rowCache.TryGetValue( cacheKey, out var cachedRow ) )
            {
                return cachedRow;
            }
            
            var data = GetPageForRow( row );

            if( data == null )
            {
                return null;
            }

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

            rowObj.PopulateData( parser, _Lumina, RequestedLanguage );
            
            _rowCache[ cacheKey ] = rowObj;

            return rowObj;
        }

        private static UInt64 GetCacheKey( uint rowId, uint subrowId = UInt32.MaxValue )
        {
            return (UInt64)rowId << 32 | subrowId;
        }

        private T ReadRowObj( RowParser parser, uint rowId )
        {
            parser.SeekToRow( rowId );
            
            var obj = Activator.CreateInstance< T >();
                        
            obj.PopulateData( parser, _Lumina, RequestedLanguage );

            return obj;
        }

        private T ReadSubRowObj( RowParser parser, uint rowId, uint subRowId )
        {
            parser.SeekToRow( rowId, subRowId );
            var obj = Activator.CreateInstance< T >();

            obj.PopulateData( parser, _Lumina, RequestedLanguage );

            return obj;
        }

        [Obsolete("Use the ExcelSheet< T > enumerator or sheet.ToList()")]
        public List< T > GetRows()
        {
            return this.ToList();
        }

        public IEnumerator< T > GetEnumerator()
        {
            foreach( var page in DataPages )
            {
                var file = page.File;
                var rowPtrs = file.RowData;

                var parser = new RowParser( this, file );

                foreach( var rowPtr in rowPtrs.Values )
                {
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
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}