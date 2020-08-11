// ReSharper disable All

using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "MotionTimeline", columnHash: 0xd5952f72 )]
    public class MotionTimeline : IExcelRow
    {
        
        public string Filename;
        public byte BlendGroup;
        public bool IsLoop;
        public bool IsBlinkEnable;
        public bool IsLipEnable;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Filename = parser.ReadColumn< string >( 0 );
            BlendGroup = parser.ReadColumn< byte >( 1 );
            IsLoop = parser.ReadColumn< bool >( 2 );
            IsBlinkEnable = parser.ReadColumn< bool >( 3 );
            IsLipEnable = parser.ReadColumn< bool >( 4 );
        }
    }
}