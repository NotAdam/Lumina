using System;
using System.Buffers.Binary;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Lumina.Data.Structs.Excel;
using Lumina.Extensions;

namespace Lumina.Data.Files.Excel
{
    public class ExcelDataFile : FileResource
    {
        public ExcelDataFile()
        {
        }

        public ExcelDataHeader Header { get; protected set; }

        public ExcelDataOffset[] RowData { get; protected set; }

        public override unsafe void LoadFile()
        {
            var header = Reader.ReadStructure< ExcelDataHeader >();

            if(
                header.Magic[ 0 ] != 'E' ||
                header.Magic[ 1 ] != 'X' ||
                header.Magic[ 2 ] != 'D' ||
                header.Magic[ 3 ] != 'F' )
            {
                throw new InvalidDataException( "fucked exd file :(((((" );
            }

            // swap bytes on LE systems
            if( BitConverter.IsLittleEndian )
            {
                header.Version = BinaryPrimitives.ReverseEndianness( header.Version );
                header.IndexSize = BinaryPrimitives.ReverseEndianness( header.IndexSize );
            }

            Header = header;

            // read offsets
            var offsetSize = Unsafe.SizeOf< ExcelDataOffset >();
            var count = header.IndexSize / offsetSize;

            RowData = Reader.ReadStructuresAsArray< ExcelDataOffset >( (int)count );

            if( BitConverter.IsLittleEndian )
            {
                for( var i = 0; i < RowData.Length; i++ )
                {
                    ref var row = ref RowData[ i ];

                    row.RowId = BinaryPrimitives.ReverseEndianness( row.RowId );
                    row.Offset = BinaryPrimitives.ReverseEndianness( row.Offset );
                }
            }
        }

        public Span< byte > GetSpanForRow( uint rowId )
        {
            var offset = (int)RowData[ rowId ].Offset;
            return DataSpan.Slice( offset );
        }

        public Span< byte > GetSpanForRow( uint rowId, uint subrowId )
        {
            throw new NotImplementedException();
        }
    }
}