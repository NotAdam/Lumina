// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "LeveAssignmentType", columnHash: 0x7c19f23c )]
    public class LeveAssignmentType : ExcelRow
    {
        
        public bool IsFaction;
        public int Icon;
        public SeString Name;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            IsFaction = parser.ReadColumn< bool >( 0 );
            Icon = parser.ReadColumn< int >( 1 );
            Name = parser.ReadColumn< SeString >( 2 );
        }
    }
}