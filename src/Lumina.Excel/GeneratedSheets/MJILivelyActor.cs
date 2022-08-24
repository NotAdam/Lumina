// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "MJILivelyActor", columnHash: 0xc8ec8dc5 )]
    public partial class MJILivelyActor : ExcelRow
    {
        
        public uint Unknown0 { get; set; }
        public ushort Unknown1 { get; set; }
        public float Unknown2 { get; set; }
        public float Unknown3 { get; set; }
        public float Unknown4 { get; set; }
        public float Unknown5 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Unknown0 = parser.ReadColumn< uint >( 0 );
            Unknown1 = parser.ReadColumn< ushort >( 1 );
            Unknown2 = parser.ReadColumn< float >( 2 );
            Unknown3 = parser.ReadColumn< float >( 3 );
            Unknown4 = parser.ReadColumn< float >( 4 );
            Unknown5 = parser.ReadColumn< float >( 5 );
        }
    }
}