// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "DeepDungeonFloorEffectUI", columnHash: 0x11a44a12 )]
    public class DeepDungeonFloorEffectUI : ExcelRow
    {
        
        public uint Icon;
        public SeString Name;
        public SeString Description;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            Icon = parser.ReadColumn< uint >( 0 );
            Name = parser.ReadColumn< SeString >( 1 );
            Description = parser.ReadColumn< SeString >( 2 );
        }
    }
}