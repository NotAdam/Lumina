using System;
using System.Buffers.Binary;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using Lumina.Data.Files.Excel;
using Lumina.Data.Structs.Excel;
using Lumina.Extensions;

namespace Lumina.Excel
{
    public class RowParser
    {
        private readonly ExcelSheetImpl _Sheet;
        private readonly ExcelDataFile _DataFile;

        private ExcelDataOffset _Offset;
        private ExcelDataRowHeader _RowHeader;
        
        private long _RowOffset;

        public uint Row;
        public uint SubRow;
        public uint RowCount => _RowHeader.RowCount;

        private MemoryStream Stream => _DataFile.FileStream;
        
        public RowParser( ExcelSheetImpl sheet, ExcelDataFile dataFile )
        {
            _Sheet = sheet;
            _DataFile = dataFile;
        }

        public RowParser( ExcelSheetImpl sheet, ExcelDataFile dataFile, uint row )
            : this( sheet, dataFile )
        {
            SeekToRow( row );
        }

        public RowParser( ExcelSheetImpl sheet, ExcelDataFile dataFile, uint row, uint subRow )
            : this( sheet, dataFile, row )
        {
            SeekToRow( row, subRow );
        }

        public void SeekToRow( uint row )
        {
            Row = row;
            _Offset = _DataFile.RowData[ Row ];

            var br = _DataFile.Reader;

            Stream.Position = _Offset.Offset;

            _RowHeader = br.ReadStructure< ExcelDataRowHeader >();

            if( BitConverter.IsLittleEndian )
            {
                _RowHeader.DataSize = BinaryPrimitives.ReverseEndianness( _RowHeader.DataSize );
                _RowHeader.RowCount = BinaryPrimitives.ReverseEndianness( _RowHeader.RowCount );
            }

            // header is 6 bytes large, data normally starts here except in the case of variant 2 sheets but we'll keep it anyway
            _RowOffset = _Offset.Offset + 6;
        }

        public void SeekToRow( uint row, uint subRow )
        {
            SeekToRow( row );
            
            SubRow = subRow;

            if( subRow > _RowHeader.RowCount )
            {
                throw new IndexOutOfRangeException( $"subrow {subRow} > {_RowHeader.RowCount}!" );
            }

            _RowOffset = CalculateSubRowOffset( subRow );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public long CalculateSubRowOffset( uint subRow )
        {
            return _Offset.Offset + 6 + ( subRow * _Sheet.Header.DataOffset + 2 * ( subRow + 1 ) );
        }

        public byte[] ReadBytes( int offset, int count )
        {
            var br = _DataFile.Reader;
            
            Stream.Position = _RowOffset + offset;

            return br.ReadBytes( count );
        }

        public T ReadStructure< T >( int offset ) where T : struct
        {
            var br = _DataFile.Reader;
            
            Stream.Position = _RowOffset + offset;

            return br.ReadStructure< T >();
        }
        
        public List< T > ReadStructures< T >( int offset, int count ) where T : struct
        {
            var br = _DataFile.Reader;
            
            Stream.Position = _RowOffset + offset;

            return br.ReadStructures< T >( count );
        }
        
        public T[] ReadStructuresAsArray< T >( int offset, int count ) where T : struct
        {
            var br = _DataFile.Reader;
            
            Stream.Position = _RowOffset + offset;

            return br.ReadStructuresAsArray< T >( count );
        }

        private T ReadField< T >( ExcelColumnDataType type )
        {
            var br = _DataFile.Reader;

            object data = null;

            switch( type )
            {
                case ExcelColumnDataType.String:
                {
                    var stringOffset = br.ReadUInt32();
                    data = br.ReadStringOffset( _RowOffset + _Sheet.Header.DataOffset + stringOffset );

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
                    data = br.ReadUInt64();
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
                    throw new ArgumentOutOfRangeException( "type", $"invalid excel column type: {type}" );
            }

            if( _Sheet._Lumina.Options.ExcelSheetStrictCastingEnabled )
            {
                return (T)data;
            }

            if( data is T castedData )
            {
                return castedData;
            }

            return default;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private byte GetBitPosition( byte flag )
        {
            byte count = 0;

            while( flag != 1 )
            {
                flag >>= 1;
                count++;
            }

            return count;
        }

        public T ReadOffset< T >( ushort offset, byte bit = 0 )
        {
            Stream.Position = _RowOffset + offset;

            if( bit > 0 )
            {
                var pos = GetBitPosition( bit );
                var flag = ExcelColumnDataType.PackedBool0 + pos;

                return ReadField< T >( flag );
            }

            return ReadField< T >( _Sheet.ColumnsByOffset[offset].Type );
        }

        public T ReadOffset< T >( int offset, ExcelColumnDataType type )
        {
            Stream.Position = _RowOffset + offset;
            
            return ReadField< T >( type );
        }

        public T ReadColumn< T >( int column )
        {
            var col = _Sheet.Columns[ column ];

            Stream.Position = _RowOffset + col.Offset;

            return ReadField< T >( col.Type );
        }
    }
}