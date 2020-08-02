using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Windows.Controls;
using DynamicData;
using Lumina.Data;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;
using ReactiveUI;

namespace Umbra.ViewModels.Explorer.Files
{
    // todo: this entire thing is fucking garbage
    public class ExcelSheetPageViewModel : ReactiveObject
    {
        public sealed class SheetColumnInfo
        {
            public int Index { get; set; }
            public ExcelColumnDataType Type { get; set; }
            public ushort Offset { get; set; }
        }

        private readonly Lumina.Lumina _lumina;

        public ExcelSheetPageViewModel( string sheetName, Lumina.Lumina lumina )
        {
            SheetColumns = new ObservableCollection< SheetColumnInfo >();
            SheetPages = new ObservableCollection< ExcelPage >();
            Languages = new ObservableCollection< string >();
            RawRowData = new ObservableCollection< object >();
            RawColumnData = new ObservableCollection< DataGridColumn >();
            RawData = new ObservableCollection< object >();

            // get shit
            _lumina = lumina;
            SheetName = sheetName;

            // break shit
            RawSheet = lumina.Excel.GetSheetRaw( sheetName, Language.English );
            Debug.Assert( RawSheet != null, "somehow the sheet name is null, shit is fucked" );

            HeaderFileName = RawSheet.HeaderFile.FilePath;
            Languages.AddRange( RawSheet.Languages.Select( l => l.ToString() ) );

            for( int i = 0; i < RawSheet.Columns.Length; i++ )
            {
                var c = RawSheet.Columns[ i ];
                var sci = new SheetColumnInfo
                {
                    Index = i,
                    Type = c.Type,
                    Offset = c.Offset
                };

                SheetColumns.Add( sci );
            }

            foreach( var page in RawSheet.DataPages )
            {
                var file = page.File;
                var rowPtrs = file.RowData;

                var parser = new RowParser( RawSheet, file );

                foreach( var rowPtr in rowPtrs.Values )
                {
                    var row = new object[RawSheet.ColumnCount + 1];
                    row[ 0 ] = rowPtr.RowId;
                    
                    parser.SeekToRow(rowPtr.RowId);

                    for( int c = 0; c < RawSheet.ColumnCount; c++ )
                    {
                        row[ c + 1 ] = parser.ReadColumnRaw( c );
                    }

                    RawData.Add( row );
                }
            }

            SheetPages.AddRange( RawSheet.DataPages );
        }

        public readonly ExcelSheetImpl RawSheet;

        private string _sheetName;

        public string SheetName
        {
            get => _sheetName;
            set => this.RaiseAndSetIfChanged( ref _sheetName, value );
        }

        private string _headerFileName;

        public string HeaderFileName
        {
            get => _headerFileName;
            set => this.RaiseAndSetIfChanged( ref _headerFileName, value );
        }

        public ObservableCollection< SheetColumnInfo > SheetColumns { get; set; }
        public ObservableCollection< ExcelPage > SheetPages { get; set; }
        public ObservableCollection< string > Languages { get; set; }

        public ObservableCollection< object > RawRowData { get; set; }
        public ObservableCollection< DataGridColumn > RawColumnData { get; set; }

        public ObservableCollection< object > RawData { get; set; }
    }
}