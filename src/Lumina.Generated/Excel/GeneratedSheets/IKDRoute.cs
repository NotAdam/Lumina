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

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            for( var i = 0; i < 5; i++ )
                Spot[ i ] = new LazyRow< IKDSpot >( lumina, parser.ReadColumn< uint >( 0 + i ) );
            TimeDefine = parser.ReadColumn< byte >( 5 );
            Image = parser.ReadColumn< uint >( 6 );
            TerritoryType = new LazyRow< TerritoryType >( lumina, parser.ReadColumn< uint >( 7 ) );
            Name = parser.ReadColumn< string >( 8 );
        }
    }
}