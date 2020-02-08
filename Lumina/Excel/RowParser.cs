using System;
using System.Collections.Generic;
using Lumina.Data.Files.Excel;
using Lumina.Data.Structs.Excel;
using Lumina.Extensions;

namespace Lumina.Excel
{
    public class RowParser
    {
        private readonly ExcelSheetImpl  _Sheet;
        private readonly ExcelDataFile _DataFile;
        private readonly uint _Row;
        private readonly uint _SubRow;

        private readonly ExcelDataOffset _Offset;

        public RowParser( ExcelSheetImpl sheet, ExcelDataFile dataFile, uint row, uint subRow = uint.MaxValue )
        {
            _Sheet = sheet;
            _DataFile = dataFile;
            _Row = row;
            _SubRow = subRow;
            
            _Offset = _DataFile.RowData[ _Row ];
        }

        private T ReadField< T >( ExcelColumnDataType type )
        {
            var stream = _DataFile.FileStream;
            var br = _DataFile.Reader;

            object data = null;
            
            switch( type )
            {
                case ExcelColumnDataType.String:
                {
                    var stringOffset = br.ReadUInt32();
                    data = br.ReadStringOffset( _Offset.Offset + 6 + _Sheet.Header.DataOffset + stringOffset );

                    break;
                }
                case ExcelColumnDataType.Bool:
                {
                    data = br.ReadByte() != 0;
                    break;
                }
                case ExcelColumnDataType.Int8:
                {
                    data = br.ReadSByte();
                    break;
                }
                case ExcelColumnDataType.UInt8:
                {
                    data = br.ReadByte();
                    break;
                }
                case ExcelColumnDataType.Int16:
                {
                    data = br.ReadInt16();
                    break;
                }
                case ExcelColumnDataType.UInt16:
                {
                    data = br.ReadUInt16();
                    break;
                }
                case ExcelColumnDataType.Int32:
                {
                    data = br.ReadInt32();
                    break;
                }
                case ExcelColumnDataType.UInt32:
                {
                    data = br.ReadUInt32();
                    break;
                }
                // case ExcelColumnDataType.Unk:
                // break;
                case ExcelColumnDataType.Float32:
                {
                    data = br.ReadSingle();
                    break;
                }
                case ExcelColumnDataType.Int64:
                {
                    data = br.ReadInt64();
                    break;
                }
                case ExcelColumnDataType.UInt64:
                {
                    data = br.ReadUInt64();
                    break;
                }
                // case ExcelColumnDataType.Unk2:
                // break;
                case ExcelColumnDataType.PackedBool0:
                case ExcelColumnDataType.PackedBool1:
                case ExcelColumnDataType.PackedBool2:
                case ExcelColumnDataType.PackedBool3:
                case ExcelColumnDataType.PackedBool4:
                case ExcelColumnDataType.PackedBool5:
                case ExcelColumnDataType.PackedBool6:
                case ExcelColumnDataType.PackedBool7:
                {
                    var shift = (int)type - (int)ExcelColumnDataType.PackedBool0;
                    var bit = 1 << shift;

                    var rawData = br.ReadByte();

                    data = ( rawData & bit ) == bit;

                    break;
                }
                default:
                    throw new ArgumentOutOfRangeException();
            }

            return (T)data;
        }

        public T ReadOffset< T >( int offset, byte bit = 0 )
        {
            ExcelColumnDefinition col = default;
            int colId = -1;

            // todo: this is shite
            for( int i = 0; i < _Sheet.Columns.Length; i++ )
            {
                col = _Sheet.Columns[ i ];

                if( col.Offset != offset )
                    continue;
                
                colId = i;
                break;
            }
        
            if( colId == -1 )
            {
                throw new KeyNotFoundException( $"offset {offset:x8} in sheet {_Sheet.Name} doesn't match any columns!" );
            }
            
            return ReadColumn< T >( colId );
        }

        public T ReadColumn< T >( int column )
        {
            var col = _Sheet.Columns[ column ];
            var row = _DataFile.RowData[ _Row ];

            var stream = _DataFile.FileStream;
            var br = _DataFile.Reader;

            stream.Position = row.Offset + 6 + col.Offset;

            return ReadField< T >( col.Type );
        }
    }
}