// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "MountCustomize", columnHash: 0x82bd7e3f )]
    public partial class MountCustomize : ExcelRow
    {
        
        public bool Unknown0 { get; set; }
        public ushort HyurMaleScale { get; set; }
        public ushort HyurFemaleScale { get; set; }
        public ushort ElezenMaleScale { get; set; }
        public ushort ElezenFemaleScale { get; set; }
        public ushort LalaMaleScale { get; set; }
        public ushort LalaFemaleScale { get; set; }
        public ushort MiqoMaleScale { get; set; }
        public ushort MiqoFemaleScale { get; set; }
        public ushort RoeMaleScale { get; set; }
        public ushort RoeFemaleScale { get; set; }
        public ushort AuRaMaleScale { get; set; }
        public ushort AuRaFemaleScale { get; set; }
        public ushort HrothgarMaleScale { get; set; }
        public ushort HrothgarFemaleScale { get; set; }
        public ushort VieraMaleScale { get; set; }
        public ushort VieraFemaleScale { get; set; }
        public byte HyurMaleCameraHeight { get; set; }
        public byte HyurFemaleCameraHeight { get; set; }
        public byte ElezenMaleCameraHeight { get; set; }
        public byte ElezenFemaleCameraHeight { get; set; }
        public byte LalaMaleCameraHeight { get; set; }
        public byte LalaFemaleCameraHeight { get; set; }
        public byte MiqoMaleCameraHeight { get; set; }
        public byte MiqoFemaleCameraHeight { get; set; }
        public byte RoeMaleCameraHeight { get; set; }
        public byte RoeFemaleCameraHeight { get; set; }
        public byte AuRaMaleCameraHeight { get; set; }
        public byte AuRaFemaleCameraHeight { get; set; }
        public byte HrothgarMaleCameraHeight { get; set; }
        public byte HrothgarRoeFemaleCameraHeight { get; set; }
        public byte VieraMaleCameraHeight { get; set; }
        public byte VieraFemaleCameraHeight { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

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