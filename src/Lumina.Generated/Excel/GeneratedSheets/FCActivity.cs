// ReSharper disable All

using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "FCActivity", columnHash: 0xe45dc889 )]
    public class FCActivity : IExcelRow
    {
        
        public string Text;
        public byte SelfKind;
        public byte TargetKind;
        public byte NumParam;
        public LazyRow< FCActivityCategory > FCActivityCategory;
        public sbyte IconType;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Text = parser.ReadColumn< string >( 0 );
            SelfKind = parser.ReadColumn< byte >( 1 );
            TargetKind = parser.ReadColumn< byte >( 2 );
            NumParam = parser.ReadColumn< byte >( 3 );
            FCActivityCategory = new LazyRow< FCActivityCategory >( lumina, parser.ReadColumn< byte >( 4 ), language );
            IconType = parser.ReadColumn< sbyte >( 5 );
        }
    }
}