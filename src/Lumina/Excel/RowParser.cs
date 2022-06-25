using System;
using System.Buffers.Binary;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using Lumina.Data.Files.Excel;
using Lumina.Data.Structs.Excel;
using Lumina.Extensions;
using Lumina.Text;

namespace Lumina.Excel
{
    public class RowParser
    {
        private readonly ExcelSheetImpl _sheet;
        private readonly Dictionary< uint, ExcelDataOffset > _rowData;
        private readonly BinaryReader _reader;

        private ExcelDataOffset _offset;
        private ExcelDataRowHeader _rowHeader;

        private long _rowOffset;

        public uint RowId;
        public uint SubRowId;
        public uint RowCount => _rowHeader.RowCount;


        /// <summary>
        /// Provides access to the base data generated for a sheet
        /// </summary>
        public ExcelSheetImpl Sheet => _sheet;

        public RowParser( ExcelSheetImpl sheet, ExcelDataFile dataFile )
        {
            _sheet = sheet;
            _rowData = dataFile.RowData;
            _reader = new BinaryReader( new MemoryStream( dataFile.Data, false ) );
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

        /// <summary>
        /// Moves the parser to a row in the current page given its index
        /// </summary>
        /// <param name="row">The row index to seek to</param>
        /// /// <exception cref="IndexOutOfRangeException">Given row index was out of bounds</exception>
        public void SeekToRow( uint row )
        {
            if( !TrySeekToRow( row ) )
            {
                throw new IndexOutOfRangeException( $"the row {row} could not be found in the sheet!" );
            }
        }
        
        /// <summary>
        /// Moves the parser to a row in the current page given its index
        /// </summary>
        /// <param name="row">The row index to seek to</param>
        /// <returns>true if the row was seeked to successfully, false if the row wasn't found or otherwise</returns>
        public bool TrySeekToRow( uint row )
        {
            RowId = row;

            if( !_rowData.TryGetValue( RowId, out var offset ) )
            {
                return false;
            }

            _offset = offset;
            
            _reader.BaseStream.Position = _offset.Offset;

            _rowHeader = _reader.ReadStructure< ExcelDataRowHeader >();

            if( BitConverter.IsLittleEndian )
            {
                _rowHeader.DataSize = BinaryPrimitives.ReverseEndianness( _rowHeader.DataSize );
                _rowHeader.RowCount = BinaryPrimitives.ReverseEndianness( _rowHeader.RowCount );
            }

            // header is 6 bytes large, data normally starts here except in the case of variant 2 sheets but we'll keep it anyway
            _rowOffset = _offset.Offset + 6;

            return true;
        }

        /// <summary>
        /// Moves the parser to a row + subrow in the current page given their indexes
        /// </summary>
        /// <param name="row">The row index to seek to</param>
        /// <param name="subRow">The subrow index to seek to</param>
        /// <exception cref="IndexOutOfRangeException">Given subrow index was out of bounds</exception>
        public void SeekToRow( uint row, uint subRow )
        {
            if( !TrySeekToRow( row, subRow ) )
            {
                throw new IndexOutOfRangeException( $"subrow {subRow} > {_rowHeader.RowCount}!" );
            }
        }

        /// <summary>
        /// Moves the parser to a row + subrow in the current page given their indexes
        /// </summary>
        /// <param name="row">The row index to seek to</param>
        /// <param name="subRow">The subrow index to seek to</param>
        /// /// <returns>true if the row and subrow was seeked to successfully, false if the row or subrow wasn't found or otherwise</returns>
        public bool TrySeekToRow( uint row, uint subRow )
        {
            if( !TrySeekToRow( row ) )
            {
                return false;
            }
            
            SubRowId = subRow;
            
            if( subRow > _rowHeader.RowCount )
            {
                return false;
            }
            
            _rowOffset = CalculateSubRowOffset( subRow );

            return true;
        }

        [MethodImpl( MethodImplOptions.AggressiveInlining )]
        public long CalculateSubRowOffset( uint subRow )
        {
            // +6 is the ExcelDataRowHeader
            return _offset.Offset + 6 + ( subRow * _sheet.Header.DataOffset + 2 * ( subRow + 1 ) );
        }

        /// <summary>
        /// Read n bytes starting from the row offset + offset
        /// </summary>
        /// <param name="offset">The offset inside the row</param>
        /// <param name="count">The number of bytes to read</param>
        /// <returns>A copy of the read bytes</returns>
        public byte[] ReadBytes( int offset, int count )
        {
            _reader.BaseStream.Position = _rowOffset + offset;

            return _reader.ReadBytes( count );
        }

        /// <summary>
        /// Reads a structure from an offset inside the current row
        /// </summary>
        /// <param name="offset">The offset to start reading from</param>
        /// <typeparam name="T">The type of struct to read out from the row</typeparam>
        /// <returns>The read structure filled from the row data</returns>
        public T ReadStructure< T >( int offset ) where T : struct
        {
            _reader.BaseStream.Position = _rowOffset + offset;

            return _reader.ReadStructure< T >();
        }

        /// <summary>
        /// Reads structures from an offset inside the current row
        /// </summary>
        /// <param name="offset">The offset to start reading from</param>
        /// <param name="count">The number of structures to read sequentially</param>
        /// <typeparam name="T">The type of struct to read out from the row</typeparam>
        /// <returns>The read structures filled from the row data</returns>
        public List< T > ReadStructures< T >( int offset, int count ) where T : struct
        {
            _reader.BaseStream.Position = _rowOffset + offset;

            return _reader.ReadStructures< T >( count );
        }

        /// <summary>
        /// Reads structures from an offset inside the current row
        /// </summary>
        /// <param name="offset">The offset to start reading from</param>
        /// <param name="count">The number of structures to read sequentially</param>
        /// <typeparam name="T">The type of struct to read out from the row</typeparam>
        /// <returns>The read structures filled from the row data</returns>
        public T[] ReadStructuresAsArray< T >( int offset, int count ) where T : struct
        {
            _reader.BaseStream.Position = _rowOffset + offset;

            return _reader.ReadStructuresAsArray< T >( count );
        }

        // bit faster way of finding _rsv_ keys without having to convert the whole thing to a string first and shit
        private readonly byte[] _rsvMagic = { 0x5f, 0x72, 0x73, 0x76, 0x5f };

        private SeString? ReplaceRsvKeyWithValue( byte[] originalData )
        {
            // so we don't do unnecessary array comparisons
            if( !Sheet.GameData.Excel.RsvProvider.HasValues )
            {
                return null;
            }
            
            if( originalData.Length < _rsvMagic.Length )
            {
                return null;
            }
            
            for( var i = 0; i < _rsvMagic.Length; i++ )
            {
                if( originalData[ i ] != _rsvMagic[ i ] )
                {
                    return null;
                }
            }

            var key = Encoding.ASCII.GetString( originalData );
            var value = Sheet.GameData.Excel.RsvProvider.GetValue( key );

            if( value == null )
            {
                return null;
            }

            return new SeString( value );
        }

        private object ReadFieldInternal( ExcelColumnDataType type )
        {
            object? data = null;

            switch( type )
            {
                case ExcelColumnDataType.String:
                {
                    var stringOffset = _reader.ReadUInt32();
                    var raw = _reader.ReadRawOffsetData( _rowOffset + _sheet.Header.DataOffset + stringOffset );

                    if( Sheet.GameData.Options.ResolveKnownRsvSheetValues )
                    {
                        var replacement = ReplaceRsvKeyWithValue( raw );
                        if( replacement != null )
                        {
                            data = replacement;
                            break;
                        }
                    }
                    
                    data = new SeString( raw );
                    break;
                }
                case ExcelColumnDataType.Bool:
                {
                    data = _reader.ReadByte() != 0;
                    break;
                }
                case ExcelColumnDataType.Int8:
                {
                    data = _reader.ReadSByte();
                    break;
                }
                case ExcelColumnDataType.UInt8:
                {
                    data = _reader.ReadByte();
                    break;
                }
                case ExcelColumnDataType.Int16:
                {
                    data = _reader.ReadInt16();
                    break;
                }
                case ExcelColumnDataType.UInt16:
                {
                    data = _reader.ReadUInt16();
                    break;
                }
                case ExcelColumnDataType.Int32:
                {
                    data = _reader.ReadInt32();
                    break;
                }
                case ExcelColumnDataType.UInt32:
                {
                    data = _reader.ReadUInt32();
                    break;
                }
                // case ExcelColumnDataType.Unk:
                // break;
                case ExcelColumnDataType.Float32:
                {
                    data = _reader.ReadSingle();
                    break;
                }
                case ExcelColumnDataType.Int64:
                {
                    data = _reader.ReadUInt64();
                    break;
                }
                case ExcelColumnDataType.UInt64:
                {
                    data = _reader.ReadUInt64();
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

                    var rawData = _reader.ReadByte();

                    data = ( rawData & bit ) == bit;

                    break;
                }
                default:
                    throw new ArgumentOutOfRangeException( "type", $"invalid excel column type: {type}" );
            }

            return data;
        }

        /// <summary>
        /// Read a field from the current stream position
        /// </summary>
        /// <param name="type">The sheet type to read</param>
        /// <typeparam name="T">The CLR type to store the read data in</typeparam>
        /// <returns>The read data stored in the provided type</returns>
        /// <exception cref="ArgumentOutOfRangeException">An invalid column type was provided</exception>
        private T? ReadField< T >( ExcelColumnDataType type )
        {
            var data = ReadFieldInternal( type );

            if( _sheet.GameData.Options.ExcelSheetStrictCastingEnabled )
            {
                return (T)data;
            }

            // todo: this is fucking shit but is a wip fix so that you can still ReadField< string > and get something back because 1am brain can't figure it out rn
            if( typeof( T ) == typeof( string ) && data is SeString seString )
            {
                // haha fuck you c#
                return (T)(object)seString.RawString;
            }

            if( data is T castedData )
            {
                return castedData;
            }

            return default;
        }

        /// <summary>
        /// Given a bitset with 1 flag set, find which index that bit is set at
        /// </summary>
        /// <param name="flag"></param>
        /// <returns></returns>
        [MethodImpl( MethodImplOptions.AggressiveInlining )]
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

        /// <summary>
        /// Read a type from an offset in the row
        /// </summary>
        /// <param name="offset">The offset to read from</param>
        /// <param name="bit">Read a specific bit from the underlying position - useful for bools</param>
        /// <typeparam name="T">The type to store the data in</typeparam>
        /// <returns>The read data contained in the provided type</returns>
        public T? ReadOffset< T >( ushort offset, byte bit = 0 )
        {
            _reader.BaseStream.Position = _rowOffset + offset;

            if( bit == 0 )
            {
                return ReadField< T >( _sheet.ColumnsByOffset[ offset ].Type );
            }
            
            var pos = GetBitPosition( bit );
            var flag = ExcelColumnDataType.PackedBool0 + pos;

            return ReadField< T >( flag );
        }

        /// <summary>
        /// Read a type from an offset in the row
        /// </summary>
        /// <param name="offset">The offset to read from</param>
        /// <param name="type">The excel column type to read</param>
        /// <returns>The read data contained in the provided type</returns>
        public T? ReadOffset< T >( int offset, ExcelColumnDataType type )
        {
            _reader.BaseStream.Position = _rowOffset + offset;

            return ReadField< T >( type );
        }

        /// <summary>
        /// Read a type from a column index in the row
        /// </summary>
        /// <param name="column">The column index to lookup</param>
        /// <typeparam name="T">The type to store the read data in</typeparam>
        /// <returns>The read data contained in the provided type, or the default value of the type if the column given is out of bounds</returns>
        public T? ReadColumn< T >( int column )
        {
            if( column >= _sheet.ColumnCount )
            {
                return default;
            }
            
            var col = _sheet.Columns[ column ];

            _reader.BaseStream.Position = _rowOffset + col.Offset;

            return ReadField< T >( col.Type );
        }

        /// <summary>
        /// Grab the raw value from the sheet.
        /// </summary>
        /// <remarks>
        /// This effectively acts as a variant and the object encapsulates it. You'll still need to do a type check or safely cast it to avoid exceptions
        /// but this can be useful when you don't need to care about it's type and can use it as is - e.g. ToString and so on
        /// </remarks>
        /// <param name="column">The column index to read from</param>
        /// <returns>An object containing the data from the row, or null if the column given is out of bounds</returns>
        public object? ReadColumnRaw( int column )
        {
            if( column >= _sheet.ColumnCount )
            {
                return null;
            }
            
            var col = _sheet.Columns[ column ];

            _reader.BaseStream.Position = _rowOffset + col.Offset;

            return ReadFieldInternal( col.Type );
        }
    }
}