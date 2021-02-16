// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "FCRank", columnHash: 0x0105b558 )]
    public class FCRank : ExcelRow
    {
        
        public uint NextPoint;
        public uint CurrentPoint;
        public ushort Rights;
        public ushort Unknown3;
        public ushort Unknown4;
        public byte FCActionActiveNum;
        public byte FCActionStockNum;
        public byte Unknown7;
        

        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            NextPoint = parser.ReadColumn< uint >( 0 );
            CurrentPoint = parser.ReadColumn< uint >( 1 );
            Rights = parser.ReadColumn< ushort >( 2 );
            Unknown3 = parser.ReadColumn< ushort >( 3 );
            Unknown4 = parser.ReadColumn< ushort >( 4 );
            FCActionActiveNum = parser.ReadColumn< byte >( 5 );
            FCActionStockNum = parser.ReadColumn< byte >( 6 );
            Unknown7 = parser.ReadColumn< byte >( 7 );
        }
    }
}