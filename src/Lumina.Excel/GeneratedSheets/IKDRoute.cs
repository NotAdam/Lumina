// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "IKDRoute", columnHash: 0x9a3e7720 )]
    public class IKDRoute : ExcelRow
    {
        public struct UnkStruct0Struct
        {
            public uint Spot;
            public byte Time;
        }
        
        public UnkStruct0Struct[] UnkStruct0;
        public uint Image;
        public LazyRow< TerritoryType > TerritoryType;
        public SeString Name;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            UnkStruct0 = new UnkStruct0Struct[ 3 ];
            for( var i = 0; i < 3; i++ )
            {
                UnkStruct0[ i ] = new UnkStruct0Struct();
                UnkStruct0[ i ].Spot = parser.ReadColumn< uint >( 0 + ( i * 2 + 0 ) );
                UnkStruct0[ i ].Time = parser.ReadColumn< byte >( 0 + ( i * 2 + 1 ) );
            }
            Image = parser.ReadColumn< uint >( 6 );
            TerritoryType = new LazyRow< TerritoryType >( lumina, parser.ReadColumn< uint >( 7 ), language );
            Name = parser.ReadColumn< SeString >( 8 );
        }
    }
}