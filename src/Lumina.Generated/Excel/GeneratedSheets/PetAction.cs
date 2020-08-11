// ReSharper disable All

using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "PetAction", columnHash: 0x5e492849 )]
    public class PetAction : IExcelRow
    {
        
        public string Name;
        public string Description;
        public int Icon;
        public LazyRow< Action > Action;
        public LazyRow< Pet > Pet;
        public bool MasterOrder;
        public bool DisableOrder;
        public bool Unknown7;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Name = parser.ReadColumn< string >( 0 );
            Description = parser.ReadColumn< string >( 1 );
            Icon = parser.ReadColumn< int >( 2 );
            Action = new LazyRow< Action >( lumina, parser.ReadColumn< ushort >( 3 ), language );
            Pet = new LazyRow< Pet >( lumina, parser.ReadColumn< byte >( 4 ), language );
            MasterOrder = parser.ReadColumn< bool >( 5 );
            DisableOrder = parser.ReadColumn< bool >( 6 );
            Unknown7 = parser.ReadColumn< bool >( 7 );
        }
    }
}