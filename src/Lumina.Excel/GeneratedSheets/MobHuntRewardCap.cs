// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "MobHuntRewardCap", columnHash: 0xdbf43666 )]
    public class MobHuntRewardCap : ExcelRow
    {
        
        public uint ExpCap;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            ExpCap = parser.ReadColumn< uint >( 0 );
        }
    }
}