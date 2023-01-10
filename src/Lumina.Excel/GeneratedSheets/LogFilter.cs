// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "LogFilter", columnHash: 0x6ef5ba16 )]
    public partial class LogFilter : ExcelRow
    {
        
        public byte LogKind { get; set; }
        public ushort Caster { get; set; }
        public ushort Target { get; set; }
        public byte Category { get; set; }
        public byte DisplayOrder { get; set; }
        public byte Preset { get; set; }
        public SeString Name { get; set; }
        public SeString Example { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

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