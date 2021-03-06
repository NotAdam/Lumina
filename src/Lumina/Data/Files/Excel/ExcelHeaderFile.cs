using System;
using System.Buffers.Binary;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using Lumina.Data.Attributes;
using Lumina.Data.Structs.Excel;
using Lumina.Extensions;
using Lumina.Misc;

namespace Lumina.Data.Files.Excel
{
    [FileExtension( "exh" )]
    public class ExcelHeaderFile : FileResource
    {
        public ExcelHeaderFile()
        {
        }

        public const string Magic = "EXHF";

        public ExcelHeaderHeader Header { get; private set; }

        public ExcelColumnDefinition[] ColumnDefinitions { get; private set; }

        public ExcelDataPagination[] DataPages { get; private set; }

        public Language[] Languages { get; private set; }

        public override unsafe void LoadFile()
        {
            // fuck c# and its FIXED MUST BE ACCESSED BY LOCAL VARIABLE
            var header = Reader.ReadStructure< ExcelHeaderHeader >();

            if(
                header.Magic[ 0 ] != 'E' ||
                header.Magic[ 1 ] != 'X' ||
                header.Magic[ 2 ] != 'H' ||
                header.Magic[ 3 ] != 'F' )
            {
                throw new InvalidDataException( "fucked exh file :(((((" );
            }

            FileStream.Position = 0x20;

            // swap bytes on LE systems
            if( BitConverter.IsLittleEndian )
            {
                header.Version = BinaryPrimitives.ReverseEndianness( header.Version );
                header.DataOffset = BinaryPrimitives.ReverseEndianness( header.DataOffset );
                header.ColumnCount = BinaryPrimitives.ReverseEndianness( header.ColumnCount );
                header.PageCount = BinaryPrimitives.ReverseEndianness( header.PageCount );
                header.LanguageCount = BinaryPrimitives.ReverseEndianness( header.LanguageCount );
                header.RowCount = BinaryPrimitives.ReverseEndianness( header.RowCount );
            }

            // fucking c# and its STRUCTS ARE ALWAYS A COPY
            Header = header;

            ColumnDefinitions = Reader.ReadStructuresAsArray< ExcelColumnDefinition >( header.ColumnCount );
            DataPages = Reader.ReadStructuresAsArray< ExcelDataPagination >( header.PageCount );

            // todo: these are LE? what the fuck? am i going insane?
            Languages = Reader.ReadStructures< ushort >( header.LanguageCount ).Select( lang => (Language)lang ).ToArray();

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

            for( var i = 0; i < DataPages.Length; i++ )
            {
                ref var db = ref DataPages[ i ];
                db.RowCount = BinaryPrimitives.ReverseEndianness( db.RowCount );
                db.StartId = BinaryPrimitives.ReverseEndianness( db.StartId );
            }
        }

        public uint GetColumnsHash()
        {
            var headerSize = Unsafe.SizeOf< ExcelHeaderHeader >();
            var span = DataSpan.Slice( headerSize, Unsafe.SizeOf< ExcelColumnDefinition >() * Header.ColumnCount );

            return Crc32.Get( span );
        }

        public string GetColumnsHashString()
        {
            return GetColumnsHash().ToString( "x8" );
        }
    }
}