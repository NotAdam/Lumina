// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "InstanceContentCSBonus", columnHash: 0x43042e70 )]
    public partial class InstanceContentCSBonus : ExcelRow
    {
        
        public LazyRow< InstanceContent > Instance { get; set; }
        public LazyRow< Item > Item { get; set; }
        public byte Unknown2 { get; set; }
        public byte Unknown3 { get; set; }
        public byte Unknown4 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Instance = new LazyRow< InstanceContent >( gameData, parser.ReadColumn< ushort >( 0 ), language );
            Item = new LazyRow< Item >( gameData, parser.ReadColumn< uint >( 1 ), language );
            Unknown2 = parser.ReadColumn< byte >( 2 );
            Unknown3 = parser.ReadColumn< byte >( 3 );
            Unknown4 = parser.ReadColumn< byte >( 4 );
        }
    }
}