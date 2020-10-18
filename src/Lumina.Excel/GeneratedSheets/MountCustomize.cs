// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "MountCustomize", columnHash: 0x82bd7e3f )]
    public class MountCustomize : IExcelRow
    {
        
        public bool Unknown0;
        public ushort HyurMaleScale;
        public ushort HyurFemaleScale;
        public ushort ElezenMaleScale;
        public ushort ElezenFemaleScale;
        public ushort LalaMaleScale;
        public ushort LalaFemaleScale;
        public ushort MiqoMaleScale;
        public ushort MiqoFemaleScale;
        public ushort RoeMaleScale;
        public ushort RoeFemaleScale;
        public ushort AuRaMaleScale;
        public ushort AuRaFemaleScale;
        public ushort HrothgarMaleScale;
        public ushort HrothgarFemaleScale;
        public ushort VieraMaleScale;
        public ushort VieraFemaleScale;
        public byte HyurMaleCameraHeight;
        public byte HyurFemaleCameraHeight;
        public byte ElezenMaleCameraHeight;
        public byte ElezenFemaleCameraHeight;
        public byte LalaMaleCameraHeight;
        public byte LalaFemaleCameraHeight;
        public byte MiqoMaleCameraHeight;
        public byte MiqoFemaleCameraHeight;
        public byte RoeMaleCameraHeight;
        public byte RoeFemaleCameraHeight;
        public byte AuRaMaleCameraHeight;
        public byte AuRaFemaleCameraHeight;
        public byte HrothgarMaleCameraHeight;
        public byte HrothgarRoeFemaleCameraHeight;
        public byte VieraMaleCameraHeight;
        public byte VieraFemaleCameraHeight;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Unknown0 = parser.ReadColumn< bool >( 0 );
            HyurMaleScale = parser.ReadColumn< ushort >( 1 );
            HyurFemaleScale = parser.ReadColumn< ushort >( 2 );
            ElezenMaleScale = parser.ReadColumn< ushort >( 3 );
            ElezenFemaleScale = parser.ReadColumn< ushort >( 4 );
            LalaMaleScale = parser.ReadColumn< ushort >( 5 );
            LalaFemaleScale = parser.ReadColumn< ushort >( 6 );
            MiqoMaleScale = parser.ReadColumn< ushort >( 7 );
            MiqoFemaleScale = parser.ReadColumn< ushort >( 8 );
            RoeMaleScale = parser.ReadColumn< ushort >( 9 );
            RoeFemaleScale = parser.ReadColumn< ushort >( 10 );
            AuRaMaleScale = parser.ReadColumn< ushort >( 11 );
            AuRaFemaleScale = parser.ReadColumn< ushort >( 12 );
            HrothgarMaleScale = parser.ReadColumn< ushort >( 13 );
            HrothgarFemaleScale = parser.ReadColumn< ushort >( 14 );
            VieraMaleScale = parser.ReadColumn< ushort >( 15 );
            VieraFemaleScale = parser.ReadColumn< ushort >( 16 );
            HyurMaleCameraHeight = parser.ReadColumn< byte >( 17 );
            HyurFemaleCameraHeight = parser.ReadColumn< byte >( 18 );
            ElezenMaleCameraHeight = parser.ReadColumn< byte >( 19 );
            ElezenFemaleCameraHeight = parser.ReadColumn< byte >( 20 );
            LalaMaleCameraHeight = parser.ReadColumn< byte >( 21 );
            LalaFemaleCameraHeight = parser.ReadColumn< byte >( 22 );
            MiqoMaleCameraHeight = parser.ReadColumn< byte >( 23 );
            MiqoFemaleCameraHeight = parser.ReadColumn< byte >( 24 );
            RoeMaleCameraHeight = parser.ReadColumn< byte >( 25 );
            RoeFemaleCameraHeight = parser.ReadColumn< byte >( 26 );
            AuRaMaleCameraHeight = parser.ReadColumn< byte >( 27 );
            AuRaFemaleCameraHeight = parser.ReadColumn< byte >( 28 );
            HrothgarMaleCameraHeight = parser.ReadColumn< byte >( 29 );
            HrothgarRoeFemaleCameraHeight = parser.ReadColumn< byte >( 30 );
            VieraMaleCameraHeight = parser.ReadColumn< byte >( 31 );
            VieraFemaleCameraHeight = parser.ReadColumn< byte >( 32 );
        }
    }
}