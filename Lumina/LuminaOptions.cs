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

        /// <summary>
        /// If true, each loaded FileResource will have a weak reference maintained by Lumina so that sequential loads will return the pre-loaded file
        /// in the event it hasn't been GC'd. This is constrained by the file type used to load, so loading the same file as a FileResource and then a
        /// TexFile will kill the old FileResource reference and replace it with a TexFile reference and miss the cache.
        /// </summary>
        public bool CacheFileResources { get; set; } = true;

        /// <summary>
        /// If true, files that do not have an immutable ID set will not be immediately loaded and instead will have their header loaded when their
        /// row(s) are requested.
        /// </summary>
        public bool PreCacheAllExcelHeaders { get; set; } = false;

        /// <summary>
        /// The default language to fetch from Excel sheets. Can be overriden on a case-by-case basis but this serves as the default.
        /// </summary>
        public Language DefaultExcelLanguage { get; set; } = Language.English;
    }
}