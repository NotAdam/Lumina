using System;
using System.Buffers.Binary;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using Lumina.Data;
using Lumina.Data.Files.Excel;
using Lumina.Data.Parsing.Tex;
using Lumina.Data.Structs.Excel;
using Lumina.Extensions;

namespace Lumina.Excel
{
    public class ExcelSheetImpl
    {
        public ExcelSheetImpl()
        {
            DataPages = new Dictionary< Language, List< ExcelPage > >();
        }

        public ExcelSheetImpl( ExcelHeaderFile headerFile, string name ) :
            this()
        {
            HeaderFile = headerFile;
            Name = name;
        }

        public ExcelSheetImpl( ExcelHeaderFile headerFile, string name, Lumina lumina ) :
            this( headerFile, name )
        {
            _Lumina = lumina;

            GenerateFileSegments();
        }

        public string Name { get; }

        public ExcelHeaderFile HeaderFile { get; }

        public ExcelHeaderHeader Header => HeaderFile.Header;
        
        public uint RowCount => Header.RowCount;

        public uint ColumnCount => Header.ColumnCount;

        public ExcelVariant Variant => Header.Variant;

        public readonly Dictionary< Language, List< ExcelPage > > DataPages;

        public ExcelColumnDefinition[] Columns => HeaderFile.ColumnDefinitions;

        public ExcelDataPagination[] DataPagination => HeaderFile.DataPagination;

        public ExcelLanguage[] Languages => HeaderFile.Languages;

        protected readonly Lumina _Lumina;

        internal List< ExcelPage > GetLanguagePages( Language lang )
        {
            if( DataPages.TryGetValue( lang, out var obj ) )
            {
                return obj;
            }

            if( DataPages.TryGetValue( Language.None, out var noLang ) )
            {
                return noLang;
            }

            return null;
        }
        
        protected string GenerateFilePath( string name, uint startId, Language language )
        {
            if( language == Language.None )
            {
                return $"exd/{name}_{startId}.exd";
            }

            var lang = LanguageUtil.GetLanguageStr( language );

            return $"exd/{name}_{startId}_{lang}.exd";
        }

        protected void GenerateFileSegments()
        {
            foreach( var lang in HeaderFile.Languages )
            {
                foreach( var bp in HeaderFile.DataPagination )
                {
                    var filePath = GenerateFilePath( Name, bp.StartId, lang.Language );

                    // ignore languages that don't exist in this client build
                    if( !_Lumina.FileExists( filePath ) )
                    {
                        continue;
                    }

                    var segment = new ExcelPage
                    {
                        FilePath = filePath,
                        RowCount = bp.RowCount,
                        StartId = bp.StartId
                    };

                    List< ExcelPage > segments;
                    if( !DataPages.ContainsKey( lang.Language ) )
                    {
                        segments = DataPages[ lang.Language ] = new List< ExcelPage >();
                    }
                    else
                    {
                        segments = DataPages[ lang.Language ];
                    }

                    segment.File = _Lumina.GetFile< ExcelDataFile >( segment.FilePath );
                    
                    // convert big endian to little endian on le systems
                    ProcessDataEndianness( segment.File );

                    segments.Add( segment );
                }
            }
        }

        protected void ProcessDataRow( long offset, MemoryStream ms, BinaryWriter bw, BinaryReader br )
        {
            foreach( var row in Columns )
            {
                var type = row.Type;

                // ignore single byte fields
                if( type == ExcelColumnDataType.Bool ||
                    type == ExcelColumnDataType.Int8 ||
                    type == ExcelColumnDataType.UInt8 ||
                    (int)type >= (int)ExcelColumnDataType.PackedBool0
                )
                {
                    continue;
                }
                
                long colOffset = offset + row.Offset;
                ms.Position = colOffset;

                byte[] data = null;

                switch( type )
                {
                    case ExcelColumnDataType.Int16:
                    case ExcelColumnDataType.UInt16:
                    {
                        data = br.ReadBytes( Unsafe.SizeOf< UInt16 >() );
                        break;
                    }
                    case ExcelColumnDataType.String:
                    case ExcelColumnDataType.Int32:
                    case ExcelColumnDataType.UInt32:
                    case ExcelColumnDataType.Float32:
                    {
                        data = br.ReadBytes( Unsafe.SizeOf< UInt32 >() );
                        break;
                    }
                    case ExcelColumnDataType.Int64:
                    case ExcelColumnDataType.UInt64:
                    {
                        data = br.ReadBytes( Unsafe.SizeOf< UInt64 >() );
                        break;
                    }
                    default:
                        throw new ArgumentOutOfRangeException();
                }

                Array.Reverse( data );

                ms.Position -= data.Length;
                bw.Write( data );
            }
        }
        
        protected void ProcessDataEndianness( ExcelDataFile file )
        {
            if( !BitConverter.IsLittleEndian )
            {
                return;
            }

            var stream = new MemoryStream( file.Data );
            var writer = new BinaryWriter( stream );
            var reader = new BinaryReader( stream );

            foreach( var row in file.RowData )
            {
                var offset = row.Offset;

                stream.Position = offset;

                if( Variant == ExcelVariant.Subrows )
                {
                    var rowHdr = reader.ReadStructure< ExcelDataRowHeader >();
                    rowHdr.RowCount = BinaryPrimitives.ReverseEndianness( rowHdr.RowCount );
                    rowHdr.DataSize = BinaryPrimitives.ReverseEndianness( rowHdr.DataSize );

                    for( var i = 0; i < rowHdr.RowCount; i++ )
                    {
                        var subRowOffset = row.Offset + 6 + ( i * Header.DataOffset + 2 * ( i + 1 ) );

                        stream.Position = subRowOffset;
                        
                        ProcessDataRow( subRowOffset, stream, writer, reader );
                    }
                }
                else
                {
                    // skip header
                    ProcessDataRow( offset + 6, stream, writer, reader );
                }
            }
        }
    }
}