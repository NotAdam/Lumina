using System;
using System.Buffers.Binary;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Lumina.Data.Structs.Excel;
using Lumina.Extensions;
using System.Net;

namespace Lumina.Data.Files.Excel
{
    public class ExcelHeaderFile : FileResource
    {
        public ExcelHeaderFile()
        {
        }

        public const string Magic = "EXHF";

        public ExcelHeaderHeader Header { get; internal set; }

        public ExcelColumnDefinition[] ColumnDefinitions { get; internal set; }

        public ExcelDataBreakpoint[] DataBreakpoints { get; internal set; }
        
        public Language[] Languages { get; internal set; }

        public override unsafe void LoadFile()
        {
            // fuck c# and its FIXED MUST BE ACCESSED BY LOCAL VARIABLE
            var header = Header = Reader.ReadStructure< ExcelHeaderHeader >();

            if(
                header.Magic[ 0 ] != 'E' ||
                header.Magic[ 1 ] != 'X' ||
                header.Magic[ 2 ] != 'H' ||
                header.Magic[ 3 ] != 'F' )
            {
                throw new InvalidDataException( "fucked exh file :(((((" );
            }

            DataStream.Position = 0x20;

            // swap bytes on LE systems
            if( BitConverter.IsLittleEndian )
            {
                header.Version = BinaryPrimitives.ReverseEndianness( header.Version );
                header.DataOffset = BinaryPrimitives.ReverseEndianness( header.DataOffset );
                header.ColumnCount = BinaryPrimitives.ReverseEndianness( header.ColumnCount );
                header.ExdCount = BinaryPrimitives.ReverseEndianness( header.ExdCount );
                header.LanguageCount = BinaryPrimitives.ReverseEndianness( header.LanguageCount );

                // just neck me now
                header.Variant = (ExcelHeaderHeader.ExcelVariant)BinaryPrimitives.ReverseEndianness( (int)header.Variant );
            }

            ColumnDefinitions = Reader.ReadStructuresAsArray< ExcelColumnDefinition >( header.ColumnCount );
            DataBreakpoints = Reader.ReadStructuresAsArray< ExcelDataBreakpoint >( header.ExdCount );

            Languages = Reader.ReadStructuresAsArray< UInt16 >( header.LanguageCount ).Select( v => (Language)v ).ToArray();

            if( !BitConverter.IsLittleEndian )
            {
                return;
            }

            for( var i = 0; i < ColumnDefinitions.Length; i++ )
            {
                // fuck c# lmao
                ref var cd = ref ColumnDefinitions[ i ];
                cd.Offset = BinaryPrimitives.ReverseEndianness( cd.Offset );
                cd.Type = (ExcelColumnDataType)BinaryPrimitives.ReverseEndianness( (ushort)cd.Type );
            }

            for( var i = 0; i < DataBreakpoints.Length; i++ )
            {
                ref var db = ref DataBreakpoints[ i ];
                db.RowCount = BinaryPrimitives.ReverseEndianness( db.RowCount );
                db.StartId = BinaryPrimitives.ReverseEndianness( db.StartId );
            }
        }
    }
}