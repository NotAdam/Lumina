// ReSharper disable All

using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Transformation", columnHash: 0xcd364718 )]
    public class Transformation : IExcelRow
    {
        
        public byte Unknown0;
        public LazyRow< ModelChara > Model;
        public LazyRow< BNpcName > BNpcName;
        public LazyRow< BNpcCustomize > BNpcCustomize;
        public LazyRow< NpcEquip > NpcEquip;
        public bool ExHotbarEnableConfig;
        public LazyRow< Action > Action0;
        public bool Unknown7;
        public LazyRow< Action > Action1;
        public bool Unknown9;
        public LazyRow< Action > Action2;
        public bool Unknown11;
        public LazyRow< Action > Action3;
        public bool Unknown13;
        public LazyRow< Action > Action4;
        public LazyRow< Action > Action5;
        public ushort Unknown16;
        public bool Unknown17;
        public LazyRow< RPParameter > RPParameter;
        public LazyRow< Action > RemoveAction;
        public bool Unknown20;
        public bool Unknown21;
        public byte Unknown22;
        public float Speed;
        public float Scale;
        public bool IsPvP;
        public bool IsEvent;
        public bool PlayerCamera;
        public bool Unknown28;
        public bool Unknown29;
        public LazyRow< VFX > StartVFX;
        public LazyRow< VFX > EndVFX;
        public LazyRow< Action > Action6;
        public sbyte Unknown33;
        public LazyRow< Action > Action7;
        public byte Unknown35;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Unknown0 = parser.ReadColumn< byte >( 0 );
            Model = new LazyRow< ModelChara >( lumina, parser.ReadColumn< short >( 1 ), language );
            BNpcName = new LazyRow< BNpcName >( lumina, parser.ReadColumn< ushort >( 2 ), language );
            BNpcCustomize = new LazyRow< BNpcCustomize >( lumina, parser.ReadColumn< int >( 3 ), language );
            NpcEquip = new LazyRow< NpcEquip >( lumina, parser.ReadColumn< int >( 4 ), language );
            ExHotbarEnableConfig = parser.ReadColumn< bool >( 5 );
            Action0 = new LazyRow< Action >( lumina, parser.ReadColumn< ushort >( 6 ), language );
            Unknown7 = parser.ReadColumn< bool >( 7 );
            Action1 = new LazyRow< Action >( lumina, parser.ReadColumn< ushort >( 8 ), language );
            Unknown9 = parser.ReadColumn< bool >( 9 );
            Action2 = new LazyRow< Action >( lumina, parser.ReadColumn< ushort >( 10 ), language );
            Unknown11 = parser.ReadColumn< bool >( 11 );
            Action3 = new LazyRow< Action >( lumina, parser.ReadColumn< ushort >( 12 ), language );
            Unknown13 = parser.ReadColumn< bool >( 13 );
            Action4 = new LazyRow< Action >( lumina, parser.ReadColumn< ushort >( 14 ), language );
            //Action5 = new LazyRow< Action >( lumina, parser.ReadColumn< bool >( 15 ), language );
            Unknown16 = parser.ReadColumn< ushort >( 16 );
            Unknown17 = parser.ReadColumn< bool >( 17 );
            RPParameter = new LazyRow< RPParameter >( lumina, parser.ReadColumn< ushort >( 18 ), language );
            RemoveAction = new LazyRow< Action >( lumina, parser.ReadColumn< ushort >( 19 ), language );
            Unknown20 = parser.ReadColumn< bool >( 20 );
            Unknown21 = parser.ReadColumn< bool >( 21 );
            Unknown22 = parser.ReadColumn< byte >( 22 );
            Speed = parser.ReadColumn< float >( 23 );
            Scale = parser.ReadColumn< float >( 24 );
            IsPvP = parser.ReadColumn< bool >( 25 );
            IsEvent = parser.ReadColumn< bool >( 26 );
            PlayerCamera = parser.ReadColumn< bool >( 27 );
            Unknown28 = parser.ReadColumn< bool >( 28 );
            Unknown29 = parser.ReadColumn< bool >( 29 );
            StartVFX = new LazyRow< VFX >( lumina, parser.ReadColumn< ushort >( 30 ), language );
            EndVFX = new LazyRow< VFX >( lumina, parser.ReadColumn< ushort >( 31 ), language );
            Action6 = new LazyRow< Action >( lumina, parser.ReadColumn< uint >( 32 ), language );
            Unknown33 = parser.ReadColumn< sbyte >( 33 );
            Action7 = new LazyRow< Action >( lumina, parser.ReadColumn< ushort >( 34 ), language );
            Unknown35 = parser.ReadColumn< byte >( 35 );
        }
    }
}