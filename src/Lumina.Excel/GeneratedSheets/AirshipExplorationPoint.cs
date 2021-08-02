// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "AirshipExplorationPoint", columnHash: 0x307f38a2 )]
    public class AirshipExplorationPoint : ExcelRow
    {
        
        public SeString Name { get; set; }
        public SeString NameShort { get; set; }
        public bool Unknown2 { get; set; }
        public short X { get; set; }
        public short Y { get; set; }
        public byte RequiredLevel { get; set; }
        public ushort RequiredFuel { get; set; }
        public ushort Durationmin { get; set; }
        public ushort Unknown8 { get; set; }
        public byte Unknown9 { get; set; }
        public byte RequiredSurveillance { get; set; }
        public byte Unknown11 { get; set; }
        public byte Unknown12 { get; set; }
        public uint ExpReward { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Name = parser.ReadColumn< SeString >( 0 );
            NameShort = parser.ReadColumn< SeString >( 1 );
            Unknown2 = parser.ReadColumn< bool >( 2 );
            X = parser.ReadColumn< short >( 3 );
            Y = parser.ReadColumn< short >( 4 );
            RequiredLevel = parser.ReadColumn< byte >( 5 );
            RequiredFuel = parser.ReadColumn< ushort >( 6 );
            Durationmin = parser.ReadColumn< ushort >( 7 );
            Unknown8 = parser.ReadColumn< ushort >( 8 );
            Unknown9 = parser.ReadColumn< byte >( 9 );
            RequiredSurveillance = parser.ReadColumn< byte >( 10 );
            Unknown11 = parser.ReadColumn< byte >( 11 );
            Unknown12 = parser.ReadColumn< byte >( 12 );
            ExpReward = parser.ReadColumn< uint >( 13 );
        }
    }
}