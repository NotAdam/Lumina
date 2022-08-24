// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "GimmickRect", columnHash: 0x9be6d434 )]
    public partial class GimmickRect : ExcelRow
    {
        
        public uint LayoutID { get; set; }
        public byte TriggerIn { get; set; }
        public uint Param0 { get; set; }
        public uint Unknown3 { get; set; }
        public uint Unknown4 { get; set; }
        public uint Unknown5 { get; set; }
        public byte TriggerOut { get; set; }
        public uint Param1 { get; set; }
        public uint Unknown8 { get; set; }
        public uint Unknown9 { get; set; }
        public uint Unknown10 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            LayoutID = parser.ReadColumn< uint >( 0 );
            TriggerIn = parser.ReadColumn< byte >( 1 );
            Param0 = parser.ReadColumn< uint >( 2 );
            Unknown3 = parser.ReadColumn< uint >( 3 );
            Unknown4 = parser.ReadColumn< uint >( 4 );
            Unknown5 = parser.ReadColumn< uint >( 5 );
            TriggerOut = parser.ReadColumn< byte >( 6 );
            Param1 = parser.ReadColumn< uint >( 7 );
            Unknown8 = parser.ReadColumn< uint >( 8 );
            Unknown9 = parser.ReadColumn< uint >( 9 );
            Unknown10 = parser.ReadColumn< uint >( 10 );
        }
    }
}