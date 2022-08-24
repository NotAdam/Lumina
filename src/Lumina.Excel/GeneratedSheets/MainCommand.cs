// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "MainCommand", columnHash: 0xc6604a03 )]
    public partial class MainCommand : ExcelRow
    {
        
        public int Icon { get; set; }
        public byte Category { get; set; }
        public LazyRow< MainCommandCategory > MainCommandCategory { get; set; }
        public sbyte SortID { get; set; }
        public byte Unknown4 { get; set; }
        public SeString Name { get; set; }
        public SeString Description { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Icon = parser.ReadColumn< int >( 0 );
            Category = parser.ReadColumn< byte >( 1 );
            MainCommandCategory = new LazyRow< MainCommandCategory >( gameData, parser.ReadColumn< byte >( 2 ), language );
            SortID = parser.ReadColumn< sbyte >( 3 );
            Unknown4 = parser.ReadColumn< byte >( 4 );
            Name = parser.ReadColumn< SeString >( 5 );
            Description = parser.ReadColumn< SeString >( 6 );
        }
    }
}