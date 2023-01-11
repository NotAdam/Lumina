// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ItemAction", columnHash: 0xb1f26af0 )]
    public partial class ItemAction : ExcelRow
    {
        
        public byte CondLv { get; set; }
        public bool CondBattle { get; set; }
        public bool CondPVP { get; set; }
        public bool CondPVPOnly { get; set; }
        public ushort Type { get; set; }
        public ushort[] Data { get; set; }
        public ushort[] DataHQ { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            CondLv = parser.ReadColumn< byte >( 0 );
            CondBattle = parser.ReadColumn< bool >( 1 );
            CondPVP = parser.ReadColumn< bool >( 2 );
            CondPVPOnly = parser.ReadColumn< bool >( 3 );
            Type = parser.ReadColumn< ushort >( 4 );
            Data = new ushort[ 9 ];
            for( var i = 0; i < 9; i++ )
                Data[ i ] = parser.ReadColumn< ushort >( 5 + i );
            DataHQ = new ushort[ 9 ];
            for( var i = 0; i < 9; i++ )
                DataHQ[ i ] = parser.ReadColumn< ushort >( 14 + i );
        }
    }
}