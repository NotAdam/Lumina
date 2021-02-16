// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "CompleteJournal", columnHash: 0x8741e36a )]
    public class CompleteJournal : ExcelRow
    {
        
        public uint Unknown0;
        public ushort RequiredLevel;
        public byte Unknown2;
        public int Icon;
        public uint Unknown4;
        public SeString Name;
        public LazyRow< Cutscene >[] Cutscene;
        

        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Unknown0 = parser.ReadColumn< uint >( 0 );
            RequiredLevel = parser.ReadColumn< ushort >( 1 );
            Unknown2 = parser.ReadColumn< byte >( 2 );
            Icon = parser.ReadColumn< int >( 3 );
            Unknown4 = parser.ReadColumn< uint >( 4 );
            Name = parser.ReadColumn< SeString >( 5 );
            Cutscene = new LazyRow< Cutscene >[ 24 ];
            for( var i = 0; i < 24; i++ )
                Cutscene[ i ] = new LazyRow< Cutscene >( gameData, parser.ReadColumn< int >( 6 + i ), language );
        }
    }
}