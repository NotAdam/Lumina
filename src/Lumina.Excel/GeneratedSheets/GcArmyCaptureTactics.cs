// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "GcArmyCaptureTactics", columnHash: 0x62bcfbad )]
    public partial class GcArmyCaptureTactics : ExcelRow
    {
        
        public LazyRow< Status > Name { get; set; }
        public byte HP { get; set; }
        public byte DamageDealt { get; set; }
        public byte DamageReceived { get; set; }
        public LazyRow< Addon > Tactic { get; set; }
        public uint Icon { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Name = new LazyRow< Status >( gameData, parser.ReadColumn< int >( 0 ), language );
            HP = parser.ReadColumn< byte >( 1 );
            DamageDealt = parser.ReadColumn< byte >( 2 );
            DamageReceived = parser.ReadColumn< byte >( 3 );
            Tactic = new LazyRow< Addon >( gameData, parser.ReadColumn< uint >( 4 ), language );
            Icon = parser.ReadColumn< uint >( 5 );
        }
    }
}