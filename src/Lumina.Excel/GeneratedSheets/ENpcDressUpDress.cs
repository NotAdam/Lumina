// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ENpcDressUpDress", columnHash: 0xd0267043 )]
    public class ENpcDressUpDress : ExcelRow
    {
        
        public uint Unknown0;
        public bool Unknown1;
        public bool Unknown2;
        public bool Unknown3;
        public bool Unknown4;
        public bool AddedIn530;
        public byte Unknown6;
        public LazyRow< ENpcResident > ENpc;
        public ushort AddedIn531;
        public LazyRow< Behavior > Behavior;
        public ushort Unknown10;
        public byte Unknown11;
        public byte Unknown12;
        public byte Unknown13;
        public byte Unknown14;
        public byte Unknown15;
        public byte Unknown16;
        public byte Unknown17;
        public byte Unknown18;
        public byte Unknown19;
        public byte Unknown20;
        public byte Unknown21;
        public byte Unknown22;
        public byte Unknown23;
        public byte Unknown24;
        public byte Unknown25;
        public byte Unknown26;
        public byte Unknown27;
        public byte Unknown28;
        public byte Unknown29;
        public byte Unknown30;
        public byte Unknown31;
        public byte Unknown32;
        public byte Unknown33;
        public byte Unknown34;
        public byte Unknown35;
        public byte AddedIn532;
        public ulong ModelMainHand;
        public LazyRow< Stain > DyeMainHand;
        public ulong ModelOffHand;
        public LazyRow< Stain > DyeOffHand;
        public uint ModelHead;
        public LazyRow< Stain > DyeHead;
        public uint ModelBody;
        public LazyRow< Stain > DyeBody;
        public uint ModelHands;
        public LazyRow< Stain > DyeHands;
        public uint ModelLegs;
        public LazyRow< Stain > DyeLegs;
        public uint ModelFeet;
        public LazyRow< Stain > DyeFeet;
        public uint Unknown51;
        public byte Unknown52;
        public uint Unknown53;
        public byte Unknown54;
        public uint Unknown55;
        public byte Unknown56;
        public uint Unknown57;
        public byte Unknown58;
        public uint Unknown59;
        public byte Unknown60;
        

        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Unknown0 = parser.ReadColumn< uint >( 0 );
            Unknown1 = parser.ReadColumn< bool >( 1 );
            Unknown2 = parser.ReadColumn< bool >( 2 );
            Unknown3 = parser.ReadColumn< bool >( 3 );
            Unknown4 = parser.ReadColumn< bool >( 4 );
            AddedIn530 = parser.ReadColumn< bool >( 5 );
            Unknown6 = parser.ReadColumn< byte >( 6 );
            ENpc = new LazyRow< ENpcResident >( gameData, parser.ReadColumn< uint >( 7 ), language );
            AddedIn531 = parser.ReadColumn< ushort >( 8 );
            Behavior = new LazyRow< Behavior >( gameData, parser.ReadColumn< ushort >( 9 ), language );
            Unknown10 = parser.ReadColumn< ushort >( 10 );
            Unknown11 = parser.ReadColumn< byte >( 11 );
            Unknown12 = parser.ReadColumn< byte >( 12 );
            Unknown13 = parser.ReadColumn< byte >( 13 );
            Unknown14 = parser.ReadColumn< byte >( 14 );
            Unknown15 = parser.ReadColumn< byte >( 15 );
            Unknown16 = parser.ReadColumn< byte >( 16 );
            Unknown17 = parser.ReadColumn< byte >( 17 );
            Unknown18 = parser.ReadColumn< byte >( 18 );
            Unknown19 = parser.ReadColumn< byte >( 19 );
            Unknown20 = parser.ReadColumn< byte >( 20 );
            Unknown21 = parser.ReadColumn< byte >( 21 );
            Unknown22 = parser.ReadColumn< byte >( 22 );
            Unknown23 = parser.ReadColumn< byte >( 23 );
            Unknown24 = parser.ReadColumn< byte >( 24 );
            Unknown25 = parser.ReadColumn< byte >( 25 );
            Unknown26 = parser.ReadColumn< byte >( 26 );
            Unknown27 = parser.ReadColumn< byte >( 27 );
            Unknown28 = parser.ReadColumn< byte >( 28 );
            Unknown29 = parser.ReadColumn< byte >( 29 );
            Unknown30 = parser.ReadColumn< byte >( 30 );
            Unknown31 = parser.ReadColumn< byte >( 31 );
            Unknown32 = parser.ReadColumn< byte >( 32 );
            Unknown33 = parser.ReadColumn< byte >( 33 );
            Unknown34 = parser.ReadColumn< byte >( 34 );
            Unknown35 = parser.ReadColumn< byte >( 35 );
            AddedIn532 = parser.ReadColumn< byte >( 36 );
            ModelMainHand = parser.ReadColumn< ulong >( 37 );
            DyeMainHand = new LazyRow< Stain >( gameData, parser.ReadColumn< byte >( 38 ), language );
            ModelOffHand = parser.ReadColumn< ulong >( 39 );
            DyeOffHand = new LazyRow< Stain >( gameData, parser.ReadColumn< byte >( 40 ), language );
            ModelHead = parser.ReadColumn< uint >( 41 );
            DyeHead = new LazyRow< Stain >( gameData, parser.ReadColumn< byte >( 42 ), language );
            ModelBody = parser.ReadColumn< uint >( 43 );
            DyeBody = new LazyRow< Stain >( gameData, parser.ReadColumn< byte >( 44 ), language );
            ModelHands = parser.ReadColumn< uint >( 45 );
            DyeHands = new LazyRow< Stain >( gameData, parser.ReadColumn< byte >( 46 ), language );
            ModelLegs = parser.ReadColumn< uint >( 47 );
            DyeLegs = new LazyRow< Stain >( gameData, parser.ReadColumn< byte >( 48 ), language );
            ModelFeet = parser.ReadColumn< uint >( 49 );
            DyeFeet = new LazyRow< Stain >( gameData, parser.ReadColumn< byte >( 50 ), language );
            Unknown51 = parser.ReadColumn< uint >( 51 );
            Unknown52 = parser.ReadColumn< byte >( 52 );
            Unknown53 = parser.ReadColumn< uint >( 53 );
            Unknown54 = parser.ReadColumn< byte >( 54 );
            Unknown55 = parser.ReadColumn< uint >( 55 );
            Unknown56 = parser.ReadColumn< byte >( 56 );
            Unknown57 = parser.ReadColumn< uint >( 57 );
            Unknown58 = parser.ReadColumn< byte >( 58 );
            Unknown59 = parser.ReadColumn< uint >( 59 );
            Unknown60 = parser.ReadColumn< byte >( 60 );
        }
    }
}