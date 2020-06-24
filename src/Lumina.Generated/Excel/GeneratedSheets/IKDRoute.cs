using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "IKDRoute", columnHash: 0x9a3e7720 )]
    public class IKDRoute : IExcelRow
    {
        
        public LazyRow< IKDSpot >[] Spot;
        public byte TimeDefine;
        public uint Image;
        public LazyRow< TerritoryType > TerritoryType;
        public string Name;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Spot = new LazyRow< IKDSpot >[ 5 ];
            for( var i = 0; i < 5; i++ )
                Spot[ i ] = new LazyRow< IKDSpot >( lumina, parser.ReadColumn< uint >( 0 + i ), language );
            TimeDefine = parser.ReadColumn< byte >( 5 );
            Image = parser.ReadColumn< uint >( 6 );
            TerritoryType = new LazyRow< TerritoryType >( lumina, parser.ReadColumn< uint >( 7 ), language );
            Name = parser.ReadColumn< string >( 8 );
        }
    }
}