using System;
using System.Buffers.Binary;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Lumina.Data.Attributes;
using Lumina.Data.Structs.Excel;
using Lumina.Extensions;

namespace Lumina.Data.Files.Excel
{
    [FileExtension( ".exd" )]
    public class ExcelDataFile : FileResource
    {
        private Dictionary< uint, ExcelDataOffset >? _rowData;

        public ExcelDataFile()
        {
        }

        public ExcelDataHeader Header { get; protected set; }

        /// <summary>
        /// The row offsets in file order, or <see langword="null"/> if <see cref="RowData"/> has been assigned instead.
        /// </summary>
        internal ExcelDataOffset[]? RowOffsets { get; private set; }

        /// <remarks>
        /// Built on first access, sheets read <see cref="RowOffsets"/> instead.
        /// </remarks>
        public Dictionary< uint, ExcelDataOffset > RowData
        {
            get
            {
                if( _rowData == null && RowOffsets != null )
                {
                    var rowData = new Dictionary< uint, ExcelDataOffset >( RowOffsets.Length );
                    foreach( var row in RowOffsets )
                    {
                        rowData.Add( row.RowId, row );
                    }

                    Interlocked.CompareExchange( ref _rowData, rowData, null );
                }

                return _rowData!;
            }
            protected set
            {
                _rowData = value;
                RowOffsets = null;
            }
        }
        
        internal readonly object ReaderLock = new();

        public override unsafe void LoadFile()
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
                throw new InvalidDataException( "fucked exd file :(((((" );
            }

            // read offsets
            var offsetSize = Unsafe.SizeOf< ExcelDataOffset >();
            var count = Header.IndexSize / offsetSize;

            var rowOffsets = GC.AllocateUninitializedArray< ExcelDataOffset >( (int)count );
            Reader.BaseStream.ReadExactly( MemoryMarshal.AsBytes( rowOffsets.AsSpan() ) );

            if( Reader.ConvertEndianness )
            {
                Debug.Assert( Unsafe.SizeOf< ExcelDataOffset >() == 2 * sizeof( uint ) );
                var values = MemoryMarshal.Cast< ExcelDataOffset, uint >( rowOffsets.AsSpan() );
                BinaryPrimitives.ReverseEndianness( values, values );
            }

            _rowData = null;
            RowOffsets = rowOffsets;
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