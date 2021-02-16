// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "TripleTriadCard", columnHash: 0x45c06ae0 )]
    public class TripleTriadCard : ExcelRow
    {
        
        public SeString Name;
        public sbyte Unknown1;
        public SeString Unknown2;
        public sbyte Unknown3;
        public sbyte StartsWithVowel;
        public sbyte Unknown5;
        public sbyte Unknown6;
        public sbyte Unknown7;
        public SeString Description;
        

        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Name = parser.ReadColumn< SeString >( 0 );
            Unknown1 = parser.ReadColumn< sbyte >( 1 );
            Unknown2 = parser.ReadColumn< SeString >( 2 );
            Unknown3 = parser.ReadColumn< sbyte >( 3 );
            StartsWithVowel = parser.ReadColumn< sbyte >( 4 );
            Unknown5 = parser.ReadColumn< sbyte >( 5 );
            Unknown6 = parser.ReadColumn< sbyte >( 6 );
            Unknown7 = parser.ReadColumn< sbyte >( 7 );
            Description = parser.ReadColumn< SeString >( 8 );
        }
    }
}