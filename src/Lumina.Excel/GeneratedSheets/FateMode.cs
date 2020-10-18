// ReSharper disable All

using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "FateMode", columnHash: 0x6be0e840 )]
    public class FateMode : IExcelRow
    {
        
        public uint Unknown0;
        public uint MotivationIcon;
        public uint MotivationMapMarker;
        public uint ObjectiveIcon;
        public uint ObjectiveMapMarker;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Unknown0 = parser.ReadColumn< uint >( 0 );
            MotivationIcon = parser.ReadColumn< uint >( 1 );
            MotivationMapMarker = parser.ReadColumn< uint >( 2 );
            ObjectiveIcon = parser.ReadColumn< uint >( 3 );
            ObjectiveMapMarker = parser.ReadColumn< uint >( 4 );
        }
    }
}