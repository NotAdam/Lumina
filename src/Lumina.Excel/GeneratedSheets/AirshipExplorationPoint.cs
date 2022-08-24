// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "AirshipExplorationPoint", columnHash: 0x307f38a2 )]
    public partial class AirshipExplorationPoint : ExcelRow
    {
        
        public SeString Name { get; set; }
        public SeString NameShort { get; set; }
        public bool Passengers { get; set; }
        public short X { get; set; }
        public short Y { get; set; }
        public byte RankReq { get; set; }
        public ushort CeruleumTankReq { get; set; }
        public ushort SurveyDurationmin { get; set; }
        public ushort SurveyDistance { get; set; }
        public byte Unknown9 { get; set; }
        public byte SurveillanceReq { get; set; }
        public byte Unknown11 { get; set; }
        public byte Unknown12 { get; set; }
        public uint ExpReward { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Name = parser.ReadColumn< SeString >( 0 );
            NameShort = parser.ReadColumn< SeString >( 1 );
            Passengers = parser.ReadColumn< bool >( 2 );
            X = parser.ReadColumn< short >( 3 );
            Y = parser.ReadColumn< short >( 4 );
            RankReq = parser.ReadColumn< byte >( 5 );
            CeruleumTankReq = parser.ReadColumn< ushort >( 6 );
            SurveyDurationmin = parser.ReadColumn< ushort >( 7 );
            SurveyDistance = parser.ReadColumn< ushort >( 8 );
            Unknown9 = parser.ReadColumn< byte >( 9 );
            SurveillanceReq = parser.ReadColumn< byte >( 10 );
            Unknown11 = parser.ReadColumn< byte >( 11 );
            Unknown12 = parser.ReadColumn< byte >( 12 );
            ExpReward = parser.ReadColumn< uint >( 13 );
        }
    }
}