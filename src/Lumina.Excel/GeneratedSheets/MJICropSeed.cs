// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "MJICropSeed", columnHash: 0xcd7b9ae9 )]
    public partial class MJICropSeed : ExcelRow
    {
        
        public LazyRow< Item > Item { get; set; }
        public ushort Unknown1 { get; set; }
        public uint Unknown2 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Item = new LazyRow< Item >( gameData, parser.ReadColumn< uint >( 0 ), language );
            Unknown1 = parser.ReadColumn< ushort >( 1 );
            Unknown2 = parser.ReadColumn< uint >( 2 );
        }
    }
}