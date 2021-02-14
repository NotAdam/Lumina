// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "DisposalShopItem", columnHash: 0x1990ed53 )]
    public class DisposalShopItem : ExcelRow
    {
        
        public LazyRow< Item > ItemDisposed;
        public bool Unknown1;
        public LazyRow< Item > ItemReceived;
        public bool Unknown3;
        public uint QuantityReceived;
        public ushort Unknown5;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            ItemDisposed = new LazyRow< Item >( lumina, parser.ReadColumn< int >( 0 ), language );
            Unknown1 = parser.ReadColumn< bool >( 1 );
            ItemReceived = new LazyRow< Item >( lumina, parser.ReadColumn< int >( 2 ), language );
            Unknown3 = parser.ReadColumn< bool >( 3 );
            QuantityReceived = parser.ReadColumn< uint >( 4 );
            Unknown5 = parser.ReadColumn< ushort >( 5 );
        }
    }
}