// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Ornament", columnHash: 0x6768819a )]
    public partial class Ornament : ExcelRow
    {
        
        public ushort Model { get; set; }
        public byte Unknown1 { get; set; }
        public byte Unknown2 { get; set; }
        public bool Unknown3 { get; set; }
        public short Order { get; set; }
        public ushort Icon { get; set; }
        public ushort Transient { get; set; }
        public SeString Singular { get; set; }
        public sbyte Adjective { get; set; }
        public SeString Plural { get; set; }
        public sbyte PossessivePronoun { get; set; }
        public sbyte StartsWithVowel { get; set; }
        public sbyte Unknown12 { get; set; }
        public sbyte Pronoun { get; set; }
        public sbyte Article { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Model = parser.ReadColumn< ushort >( 0 );
            Unknown1 = parser.ReadColumn< byte >( 1 );
            Unknown2 = parser.ReadColumn< byte >( 2 );
            Unknown3 = parser.ReadColumn< bool >( 3 );
            Order = parser.ReadColumn< short >( 4 );
            Icon = parser.ReadColumn< ushort >( 5 );
            Transient = parser.ReadColumn< ushort >( 6 );
            Singular = parser.ReadColumn< SeString >( 7 );
            Adjective = parser.ReadColumn< sbyte >( 8 );
            Plural = parser.ReadColumn< SeString >( 9 );
            PossessivePronoun = parser.ReadColumn< sbyte >( 10 );
            StartsWithVowel = parser.ReadColumn< sbyte >( 11 );
            Unknown12 = parser.ReadColumn< sbyte >( 12 );
            Pronoun = parser.ReadColumn< sbyte >( 13 );
            Article = parser.ReadColumn< sbyte >( 14 );
        }
    }
}