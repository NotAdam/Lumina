// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "StatusLoopVFX", columnHash: 0x69d57da3 )]
    public partial class StatusLoopVFX : ExcelRow
    {
        
        public LazyRow< VFX > VFX { get; set; }
        public byte Unknown1 { get; set; }
        public LazyRow< VFX > VFX2 { get; set; }
        public byte Unknown3 { get; set; }
        public LazyRow< VFX > VFX3 { get; set; }
        public byte Unknown5 { get; set; }
        public byte Unknown6 { get; set; }
        public bool Unknown7 { get; set; }
        public bool Unknown8 { get; set; }
        public bool Unknown9 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            VFX = new LazyRow< VFX >( gameData, parser.ReadColumn< ushort >( 0 ), language );
            Unknown1 = parser.ReadColumn< byte >( 1 );
            VFX2 = new LazyRow< VFX >( gameData, parser.ReadColumn< ushort >( 2 ), language );
            Unknown3 = parser.ReadColumn< byte >( 3 );
            VFX3 = new LazyRow< VFX >( gameData, parser.ReadColumn< ushort >( 4 ), language );
            Unknown5 = parser.ReadColumn< byte >( 5 );
            Unknown6 = parser.ReadColumn< byte >( 6 );
            Unknown7 = parser.ReadColumn< bool >( 7 );
            Unknown8 = parser.ReadColumn< bool >( 8 );
            Unknown9 = parser.ReadColumn< bool >( 9 );
        }
    }
}