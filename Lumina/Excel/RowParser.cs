using System;
using System.Buffers.Binary;
using System.Collections.Generic;
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

        private readonly ExcelDataOffset _Offset;
        private readonly ExcelDataRowHeader _RowHeader;
        
        private long _RowOffset;

        public readonly int Row;
        public readonly int SubRow;
        public int RowCount => _RowHeader.RowCount;

        public RowParser( ExcelSheetImpl sheet, ExcelDataFile dataFile, int row )
        {
            _Sheet = sheet;
            _DataFile = dataFile;
            Row = row;

            _Offset = _DataFile.RowData[ Row ];

            var stream = _DataFile.FileStream;
            var br = _DataFile.Reader;

            stream.Position = _Offset.Offset;

            _RowHeader = br.ReadStructure< ExcelDataRowHeader >();

            if( BitConverter.IsLittleEndian )
            {
                _RowHeader.DataSize = BinaryPrimitives.ReverseEndianness( _RowHeader.DataSize );
                _RowHeader.RowCount = BinaryPrimitives.ReverseEndianness( _RowHeader.RowCount );
            }

            // header is 6 bytes large, data normally starts here except in the case of variant 2 sheets but we'll keep it anyway
            _RowOffset = _Offset.Offset + 6;
        }

        public RowParser( ExcelSheetImpl sheet, ExcelDataFile dataFile, int row, int subRow )
            : this( sheet, dataFile, row )
        {
            SubRow = subRow;

            if( subRow > _RowHeader.RowCount )
            {
                throw new IndexOutOfRangeException( $"subrow {subRow} > {_RowHeader.RowCount}!" );
            }

            _RowOffset = CalculateSubRowOffset( subRow );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public long CalculateSubRowOffset( int subRow )
        {
            return _Offset.Offset + 6 + ( subRow * _Sheet.Header.DataOffset + 2 * ( subRow + 1 ) );
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
                    var stringOffset = BinaryPrimitives.ReadUInt32BigEndian( br.ReadBytes( Unsafe.SizeOf< UInt32 >() ) );
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
                    data = BinaryPrimitives.ReadInt16BigEndian( br.ReadBytes( Unsafe.SizeOf< Int16 >() ) );
                    break;
                }
                case ExcelColumnDataType.UInt16:
                {
                    data = BinaryPrimitives.ReadUInt16BigEndian( br.ReadBytes( Unsafe.SizeOf< UInt16 >() ) );
                    break;
                }
                case ExcelColumnDataType.Int32:
                {
                    data = BinaryPrimitives.ReadInt32BigEndian( br.ReadBytes( Unsafe.SizeOf< Int32 >() ) );
                    break;
                }
                case ExcelColumnDataType.UInt32:
                {
                    data = BinaryPrimitives.ReadUInt32BigEndian( br.ReadBytes( Unsafe.SizeOf< UInt32 >() ) );
                    break;
                }
                // case ExcelColumnDataType.Unk:
                // break;
                case ExcelColumnDataType.Float32:
                {
                    data = BitConverter.Int32BitsToSingle( BinaryPrimitives.ReadInt32BigEndian( br.ReadBytes( Unsafe.SizeOf< float >() ) ) );
                    break;
                }
                case ExcelColumnDataType.Int64:
                {
                    data = BinaryPrimitives.ReadInt64BigEndian( br.ReadBytes( Unsafe.SizeOf< Int64 >() ) );
                    break;
                }
                case ExcelColumnDataType.UInt64:
                {
                    data = BinaryPrimitives.ReadUInt64BigEndian( br.ReadBytes( Unsafe.SizeOf< UInt64 >() ) );
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

            return (T)data;
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

        public T ReadOffset< T >( int offset, byte bit = 0 )
        {
            var stream = _DataFile.FileStream;
            var br = _DataFile.Reader;

            stream.Position = _RowOffset + offset;

            if( bit > 0 )
            {
                var pos = GetBitPosition( bit );
                var flag = ExcelColumnDataType.PackedBool0 + pos;

                return ReadField< T >( flag );
            }

            var col = _Sheet.Columns.First( c => c.Offset == offset );
            return ReadField< T >( col.Type );
        }

        public T ReadColumn< T >( int column )
        {
            var col = _Sheet.Columns[ column ];
            var stream = _DataFile.FileStream;

            stream.Position = _RowOffset + col.Offset;

            return ReadField< T >( col.Type );
        }
    }
}