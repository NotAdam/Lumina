// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "MovieStaffList", columnHash: 0xc3212d0e )]
    public partial class MovieStaffList : ExcelRow
    {
        
        public uint Image { get; set; }
        public float StartTime { get; set; }
        public float EndTime { get; set; }
        public sbyte Unknown3 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Image = parser.ReadColumn< uint >( 0 );
            StartTime = parser.ReadColumn< float >( 1 );
            EndTime = parser.ReadColumn< float >( 2 );
            Unknown3 = parser.ReadColumn< sbyte >( 3 );
        }
    }
}