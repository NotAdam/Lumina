// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ScenarioTreeTips", columnHash: 0x71371b8c )]
    public partial class ScenarioTreeTips : ExcelRow
    {
        
        public byte Unknown0 { get; set; }
        public uint Tips1 { get; set; }
        public ushort Unknown2 { get; set; }
        public LazyRow< ScenarioTree > Tips2 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Unknown0 = parser.ReadColumn< byte >( 0 );
            Tips1 = parser.ReadColumn< uint >( 1 );
            Unknown2 = parser.ReadColumn< ushort >( 2 );
            Tips2 = new LazyRow< ScenarioTree >( gameData, parser.ReadColumn< uint >( 3 ), language );
        }
    }
}