// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ExtraCommand", columnHash: 0x173a0318 )]
    public partial class ExtraCommand : ExcelRow
    {
        
        public SeString Name { get; set; }
        public SeString Description { get; set; }
        public int Icon { get; set; }
        public sbyte Order { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Name = parser.ReadColumn< SeString >( 0 );
            Description = parser.ReadColumn< SeString >( 1 );
            Icon = parser.ReadColumn< int >( 2 );
            Order = parser.ReadColumn< sbyte >( 3 );
        }
    }
}