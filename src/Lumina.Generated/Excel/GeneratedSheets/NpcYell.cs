using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "NpcYell", columnHash: 0xbd07b3cb )]
    public class NpcYell : IExcelRow
    {
        
        public uint Unknown0;
        public byte Unknown1;
        public bool Unknown2;
        public bool Unknown3;
        public bool Unknown4;
        public byte OutputType;
        public float BalloonTime;
        public bool IsBalloonSlow;
        public bool BattleTalkTime;
        public float Text;
        public string Unknown10;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Unknown0 = parser.ReadColumn< uint >( 0 );
            Unknown1 = parser.ReadColumn< byte >( 1 );
            Unknown2 = parser.ReadColumn< bool >( 2 );
            Unknown3 = parser.ReadColumn< bool >( 3 );
            Unknown4 = parser.ReadColumn< bool >( 4 );
            OutputType = parser.ReadColumn< byte >( 5 );
            BalloonTime = parser.ReadColumn< float >( 6 );
            IsBalloonSlow = parser.ReadColumn< bool >( 7 );
            BattleTalkTime = parser.ReadColumn< bool >( 8 );
            Text = parser.ReadColumn< float >( 9 );
            Unknown10 = parser.ReadColumn< string >( 10 );
        }
    }
}