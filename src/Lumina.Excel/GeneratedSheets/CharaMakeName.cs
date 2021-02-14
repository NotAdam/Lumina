// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "CharaMakeName", columnHash: 0x8230a5a1 )]
    public class CharaMakeName : ExcelRow
    {
        
        public SeString HyurMidlanderMale;
        public SeString HyurMidlanderFemale;
        public SeString HyurMidlanderLastName;
        public SeString HyurHighlanderMale;
        public SeString HyurHighlanderFemale;
        public SeString HyurHighlanderLastName;
        public SeString ElezenMale;
        public SeString ElezenFemale;
        public SeString ElezenWildwoodLastName;
        public SeString ElezenDuskwightLastName;
        public SeString MiqoteSunMale;
        public SeString MiqoteSunFemale;
        public SeString MiqoteSunMaleLastName;
        public SeString MiqoteSunFemaleLastName;
        public SeString MiqoteMoonMale;
        public SeString MiqoteMoonFemale;
        public SeString MiqoteMoonLastname;
        public SeString LalafellPlainsfolkFirstNameStart;
        public SeString LalafellPlainsfolkLastNameStart;
        public SeString LalafellPlainsfolkEndOfNames;
        public SeString LalafellDunesfolkMale;
        public SeString LalafellDunesfolkMaleLastName;
        public SeString LalafellDunesfolkFemale;
        public SeString LalafellDunesfolkFemaleLastName;
        public SeString RoegadynSeaWolfMale;
        public SeString RoegadynSeaWolfMaleLastName;
        public SeString RoegadynSeaWolfFemale;
        public SeString RoegadynSeaWolfFemaleLastName;
        public SeString RoegadynHellsguardFirstName;
        public SeString RoegadynHellsguardMaleLastName;
        public SeString RoegadynHellsguardFemaleLastName;
        public SeString AuRaRaenMale;
        public SeString AuRaRaenFemale;
        public SeString AuRaRaenLastName;
        public SeString AuRaXaelaMale;
        public SeString AuRaXaelaFemale;
        public SeString AuRaXaelaLastName;
        public SeString HrothgarHellionsFirstName;
        public SeString HrothgarHellionsLastName;
        public SeString HrothgarLostFirstName;
        public SeString HrothgarLostLastName;
        public SeString VieraFirstName;
        public SeString VieraRavaLastName;
        public SeString VieraVeenaLastName;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

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
            VieraFirstName = parser.ReadColumn< SeString >( 41 );
            VieraRavaLastName = parser.ReadColumn< SeString >( 42 );
            VieraVeenaLastName = parser.ReadColumn< SeString >( 43 );
        }
    }
}