// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "LogMessage", columnHash: 0xf3a6d024 )]
    public class LogMessage : ExcelRow
    {
        
        public ushort LogKind;
        public ushort Unknown1;
        public byte Unknown2;
        public bool Unknown3;
        public SeString Text;
        

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