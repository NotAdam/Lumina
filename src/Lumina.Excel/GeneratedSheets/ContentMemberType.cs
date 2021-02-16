// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ContentMemberType", columnHash: 0x65d5ee00 )]
    public class ContentMemberType : ExcelRow
    {
        
        public bool Unknown0;
        public byte Unknown1;
        public bool Unknown2;
        public bool Unknown3;
        public byte Unknown4;
        public byte Unknown5;
        public byte Unknown6;
        public byte Unknown7;
        public byte Unknown8;
        public byte TanksPerParty;
        public byte HealersPerParty;
        public byte MeleesPerParty;
        public byte RangedPerParty;
        public byte Unknown54;
        public bool Unknown14;
        public bool Unknown15;
        public bool Unknown16;
        public bool Unknown17;
        public bool Unknown18;
        

        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Unknown0 = parser.ReadColumn< bool >( 0 );
            Unknown1 = parser.ReadColumn< byte >( 1 );
            Unknown2 = parser.ReadColumn< bool >( 2 );
            Unknown3 = parser.ReadColumn< bool >( 3 );
            Unknown4 = parser.ReadColumn< byte >( 4 );
            Unknown5 = parser.ReadColumn< byte >( 5 );
            Unknown6 = parser.ReadColumn< byte >( 6 );
            Unknown7 = parser.ReadColumn< byte >( 7 );
            Unknown8 = parser.ReadColumn< byte >( 8 );
            TanksPerParty = parser.ReadColumn< byte >( 9 );
            HealersPerParty = parser.ReadColumn< byte >( 10 );
            MeleesPerParty = parser.ReadColumn< byte >( 11 );
            RangedPerParty = parser.ReadColumn< byte >( 12 );
            Unknown54 = parser.ReadColumn< byte >( 13 );
            Unknown14 = parser.ReadColumn< bool >( 14 );
            Unknown15 = parser.ReadColumn< bool >( 15 );
            Unknown16 = parser.ReadColumn< bool >( 16 );
            Unknown17 = parser.ReadColumn< bool >( 17 );
            Unknown18 = parser.ReadColumn< bool >( 18 );
        }
    }
}