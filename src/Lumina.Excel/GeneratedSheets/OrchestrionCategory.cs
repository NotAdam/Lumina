// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "OrchestrionCategory", columnHash: 0x7ac3ee00 )]
    public class OrchestrionCategory : ExcelRow
    {
        
        public SeString Name;
        public byte HideOrder;
        public uint Icon;
        public byte Order;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            Name = parser.ReadColumn< SeString >( 0 );
            HideOrder = parser.ReadColumn< byte >( 1 );
            Icon = parser.ReadColumn< uint >( 2 );
            Order = parser.ReadColumn< byte >( 3 );
        }
    }
}