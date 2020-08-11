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
        /// If true, each loaded FileResource will have a weak reference maintained by Lumina so that sequential loads will return the pre-loaded file
        /// in the event it hasn't been GC'd/a reference is maintained elsewhere. This is constrained by the file type used to load, so loading the
        /// same file as a FileResource and then a TexFile will kill the old FileResource reference and replace it with a TexFile reference and miss the cache.
        /// </summary>
        public bool CacheFileResources { get; set; } = true;

        /// <summary>
        /// The default language to fetch from Excel sheets. Can be overriden on a case-by-case basis but this serves as the default.
        /// </summary>
        public Language DefaultExcelLanguage { get; set; } = Language.English;

        /// <summary>
        /// Whether or not an exception should be thrown in the event that a sheet's column checksum no longer matches. This has no effect on sheets
        /// which do not define a column checksum.
        /// </summary>
        public bool PanicOnSheetChecksumMismatch { get; set; } = true;

        /// <summary>
        /// If enabled, when a cast fails in an excel sheet, an InvalidCastException will be thrown instead of the types default value being inserted instead.
        /// </summary>
        public bool ExcelSheetStrictCastingEnabled { get; set; } = false;
    }
}