// ReSharper disable All

using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "CreditList", columnHash: 0x089033fa )]
    public class CreditList : IExcelRow
    {
        
        public ushort Scale;
        public uint Icon;
        public uint Font;
        public byte Unknown3;
        public byte Unknown4;
        public LazyRow< CreditListText > Cast;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Scale = parser.ReadColumn< ushort >( 0 );
            Icon = parser.ReadColumn< uint >( 1 );
            Font = parser.ReadColumn< uint >( 2 );
            Unknown3 = parser.ReadColumn< byte >( 3 );
            Unknown4 = parser.ReadColumn< byte >( 4 );
            Cast = new LazyRow< CreditListText >( lumina, parser.ReadColumn< uint >( 5 ), language );
        }
    }
}