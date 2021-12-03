using Lumina.Data;

namespace Lumina.Excel
{
    public abstract class ExcelRow
    {
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }
        
        public string SheetName { get; protected set; }
        
        public Language SheetLanguage { get; set; }

        protected GameData? _gameData;

        public virtual void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            _gameData = gameData;
            
            RowId = parser.RowId;
            SubRowId = parser.SubRowId;
            SheetLanguage = language;

            SheetName = parser.Sheet.Name;
        }

        /// <summary>
        /// Implementation shim around what SC calls default columns, allows a sheet impl to provide something more meaningful as a default display value
        /// </summary>
        public virtual object GetDefaultColumnValue()
        {
            // todo: we can probably just handle subrows in an override instead of doing something funny here because we know statically what are variant 2 sheets
            return $"{SheetName}#{RowId}";
        }

        public override string ToString()
        {
            return $"{SheetName}#{RowId}";
        }
    }
}