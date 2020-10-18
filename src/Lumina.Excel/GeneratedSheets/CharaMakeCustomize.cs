// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "CharaMakeCustomize", columnHash: 0x2ba6bf0f )]
    public class CharaMakeCustomize : IExcelRow
    {
        
        public byte FeatureID;
        public uint Icon;
        public ushort Data;
        public bool IsPurchasable;
        public LazyRow< Lobby > Hint;
        public LazyRow< Item > HintItem;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            FeatureID = parser.ReadColumn< byte >( 0 );
            Icon = parser.ReadColumn< uint >( 1 );
            Data = parser.ReadColumn< ushort >( 2 );
            IsPurchasable = parser.ReadColumn< bool >( 3 );
            Hint = new LazyRow< Lobby >( lumina, parser.ReadColumn< uint >( 4 ), language );
            HintItem = new LazyRow< Item >( lumina, parser.ReadColumn< uint >( 5 ), language );
        }
    }
}