// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "InstanceContentCSBonus", columnHash: 0x43042e70 )]
    public class InstanceContentCSBonus : ExcelRow
    {
        
        public LazyRow< InstanceContent > Instance;
        public LazyRow< Item > Item;
        public byte Unknown2;
        public byte Unknown540;
        public byte Unknown541;
        

        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Instance = new LazyRow< InstanceContent >( gameData, parser.ReadColumn< ushort >( 0 ), language );
            Item = new LazyRow< Item >( gameData, parser.ReadColumn< uint >( 1 ), language );
            Unknown2 = parser.ReadColumn< byte >( 2 );
            Unknown540 = parser.ReadColumn< byte >( 3 );
            Unknown541 = parser.ReadColumn< byte >( 4 );
        }
    }
}