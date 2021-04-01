// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "MasterpieceSupplyMultiplier", columnHash: 0x1b64fcf8 )]
    public class MasterpieceSupplyMultiplier : ExcelRow
    {
        
        public ushort[] XpMultiplier { get; set; }
        public ushort Unknown2 { get; set; }
        public ushort Unknown3 { get; set; }
        public ushort[] CurrencyMultiplier { get; set; }
        public ushort Unknown6 { get; set; }
        public ushort Unknown7 { get; set; }
        public ushort Unknown8 { get; set; }
        public ushort Unknown9 { get; set; }
        public ushort Unknown10 { get; set; }
        public ushort Unknown11 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            XpMultiplier = new ushort[ 2 ];
            for( var i = 0; i < 2; i++ )
                XpMultiplier[ i ] = parser.ReadColumn< ushort >( 0 + i );
            Unknown2 = parser.ReadColumn< ushort >( 2 );
            Unknown3 = parser.ReadColumn< ushort >( 3 );
            CurrencyMultiplier = new ushort[ 2 ];
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