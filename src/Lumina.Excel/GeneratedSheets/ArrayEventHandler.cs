// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ArrayEventHandler", columnHash: 0xb404681e )]
    public partial class ArrayEventHandler : ExcelRow
    {
        
        public uint[] Data { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Data = new uint[ 16 ];
            for( var i = 0; i < 16; i++ )
                Data[ i ] = parser.ReadColumn< uint >( 0 + i );
        }
    }
}