// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "MainCommand", columnHash: 0x63da0c66 )]
    public class MainCommand : ExcelRow
    {
        
        public int Icon { get; set; }
        public byte Category { get; set; }
        public LazyRow< MainCommandCategory > MainCommandCategory { get; set; }
        public sbyte SortID { get; set; }
        public SeString Name { get; set; }
        public SeString Description { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Icon = parser.ReadColumn< int >( 0 );
            Category = parser.ReadColumn< byte >( 1 );
            MainCommandCategory = new LazyRow< MainCommandCategory >( gameData, parser.ReadColumn< byte >( 2 ), language );
            SortID = parser.ReadColumn< sbyte >( 3 );
            Name = parser.ReadColumn< SeString >( 4 );
            Description = parser.ReadColumn< SeString >( 5 );
        }
    }
}