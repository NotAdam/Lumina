// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ScreenImage", columnHash: 0xf03c70eb )]
    public class ScreenImage : ExcelRow
    {
        
        public uint Image;
        public short Jingle;
        public sbyte Type;
        public bool Lang;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            Image = parser.ReadColumn< uint >( 0 );
            Jingle = parser.ReadColumn< short >( 1 );
            Type = parser.ReadColumn< sbyte >( 2 );
            Lang = parser.ReadColumn< bool >( 3 );
        }
    }
}