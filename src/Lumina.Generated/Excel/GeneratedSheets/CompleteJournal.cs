using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "CompleteJournal", columnHash: 0x6f3a5c4a )]
    public class CompleteJournal : IExcelRow
    {
        
        public uint Unknown0;
        public ushort RequiredLevel;
        public byte Unknown2;
        public int Icon;
        public uint Unknown4;
        public string Name;
        public LazyRow< Cutscene >[] Cutscene;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Unknown0 = parser.ReadColumn< uint >( 0 );
            RequiredLevel = parser.ReadColumn< ushort >( 1 );
            Unknown2 = parser.ReadColumn< byte >( 2 );
            Icon = parser.ReadColumn< int >( 3 );
            Unknown4 = parser.ReadColumn< uint >( 4 );
            Name = parser.ReadColumn< string >( 5 );
            Cutscene = new LazyRow< Cutscene >[ 24 ];
            for( var i = 0; i < 24; i++ )
                Cutscene[ i ] = new LazyRow< Cutscene >( lumina, parser.ReadColumn< int >( 6 + i ), language );
        }
    }
}