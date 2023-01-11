// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "HousingYardObject", columnHash: 0x8ecbe67c )]
    public partial class HousingYardObject : ExcelRow
    {
        
        public ushort ModelKey { get; set; }
        public byte HousingItemCategory { get; set; }
        public byte UsageType { get; set; }
        public uint UsageParameter { get; set; }
        public byte Unknown4 { get; set; }
        public LazyRow< CustomTalk > CustomTalk { get; set; }
        public LazyRow< Item > Item { get; set; }
        public bool DestroyOnRemoval { get; set; }
        public bool Unknown8 { get; set; }
        public bool Unknown9 { get; set; }
        public byte Unknown10 { get; set; }
        public byte Unknown11 { get; set; }
        public byte Unknown12 { get; set; }
        public bool Unknown13 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            ModelKey = parser.ReadColumn< ushort >( 0 );
            HousingItemCategory = parser.ReadColumn< byte >( 1 );
            UsageType = parser.ReadColumn< byte >( 2 );
            UsageParameter = parser.ReadColumn< uint >( 3 );
            Unknown4 = parser.ReadColumn< byte >( 4 );
            CustomTalk = new LazyRow< CustomTalk >( gameData, parser.ReadColumn< uint >( 5 ), language );
            Item = new LazyRow< Item >( gameData, parser.ReadColumn< uint >( 6 ), language );
            DestroyOnRemoval = parser.ReadColumn< bool >( 7 );
            Unknown8 = parser.ReadColumn< bool >( 8 );
            Unknown9 = parser.ReadColumn< bool >( 9 );
            Unknown10 = parser.ReadColumn< byte >( 10 );
            Unknown11 = parser.ReadColumn< byte >( 11 );
            Unknown12 = parser.ReadColumn< byte >( 12 );
            Unknown13 = parser.ReadColumn< bool >( 13 );
        }
    }
}