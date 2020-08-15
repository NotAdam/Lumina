using System.Threading.Tasks;
using Lumina.Excel.GeneratedSheets;
using Serilog;

namespace Umbra.Services
{
    public class GameFileDiscoveryService
    {
        public bool IsDiscoveringFiles { get; private set; } = false;

        public void StartFileDiscovery( Lumina.Lumina lumina )
        {
            DiscoverExcelFiles( lumina );
        }

        private void DiscoverExcelFiles( Lumina.Lumina lumina )
        {
            var sheets = lumina.Excel.SheetNames;
            foreach( var sheet in sheets )
            {
                DiscoverFile( lumina, $"exd/{sheet}.exh" );
            }
        }

        private void DiscoverLevelPaths( Lumina.Lumina lumina )
        {
            var territoryType = lumina.GetExcelSheet< TerritoryType >();
            foreach( var row in territoryType )
            {
                var basePath = $"bg/{row.Bg}";
            }
        }

        private void DiscoverFile( Lumina.Lumina lumina, string path )
        {
            Log.Verbose( "discovered file: {FilePath}", path );

            if( !lumina.FileExists( path ) )
            {
                return;
            }

            Events.EventHelper.DiscoverNewFile( path );
        }
    }
}