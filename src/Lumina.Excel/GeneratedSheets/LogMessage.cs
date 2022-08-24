// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "LogMessage", columnHash: 0xf3a6d024 )]
    public partial class LogMessage : ExcelRow
    {
        
        public ushort LogKind { get; set; }
        public ushort Unknown1 { get; set; }
        public byte Unknown2 { get; set; }
        public bool Unknown3 { get; set; }
        public SeString Text { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            LogKind = parser.ReadColumn< ushort >( 0 );
            Unknown1 = parser.ReadColumn< ushort >( 1 );
            Unknown2 = parser.ReadColumn< byte >( 2 );
            Unknown3 = parser.ReadColumn< bool >( 3 );
            Text = parser.ReadColumn< SeString >( 4 );
        }
    }
}