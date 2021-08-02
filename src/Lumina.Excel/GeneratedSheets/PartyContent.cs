// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "PartyContent", columnHash: 0x0fe3ae35 )]
    public partial class PartyContent : ExcelRow
    {
        
        public byte Key { get; set; }
        public ushort TimeLimit { get; set; }
        public bool Name { get; set; }
        public LazyRow< PartyContentTextData > TextDataStart { get; set; }
        public LazyRow< PartyContentTextData > TextDataEnd { get; set; }
        public uint[] LGBEventObject0 { get; set; }
        public uint[] LGBEventRange { get; set; }
        public uint[] LGBEventObject1 { get; set; }
        public ushort Unknown32 { get; set; }
        public LazyRow< ContentFinderCondition > ContentFinderCondition { get; set; }
        public uint Image { get; set; }
        public byte Unknown35 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Key = parser.ReadColumn< byte >( 0 );
            TimeLimit = parser.ReadColumn< ushort >( 1 );
            Name = parser.ReadColumn< bool >( 2 );
            TextDataStart = new LazyRow< PartyContentTextData >( gameData, parser.ReadColumn< uint >( 3 ), language );
            TextDataEnd = new LazyRow< PartyContentTextData >( gameData, parser.ReadColumn< uint >( 4 ), language );
            LGBEventObject0 = new uint[ 9 ];
            for( var i = 0; i < 9; i++ )
                LGBEventObject0[ i ] = parser.ReadColumn< uint >( 5 + i );
            LGBEventRange = new uint[ 9 ];
            for( var i = 0; i < 9; i++ )
                LGBEventRange[ i ] = parser.ReadColumn< uint >( 14 + i );
            LGBEventObject1 = new uint[ 9 ];
            for( var i = 0; i < 9; i++ )
                LGBEventObject1[ i ] = parser.ReadColumn< uint >( 23 + i );
            Unknown32 = parser.ReadColumn< ushort >( 32 );
            ContentFinderCondition = new LazyRow< ContentFinderCondition >( gameData, parser.ReadColumn< ushort >( 33 ), language );
            Image = parser.ReadColumn< uint >( 34 );
            Unknown35 = parser.ReadColumn< byte >( 35 );
        }
    }
}