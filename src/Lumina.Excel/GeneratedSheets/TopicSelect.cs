// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "TopicSelect", columnHash: 0xc312c89f )]
    public class TopicSelect : ExcelRow
    {
        public struct UnkStruct4Struct
        {
            public uint Shop;
        }
        
        public SeString Name { get; set; }
        public bool Unknown1 { get; set; }
        public byte Unknown2 { get; set; }
        public ushort Unknown3 { get; set; }
        public UnkStruct4Struct[] UnkStruct4 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Name = parser.ReadColumn< SeString >( 0 );
            Unknown1 = parser.ReadColumn< bool >( 1 );
            Unknown2 = parser.ReadColumn< byte >( 2 );
            Unknown3 = parser.ReadColumn< ushort >( 3 );
            UnkStruct4 = new UnkStruct4Struct[ 10 ];
            for( var i = 0; i < 10; i++ )
            {
                UnkStruct4[ i ] = new UnkStruct4Struct();
                UnkStruct4[ i ].Shop = parser.ReadColumn< uint >( 4 + ( i * 1 + 0 ) );
            }
        }
    }
}