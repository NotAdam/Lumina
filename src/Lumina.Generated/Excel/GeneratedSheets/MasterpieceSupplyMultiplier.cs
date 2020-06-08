using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "MasterpieceSupplyMultiplier", columnHash: 0x1b64fcf8 )]
    public class MasterpieceSupplyMultiplier : IExcelRow
    {
        
        public ushort[] XpMultiplier;
        public ushort Unknown2;
        public ushort Unknown3;
        public ushort[] CurrencyMultiplier;
        public ushort Unknown6;
        public ushort Unknown7;
        public ushort Unknown8;
        public ushort Unknown9;
        public ushort Unknown10;
        public ushort Unknown11;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            for( var i = 0; i < 2; i++ )
                XpMultiplier[ i ] = parser.ReadColumn< ushort >( 0 + i );
            Unknown2 = parser.ReadColumn< ushort >( 2 );
            Unknown3 = parser.ReadColumn< ushort >( 3 );
            for( var i = 0; i < 2; i++ )
                CurrencyMultiplier[ i ] = parser.ReadColumn< ushort >( 4 + i );
            Unknown6 = parser.ReadColumn< ushort >( 6 );
            Unknown7 = parser.ReadColumn< ushort >( 7 );
            Unknown8 = parser.ReadColumn< ushort >( 8 );
            Unknown9 = parser.ReadColumn< ushort >( 9 );
            Unknown10 = parser.ReadColumn< ushort >( 10 );
            Unknown11 = parser.ReadColumn< ushort >( 11 );
        }
    }
}