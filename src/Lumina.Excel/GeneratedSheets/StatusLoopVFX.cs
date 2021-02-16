// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "StatusLoopVFX", columnHash: 0xaa82c4a9 )]
    public class StatusLoopVFX : ExcelRow
    {
        
        public LazyRow< VFX > VFX;
        public byte Unknown1;
        public LazyRow< VFX > VFX2;
        public byte Unknown3;
        public LazyRow< VFX > VFX3;
        public byte Unknown5;
        public byte Unknown6;
        public bool Unknown7;
        public bool Unknown8;
        

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
        }
    }
}