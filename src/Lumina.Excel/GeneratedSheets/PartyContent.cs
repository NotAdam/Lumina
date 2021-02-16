// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "PartyContent", columnHash: 0x0fe3ae35 )]
    public class PartyContent : ExcelRow
    {
        
        public byte Key;
        public ushort TimeLimit;
        public bool Name;
        public LazyRow< PartyContentTextData > TextDataStart;
        public LazyRow< PartyContentTextData > TextDataEnd;
        public uint[] LGBEventObject0;
        public uint[] LGBEventRange;
        public uint[] LGBEventObject1;
        public ushort Unknown32;
        public LazyRow< ContentFinderCondition > ContentFinderCondition;
        public uint Image;
        public byte Unknown35;
        

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