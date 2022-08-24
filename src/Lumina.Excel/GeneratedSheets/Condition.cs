// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Condition", columnHash: 0xf234a002 )]
    public partial class Condition : ExcelRow
    {
        
        public bool Unknown0 { get; set; }
        public byte Unknown1 { get; set; }
        public LazyRow< LogMessage > LogMessage { get; set; }
        public byte Unknown3 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Unknown0 = parser.ReadColumn< bool >( 0 );
            Unknown1 = parser.ReadColumn< byte >( 1 );
            LogMessage = new LazyRow< LogMessage >( gameData, parser.ReadColumn< uint >( 2 ), language );
            Unknown3 = parser.ReadColumn< byte >( 3 );
        }
    }
}