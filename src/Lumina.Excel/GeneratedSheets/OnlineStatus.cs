// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "OnlineStatus", columnHash: 0xd87db84c )]
    public class OnlineStatus : ExcelRow
    {
        
        public bool List;
        public bool Unknown1;
        public byte Priority;
        public SeString Name;
        public uint Icon;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            List = parser.ReadColumn< bool >( 0 );
            Unknown1 = parser.ReadColumn< bool >( 1 );
            Priority = parser.ReadColumn< byte >( 2 );
            Name = parser.ReadColumn< SeString >( 3 );
            Icon = parser.ReadColumn< uint >( 4 );
        }
    }
}