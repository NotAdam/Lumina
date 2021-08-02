// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Resident", columnHash: 0x9af0b586 )]
    public partial class Resident : ExcelRow
    {
        
        public byte Unknown0 { get; set; }
        public ulong Model { get; set; }
        public LazyRow< NpcYell > NpcYell { get; set; }
        public ushort Unknown3 { get; set; }
        public byte ResidentMotionType { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Unknown0 = parser.ReadColumn< byte >( 0 );
            Model = parser.ReadColumn< ulong >( 1 );
            NpcYell = new LazyRow< NpcYell >( gameData, parser.ReadColumn< int >( 2 ), language );
            Unknown3 = parser.ReadColumn< ushort >( 3 );
            ResidentMotionType = parser.ReadColumn< byte >( 4 );
        }
    }
}