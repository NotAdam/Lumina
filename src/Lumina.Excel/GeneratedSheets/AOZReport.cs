// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "AOZReport", columnHash: 0x1a97b0af )]
    public partial class AOZReport : ExcelRow
    {
        
        public uint Unknown0 { get; set; }
        public byte Reward { get; set; }
        public sbyte Order { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Unknown0 = parser.ReadColumn< uint >( 0 );
            Reward = parser.ReadColumn< byte >( 1 );
            Order = parser.ReadColumn< sbyte >( 2 );
        }
    }
}