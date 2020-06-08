using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "EurekaLogosMixerProbability", columnHash: 0xdcfd9eba )]
    public class EurekaLogosMixerProbability : IExcelRow
    {
        
        public byte ProbabilityPct;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            ProbabilityPct = parser.ReadColumn< byte >( 0 );
        }
    }
}