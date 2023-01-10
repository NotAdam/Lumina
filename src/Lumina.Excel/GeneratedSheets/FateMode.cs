// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "FateMode", columnHash: 0x6be0e840 )]
    public partial class FateMode : ExcelRow
    {
        
        public uint Unknown0 { get; set; }
        public uint MotivationIcon { get; set; }
        public uint MotivationMapMarker { get; set; }
        public uint ObjectiveIcon { get; set; }
        public uint ObjectiveMapMarker { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Unknown0 = parser.ReadColumn< uint >( 0 );
            MotivationIcon = parser.ReadColumn< uint >( 1 );
            MotivationMapMarker = parser.ReadColumn< uint >( 2 );
            ObjectiveIcon = parser.ReadColumn< uint >( 3 );
            ObjectiveMapMarker = parser.ReadColumn< uint >( 4 );
        }
    }
}