// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "EquipRaceCategory", columnHash: 0xf914b198 )]
    public class EquipRaceCategory : IExcelRow
    {
        
        public bool Hyur;
        public bool Elezen;
        public bool Lalafell;
        public bool Miqote;
        public bool Roegadyn;
        public bool AuRa;
        public bool Unknown6;
        public bool Unknown7;
        public bool Male;
        public bool Female;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Hyur = parser.ReadColumn< bool >( 0 );
            Elezen = parser.ReadColumn< bool >( 1 );
            Lalafell = parser.ReadColumn< bool >( 2 );
            Miqote = parser.ReadColumn< bool >( 3 );
            Roegadyn = parser.ReadColumn< bool >( 4 );
            AuRa = parser.ReadColumn< bool >( 5 );
            Unknown6 = parser.ReadColumn< bool >( 6 );
            Unknown7 = parser.ReadColumn< bool >( 7 );
            Male = parser.ReadColumn< bool >( 8 );
            Female = parser.ReadColumn< bool >( 9 );
        }
    }
}