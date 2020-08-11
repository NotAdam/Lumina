// ReSharper disable All

using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Adventure", columnHash: 0xf6b785f8 )]
    public class Adventure : IExcelRow
    {
        
        public LazyRow< Level > Level;
        public int MinLevel;
        public byte MaxLevel;
        public LazyRow< Emote > Emote;
        public ushort MinTime;
        public ushort MaxTime;
        public LazyRow< PlaceName > PlaceName;
        public int IconList;
        public int IconDiscovered;
        public string Name;
        public string Impression;
        public string Description;
        public int IconUndiscovered;
        public bool IsInitial;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Level = new LazyRow< Level >( lumina, parser.ReadColumn< int >( 0 ), language );
            MinLevel = parser.ReadColumn< int >( 1 );
            MaxLevel = parser.ReadColumn< byte >( 2 );
            Emote = new LazyRow< Emote >( lumina, parser.ReadColumn< ushort >( 3 ), language );
            MinTime = parser.ReadColumn< ushort >( 4 );
            MaxTime = parser.ReadColumn< ushort >( 5 );
            PlaceName = new LazyRow< PlaceName >( lumina, parser.ReadColumn< int >( 6 ), language );
            IconList = parser.ReadColumn< int >( 7 );
            IconDiscovered = parser.ReadColumn< int >( 8 );
            Name = parser.ReadColumn< string >( 9 );
            Impression = parser.ReadColumn< string >( 10 );
            Description = parser.ReadColumn< string >( 11 );
            IconUndiscovered = parser.ReadColumn< int >( 12 );
            IsInitial = parser.ReadColumn< bool >( 13 );
        }
    }
}