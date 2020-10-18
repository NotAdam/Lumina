// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "SwitchTalkVariation", columnHash: 0x031e9614 )]
    public class SwitchTalkVariation : IExcelRow
    {
        
        public uint Quest0;
        public LazyRow< Quest > Quest1;
        public byte Unknown2;
        public LazyRow< DefaultTalk > DefaultTalk;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Quest0 = parser.ReadColumn< uint >( 0 );
            Quest1 = new LazyRow< Quest >( lumina, parser.ReadColumn< uint >( 1 ), language );
            Unknown2 = parser.ReadColumn< byte >( 2 );
            DefaultTalk = new LazyRow< DefaultTalk >( lumina, parser.ReadColumn< uint >( 3 ), language );
        }
    }
}