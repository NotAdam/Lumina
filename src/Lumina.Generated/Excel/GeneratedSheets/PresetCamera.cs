using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "PresetCamera", columnHash: 0x7d6930eb )]
    public class PresetCamera : IExcelRow
    {
        
        public ushort EID;
        public float PosX;
        public float PosY;
        public float PosZ;
        public float Elezen;
        public float Lalafell;
        public float Miqote;
        public float Roe;
        public float Hrothgar;
        public float Viera;
        public float Hyur_F;
        public float Elezen_F;
        public float Lalafell_F;
        public float Miqote_F;
        public float Roe_F;
        public float Hrothgar_F;
        public float Viera_F;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

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
            Hyur_F = parser.ReadColumn< float >( 10 );
            Elezen_F = parser.ReadColumn< float >( 11 );
            Lalafell_F = parser.ReadColumn< float >( 12 );
            Miqote_F = parser.ReadColumn< float >( 13 );
            Roe_F = parser.ReadColumn< float >( 14 );
            Hrothgar_F = parser.ReadColumn< float >( 15 );
            Viera_F = parser.ReadColumn< float >( 16 );
        }
    }
}