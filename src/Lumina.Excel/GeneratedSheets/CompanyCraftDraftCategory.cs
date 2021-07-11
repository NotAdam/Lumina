// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "CompanyCraftDraftCategory", columnHash: 0xf6570594 )]
    public class CompanyCraftDraftCategory : ExcelRow
    {
        public class UnkData1Obj
        {
            public ushort CompanyCraftType { get; set; }
        }
        
        public SeString Name { get; set; }
        public UnkData1Obj[] UnkData1 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Name = parser.ReadColumn< SeString >( 0 );
            UnkData1 = new UnkData1Obj[ 10 ];
            for( var i = 0; i < 10; i++ )
            {
                UnkData1[ i ] = new UnkData1Obj();
                UnkData1[ i ].CompanyCraftType = parser.ReadColumn< ushort >( 1 + ( i * 1 + 0 ) );
            }
        }
    }
}