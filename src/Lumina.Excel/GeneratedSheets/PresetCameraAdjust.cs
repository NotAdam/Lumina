// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "PresetCameraAdjust", columnHash: 0x1d35bc8f )]
    public partial class PresetCameraAdjust : ExcelRow
    {
        
        public float Hyur_M { get; set; }
        public float Hyur_F { get; set; }
        public float Elezen_M { get; set; }
        public float Elezen_F { get; set; }
        public float Lalafell_M { get; set; }
        public float Lalafell_F { get; set; }
        public float Miqote_M { get; set; }
        public float Miqote_F { get; set; }
        public float Roe_M { get; set; }
        public float Roe_F { get; set; }
        public float Hrothgar_M { get; set; }
        public float Hrothgar_F { get; set; }
        public float Viera_M { get; set; }
        public float Viera_F { get; set; }
        public float Unknown14 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Hyur_M = parser.ReadColumn< float >( 0 );
            Hyur_F = parser.ReadColumn< float >( 1 );
            Elezen_M = parser.ReadColumn< float >( 2 );
            Elezen_F = parser.ReadColumn< float >( 3 );
            Lalafell_M = parser.ReadColumn< float >( 4 );
            Lalafell_F = parser.ReadColumn< float >( 5 );
            Miqote_M = parser.ReadColumn< float >( 6 );
            Miqote_F = parser.ReadColumn< float >( 7 );
            Roe_M = parser.ReadColumn< float >( 8 );
            Roe_F = parser.ReadColumn< float >( 9 );
            Hrothgar_M = parser.ReadColumn< float >( 10 );
            Hrothgar_F = parser.ReadColumn< float >( 11 );
            Viera_M = parser.ReadColumn< float >( 12 );
            Viera_F = parser.ReadColumn< float >( 13 );
            Unknown14 = parser.ReadColumn< float >( 14 );
        }
    }
}