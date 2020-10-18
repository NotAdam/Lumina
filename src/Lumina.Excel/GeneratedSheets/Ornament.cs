// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Ornament", columnHash: 0x6768819a )]
    public class Ornament : IExcelRow
    {
        
        public ushort Model;
        public byte Unknown1;
        public byte Unknown2;
        public bool Unknown3;
        public short Order;
        public ushort Icon;
        public ushort Transient;
        public SeString Singular;
        public sbyte Adjective;
        public SeString Plural;
        public sbyte PossessivePronoun;
        public sbyte StartsWithVowel;
        public sbyte Unknown12;
        public sbyte Pronoun;
        public sbyte Article;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

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