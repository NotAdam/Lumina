using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using Lumina.Data.Attributes;
using Lumina.Data.Structs.Excel;
using Lumina.Extensions;

namespace Lumina.Data.Files.Excel
{
    [FileExtension( ".exd" )]
    public class ExcelDataFile : FileResource
    {
        public ExcelDataFile()
        {
        }

        public ExcelDataHeader Header { get; protected set; }

        public Dictionary< uint, ExcelDataOffset > RowData { get; protected set; } = null!;
        
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

            RowData = Reader.ReadStructures< ExcelDataOffset >( (int)count ).ToDictionary( id => id.RowId, row => row );
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