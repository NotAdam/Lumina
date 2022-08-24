// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "DescriptionPage", columnHash: 0xe721cad2 )]
    public partial class DescriptionPage : ExcelRow
    {
        public class DescriptionPageUnkData3Obj
        {
            public ushort Text { get; set; }
            public uint Image { get; set; }
        }
        
        public byte Unknown0 { get; set; }
        public LazyRow< Quest > Quest { get; set; }
        public byte Unknown2 { get; set; }
        public DescriptionPageUnkData3Obj[] UnkData3 { get; set; }
        public ushort Unknown25 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Unknown0 = parser.ReadColumn< byte >( 0 );
            Quest = new LazyRow< Quest >( gameData, parser.ReadColumn< uint >( 1 ), language );
            Unknown2 = parser.ReadColumn< byte >( 2 );
            UnkData3 = new DescriptionPageUnkData3Obj[ 11 ];
            for( var i = 0; i < 11; i++ )
            {
                UnkData3[ i ] = new DescriptionPageUnkData3Obj();
                UnkData3[ i ].Text = parser.ReadColumn< ushort >( 3 + ( i * 2 + 0 ) );
                UnkData3[ i ].Image = parser.ReadColumn< uint >( 3 + ( i * 2 + 1 ) );
            }
            Unknown25 = parser.ReadColumn< ushort >( 25 );
        }
    }
}