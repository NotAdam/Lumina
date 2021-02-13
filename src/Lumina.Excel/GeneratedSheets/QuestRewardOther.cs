// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "QuestRewardOther", columnHash: 0xaafab8d8 )]
    public class QuestRewardOther : ExcelRow
    {
        
        public uint Icon;
        public SeString Name;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            Icon = parser.ReadColumn< uint >( 0 );
            Name = parser.ReadColumn< SeString >( 1 );
        }
    }
}