using Lumina.Data;
using Lumina.Excel;

namespace Lumina;

/// <summary>
/// Options that can be provided to change the behaviour of caching, integrity checks and other behaviour.
/// </summary>
public class LuminaOptions
{
    /// <summary>
    /// Current platform id used to load data files
    /// </summary>
    public PlatformType CurrentPlatform { get; set; } = PlatformType.Win32;

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
    /// The resolver delegate to use when resolving RSV strings. Leave <see langword="null"/> if you don't need it.
    /// </summary>
    public ExcelModule.ResolveRsvDelegate? RsvResolver { get; set; }

    public SqPackVfs.ResolveRsfDelegate? RsfResolver { get; set; }

    /// <summary>
    /// The logger that Lumina will use to log events to. If not provided, Lumina will not log anything.
    /// </summary>
    public ILogger? Logger { get; set; }
}