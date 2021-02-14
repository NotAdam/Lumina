// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "GeneralAction", columnHash: 0x5dffa8fa )]
    public class GeneralAction : ExcelRow
    {
        
        public SeString Name;
        public SeString Description;
        public byte Unknown2;
        public LazyRow< Action > Action;
        public ushort UnlockLink;
        public byte Recast;
        public byte UIPriority;
        public int Icon;
        public bool Unknown8;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            Name = parser.ReadColumn< SeString >( 0 );
            Description = parser.ReadColumn< SeString >( 1 );
            Unknown2 = parser.ReadColumn< byte >( 2 );
            Action = new LazyRow< Action >( lumina, parser.ReadColumn< ushort >( 3 ), language );
            UnlockLink = parser.ReadColumn< ushort >( 4 );
            Recast = parser.ReadColumn< byte >( 5 );
            UIPriority = parser.ReadColumn< byte >( 6 );
            Icon = parser.ReadColumn< int >( 7 );
            Unknown8 = parser.ReadColumn< bool >( 8 );
        }
    }
}