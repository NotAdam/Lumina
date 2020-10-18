// ReSharper disable All

using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "BGMSwitch", columnHash: 0x0989d4f2 )]
    public class BGMSwitch : IExcelRow
    {
        
        public LazyRow< BGMSystemDefine > BGMSystemDefine;
        public LazyRow< Quest > Quest;
        public byte Unknown2;
        public LazyRow< BGM > BGM;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            BGMSystemDefine = new LazyRow< BGMSystemDefine >( lumina, parser.ReadColumn< byte >( 0 ), language );
            Quest = new LazyRow< Quest >( lumina, parser.ReadColumn< uint >( 1 ), language );
            Unknown2 = parser.ReadColumn< byte >( 2 );
            BGM = new LazyRow< BGM >( lumina, parser.ReadColumn< ushort >( 3 ), language );
        }
    }
}