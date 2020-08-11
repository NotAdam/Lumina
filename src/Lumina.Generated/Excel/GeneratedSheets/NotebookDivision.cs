// ReSharper disable All

using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "NotebookDivision", columnHash: 0xb4638be9 )]
    public class NotebookDivision : IExcelRow
    {
        
        public string Name;
        public LazyRow< NotebookDivisionCategory > NotebookDivisionCategory;
        public byte CraftOpeningLevel;
        public byte GatheringOpeningLevel;
        public LazyRow< Quest > QuestUnlock;
        public byte Unknown5;
        public bool Unknown6;
        public bool CRPCraft;
        public bool BSMCraft;
        public bool ARMCraft;
        public bool GSMCraft;
        public bool LTWCraft;
        public bool WVRCraft;
        public bool ALCCraft;
        public bool CULCraft;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Name = parser.ReadColumn< string >( 0 );
            NotebookDivisionCategory = new LazyRow< NotebookDivisionCategory >( lumina, parser.ReadColumn< byte >( 1 ), language );
            CraftOpeningLevel = parser.ReadColumn< byte >( 2 );
            GatheringOpeningLevel = parser.ReadColumn< byte >( 3 );
            QuestUnlock = new LazyRow< Quest >( lumina, parser.ReadColumn< uint >( 4 ), language );
            Unknown5 = parser.ReadColumn< byte >( 5 );
            Unknown6 = parser.ReadColumn< bool >( 6 );
            CRPCraft = parser.ReadColumn< bool >( 7 );
            BSMCraft = parser.ReadColumn< bool >( 8 );
            ARMCraft = parser.ReadColumn< bool >( 9 );
            GSMCraft = parser.ReadColumn< bool >( 10 );
            LTWCraft = parser.ReadColumn< bool >( 11 );
            WVRCraft = parser.ReadColumn< bool >( 12 );
            ALCCraft = parser.ReadColumn< bool >( 13 );
            CULCraft = parser.ReadColumn< bool >( 14 );
        }
    }
}