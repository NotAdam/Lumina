// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "CompanyCraftDraftCategory", columnHash: 0xf6570594 )]
    public partial class CompanyCraftDraftCategory : ExcelRow
    {
        
        public SeString Name { get; set; }
        public ushort[] CompanyCraftType { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Name = parser.ReadColumn< SeString >( 0 );
            CompanyCraftType = new ushort[ 10 ];
            for( var i = 0; i < 10; i++ )
                CompanyCraftType[ i ] = parser.ReadColumn< ushort >( 1 + i );
        }
    }
}