// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ClassJobCategory", columnHash: 0x7caef8ce )]
    public partial class ClassJobCategory : ExcelRow
    {
        
        public SeString Name { get; set; }
        public bool ADV { get; set; }
        public bool GLA { get; set; }
        public bool PGL { get; set; }
        public bool MRD { get; set; }
        public bool LNC { get; set; }
        public bool ARC { get; set; }
        public bool CNJ { get; set; }
        public bool THM { get; set; }
        public bool CRP { get; set; }
        public bool BSM { get; set; }
        public bool ARM { get; set; }
        public bool GSM { get; set; }
        public bool LTW { get; set; }
        public bool WVR { get; set; }
        public bool ALC { get; set; }
        public bool CUL { get; set; }
        public bool MIN { get; set; }
        public bool BTN { get; set; }
        public bool FSH { get; set; }
        public bool PLD { get; set; }
        public bool MNK { get; set; }
        public bool WAR { get; set; }
        public bool DRG { get; set; }
        public bool BRD { get; set; }
        public bool WHM { get; set; }
        public bool BLM { get; set; }
        public bool ACN { get; set; }
        public bool SMN { get; set; }
        public bool SCH { get; set; }
        public bool ROG { get; set; }
        public bool NIN { get; set; }
        public bool MCH { get; set; }
        public bool DRK { get; set; }
        public bool AST { get; set; }
        public bool SAM { get; set; }
        public bool RDM { get; set; }
        public bool BLU { get; set; }
        public bool GNB { get; set; }
        public bool DNC { get; set; }
        public bool RPR { get; set; }
        public bool SGE { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Name = parser.ReadColumn< SeString >( 0 );
            ADV = parser.ReadColumn< bool >( 1 );
            GLA = parser.ReadColumn< bool >( 2 );
            PGL = parser.ReadColumn< bool >( 3 );
            MRD = parser.ReadColumn< bool >( 4 );
            LNC = parser.ReadColumn< bool >( 5 );
            ARC = parser.ReadColumn< bool >( 6 );
            CNJ = parser.ReadColumn< bool >( 7 );
            THM = parser.ReadColumn< bool >( 8 );
            CRP = parser.ReadColumn< bool >( 9 );
            BSM = parser.ReadColumn< bool >( 10 );
            ARM = parser.ReadColumn< bool >( 11 );
            GSM = parser.ReadColumn< bool >( 12 );
            LTW = parser.ReadColumn< bool >( 13 );
            WVR = parser.ReadColumn< bool >( 14 );
            ALC = parser.ReadColumn< bool >( 15 );
            CUL = parser.ReadColumn< bool >( 16 );
            MIN = parser.ReadColumn< bool >( 17 );
            BTN = parser.ReadColumn< bool >( 18 );
            FSH = parser.ReadColumn< bool >( 19 );
            PLD = parser.ReadColumn< bool >( 20 );
            MNK = parser.ReadColumn< bool >( 21 );
            WAR = parser.ReadColumn< bool >( 22 );
            DRG = parser.ReadColumn< bool >( 23 );
            BRD = parser.ReadColumn< bool >( 24 );
            WHM = parser.ReadColumn< bool >( 25 );
            BLM = parser.ReadColumn< bool >( 26 );
            ACN = parser.ReadColumn< bool >( 27 );
            SMN = parser.ReadColumn< bool >( 28 );
            SCH = parser.ReadColumn< bool >( 29 );
            ROG = parser.ReadColumn< bool >( 30 );
            NIN = parser.ReadColumn< bool >( 31 );
            MCH = parser.ReadColumn< bool >( 32 );
            DRK = parser.ReadColumn< bool >( 33 );
            AST = parser.ReadColumn< bool >( 34 );
            SAM = parser.ReadColumn< bool >( 35 );
            RDM = parser.ReadColumn< bool >( 36 );
            BLU = parser.ReadColumn< bool >( 37 );
            GNB = parser.ReadColumn< bool >( 38 );
            DNC = parser.ReadColumn< bool >( 39 );
            RPR = parser.ReadColumn< bool >( 40 );
            SGE = parser.ReadColumn< bool >( 41 );
        }
    }
}