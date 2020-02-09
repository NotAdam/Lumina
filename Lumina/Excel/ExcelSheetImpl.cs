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
    public class ExcelSheetImpl
    {
        public ExcelSheetImpl()
        {
            DataSegments = new Dictionary< Language, List< ExcelSegment > >();
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

        public readonly Dictionary< Language, List< ExcelSegment > > DataSegments;

        public ExcelColumnDefinition[] Columns => HeaderFile.ColumnDefinitions;

        public ExcelDataPagination[] DataPagination => HeaderFile.DataPagination;

        public ExcelLanguage[] Languages => HeaderFile.Languages;

        protected readonly Lumina _Lumina;

        internal List< ExcelSegment > GetLangSegments( Language lang )
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

                    var segment = new ExcelSegment
                    {
                        FilePath = filePath,
                        RowCount = bp.RowCount,
                        StartId = bp.StartId
                    };

                    List< ExcelSegment > segments;
                    if( !DataSegments.ContainsKey( lang.Language ) )
                    {
                        segments = DataSegments[ lang.Language ] = new List< ExcelSegment >();
                    }
                    else
                    {
                        segments = DataSegments[ lang.Language ];
                    }

                    segment.File = _Lumina.GetFile< ExcelDataFile >( segment.FilePath );

                    segments.Add( segment );
                }
            }
        }
    }
}