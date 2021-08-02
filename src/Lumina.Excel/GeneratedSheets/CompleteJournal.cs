// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "CompleteJournal", columnHash: 0x8741e36a )]
    public partial class CompleteJournal : ExcelRow
    {
        
        public uint Unknown0 { get; set; }
        public ushort RequiredLevel { get; set; }
        public byte Unknown2 { get; set; }
        public int Icon { get; set; }
        public uint Unknown4 { get; set; }
        public SeString Name { get; set; }
        public LazyRow< Cutscene >[] Cutscene { get; set; }
        
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