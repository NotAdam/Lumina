// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "InstanceContentQICData", columnHash: 0xcfc59262 )]
    public partial class InstanceContentQICData : ExcelRow
    {
        
        public byte Unknown0 { get; set; }
        public bool Unknown1 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Unknown0 = parser.ReadColumn< byte >( 0 );
            Unknown1 = parser.ReadColumn< bool >( 1 );
        }
    }
}