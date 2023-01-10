// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "MapMarkerRegion", columnHash: 0xe2747195 )]
    public partial class MapMarkerRegion : ExcelRow
    {
        
        public byte Unknown0 { get; set; }
        public short X { get; set; }
        public short Unknown2 { get; set; }
        public ushort Unknown3 { get; set; }
        public ushort Unknown4 { get; set; }
        public short Unknown5 { get; set; }
        public short Unknown6 { get; set; }
        public ushort Unknown7 { get; set; }
        public ushort Unknown8 { get; set; }
        public short Unknown9 { get; set; }
        public short Unknown10 { get; set; }
        public bool Unknown11 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Unknown0 = parser.ReadColumn< byte >( 0 );
            X = parser.ReadColumn< short >( 1 );
            Unknown2 = parser.ReadColumn< short >( 2 );
            Unknown3 = parser.ReadColumn< ushort >( 3 );
            Unknown4 = parser.ReadColumn< ushort >( 4 );
            Unknown5 = parser.ReadColumn< short >( 5 );
            Unknown6 = parser.ReadColumn< short >( 6 );
            Unknown7 = parser.ReadColumn< ushort >( 7 );
            Unknown8 = parser.ReadColumn< ushort >( 8 );
            Unknown9 = parser.ReadColumn< short >( 9 );
            Unknown10 = parser.ReadColumn< short >( 10 );
            Unknown11 = parser.ReadColumn< bool >( 11 );
        }
    }
}