using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using CliFx;
using CliFx.Attributes;
using Lumina.Data.Files.Excel;

namespace Lumina.Cmd.Commands
{
    [Command( "excelupdate",
        Description = "Updates excel column definitions. Requires that old install location has exd dats (0a) available. Other dats are not required to exist." )]
    public class ExcelUpdate : ICommand
    {
        [CommandOption( "oldpath", 'o', Description = "Path to the older client install location", IsRequired = true )]
        public string OldPath { get; set; }

        [CommandOption( "newpath", 'n', Description = "Path to the new client install location", IsRequired = true )]
        public string NewPath { get; set; }


        public ValueTask ExecuteAsync( IConsole console )
        {
            var co = console.Output;
            var ol = new GameData( OldPath );
            var nl = new GameData( NewPath );

            co.WriteLine( $"old sheets: {ol.Excel.SheetNames.Count} new sheets: {nl.Excel.SheetNames.Count}" );

            var removedSheets = ol.Excel.SheetNames.Except( nl.Excel.SheetNames ).ToList();
            if( removedSheets.Any() )
            {
                co.WriteLine( $"{removedSheets.Count} sheets removed" );

                foreach( var sheetName in removedSheets )
                {
                    co.WriteLine( $" - {sheetName}" );
                }
            }

            var newSheets = nl.Excel.SheetNames.Except( ol.Excel.SheetNames ).ToList();
            if( newSheets.Any() )
            {
                co.WriteLine( $"{newSheets.Count} new sheets" );

                foreach( var sheetName in newSheets )
                {
                    co.WriteLine( $" - {sheetName}" );
                }
            }

            co.WriteLine( "diffing existing sheets..." );
            var existingSheets = nl.Excel.SheetNames.Intersect( ol.Excel.SheetNames ).ToList();
            foreach( var eSheet in existingSheets )
            {
                var exhPath = $"exd/{eSheet}.exh";
                var oldHeader = ol.GetFile< ExcelHeaderFile >( exhPath );
                var newHeader = nl.GetFile< ExcelHeaderFile >( exhPath );

                Debug.Assert( oldHeader != null && newHeader != null );
                
                var oldColumnsHash = oldHeader.GetColumnsHashString();
                var newColumnsHash = newHeader.GetColumnsHashString();

                var colHashChanged = oldColumnsHash != newColumnsHash;
                var rowsChanged = oldHeader.Header.RowCount != newHeader.Header.RowCount;

                if( colHashChanged )
                {
                    co.WriteLine( $" - {eSheet}" );

                    var oldHash = oldColumnsHash.Substring( 0, 8 );
                    var newHash = newColumnsHash.Substring( 0, 8 );
                    co.WriteLine($"   - col hash changed! old: {oldHash} new: {newHash}");
                    co.WriteLine($"   - old col count: {oldHeader.Header.ColumnCount} new col count: {newHeader.Header.ColumnCount}");
                }
            }

            return default;
        }
    }
}