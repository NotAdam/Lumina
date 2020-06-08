using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "TopicSelect", columnHash: 0xc312c89f )]
    public class TopicSelect : IExcelRow
    {
        public struct UnkStruct4Struct
        {
            public uint Shop;
        }
        
        public string Name;
        public bool Unknown1;
        public byte Unknown2;
        public ushort Unknown3;
        public UnkStruct4Struct[] UnkStruct4;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Name = parser.ReadColumn< string >( 0 );
            Unknown1 = parser.ReadColumn< bool >( 1 );
            Unknown2 = parser.ReadColumn< byte >( 2 );
            Unknown3 = parser.ReadColumn< ushort >( 3 );
            for( var i = 0; i < 10; i++ )
            {
                UnkStruct4[ i ] = new UnkStruct4Struct();
                UnkStruct4[ i ].Shop = parser.ReadColumn< uint >( 4 + ( i * 10 + 0 ) );
            }
        }
    }
}