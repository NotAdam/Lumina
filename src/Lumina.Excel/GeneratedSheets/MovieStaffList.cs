// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "MovieStaffList", columnHash: 0xc3212d0e )]
    public class MovieStaffList : ExcelRow
    {
        
        public uint Image;
        public float StartTime;
        public float EndTime;
        public sbyte Unknown3;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            Image = parser.ReadColumn< uint >( 0 );
            StartTime = parser.ReadColumn< float >( 1 );
            EndTime = parser.ReadColumn< float >( 2 );
            Unknown3 = parser.ReadColumn< sbyte >( 3 );
        }
    }
}