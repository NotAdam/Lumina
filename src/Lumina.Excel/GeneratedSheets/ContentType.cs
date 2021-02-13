// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ContentType", columnHash: 0xf75a9d4b )]
    public class ContentType : ExcelRow
    {
        
        public SeString Name;
        public uint Icon;
        public uint IconDutyFinder;
        public byte Unknown3;
        public byte Unknown4;
        public byte Unknown5;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            Name = parser.ReadColumn< SeString >( 0 );
            Icon = parser.ReadColumn< uint >( 1 );
            IconDutyFinder = parser.ReadColumn< uint >( 2 );
            Unknown3 = parser.ReadColumn< byte >( 3 );
            Unknown4 = parser.ReadColumn< byte >( 4 );
            Unknown5 = parser.ReadColumn< byte >( 5 );
        }
    }
}