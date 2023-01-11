// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Transformation", columnHash: 0xa1ab3fab )]
    public partial class Transformation : ExcelRow
    {
        
        public byte Unknown0 { get; set; }
        public LazyRow< ModelChara > Model { get; set; }
        public LazyRow< BNpcName > BNpcName { get; set; }
        public LazyRow< BNpcCustomize > BNpcCustomize { get; set; }
        public LazyRow< NpcEquip > NpcEquip { get; set; }
        public bool ExHotbarEnableConfig { get; set; }
        public LazyRow< Action > Action0 { get; set; }
        public bool Unknown7 { get; set; }
        public LazyRow< Action > Action1 { get; set; }
        public bool Unknown9 { get; set; }
        public LazyRow< Action > Action2 { get; set; }
        public bool Unknown11 { get; set; }
        public LazyRow< Action > Action3 { get; set; }
        public bool Unknown13 { get; set; }
        public LazyRow< Action > Action4 { get; set; }
        public bool Unknown15 { get; set; }
        public LazyRow< Action > Action5 { get; set; }
        public bool Unknown17 { get; set; }
        public LazyRow< RPParameter > RPParameter { get; set; }
        public LazyRow< Action > RemoveAction { get; set; }
        public bool Unknown20 { get; set; }
        public bool Unknown21 { get; set; }
        public byte Unknown22 { get; set; }
        public bool Unknown23 { get; set; }
        public float Speed { get; set; }
        public float Scale { get; set; }
        public bool IsPvP { get; set; }
        public bool IsEvent { get; set; }
        public bool PlayerCamera { get; set; }
        public bool Unknown29 { get; set; }
        public bool Unknown30 { get; set; }
        public LazyRow< VFX > StartVFX { get; set; }
        public LazyRow< VFX > EndVFX { get; set; }
        public LazyRow< Action > Action6 { get; set; }
        public sbyte Unknown34 { get; set; }
        public sbyte Unknown35 { get; set; }
        public LazyRow< Action > Action7 { get; set; }
        public byte Unknown37 { get; set; }
        public bool Unknown38 { get; set; }
        public bool Unknown39 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Unknown0 = parser.ReadColumn< byte >( 0 );
            Model = new LazyRow< ModelChara >( gameData, parser.ReadColumn< short >( 1 ), language );
            BNpcName = new LazyRow< BNpcName >( gameData, parser.ReadColumn< ushort >( 2 ), language );
            BNpcCustomize = new LazyRow< BNpcCustomize >( gameData, parser.ReadColumn< int >( 3 ), language );
            NpcEquip = new LazyRow< NpcEquip >( gameData, parser.ReadColumn< int >( 4 ), language );
            ExHotbarEnableConfig = parser.ReadColumn< bool >( 5 );
            Action0 = new LazyRow< Action >( gameData, parser.ReadColumn< ushort >( 6 ), language );
            Unknown7 = parser.ReadColumn< bool >( 7 );
            Action1 = new LazyRow< Action >( gameData, parser.ReadColumn< ushort >( 8 ), language );
            Unknown9 = parser.ReadColumn< bool >( 9 );
            Action2 = new LazyRow< Action >( gameData, parser.ReadColumn< ushort >( 10 ), language );
            Unknown11 = parser.ReadColumn< bool >( 11 );
            Action3 = new LazyRow< Action >( gameData, parser.ReadColumn< ushort >( 12 ), language );
            Unknown13 = parser.ReadColumn< bool >( 13 );
            Action4 = new LazyRow< Action >( gameData, parser.ReadColumn< ushort >( 14 ), language );
            Unknown15 = parser.ReadColumn< bool >( 15 );
            Action5 = new LazyRow< Action >( gameData, parser.ReadColumn< ushort >( 16 ), language );
            Unknown17 = parser.ReadColumn< bool >( 17 );
            RPParameter = new LazyRow< RPParameter >( gameData, parser.ReadColumn< ushort >( 18 ), language );
            RemoveAction = new LazyRow< Action >( gameData, parser.ReadColumn< ushort >( 19 ), language );
            Unknown20 = parser.ReadColumn< bool >( 20 );
            Unknown21 = parser.ReadColumn< bool >( 21 );
            Unknown22 = parser.ReadColumn< byte >( 22 );
            Unknown23 = parser.ReadColumn< bool >( 23 );
            Speed = parser.ReadColumn< float >( 24 );
            Scale = parser.ReadColumn< float >( 25 );
            IsPvP = parser.ReadColumn< bool >( 26 );
            IsEvent = parser.ReadColumn< bool >( 27 );
            PlayerCamera = parser.ReadColumn< bool >( 28 );
            Unknown29 = parser.ReadColumn< bool >( 29 );
            Unknown30 = parser.ReadColumn< bool >( 30 );
            StartVFX = new LazyRow< VFX >( gameData, parser.ReadColumn< ushort >( 31 ), language );
            EndVFX = new LazyRow< VFX >( gameData, parser.ReadColumn< ushort >( 32 ), language );
            Action6 = new LazyRow< Action >( gameData, parser.ReadColumn< uint >( 33 ), language );
            Unknown34 = parser.ReadColumn< sbyte >( 34 );
            Unknown35 = parser.ReadColumn< sbyte >( 35 );
            Action7 = new LazyRow< Action >( gameData, parser.ReadColumn< ushort >( 36 ), language );
            Unknown37 = parser.ReadColumn< byte >( 37 );
            Unknown38 = parser.ReadColumn< bool >( 38 );
            Unknown39 = parser.ReadColumn< bool >( 39 );
        }
    }
}