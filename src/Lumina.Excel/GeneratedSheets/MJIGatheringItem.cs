// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "MJIGatheringItem", columnHash: 0xe14e177e )]
    public partial class MJIGatheringItem : ExcelRow
    {
        
        public uint Unknown0 { get; set; }
        public byte Unknown1 { get; set; }
        public byte Unknown2 { get; set; }
        public short Unknown3 { get; set; }
        public short Unknown4 { get; set; }
        public ushort Unknown5 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Unknown0 = parser.ReadColumn< uint >( 0 );
            Unknown1 = parser.ReadColumn< byte >( 1 );
            Unknown2 = parser.ReadColumn< byte >( 2 );
            Unknown3 = parser.ReadColumn< short >( 3 );
            Unknown4 = parser.ReadColumn< short >( 4 );
            Unknown5 = parser.ReadColumn< ushort >( 5 );
        }
    }
}