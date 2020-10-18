// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "StatusLoopVFX", columnHash: 0xe9330973 )]
    public class StatusLoopVFX : IExcelRow
    {
        
        public LazyRow< VFX > VFX;
        public byte Unknown1;
        public LazyRow< VFX > VFX2;
        public byte Unknown3;
        public LazyRow< VFX > VFX3;
        public byte Unknown5;
        public byte Unknown6;
        public bool Unknown7;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            VFX = new LazyRow< VFX >( lumina, parser.ReadColumn< ushort >( 0 ), language );
            Unknown1 = parser.ReadColumn< byte >( 1 );
            VFX2 = new LazyRow< VFX >( lumina, parser.ReadColumn< ushort >( 2 ), language );
            Unknown3 = parser.ReadColumn< byte >( 3 );
            VFX3 = new LazyRow< VFX >( lumina, parser.ReadColumn< ushort >( 4 ), language );
            Unknown5 = parser.ReadColumn< byte >( 5 );
            Unknown6 = parser.ReadColumn< byte >( 6 );
            Unknown7 = parser.ReadColumn< bool >( 7 );
        }
    }
}