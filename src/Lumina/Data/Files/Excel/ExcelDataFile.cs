using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Buffers.Binary;
using System.Runtime.InteropServices;
using Lumina.Data.Attributes;
using Lumina.Data.Structs.Excel;

namespace Lumina.Data.Files.Excel
{
    [FileExtension( ".exd" )]
    public class ExcelDataFile : FileResource
    {
        public ExcelDataHeader Header { get; protected set; }

        /// <summary>
        /// The row offsets in this page, in file order.
        /// </summary>
        public ExcelDataOffset[] RowData { get; protected set; } = null!;

        internal readonly object ReaderLock = new();

        public override void LoadFile()
        {
            // exd data is always in big endian
            Reader.IsLittleEndian = false;

            Header = ExcelDataHeader.Read( Reader );

            if(
                Header.Magic[ 0 ] != 'E' ||
                Header.Magic[ 1 ] != 'X' ||
                Header.Magic[ 2 ] != 'D' ||
                Header.Magic[ 3 ] != 'F' )
            {
                throw new InvalidDataException( "Invalid EXD file magic" );
            }

            var offsetSize = Unsafe.SizeOf< ExcelDataOffset >();
            var count = Header.IndexSize / offsetSize;

            RowData = GC.AllocateUninitializedArray< ExcelDataOffset >( checked( (int)count ) );
            Reader.BaseStream.ReadExactly( MemoryMarshal.AsBytes( RowData.AsSpan() ) );
            if( Reader.ConvertEndianness )
            {
                var words = MemoryMarshal.Cast< ExcelDataOffset, uint >( RowData.AsSpan() );
                BinaryPrimitives.ReverseEndianness( words, words );
            }
        }

        [Obsolete]
        public Span< byte > GetSpanForRow( uint rowId )
        {
            var offset = (int)Array.Find( RowData, row => row.RowId == rowId ).Offset;
            return DataSpan[ offset.. ];
        }

        [Obsolete]
        public Span< byte > GetSpanForRow( uint rowId, uint subrowId )
        {
            throw new NotImplementedException();
        }
    }
}