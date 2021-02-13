// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "DynamicEventType", columnHash: 0x6be0e840 )]
    public class DynamicEventType : ExcelRow
    {
        
        public uint IconObjective0;
        public uint IconObjective1;
        public uint Unknown2;
        public uint Unknown3;
        public uint Unknown4;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            IconObjective0 = parser.ReadColumn< uint >( 0 );
            IconObjective1 = parser.ReadColumn< uint >( 1 );
            Unknown2 = parser.ReadColumn< uint >( 2 );
            Unknown3 = parser.ReadColumn< uint >( 3 );
            Unknown4 = parser.ReadColumn< uint >( 4 );
        }
    }
}