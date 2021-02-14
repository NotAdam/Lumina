// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "PvPSelectTrait", columnHash: 0xbddf8130 )]
    public class PvPSelectTrait : ExcelRow
    {
        
        public SeString Effect;
        public uint Icon;
        public short Value;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            Effect = parser.ReadColumn< SeString >( 0 );
            Icon = parser.ReadColumn< uint >( 1 );
            Value = parser.ReadColumn< short >( 2 );
        }
    }
}