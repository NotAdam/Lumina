// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "GeneralAction", columnHash: 0x5dffa8fa )]
    public partial class GeneralAction : ExcelRow
    {
        
        public SeString Name { get; set; }
        public SeString Description { get; set; }
        public byte Unknown2 { get; set; }
        public LazyRow< Action > Action { get; set; }
        public ushort UnlockLink { get; set; }
        public byte Recast { get; set; }
        public byte UIPriority { get; set; }
        public int Icon { get; set; }
        public bool Unknown8 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Name = parser.ReadColumn< SeString >( 0 );
            Description = parser.ReadColumn< SeString >( 1 );
            Unknown2 = parser.ReadColumn< byte >( 2 );
            Action = new LazyRow< Action >( gameData, parser.ReadColumn< ushort >( 3 ), language );
            UnlockLink = parser.ReadColumn< ushort >( 4 );
            Recast = parser.ReadColumn< byte >( 5 );
            UIPriority = parser.ReadColumn< byte >( 6 );
            Icon = parser.ReadColumn< int >( 7 );
            Unknown8 = parser.ReadColumn< bool >( 8 );
        }
    }
}