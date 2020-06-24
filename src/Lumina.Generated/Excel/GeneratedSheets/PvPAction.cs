using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "PvPAction", columnHash: 0x3818ca1d )]
    public class PvPAction : IExcelRow
    {
        
        public LazyRow< Action > Action;
        public byte Unknown1;
        public ushort Unknown2;
        public ushort Unknown3;
        public ushort Unknown4;
        public bool[] GrandCompany;
        public byte Unknown8;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Action = new LazyRow< Action >( lumina, parser.ReadColumn< ushort >( 0 ), language );
            Unknown1 = parser.ReadColumn< byte >( 1 );
            Unknown2 = parser.ReadColumn< ushort >( 2 );
            Unknown3 = parser.ReadColumn< ushort >( 3 );
            Unknown4 = parser.ReadColumn< ushort >( 4 );
            GrandCompany = new bool[ 3 ];
            for( var i = 0; i < 3; i++ )
                GrandCompany[ i ] = parser.ReadColumn< bool >( 5 + i );
            Unknown8 = parser.ReadColumn< byte >( 8 );
        }
    }
}