// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ClassJobCategory", columnHash: 0xd6e993c1 )]
    public class ClassJobCategory : IExcelRow
    {
        
        public SeString Name;
        public bool ADV;
        public bool GLA;
        public bool PGL;
        public bool MRD;
        public bool LNC;
        public bool ARC;
        public bool CNJ;
        public bool THM;
        public bool CRP;
        public bool BSM;
        public bool ARM;
        public bool GSM;
        public bool LTW;
        public bool WVR;
        public bool ALC;
        public bool CUL;
        public bool MIN;
        public bool BTN;
        public bool FSH;
        public bool PLD;
        public bool MNK;
        public bool WAR;
        public bool DRG;
        public bool BRD;
        public bool WHM;
        public bool BLM;
        public bool ACN;
        public bool SMN;
        public bool SCH;
        public bool ROG;
        public bool NIN;
        public bool MCH;
        public bool DRK;
        public bool AST;
        public bool SAM;
        public bool RDM;
        public bool BLU;
        public bool GNB;
        public bool DNC;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

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
        }
    }
}