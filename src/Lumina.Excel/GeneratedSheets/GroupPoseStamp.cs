// ReSharper disable All

using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "GroupPoseStamp", columnHash: 0xf11408ee )]
    public class GroupPoseStamp : IExcelRow
    {
        
        public int StampIcon;
        public int Unknown1;
        public LazyRow< GroupPoseStampCategory > Category;
        public ushort Unknown3;
        public bool Unknown4;
        public bool Unknown5;
        public string Name;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            StampIcon = parser.ReadColumn< int >( 0 );
            Unknown1 = parser.ReadColumn< int >( 1 );
            Category = new LazyRow< GroupPoseStampCategory >( lumina, parser.ReadColumn< int >( 2 ), language );
            Unknown3 = parser.ReadColumn< ushort >( 3 );
            Unknown4 = parser.ReadColumn< bool >( 4 );
            Unknown5 = parser.ReadColumn< bool >( 5 );
            Name = parser.ReadColumn< string >( 6 );
        }
    }
}