// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "InstanceContentCSBonus", columnHash: 0x43042e70 )]
    public class InstanceContentCSBonus : IExcelRow
    {
        
        public LazyRow< InstanceContent > Instance;
        public LazyRow< Item > Item;
        public byte Unknown2;
        public byte Unknown540;
        public byte Unknown541;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Instance = new LazyRow< InstanceContent >( lumina, parser.ReadColumn< ushort >( 0 ), language );
            Item = new LazyRow< Item >( lumina, parser.ReadColumn< uint >( 1 ), language );
            Unknown2 = parser.ReadColumn< byte >( 2 );
            Unknown540 = parser.ReadColumn< byte >( 3 );
            Unknown541 = parser.ReadColumn< byte >( 4 );
        }
    }
}