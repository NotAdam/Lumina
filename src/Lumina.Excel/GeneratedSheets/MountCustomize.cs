// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "MountCustomize", columnHash: 0x859ade0f )]
    public partial class MountCustomize : ExcelRow
    {
        
        public bool Unknown0 { get; set; }
        public ushort HyurMidlanderMaleScale { get; set; }
        public ushort HyurMidlanderFemaleScale { get; set; }
        public ushort HyurHighlanderMaleScale { get; set; }
        public ushort HyurHighlanderFemaleScale { get; set; }
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
        public ushort VieraMaleScale { get; set; }
        public ushort VieraFemaleScale { get; set; }
        public ushort HyurMidlanderMaleCameraHeight { get; set; }
        public byte HyurMidlanderFemaleCameraHeight { get; set; }
        public byte HyurHighlanderMaleCameraHeight { get; set; }
        public byte HyurHighlanderFemaleCameraHeight { get; set; }
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
        public byte VieraMaleCameraHeight { get; set; }
        public byte VieraFemaleCameraHeight { get; set; }
        public byte Unknown35 { get; set; }
        public byte Unknown36 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Unknown0 = parser.ReadColumn< bool >( 0 );
            HyurMidlanderMaleScale = parser.ReadColumn< ushort >( 1 );
            HyurMidlanderFemaleScale = parser.ReadColumn< ushort >( 2 );
            HyurHighlanderMaleScale = parser.ReadColumn< ushort >( 3 );
            HyurHighlanderFemaleScale = parser.ReadColumn< ushort >( 4 );
            ElezenMaleScale = parser.ReadColumn< ushort >( 5 );
            ElezenFemaleScale = parser.ReadColumn< ushort >( 6 );
            LalaMaleScale = parser.ReadColumn< ushort >( 7 );
            LalaFemaleScale = parser.ReadColumn< ushort >( 8 );
            MiqoMaleScale = parser.ReadColumn< ushort >( 9 );
            MiqoFemaleScale = parser.ReadColumn< ushort >( 10 );
            RoeMaleScale = parser.ReadColumn< ushort >( 11 );
            RoeFemaleScale = parser.ReadColumn< ushort >( 12 );
            AuRaMaleScale = parser.ReadColumn< ushort >( 13 );
            AuRaFemaleScale = parser.ReadColumn< ushort >( 14 );
            HrothgarMaleScale = parser.ReadColumn< ushort >( 15 );
            VieraMaleScale = parser.ReadColumn< ushort >( 16 );
            VieraFemaleScale = parser.ReadColumn< ushort >( 17 );
            HyurMidlanderMaleCameraHeight = parser.ReadColumn< ushort >( 18 );
            HyurMidlanderFemaleCameraHeight = parser.ReadColumn< byte >( 19 );
            HyurHighlanderMaleCameraHeight = parser.ReadColumn< byte >( 20 );
            HyurHighlanderFemaleCameraHeight = parser.ReadColumn< byte >( 21 );
            ElezenMaleCameraHeight = parser.ReadColumn< byte >( 22 );
            ElezenFemaleCameraHeight = parser.ReadColumn< byte >( 23 );
            LalaMaleCameraHeight = parser.ReadColumn< byte >( 24 );
            LalaFemaleCameraHeight = parser.ReadColumn< byte >( 25 );
            MiqoMaleCameraHeight = parser.ReadColumn< byte >( 26 );
            MiqoFemaleCameraHeight = parser.ReadColumn< byte >( 27 );
            RoeMaleCameraHeight = parser.ReadColumn< byte >( 28 );
            RoeFemaleCameraHeight = parser.ReadColumn< byte >( 29 );
            AuRaMaleCameraHeight = parser.ReadColumn< byte >( 30 );
            AuRaFemaleCameraHeight = parser.ReadColumn< byte >( 31 );
            HrothgarMaleCameraHeight = parser.ReadColumn< byte >( 32 );
            VieraMaleCameraHeight = parser.ReadColumn< byte >( 33 );
            VieraFemaleCameraHeight = parser.ReadColumn< byte >( 34 );
            Unknown35 = parser.ReadColumn< byte >( 35 );
            Unknown36 = parser.ReadColumn< byte >( 36 );
        }
    }
}