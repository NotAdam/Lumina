using System;
using System.Buffers.Binary;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Lumina.Data;
using Lumina.Data.Files.Excel;
using Lumina.Data.Structs.Excel;
using Lumina.Extensions;

namespace Lumina.Excel
{
    public class ExcelSheetImpl
    {
        internal ExcelSheetImpl( ExcelHeaderFile headerFile, string name, Language requestedLanguage, GameData gameData )
        {
            DataPages = new List< ExcelPage >();
            HeaderFile = headerFile;
            Name = name;
            RequestedLanguage = requestedLanguage;
            GameData = gameData;
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

        private Dictionary< ushort, ExcelColumnDefinition > _columnsByOffset = null!;

        public Dictionary< ushort, ExcelColumnDefinition > ColumnsByOffset
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

        internal readonly GameData GameData;

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
                if( !GameData.FileExists( filePath ) )
                {
                    continue;
                }

                var segment = new ExcelPage
                {
                    FilePath = filePath,
                    RowCount = bp.RowCount,
                    StartId = bp.StartId
                };

                segment.File = GameData.GetFile< ExcelDataFile >( segment.FilePath );

                // convert big endian to little endian on le systems
                ProcessDataEndianness( segment.File );

                DataPages.Add( segment );
            }
        }

        /// <summary>
        /// Reverses an inner segment of data based on the column size
        /// </summary>
        /// <param name="offset">The row offset to start from</param>
        /// <param name="fileData">The underlying file data</param>
        protected unsafe void ProcessDataRow( long offset, byte[] fileData )
        {
            foreach( var row in Columns )
            {
                fixed( byte* ptr = &fileData[ offset + row.Offset ] )
                {
                    switch( row.Type )
                    {
                        case ExcelColumnDataType.Int16:
                        case ExcelColumnDataType.UInt16:
                        {
                            var pData = (ushort*)ptr;
                            *pData = BinaryPrimitives.ReverseEndianness( *pData );

                            break;
                        }
                        case ExcelColumnDataType.String:
                        case ExcelColumnDataType.Int32:
                        case ExcelColumnDataType.UInt32:
                        case ExcelColumnDataType.Float32:
                        {
                            var pData = (uint*)ptr;
                            *pData = BinaryPrimitives.ReverseEndianness( *pData );

                            break;
                        }
                        case ExcelColumnDataType.Int64:
                        case ExcelColumnDataType.UInt64:
                        {
                            var pData = (ulong*)ptr;
                            *pData = BinaryPrimitives.ReverseEndianness( *pData );
                            break;
                        }

                        default:
                            continue;
                    }
                }

                // not really sure why but this sometimes happens, but it'll read 0 bytes and then try and write it to the end
                // and crash because it's attempting to alloc memory for some retarded reason, makes 0 sense to me
                // todo: figure out why (item sheet, maybe quest?)
                // todo: potentially fixed by accident but don't want to remove
                // if( data.Length == 0 )
                // continue;

                // Array.Reverse( data );

                // ms.Position -= data.Length;
                // bw.Write( data );
            }
        }

        /// <summary>
        /// Reverses the endianness of a data file on LE machines so the underlying stream can be copied from as is
        /// </summary>
        /// <param name="file">The file to swap endianness for</param>
        // todo: refactor and move into ExceLDataFile
        protected void ProcessDataEndianness( ExcelDataFile file )
        {
            if( !BitConverter.IsLittleEndian )
            {
                return;
            }

            if( file.SwappedEndianness )
            {
                return;
            }

            // todo: clean this shit up too
            var stream = new MemoryStream( file.Data );
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

                        ProcessDataRow( subRowOffset, file.Data );
                    }
                }
                else
                {
                    // skip (unused) header
                    ProcessDataRow( offset + 6, file.Data );
                }
            }

            file.SwappedEndianness = true;
        }

        /// <summary>
        /// Gets the corresponding data page for a given row
        /// </summary>
        /// <param name="row">The row id to fetch the parent page for</param>
        /// <returns>The <see cref="ExcelPage"/> if found, null otherwise</returns>
        public ExcelPage? GetPageForRow( uint row )
        {
            var data = DataPages.FirstOrDefault( s => s.RowData.ContainsKey( row ) );

            // if( data == null )
            // {
            //     throw new KeyNotFoundException( $"row {row} not found in sheet {Name}!" );
            // }

            return data;
        }

        protected static ulong GetCacheKey( uint rowId, uint subrowId = UInt32.MaxValue )
        {
            return (ulong)rowId << 32 | subrowId;
        }

        /// <summary>
        /// Provides direct access to the underlying row parser for any row or subrow
        /// </summary>
        /// <param name="row">The row id to seek to</param>
        /// <param name="subRow">The subrow id to seek to</param>
        /// <returns>A <see cref="RowParser"/> instance</returns>
        public RowParser? GetRowParser( uint row, uint subRow = uint.MaxValue )
        {
            var page = GetPageForRow( row );
            if( page == null )
            {
                return null;
            }

            RowParser parser = null!;

            if( subRow != uint.MaxValue )
            {
                parser = new RowParser( this, page.File, row, subRow );
            }
            else
            {
                parser = new RowParser( this, page.File, row );
            }

            return parser;
        }
        
        /// <summary>
        /// Iterate across each row data offsets in a sheet
        /// </summary>
        /// <returns>A <see cref="IEnumerable{T}"/> containing each offset to each row or subrow group</returns>
        public IEnumerable< RowDataCursor > GetRowDataOffsets()
        {
            foreach( var page in DataPages )
            {
                var file = page.File;
                var rowPtrs = file.RowData;

                foreach( var rowPtr in rowPtrs.Values )
                {
                    yield return new()
                    {
                        RowOffset = rowPtr,
                        SheetPage = file
                    };
                }
            }
        }

        public IEnumerable< RowParser > GetRowParsers()
        {
            ExcelDataFile file = null!;
            RowParser parser = null!;
            
            foreach( var offset in GetRowDataOffsets() )
            {
                var rowPtr = offset.RowOffset;
                if( file != offset.SheetPage )
                {
                    parser = new RowParser( this, offset.SheetPage );
                }

                parser.SeekToRow( rowPtr.RowId );
                
                if( Header.Variant == ExcelVariant.Subrows )
                {
                    // read subrows
                    for( uint i = 0; i < parser.RowCount; i++ )
                    {
                        parser.SeekToRow( rowPtr.RowId, i );
                        yield return parser;
                    }
                }
                else
                {
                    yield return parser;
                }
            }
        }
    }
}