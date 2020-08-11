// ReSharper disable All

using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "CharaMakeName", columnHash: 0x43996e43 )]
    public class CharaMakeName : IExcelRow
    {
        
        public string HyurMidlanderMale;
        public string HyurMidlanderFemale;
        public string HyurMidlanderLastName;
        public string HyurHighlanderMale;
        public string HyurHighlanderFemale;
        public string HyurHighlanderLastName;
        public string ElezenMale;
        public string ElezenFemale;
        public string ElezenWildwoodLastName;
        public string ElezenDuskwightLastName;
        public string MiqoteSunMale;
        public string MiqoteSunFemale;
        public string MiqoteSunMaleLastName;
        public string MiqoteSunFemaleLastName;
        public string MiqoteMoonMale;
        public string MiqoteMoonFemale;
        public string MiqoteMoonLastname;
        public string LalafellPlainsfolkFirstNameStart;
        public string LalafellPlainsfolkLastNameStart;
        public string LalafellPlainsfolkEndOfNames;
        public string LalafellDunesfolkMale;
        public string LalafellDunesfolkMaleLastName;
        public string LalafellDunesfolkFemale;
        public string LalafellDunesfolkFemaleLastName;
        public string RoegadynSeaWolfMale;
        public string RoegadynSeaWolfMaleLastName;
        public string RoegadynSeaWolfFemale;
        public string RoegadynSeaWolfFemaleLastName;
        public string RoegadynHellsguardFirstName;
        public string RoegadynHellsguardMaleLastName;
        public string RoegadynHellsguardFemaleLastName;
        public string AuRaRaenMale;
        public string AuRaRaenFemale;
        public string AuRaRaenLastName;
        public string AuRaXaelaMale;
        public string AuRaXaelaFemale;
        public string AuRaXaelaLastName;
        public string HrothgarHellionsFirstName;
        public string HrothgarHellionsLastName;
        public string HrothgarLostFirstName;
        public string HrothgarLostLastName;
        public string VieraFirstName;
        public string VieraRavaLastName;
        public string VieraVeenaLastName;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            HyurMidlanderMale = parser.ReadColumn< string >( 0 );
            HyurMidlanderFemale = parser.ReadColumn< string >( 1 );
            HyurMidlanderLastName = parser.ReadColumn< string >( 2 );
            HyurHighlanderMale = parser.ReadColumn< string >( 3 );
            HyurHighlanderFemale = parser.ReadColumn< string >( 4 );
            HyurHighlanderLastName = parser.ReadColumn< string >( 5 );
            ElezenMale = parser.ReadColumn< string >( 6 );
            ElezenFemale = parser.ReadColumn< string >( 7 );
            ElezenWildwoodLastName = parser.ReadColumn< string >( 8 );
            ElezenDuskwightLastName = parser.ReadColumn< string >( 9 );
            MiqoteSunMale = parser.ReadColumn< string >( 10 );
            MiqoteSunFemale = parser.ReadColumn< string >( 11 );
            MiqoteSunMaleLastName = parser.ReadColumn< string >( 12 );
            MiqoteSunFemaleLastName = parser.ReadColumn< string >( 13 );
            MiqoteMoonMale = parser.ReadColumn< string >( 14 );
            MiqoteMoonFemale = parser.ReadColumn< string >( 15 );
            MiqoteMoonLastname = parser.ReadColumn< string >( 16 );
            LalafellPlainsfolkFirstNameStart = parser.ReadColumn< string >( 17 );
            LalafellPlainsfolkLastNameStart = parser.ReadColumn< string >( 18 );
            LalafellPlainsfolkEndOfNames = parser.ReadColumn< string >( 19 );
            LalafellDunesfolkMale = parser.ReadColumn< string >( 20 );
            LalafellDunesfolkMaleLastName = parser.ReadColumn< string >( 21 );
            LalafellDunesfolkFemale = parser.ReadColumn< string >( 22 );
            LalafellDunesfolkFemaleLastName = parser.ReadColumn< string >( 23 );
            RoegadynSeaWolfMale = parser.ReadColumn< string >( 24 );
            RoegadynSeaWolfMaleLastName = parser.ReadColumn< string >( 25 );
            RoegadynSeaWolfFemale = parser.ReadColumn< string >( 26 );
            RoegadynSeaWolfFemaleLastName = parser.ReadColumn< string >( 27 );
            RoegadynHellsguardFirstName = parser.ReadColumn< string >( 28 );
            RoegadynHellsguardMaleLastName = parser.ReadColumn< string >( 29 );
            RoegadynHellsguardFemaleLastName = parser.ReadColumn< string >( 30 );
            AuRaRaenMale = parser.ReadColumn< string >( 31 );
            AuRaRaenFemale = parser.ReadColumn< string >( 32 );
            AuRaRaenLastName = parser.ReadColumn< string >( 33 );
            AuRaXaelaMale = parser.ReadColumn< string >( 34 );
            AuRaXaelaFemale = parser.ReadColumn< string >( 35 );
            AuRaXaelaLastName = parser.ReadColumn< string >( 36 );
            HrothgarHellionsFirstName = parser.ReadColumn< string >( 37 );
            HrothgarHellionsLastName = parser.ReadColumn< string >( 38 );
            HrothgarLostFirstName = parser.ReadColumn< string >( 39 );
            HrothgarLostLastName = parser.ReadColumn< string >( 40 );
            VieraFirstName = parser.ReadColumn< string >( 41 );
            VieraRavaLastName = parser.ReadColumn< string >( 42 );
            VieraVeenaLastName = parser.ReadColumn< string >( 43 );
        }
    }
}