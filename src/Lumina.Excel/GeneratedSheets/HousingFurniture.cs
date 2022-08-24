// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "HousingFurniture", columnHash: 0xccfbe5ff )]
    public partial class HousingFurniture : ExcelRow
    {
        
        public ushort ModelKey { get; set; }
        public byte HousingItemCategory { get; set; }
        public byte UsageType { get; set; }
        public uint UsageParameter { get; set; }
        public byte Unknown4 { get; set; }
        public byte AquariumTier { get; set; }
        public LazyRow< CustomTalk > CustomTalk { get; set; }
        public LazyRow< Item > Item { get; set; }
        public bool DestroyOnRemoval { get; set; }
        public LazyRow< HousingPlacement > Tooltip { get; set; }
        public byte Unknown10 { get; set; }
        public byte Unknown11 { get; set; }
        public byte Unknown12 { get; set; }
        public bool Unknown13 { get; set; }
        public bool Unknown14 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            ModelKey = parser.ReadColumn< ushort >( 0 );
            HousingItemCategory = parser.ReadColumn< byte >( 1 );
            UsageType = parser.ReadColumn< byte >( 2 );
            UsageParameter = parser.ReadColumn< uint >( 3 );
            Unknown4 = parser.ReadColumn< byte >( 4 );
            AquariumTier = parser.ReadColumn< byte >( 5 );
            CustomTalk = new LazyRow< CustomTalk >( gameData, parser.ReadColumn< uint >( 6 ), language );
            Item = new LazyRow< Item >( gameData, parser.ReadColumn< uint >( 7 ), language );
            DestroyOnRemoval = parser.ReadColumn< bool >( 8 );
            #warning generator warning: the definition for this field (Tooltip) has an invalid type for a LazyRow - is a bool when should be numeric!
            Unknown10 = parser.ReadColumn< byte >( 10 );
            Unknown11 = parser.ReadColumn< byte >( 11 );
            Unknown12 = parser.ReadColumn< byte >( 12 );
            Unknown13 = parser.ReadColumn< bool >( 13 );
            Unknown14 = parser.ReadColumn< bool >( 14 );
        }
    }
}