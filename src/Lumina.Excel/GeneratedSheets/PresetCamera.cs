// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "PresetCamera", columnHash: 0x246479ab )]
    public partial class PresetCamera : ExcelRow
    {
        
        public ushort EID { get; set; }
        public float PosX { get; set; }
        public float PosY { get; set; }
        public float PosZ { get; set; }
        public float Elezen { get; set; }
        public float Lalafell { get; set; }
        public float Miqote { get; set; }
        public float Roe { get; set; }
        public float Hrothgar { get; set; }
        public float Viera { get; set; }
        public float Unknown10 { get; set; }
        public float Hyur_F { get; set; }
        public float Elezen_F { get; set; }
        public float Lalafell_F { get; set; }
        public float Miqote_F { get; set; }
        public float Roe_F { get; set; }
        public float Hrothgar_F { get; set; }
        public float Viera_F { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            EID = parser.ReadColumn< ushort >( 0 );
            PosX = parser.ReadColumn< float >( 1 );
            PosY = parser.ReadColumn< float >( 2 );
            PosZ = parser.ReadColumn< float >( 3 );
            Elezen = parser.ReadColumn< float >( 4 );
            Lalafell = parser.ReadColumn< float >( 5 );
            Miqote = parser.ReadColumn< float >( 6 );
            Roe = parser.ReadColumn< float >( 7 );
            Hrothgar = parser.ReadColumn< float >( 8 );
            Viera = parser.ReadColumn< float >( 9 );
            Unknown10 = parser.ReadColumn< float >( 10 );
            Hyur_F = parser.ReadColumn< float >( 11 );
            Elezen_F = parser.ReadColumn< float >( 12 );
            Lalafell_F = parser.ReadColumn< float >( 13 );
            Miqote_F = parser.ReadColumn< float >( 14 );
            Roe_F = parser.ReadColumn< float >( 15 );
            Hrothgar_F = parser.ReadColumn< float >( 16 );
            Viera_F = parser.ReadColumn< float >( 17 );
        }
    }
}