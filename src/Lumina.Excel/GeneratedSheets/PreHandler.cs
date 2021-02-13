// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "PreHandler", columnHash: 0x724c1806 )]
    public class PreHandler : ExcelRow
    {
        
        public SeString Unknown0;
        public uint Image;
        public uint Target;
        public LazyRow< Quest > UnlockQuest;
        public LazyRow< DefaultTalk > AcceptMessage;
        public LazyRow< DefaultTalk > DenyMessage;
        public byte Unknown6;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            Unknown0 = parser.ReadColumn< SeString >( 0 );
            Image = parser.ReadColumn< uint >( 1 );
            Target = parser.ReadColumn< uint >( 2 );
            UnlockQuest = new LazyRow< Quest >( lumina, parser.ReadColumn< uint >( 3 ), language );
            AcceptMessage = new LazyRow< DefaultTalk >( lumina, parser.ReadColumn< uint >( 4 ), language );
            DenyMessage = new LazyRow< DefaultTalk >( lumina, parser.ReadColumn< uint >( 5 ), language );
            Unknown6 = parser.ReadColumn< byte >( 6 );
        }
    }
}