// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "DisposalShop", columnHash: 0xca43e122 )]
    public class DisposalShop : ExcelRow
    {
        
        public SeString ShopName;
        public int Unknown1;
        public int Unknown2;
        public int Unknown3;
        public int Unknown4;
        public int Unknown5;
        public int Unknown6;
        public int Unknown7;
        public int Unknown8;
        public ushort Unknown9;
        public ushort Unknown10;
        public ushort Unknown11;
        public ushort Unknown12;
        public ushort Unknown13;
        public ushort Unknown14;
        public ushort Unknown15;
        public ushort Unknown16;
        public bool Unknown17;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            ShopName = parser.ReadColumn< SeString >( 0 );
            Unknown1 = parser.ReadColumn< int >( 1 );
            Unknown2 = parser.ReadColumn< int >( 2 );
            Unknown3 = parser.ReadColumn< int >( 3 );
            Unknown4 = parser.ReadColumn< int >( 4 );
            Unknown5 = parser.ReadColumn< int >( 5 );
            Unknown6 = parser.ReadColumn< int >( 6 );
            Unknown7 = parser.ReadColumn< int >( 7 );
            Unknown8 = parser.ReadColumn< int >( 8 );
            Unknown9 = parser.ReadColumn< ushort >( 9 );
            Unknown10 = parser.ReadColumn< ushort >( 10 );
            Unknown11 = parser.ReadColumn< ushort >( 11 );
            Unknown12 = parser.ReadColumn< ushort >( 12 );
            Unknown13 = parser.ReadColumn< ushort >( 13 );
            Unknown14 = parser.ReadColumn< ushort >( 14 );
            Unknown15 = parser.ReadColumn< ushort >( 15 );
            Unknown16 = parser.ReadColumn< ushort >( 16 );
            Unknown17 = parser.ReadColumn< bool >( 17 );
        }
    }
}