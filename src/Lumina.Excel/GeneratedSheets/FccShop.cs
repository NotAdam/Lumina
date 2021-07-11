// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "FccShop", columnHash: 0xccd13846 )]
    public class FccShop : ExcelRow
    {
        public class UnkData1Obj
        {
            public uint Item { get; set; }
        }
        public class UnkData11Obj
        {
            public uint Cost { get; set; }
        }
        public class UnkData21Obj
        {
            public byte FCRankRequired { get; set; }
        }
        
        public SeString Name { get; set; }
        public UnkData1Obj[] UnkData1 { get; set; }
        public UnkData11Obj[] UnkData11 { get; set; }
        public UnkData21Obj[] UnkData21 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Name = parser.ReadColumn< SeString >( 0 );
            UnkData1 = new UnkData1Obj[ 10 ];
            for( var i = 0; i < 10; i++ )
            {
                UnkData1[ i ] = new UnkData1Obj();
                UnkData1[ i ].Item = parser.ReadColumn< uint >( 1 + ( i * 1 + 0 ) );
            }
            UnkData11 = new UnkData11Obj[ 10 ];
            for( var i = 0; i < 10; i++ )
            {
                UnkData11[ i ] = new UnkData11Obj();
                UnkData11[ i ].Cost = parser.ReadColumn< uint >( 11 + ( i * 1 + 0 ) );
            }
            UnkData21 = new UnkData21Obj[ 10 ];
            for( var i = 0; i < 10; i++ )
            {
                UnkData21[ i ] = new UnkData21Obj();
                UnkData21[ i ].FCRankRequired = parser.ReadColumn< byte >( 21 + ( i * 1 + 0 ) );
            }
        }
    }
}