using System;
using System.Collections.Generic;
using System.Linq;
using Lumina.Data;
using Lumina.Data.Files.Excel;
using Lumina.Data.Structs.Excel;

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

        private Dictionary< ushort, ExcelColumnDefinition >? _columnsByOffset;

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

                DataPages.Add( segment );
            }
        }

        /// <summary>
        /// Gets the corresponding data page for a given row
        /// </summary>
        /// <param name="row">The row id to fetch the parent page for</param>
        /// <returns>The <see cref="ExcelPage"/> if found, null otherwise</returns>
        public ExcelPage? GetPageForRow( uint row )
        {
            // var data = DataPages.FirstOrDefault( s => s.RowData.ContainsKey( row ) );

            var page = DataPages.FirstOrDefault( s => row >= s.StartId && row < s.StartId + s.RowCount );

            return page;
        }

        /// <summary>
        /// Check whether a row exists in a sheet
        /// </summary>
        /// <param name="row">The rowid to check.</param>
        /// <remarks>Subrows in type 2 sheets can't be checked for in this form as the header does not contain an explicit entry for a (row, subrow) pair</remarks>
        /// <returns>True if exists, false otherwise</returns>
        public bool HasRow( uint row )
        {
            var page = GetPageForRow( row );

            if( page == null )
            {
                return false;
            }

            return page.RowData.Any( x => x.Key == row );
        }

        /// <inheritdoc cref="HasRow(uint)"/>
        public bool HasRow( int row ) => HasRow( (uint)row );

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

            return GetRowParser( page, row, subRow );
        }

        /// <summary>
        /// Provides direct access to the underlying row parser for any row or subrow
        /// </summary>
        /// <param name="page">The excel page to operate on</param>
        /// <param name="row">The row id to seek to</param>
        /// <param name="subRow">The subrow id to seek to</param>
        /// <returns>A <see cref="RowParser"/> instance</returns>
        public RowParser? GetRowParser( ExcelPage page, uint row, uint subRow = uint.MaxValue )
        {
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