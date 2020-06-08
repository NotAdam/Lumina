using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "AirshipExplorationPoint", columnHash: 0x307f38a2 )]
    public class AirshipExplorationPoint : IExcelRow
    {
        
        public string Name;
        public string NameShort;
        public bool Unknown2;
        public short Unknown3;
        public short Unknown4;
        public byte RequiredLevel;
        public ushort RequiredFuel;
        public ushort Durationmin;
        public ushort Unknown8;
        public byte Unknown9;
        public byte RequiredSurveillance;
        public byte Unknown11;
        public byte Unknown12;
        public uint ExpReward;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Name = parser.ReadColumn< string >( 0 );
            NameShort = parser.ReadColumn< string >( 1 );
            Unknown2 = parser.ReadColumn< bool >( 2 );
            Unknown3 = parser.ReadColumn< short >( 3 );
            Unknown4 = parser.ReadColumn< short >( 4 );
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