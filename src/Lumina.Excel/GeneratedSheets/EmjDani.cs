// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "EmjDani", columnHash: 0xf3fb0152 )]
    public partial class EmjDani : ExcelRow
    {
        
        public uint Icon { get; set; }
        public ushort Unknown1 { get; set; }
        public ushort Unknown2 { get; set; }
        public bool Unknown3 { get; set; }
        public short Unknown4 { get; set; }
        public short Unknown5 { get; set; }
        public short Unknown6 { get; set; }
        public short Unknown7 { get; set; }
        public short Unknown8 { get; set; }
        public short Unknown9 { get; set; }
        public short Unknown10 { get; set; }
        public short Unknown11 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Icon = parser.ReadColumn< uint >( 0 );
            Unknown1 = parser.ReadColumn< ushort >( 1 );
            Unknown2 = parser.ReadColumn< ushort >( 2 );
            Unknown3 = parser.ReadColumn< bool >( 3 );
            Unknown4 = parser.ReadColumn< short >( 4 );
            Unknown5 = parser.ReadColumn< short >( 5 );
            Unknown6 = parser.ReadColumn< short >( 6 );
            Unknown7 = parser.ReadColumn< short >( 7 );
            Unknown8 = parser.ReadColumn< short >( 8 );
            Unknown9 = parser.ReadColumn< short >( 9 );
            Unknown10 = parser.ReadColumn< short >( 10 );
            Unknown11 = parser.ReadColumn< short >( 11 );
        }
    }
}