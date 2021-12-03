// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "CharaMakeName", columnHash: 0x2bb0117b )]
    public partial class CharaMakeName : ExcelRow
    {
        
        public SeString HyurMidlanderMale { get; set; }
        public SeString HyurMidlanderFemale { get; set; }
        public SeString HyurMidlanderLastName { get; set; }
        public SeString HyurHighlanderMale { get; set; }
        public SeString HyurHighlanderFemale { get; set; }
        public SeString HyurHighlanderLastName { get; set; }
        public SeString ElezenMale { get; set; }
        public SeString ElezenFemale { get; set; }
        public SeString ElezenWildwoodLastName { get; set; }
        public SeString ElezenDuskwightLastName { get; set; }
        public SeString MiqoteSunMale { get; set; }
        public SeString MiqoteSunFemale { get; set; }
        public SeString MiqoteSunMaleLastName { get; set; }
        public SeString MiqoteSunFemaleLastName { get; set; }
        public SeString MiqoteMoonMale { get; set; }
        public SeString MiqoteMoonFemale { get; set; }
        public SeString MiqoteMoonLastname { get; set; }
        public SeString LalafellPlainsfolkFirstNameStart { get; set; }
        public SeString LalafellPlainsfolkLastNameStart { get; set; }
        public SeString LalafellPlainsfolkEndOfNames { get; set; }
        public SeString LalafellDunesfolkMale { get; set; }
        public SeString LalafellDunesfolkMaleLastName { get; set; }
        public SeString LalafellDunesfolkFemale { get; set; }
        public SeString LalafellDunesfolkFemaleLastName { get; set; }
        public SeString RoegadynSeaWolfMale { get; set; }
        public SeString RoegadynSeaWolfMaleLastName { get; set; }
        public SeString RoegadynSeaWolfFemale { get; set; }
        public SeString RoegadynSeaWolfFemaleLastName { get; set; }
        public SeString RoegadynHellsguardFirstName { get; set; }
        public SeString RoegadynHellsguardMaleLastName { get; set; }
        public SeString RoegadynHellsguardFemaleLastName { get; set; }
        public SeString AuRaRaenMale { get; set; }
        public SeString AuRaRaenFemale { get; set; }
        public SeString AuRaRaenLastName { get; set; }
        public SeString AuRaXaelaMale { get; set; }
        public SeString AuRaXaelaFemale { get; set; }
        public SeString AuRaXaelaLastName { get; set; }
        public SeString HrothgarHellionsFirstName { get; set; }
        public SeString HrothgarHellionsLastName { get; set; }
        public SeString HrothgarLostFirstName { get; set; }
        public SeString HrothgarLostLastName { get; set; }
        public SeString Unknown41 { get; set; }
        public SeString Unknown42 { get; set; }
        public SeString Unknown43 { get; set; }
        public SeString VieraFirstName { get; set; }
        public SeString VieraRavaLastName { get; set; }
        public SeString VieraVeenaLastName { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            HyurMidlanderMale = parser.ReadColumn< SeString >( 0 );
            HyurMidlanderFemale = parser.ReadColumn< SeString >( 1 );
            HyurMidlanderLastName = parser.ReadColumn< SeString >( 2 );
            HyurHighlanderMale = parser.ReadColumn< SeString >( 3 );
            HyurHighlanderFemale = parser.ReadColumn< SeString >( 4 );
            HyurHighlanderLastName = parser.ReadColumn< SeString >( 5 );
            ElezenMale = parser.ReadColumn< SeString >( 6 );
            ElezenFemale = parser.ReadColumn< SeString >( 7 );
            ElezenWildwoodLastName = parser.ReadColumn< SeString >( 8 );
            ElezenDuskwightLastName = parser.ReadColumn< SeString >( 9 );
            MiqoteSunMale = parser.ReadColumn< SeString >( 10 );
            MiqoteSunFemale = parser.ReadColumn< SeString >( 11 );
            MiqoteSunMaleLastName = parser.ReadColumn< SeString >( 12 );
            MiqoteSunFemaleLastName = parser.ReadColumn< SeString >( 13 );
            MiqoteMoonMale = parser.ReadColumn< SeString >( 14 );
            MiqoteMoonFemale = parser.ReadColumn< SeString >( 15 );
            MiqoteMoonLastname = parser.ReadColumn< SeString >( 16 );
            LalafellPlainsfolkFirstNameStart = parser.ReadColumn< SeString >( 17 );
            LalafellPlainsfolkLastNameStart = parser.ReadColumn< SeString >( 18 );
            LalafellPlainsfolkEndOfNames = parser.ReadColumn< SeString >( 19 );
            LalafellDunesfolkMale = parser.ReadColumn< SeString >( 20 );
            LalafellDunesfolkMaleLastName = parser.ReadColumn< SeString >( 21 );
            LalafellDunesfolkFemale = parser.ReadColumn< SeString >( 22 );
            LalafellDunesfolkFemaleLastName = parser.ReadColumn< SeString >( 23 );
            RoegadynSeaWolfMale = parser.ReadColumn< SeString >( 24 );
            RoegadynSeaWolfMaleLastName = parser.ReadColumn< SeString >( 25 );
            RoegadynSeaWolfFemale = parser.ReadColumn< SeString >( 26 );
            RoegadynSeaWolfFemaleLastName = parser.ReadColumn< SeString >( 27 );
            RoegadynHellsguardFirstName = parser.ReadColumn< SeString >( 28 );
            RoegadynHellsguardMaleLastName = parser.ReadColumn< SeString >( 29 );
            RoegadynHellsguardFemaleLastName = parser.ReadColumn< SeString >( 30 );
            AuRaRaenMale = parser.ReadColumn< SeString >( 31 );
            AuRaRaenFemale = parser.ReadColumn< SeString >( 32 );
            AuRaRaenLastName = parser.ReadColumn< SeString >( 33 );
            AuRaXaelaMale = parser.ReadColumn< SeString >( 34 );
            AuRaXaelaFemale = parser.ReadColumn< SeString >( 35 );
            AuRaXaelaLastName = parser.ReadColumn< SeString >( 36 );
            HrothgarHellionsFirstName = parser.ReadColumn< SeString >( 37 );
            HrothgarHellionsLastName = parser.ReadColumn< SeString >( 38 );
            HrothgarLostFirstName = parser.ReadColumn< SeString >( 39 );
            HrothgarLostLastName = parser.ReadColumn< SeString >( 40 );
            Unknown41 = parser.ReadColumn< SeString >( 41 );
            Unknown42 = parser.ReadColumn< SeString >( 42 );
            Unknown43 = parser.ReadColumn< SeString >( 43 );
            VieraFirstName = parser.ReadColumn< SeString >( 44 );
            VieraRavaLastName = parser.ReadColumn< SeString >( 45 );
            VieraVeenaLastName = parser.ReadColumn< SeString >( 46 );
        }
    }
}