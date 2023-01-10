// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ContentType", columnHash: 0xf1b99f5d )]
    public partial class ContentType : ExcelRow
    {
        
        public SeString Name { get; set; }
        public uint Icon { get; set; }
        public uint IconDutyFinder { get; set; }
        public byte Unknown3 { get; set; }
        public byte Unknown4 { get; set; }
        public uint Unknown5 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Name = parser.ReadColumn< SeString >( 0 );
            Icon = parser.ReadColumn< uint >( 1 );
            IconDutyFinder = parser.ReadColumn< uint >( 2 );
            Unknown3 = parser.ReadColumn< byte >( 3 );
            Unknown4 = parser.ReadColumn< byte >( 4 );
            Unknown5 = parser.ReadColumn< uint >( 5 );
        }
    }
}