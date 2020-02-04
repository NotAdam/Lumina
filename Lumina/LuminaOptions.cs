using Lumina.Data;

namespace Lumina
{
    public class LuminaOptions
    {
        /// <summary>
        /// Current platform id used to load data files
        /// </summary>
        public Data.Structs.PlatformId CurrentPlatform { get; set; } = Data.Structs.PlatformId.Win32;

        /// <summary>
        /// Whether or not the excel module (exd/exh) is loaded on init. Can be loaded later if required.
        /// </summary>
        public bool LoadExcelModuleOnInit { get; set; } = true;
    }
}