// ReSharper disable All

using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ContentMemberType", columnHash: 0x48587c6d )]
    public class ContentMemberType : IExcelRow
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
        public bool Unknown13;
        public bool Unknown14;
        public bool Unknown15;
        public bool Unknown16;
        public bool Unknown17;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

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
            Unknown13 = parser.ReadColumn< bool >( 13 );
            Unknown14 = parser.ReadColumn< bool >( 14 );
            Unknown15 = parser.ReadColumn< bool >( 15 );
            Unknown16 = parser.ReadColumn< bool >( 16 );
            Unknown17 = parser.ReadColumn< bool >( 17 );
        }
    }
}