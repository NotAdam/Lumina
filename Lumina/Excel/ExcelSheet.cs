using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Lumina.Data;
using Lumina.Data.Files.Excel;
using Lumina.Data.Structs.Excel;
using Lumina.Extensions;

namespace Lumina.Excel
{
    public class ExcelSheet
    {
        public class Segment
        {
            public string FilePath { get; set; }

            public uint StartId { get; set; }

            public uint RowCount { get; set; }

            public ExcelDataFile File { get; set; }
        }

        public ExcelSheet()
        {
            DataSegments = new Dictionary< Language, List< Segment > >();
        }

        public ExcelSheet( ExcelHeaderFile headerFile, int immutableId, string name ) :
            this()
        {
            HeaderFile = headerFile;
            ImmutableId = immutableId;
            Name = name;
        }

        public ExcelSheet( ExcelHeaderFile headerFile, int immutableId, string name, Lumina lumina ) :
            this( headerFile, immutableId, name )
        {
            _lumina = lumina;

            GenerateFileSegments();
        }

        public int ImmutableId { get; }

        public string Name { get; }

        public ExcelHeaderFile HeaderFile { get; }

        public ExcelHeaderHeader Header => HeaderFile.Header;

        public readonly Dictionary< Language, List< Segment > > DataSegments;

        public ExcelColumnDefinition[] Columns => HeaderFile.ColumnDefinitions;

        public ExcelDataBreakpoint[] DataBreakpoints => HeaderFile.DataBreakpoints;

        public ExcelLanguage[] Languages => HeaderFile.Languages;

        protected Lumina _lumina { get; set; }

        internal List< Segment > GetLangSegments( Language lang )
        {
            if( DataSegments.TryGetValue( lang, out var obj ) )
            {
                return obj;
            }

            if( DataSegments.TryGetValue( Language.None, out var noLang ) )
            {
                return noLang;
            }

            return null;
        }

        public T GetRow< T >( uint row ) where T : IExcelRow
        {
            return GetRow< T >( row, Lumina.Options.DefaultExcelLanguage );
        }

        public T GetRow< T >( uint row, Language lang ) where T : IExcelRow
        {
            var segments = GetLangSegments( lang );

            var data = segments.FirstOrDefault( s => row >= s.StartId && row < s.StartId + s.RowCount );

            if( data == null )
            {
                throw new KeyNotFoundException( $"row {row} not found in sheet {Name}!" );
            }

            var rowObj = Activator.CreateInstance< T >();
            var parser = new RowParser( this, data.File, row );

            rowObj.PopulateData( parser );

            return rowObj;
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
                foreach( var bp in HeaderFile.DataBreakpoints )
                {
                    var filePath = GenerateFilePath( Name, bp.StartId, lang.Language );

                    // ignore languages that don't exist in this client build
                    if( !_lumina.FileExists( filePath ) )
                    {
                        continue;
                    }

                    var segment = new Segment
                    {
                        FilePath = filePath,
                        RowCount = bp.RowCount,
                        StartId = bp.StartId
                    };

                    List< Segment > segments;
                    if( !DataSegments.ContainsKey( lang.Language ) )
                    {
                        segments = DataSegments[ lang.Language ] = new List< Segment >();
                    }
                    else
                    {
                        segments = DataSegments[ lang.Language ];
                    }

                    segment.File = _lumina.GetFile< ExcelDataFile >( segment.FilePath );

                    segments.Add( segment );
                }
            }
        }
    }
}