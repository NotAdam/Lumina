// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "DynamicEventType", columnHash: 0x6be0e840 )]
    public partial class DynamicEventType : ExcelRow
    {
        
        public uint IconObjective0 { get; set; }
        public uint IconObjective1 { get; set; }
        public uint Unknown2 { get; set; }
        public uint Unknown3 { get; set; }
        public uint Unknown4 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            IconObjective0 = parser.ReadColumn< uint >( 0 );
            IconObjective1 = parser.ReadColumn< uint >( 1 );
            Unknown2 = parser.ReadColumn< uint >( 2 );
            Unknown3 = parser.ReadColumn< uint >( 3 );
            Unknown4 = parser.ReadColumn< uint >( 4 );
        }
    }
}