// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "IKDContentBonus", columnHash: 0xb7d9b7a3 )]
    public class IKDContentBonus : ExcelRow
    {
        
        public SeString Objective;
        public SeString Requirement;
        public ushort Unknown2;
        public uint Image;
        public byte Order;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            Objective = parser.ReadColumn< SeString >( 0 );
            Requirement = parser.ReadColumn< SeString >( 1 );
            Unknown2 = parser.ReadColumn< ushort >( 2 );
            Image = parser.ReadColumn< uint >( 3 );
            Order = parser.ReadColumn< byte >( 4 );
        }
    }
}