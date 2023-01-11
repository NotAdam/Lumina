// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "FccShop", columnHash: 0xccd13846 )]
    public partial class FccShop : ExcelRow
    {
        
        public SeString Name { get; set; }
        public uint[] Item { get; set; }
        public uint[] Cost { get; set; }
        public byte[] FCRankRequired { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Name = parser.ReadColumn< SeString >( 0 );
            Item = new uint[ 10 ];
            for( var i = 0; i < 10; i++ )
                Item[ i ] = parser.ReadColumn< uint >( 1 + i );
            Cost = new uint[ 10 ];
            for( var i = 0; i < 10; i++ )
                Cost[ i ] = parser.ReadColumn< uint >( 11 + i );
            FCRankRequired = new byte[ 10 ];
            for( var i = 0; i < 10; i++ )
                FCRankRequired[ i ] = parser.ReadColumn< byte >( 21 + i );
        }
    }
}