// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "AOZReport", columnHash: 0x1a97b0af )]
    public class AOZReport : ExcelRow
    {
        
        public uint Unknown0;
        public byte Reward;
        public sbyte Order;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            Unknown0 = parser.ReadColumn< uint >( 0 );
            Reward = parser.ReadColumn< byte >( 1 );
            Order = parser.ReadColumn< sbyte >( 2 );
        }
    }
}