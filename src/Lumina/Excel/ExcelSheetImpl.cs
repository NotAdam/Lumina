using System;
using System.Buffers.Binary;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using Lumina.Data;
using Lumina.Data.Files.Excel;
using Lumina.Data.Structs.Excel;
using Lumina.Extensions;

namespace Lumina.Excel
{
    public class ExcelSheetImpl
    {
        internal ExcelSheetImpl( ExcelHeaderFile headerFile, string name, Language requestedLanguage, Lumina lumina )
        {
            DataPages = new List< ExcelPage >();
            HeaderFile = headerFile;
            Name = name;
            RequestedLanguage = requestedLanguage;
            _Lumina = lumina;
        }

        /// <summary>
        /// The name of the sheet
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// The header of the sheet which defines its properties such as total row count, pages and languages
        /// </summary>
        public ExcelHeaderFile HeaderFile { get; }

        /// <summary>
        /// A quick accessor to the data available in the sheet header
        /// </summary>
        public ExcelHeaderHeader Header => HeaderFile.Header;
        
        /// <summary>
        /// The total count of rows irrespective of paging
        /// </summary>
        public uint RowCount => Header.RowCount;

        /// <summary>
        /// The total number of columns
        /// </summary>
        public uint ColumnCount => Header.ColumnCount;

        /// <summary>
        /// The kind of sheet
        /// </summary>
        public ExcelVariant Variant => Header.Variant;

        /// <summary>
        /// The parsed data pages
        /// </summary>
        public readonly List< ExcelPage > DataPages;

        public ExcelColumnDefinition[] Columns => HeaderFile.ColumnDefinitions;

        private Dictionary<ushort, ExcelColumnDefinition> _columnsByOffset;
        public Dictionary<ushort, ExcelColumnDefinition> ColumnsByOffset
        {
            get
            {
                if( _columnsByOffset == null )
                {
                    _columnsByOffset = Columns.GroupBy( p => p.Offset ).ToDictionary( c => c.Key, c => c.First() );
                }
                return _columnsByOffset;
            }
        }


        /// <summary>
        /// Returns the data pages contained in the Excel header
        /// </summary>
        public ExcelDataPagination[] DataPagination => HeaderFile.DataPages;

        /// <summary>
        /// The available languages for this sheet.
        /// </summary>
        /// <remarks>
        /// You will need to reload this sheet with a different language if you want to access a single sheet in more than 1 language at a time.
        /// </remarks>
        public Language[] Languages => HeaderFile.Languages;
        
        /// <summary>
        /// The language that was requested for this sheet when it was loaded
        /// </summary>
        public Language RequestedLanguage { get; protected set; }

        internal readonly Lumina _Lumina;

        /// <summary>
        /// Generates an absolute path to a data file for a sheet
        /// </summary>
        /// <param name="name">The sheet name</param>
        /// <param name="startId">The page row start index</param>
        /// <param name="language">The requested language</param>
        /// <returns>An absolute path to the file</returns>
        protected string GenerateFilePath( string name, uint startId, Language language )
        {
            if( language == Language.None )
            {
                return $"exd/{name}_{startId}.exd";
            }

            var lang = LanguageUtil.GetLanguageStr( language );

            return $"exd/{name}_{startId}_{lang}.exd";
        }

        /// <summary>
        /// Iterates across sheet pagination and creates pages with their associated row counts and breakpoints
        /// </summary>
        internal void GenerateFilePages()
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

        /// <summary>
        /// Reverses an inner segment of data based on the column size
        /// </summary>
        /// <param name="offset">The row offset to start from</param>
        /// <param name="ms">The underlying <see cref="System.IO.MemoryStream"/> that contains the file data</param>
        /// <param name="bw">Used to write the correct data back into the <see cref="System.IO.MemoryStream"/></param>
        /// <param name="br">Used to read the correctly sized data from the underlying <see cref="System.IO.MemoryStream"/></param>
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
                // todo: potentially fixed by accident but don't want to remove
                if( data.Length == 0 )
                    continue;

                Array.Reverse( data );

                ms.Position -= data.Length;
                bw.Write( data );
            }
        }
        
        /// <summary>
        /// Reverses the endianness of a data file on LE machines so the underlying stream can be copied from as is
        /// </summary>
        /// <param name="file">The file to swap endianness for</param>
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