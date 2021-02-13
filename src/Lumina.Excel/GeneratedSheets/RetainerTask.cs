// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "RetainerTask", columnHash: 0x99415e4e )]
    public class RetainerTask : ExcelRow
    {
        
        public bool IsRandom;
        public LazyRow< ClassJobCategory > ClassJobCategory;
        public byte RetainerLevel;
        public ushort Unknown3;
        public LazyRow< RetainerTaskParameter > RetainerTaskParameter;
        public ushort VentureCost;
        public ushort MaxTimemin;
        public int Experience;
        public ushort RequiredItemLevel;
        public byte ConditionParam0;
        public byte ConditionParam1;
        public ushort RequiredGathering;
        public ushort Unknown12;
        public ushort Task;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            IsRandom = parser.ReadColumn< bool >( 0 );
            ClassJobCategory = new LazyRow< ClassJobCategory >( lumina, parser.ReadColumn< byte >( 1 ), language );
            RetainerLevel = parser.ReadColumn< byte >( 2 );
            Unknown3 = parser.ReadColumn< ushort >( 3 );
            RetainerTaskParameter = new LazyRow< RetainerTaskParameter >( lumina, parser.ReadColumn< ushort >( 4 ), language );
            VentureCost = parser.ReadColumn< ushort >( 5 );
            MaxTimemin = parser.ReadColumn< ushort >( 6 );
            Experience = parser.ReadColumn< int >( 7 );
            RequiredItemLevel = parser.ReadColumn< ushort >( 8 );
            ConditionParam0 = parser.ReadColumn< byte >( 9 );
            ConditionParam1 = parser.ReadColumn< byte >( 10 );
            RequiredGathering = parser.ReadColumn< ushort >( 11 );
            Unknown12 = parser.ReadColumn< ushort >( 12 );
            Task = parser.ReadColumn< ushort >( 13 );
        }
    }
}