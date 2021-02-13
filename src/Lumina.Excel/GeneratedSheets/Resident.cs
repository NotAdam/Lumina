// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Resident", columnHash: 0x9af0b586 )]
    public class Resident : ExcelRow
    {
        
        public byte Unknown0;
        public ulong Model;
        public LazyRow< NpcYell > NpcYell;
        public ushort AddedIn53;
        public byte ResidentMotionType;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            Unknown0 = parser.ReadColumn< byte >( 0 );
            Model = parser.ReadColumn< ulong >( 1 );
            NpcYell = new LazyRow< NpcYell >( lumina, parser.ReadColumn< int >( 2 ), language );
            AddedIn53 = parser.ReadColumn< ushort >( 3 );
            ResidentMotionType = parser.ReadColumn< byte >( 4 );
        }
    }
}