using System;
using System.Buffers.Binary;
using System.Collections.Generic;
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
            DataPages = new List< ExcelPage >();
        }

        public ExcelSheetImpl( ExcelHeaderFile headerFile, string name ) :
            this()
        {
            HeaderFile = headerFile;
            Name = name;
        }
        
        public ExcelSheetImpl( ExcelHeaderFile headerFile, string name, Language requestedLanguage ) :
            this( headerFile, name )
        {
            RequestedLanguage = requestedLanguage;
        }

        public ExcelSheetImpl( ExcelHeaderFile headerFile, string name, Language requestedLanguage, Lumina lumina ) :
            this( headerFile, name, requestedLanguage )
        {
            _Lumina = lumina;
        }

        public string Name { get; }

        public ExcelHeaderFile HeaderFile { get; }

        public ExcelHeaderHeader Header => HeaderFile.Header;
        
        public uint RowCount => Header.RowCount;

        public uint ColumnCount => Header.ColumnCount;

        public ExcelVariant Variant => Header.Variant;

        public readonly List< ExcelPage > DataPages;

        public ExcelColumnDefinition[] Columns => HeaderFile.ColumnDefinitions;

        public ExcelDataPagination[] DataPagination => HeaderFile.DataPages;

        public Language[] Languages => HeaderFile.Languages;
        
        public Language RequestedLanguage { get; protected set; }

        internal readonly Lumina _Lumina;

        protected string GenerateFilePath( string name, uint startId, Language language )
        {
            if( language == Language.None )
            {
                return $"exd/{name}_{startId}.exd";
            }

            var lang = LanguageUtil.GetLanguageStr( language );

            return $"exd/{name}_{startId}_{lang}.exd";
        }

        internal void GenerateFileSegments()
        {
            var lang = Language.None;

            if( HeaderFile.Languages.Contains( RequestedLanguage ) )
            {
                lang = RequestedLanguage;
            }

            foreach( var bp in HeaderFile.DataPages )
            {
                var filePath = GenerateFilePath( Name, bp.StartId, lang );

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

                segment.File = _Lumina.GetFile< ExcelDataFile >( segment.FilePath );
                    
                // convert big endian to little endian on le systems
                ProcessDataEndianness( segment.File );

                DataPages.Add( segment );
            }
        }

        protected void ProcessDataRow( long offset, MemoryStream ms, BinaryWriter bw, BinaryReader br )
        {
            foreach( var row in Columns )
            {
                var type = row.Type;
                
                ms.Position = offset + row.Offset;

                byte[] data;

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
                        continue;
                }

                // not really sure why but this sometimes happens, but it'll read 0 bytes and then try and write it to the end
                // and crash because it's attempting to alloc memory for some retarded reason, makes 0 sense to me
                // todo: figure out why (item sheet, maybe quest?)
                if( data.Length == 0 )
                    continue;

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

            foreach( var row in file.RowData.Values )
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