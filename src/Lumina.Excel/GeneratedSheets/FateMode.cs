// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "FateMode", columnHash: 0x6be0e840 )]
    public class FateMode : ExcelRow
    {
        
        public uint Unknown0;
        public uint MotivationIcon;
        public uint MotivationMapMarker;
        public uint ObjectiveIcon;
        public uint ObjectiveMapMarker;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            Unknown0 = parser.ReadColumn< uint >( 0 );
            MotivationIcon = parser.ReadColumn< uint >( 1 );
            MotivationMapMarker = parser.ReadColumn< uint >( 2 );
            ObjectiveIcon = parser.ReadColumn< uint >( 3 );
            ObjectiveMapMarker = parser.ReadColumn< uint >( 4 );
        }
    }
}