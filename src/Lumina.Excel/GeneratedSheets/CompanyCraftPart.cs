// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "CompanyCraftPart", columnHash: 0xe9ffd316 )]
    public class CompanyCraftPart : ExcelRow
    {
        
        public byte Unknown0;
        public LazyRow< CompanyCraftType > CompanyCraftType;
        public LazyRow< CompanyCraftProcess >[] CompanyCraftProcess;
        public ushort Unknown5;
        

        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Unknown0 = parser.ReadColumn< byte >( 0 );
            CompanyCraftType = new LazyRow< CompanyCraftType >( gameData, parser.ReadColumn< byte >( 1 ), language );
            CompanyCraftProcess = new LazyRow< CompanyCraftProcess >[ 3 ];
            for( var i = 0; i < 3; i++ )
                CompanyCraftProcess[ i ] = new LazyRow< CompanyCraftProcess >( gameData, parser.ReadColumn< ushort >( 2 + i ), language );
            Unknown5 = parser.ReadColumn< ushort >( 5 );
        }
    }
}