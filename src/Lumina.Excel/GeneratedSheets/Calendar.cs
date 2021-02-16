// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Calendar", columnHash: 0x005cfabb )]
    public class Calendar : ExcelRow
    {
        
        public byte[] Month;
        public byte[] Day;
        

        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Month = new byte[ 32 ];
            for( var i = 0; i < 32; i++ )
                Month[ i ] = parser.ReadColumn< byte >( 0 + i );
            Day = new byte[ 32 ];
            for( var i = 0; i < 32; i++ )
                Day[ i ] = parser.ReadColumn< byte >( 32 + i );
        }
    }
}