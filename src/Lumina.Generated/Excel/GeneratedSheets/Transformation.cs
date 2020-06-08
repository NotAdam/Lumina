using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Transformation", columnHash: 0xa9f5ba48 )]
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
        public bool Unknown16;
        public bool Unknown17;
        public LazyRow< RPParameter > RPParameter;
        public float Speed;
        public float Scale;
        public bool IsPvP;
        public bool IsEvent;
        public bool PlayerCamera;
        public LazyRow< VFX > StartVFX;
        public LazyRow< VFX > EndVFX;
        public ushort Unknown26;
        public ushort Unknown27;
        public uint Unknown28;
        public sbyte Unknown29;
        public ushort Unknown30;
        public byte Unknown31;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Unknown0 = parser.ReadColumn< byte >( 0 );
            Model = new LazyRow< ModelChara >( lumina, parser.ReadColumn< short >( 1 ) );
            BNpcName = new LazyRow< BNpcName >( lumina, parser.ReadColumn< ushort >( 2 ) );
            BNpcCustomize = new LazyRow< BNpcCustomize >( lumina, parser.ReadColumn< int >( 3 ) );
            NpcEquip = new LazyRow< NpcEquip >( lumina, parser.ReadColumn< int >( 4 ) );
            ExHotbarEnableConfig = parser.ReadColumn< bool >( 5 );
            Action0 = new LazyRow< Action >( lumina, parser.ReadColumn< ushort >( 6 ) );
            Unknown7 = parser.ReadColumn< bool >( 7 );
            Action1 = new LazyRow< Action >( lumina, parser.ReadColumn< ushort >( 8 ) );
            Unknown9 = parser.ReadColumn< bool >( 9 );
            Action2 = new LazyRow< Action >( lumina, parser.ReadColumn< ushort >( 10 ) );
            Unknown11 = parser.ReadColumn< bool >( 11 );
            Action3 = new LazyRow< Action >( lumina, parser.ReadColumn< ushort >( 12 ) );
            Unknown13 = parser.ReadColumn< bool >( 13 );
            Action4 = new LazyRow< Action >( lumina, parser.ReadColumn< ushort >( 14 ) );
            Action5 = new LazyRow< Action >( lumina, parser.ReadColumn< ushort >( 15 ) );
            Unknown16 = parser.ReadColumn< bool >( 16 );
            Unknown17 = parser.ReadColumn< bool >( 17 );
            RPParameter = new LazyRow< RPParameter >( lumina, parser.ReadColumn< byte >( 18 ) );
            Speed = parser.ReadColumn< float >( 19 );
            Scale = parser.ReadColumn< float >( 20 );
            IsPvP = parser.ReadColumn< bool >( 21 );
            IsEvent = parser.ReadColumn< bool >( 22 );
            PlayerCamera = parser.ReadColumn< bool >( 23 );
            // generator error: the definition for this field (StartVFX) has an invalid type for a LazyRow
            // generator error: the definition for this field (EndVFX) has an invalid type for a LazyRow
            Unknown26 = parser.ReadColumn< ushort >( 26 );
            Unknown27 = parser.ReadColumn< ushort >( 27 );
            Unknown28 = parser.ReadColumn< uint >( 28 );
            Unknown29 = parser.ReadColumn< sbyte >( 29 );
            Unknown30 = parser.ReadColumn< ushort >( 30 );
            Unknown31 = parser.ReadColumn< byte >( 31 );
        }
    }
}