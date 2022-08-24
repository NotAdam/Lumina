// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "OpenContent", columnHash: 0x170b114d )]
    public partial class OpenContent : ExcelRow
    {
        
        public LazyRow< ContentFinderCondition >[] Content { get; set; }
        public LazyRow< OpenContentCandidateName >[] CandidateName { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Content = new LazyRow< ContentFinderCondition >[ 16 ];
            for( var i = 0; i < 16; i++ )
                Content[ i ] = new LazyRow< ContentFinderCondition >( gameData, parser.ReadColumn< ushort >( 0 + i ), language );
            CandidateName = new LazyRow< OpenContentCandidateName >[ 16 ];
            for( var i = 0; i < 16; i++ )
                CandidateName[ i ] = new LazyRow< OpenContentCandidateName >( gameData, parser.ReadColumn< uint >( 16 + i ), language );
        }
    }
}