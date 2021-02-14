// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "GroupPoseStamp", columnHash: 0x168074a1 )]
    public class GroupPoseStamp : ExcelRow
    {
        
        public int StampIcon;
        public int Unknown1;
        public LazyRow< GroupPoseStampCategory > Category;
        public ushort Unknown3;
        public int Unknown540;
        public bool Unknown541;
        public bool Unknown6;
        public bool Unknown7;
        public SeString Name;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            StampIcon = parser.ReadColumn< int >( 0 );
            Unknown1 = parser.ReadColumn< int >( 1 );
            Category = new LazyRow< GroupPoseStampCategory >( lumina, parser.ReadColumn< int >( 2 ), language );
            Unknown3 = parser.ReadColumn< ushort >( 3 );
            Unknown540 = parser.ReadColumn< int >( 4 );
            Unknown541 = parser.ReadColumn< bool >( 5 );
            Unknown6 = parser.ReadColumn< bool >( 6 );
            Unknown7 = parser.ReadColumn< bool >( 7 );
            Name = parser.ReadColumn< SeString >( 8 );
        }
    }
}