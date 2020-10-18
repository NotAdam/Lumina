// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "LogFilter", columnHash: 0x6ef5ba16 )]
    public class LogFilter : IExcelRow
    {
        
        public byte LogKind;
        public ushort Caster;
        public ushort Target;
        public byte Category;
        public byte DisplayOrder;
        public byte Preset;
        public SeString Name;
        public SeString Example;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            LogKind = parser.ReadColumn< byte >( 0 );
            Caster = parser.ReadColumn< ushort >( 1 );
            Target = parser.ReadColumn< ushort >( 2 );
            Category = parser.ReadColumn< byte >( 3 );
            DisplayOrder = parser.ReadColumn< byte >( 4 );
            Preset = parser.ReadColumn< byte >( 5 );
            Name = parser.ReadColumn< SeString >( 6 );
            Example = parser.ReadColumn< SeString >( 7 );
        }
    }
}