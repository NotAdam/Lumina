// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "PresetCameraAdjust", columnHash: 0x4cdff077 )]
    public class PresetCameraAdjust : ExcelRow
    {
        
        public float Hyur_M;
        public float Hyur_F;
        public float Elezen_M;
        public float Elezen_F;
        public float Lalafell_M;
        public float Lalafell_F;
        public float Miqote_M;
        public float Miqote_F;
        public float Roe_M;
        public float Roe_F;
        public float Hrothgar_M;
        public float Hrothgar_F;
        public float Viera_M;
        public float Viera_F;
        

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
        }
    }
}