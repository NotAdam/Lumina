// ReSharper disable All

using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ENpcDressUpDress", columnHash: 0x21a0d8e3 )]
    public class ENpcDressUpDress : IExcelRow
    {
        
        public uint Unknown0;
        public bool Unknown1;
        public bool Unknown2;
        public bool Unknown3;
        public bool Unknown4;
        public bool AddedIn530;
        public byte Unknown6;
        public LazyRow< ENpcResident > ENpc;
        public ushort Unknown8;
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
        public byte ModelMainHand;
        public LazyRow< Stain > DyeMainHand;
        public byte ModelOffHand;
        public LazyRow< Stain > DyeOffHand;
        public byte ModelHead;
        public LazyRow< Stain > DyeHead;
        public byte ModelBody;
        public LazyRow< Stain > DyeBody;
        public byte ModelHands;
        public LazyRow< Stain > DyeHands;
        public byte ModelLegs;
        public LazyRow< Stain > DyeLegs;
        public byte ModelFeet;
        public LazyRow< Stain > DyeFeet;
        public byte Unknown50;
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
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Unknown0 = parser.ReadColumn< uint >( 0 );
            Unknown1 = parser.ReadColumn< bool >( 1 );
            Unknown2 = parser.ReadColumn< bool >( 2 );
            Unknown3 = parser.ReadColumn< bool >( 3 );
            Unknown4 = parser.ReadColumn< bool >( 4 );
            AddedIn530 = parser.ReadColumn< bool >( 5 );
            Unknown6 = parser.ReadColumn< byte >( 6 );
            ENpc = new LazyRow< ENpcResident >( lumina, parser.ReadColumn< uint >( 7 ), language );
            Unknown8 = parser.ReadColumn< ushort >( 8 );
            Behavior = new LazyRow< Behavior >( lumina, parser.ReadColumn< ushort >( 9 ), language );
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
            ModelMainHand = parser.ReadColumn< byte >( 36 );
            //DyeMainHand = new LazyRow< Stain >( lumina, parser.ReadColumn< ulong >( 37 ), language );
            ModelOffHand = parser.ReadColumn< byte >( 38 );
            //DyeOffHand = new LazyRow< Stain >( lumina, parser.ReadColumn< ulong >( 39 ), language );
            ModelHead = parser.ReadColumn< byte >( 40 );
            DyeHead = new LazyRow< Stain >( lumina, parser.ReadColumn< uint >( 41 ), language );
            ModelBody = parser.ReadColumn< byte >( 42 );
            DyeBody = new LazyRow< Stain >( lumina, parser.ReadColumn< uint >( 43 ), language );
            ModelHands = parser.ReadColumn< byte >( 44 );
            DyeHands = new LazyRow< Stain >( lumina, parser.ReadColumn< uint >( 45 ), language );
            ModelLegs = parser.ReadColumn< byte >( 46 );
            DyeLegs = new LazyRow< Stain >( lumina, parser.ReadColumn< uint >( 47 ), language );
            ModelFeet = parser.ReadColumn< byte >( 48 );
            DyeFeet = new LazyRow< Stain >( lumina, parser.ReadColumn< uint >( 49 ), language );
            Unknown50 = parser.ReadColumn< byte >( 50 );
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