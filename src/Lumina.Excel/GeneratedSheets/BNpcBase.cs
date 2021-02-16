// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "BNpcBase", columnHash: 0xdd911c47 )]
    public class BNpcBase : ExcelRow
    {
        
        public LazyRow< Behavior > Behavior;
        public byte Battalion;
        public byte LinkRace;
        public byte Rank;
        public float Scale;
        public LazyRow< ModelChara > ModelChara;
        public LazyRow< BNpcCustomize > BNpcCustomize;
        public LazyRow< NpcEquip > NpcEquip;
        public ushort Special;
        public byte SEPack;
        public bool Unknown10;
        public LazyRow< ArrayEventHandler > ArrayEventHandler;
        public LazyRow< BNpcParts > BNpcParts;
        public bool Unknown13;
        public bool IsTargetLine;
        public bool IsDisplayLevel;
        public bool Unknown16;
        public bool Unknown17;
        public byte Unknown18;
        public byte Unknown19;
        public byte Unknown20;
        

        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Behavior = new LazyRow< Behavior >( gameData, parser.ReadColumn< ushort >( 0 ), language );
            Battalion = parser.ReadColumn< byte >( 1 );
            LinkRace = parser.ReadColumn< byte >( 2 );
            Rank = parser.ReadColumn< byte >( 3 );
            Scale = parser.ReadColumn< float >( 4 );
            ModelChara = new LazyRow< ModelChara >( gameData, parser.ReadColumn< ushort >( 5 ), language );
            BNpcCustomize = new LazyRow< BNpcCustomize >( gameData, parser.ReadColumn< ushort >( 6 ), language );
            NpcEquip = new LazyRow< NpcEquip >( gameData, parser.ReadColumn< ushort >( 7 ), language );
            Special = parser.ReadColumn< ushort >( 8 );
            SEPack = parser.ReadColumn< byte >( 9 );
            Unknown10 = parser.ReadColumn< bool >( 10 );
            ArrayEventHandler = new LazyRow< ArrayEventHandler >( gameData, parser.ReadColumn< int >( 11 ), language );
            BNpcParts = new LazyRow< BNpcParts >( gameData, parser.ReadColumn< byte >( 12 ), language );
            Unknown13 = parser.ReadColumn< bool >( 13 );
            IsTargetLine = parser.ReadColumn< bool >( 14 );
            IsDisplayLevel = parser.ReadColumn< bool >( 15 );
            Unknown16 = parser.ReadColumn< bool >( 16 );
            Unknown17 = parser.ReadColumn< bool >( 17 );
            Unknown18 = parser.ReadColumn< byte >( 18 );
            Unknown19 = parser.ReadColumn< byte >( 19 );
            Unknown20 = parser.ReadColumn< byte >( 20 );
        }
    }
}