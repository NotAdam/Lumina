// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "OpenContent", columnHash: 0x170b114d )]
    public class OpenContent : ExcelRow
    {
        
        public LazyRow< ContentFinderCondition >[] Content;
        public LazyRow< OpenContentCandidateName >[] CandidateName;
        

        public override void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            base.PopulateData( parser, lumina, language );

            Content = new LazyRow< ContentFinderCondition >[ 16 ];
            for( var i = 0; i < 16; i++ )
                Content[ i ] = new LazyRow< ContentFinderCondition >( lumina, parser.ReadColumn< ushort >( 0 + i ), language );
            CandidateName = new LazyRow< OpenContentCandidateName >[ 16 ];
            for( var i = 0; i < 16; i++ )
                CandidateName[ i ] = new LazyRow< OpenContentCandidateName >( lumina, parser.ReadColumn< uint >( 16 + i ), language );
        }
    }
}