using System.Collections.Generic;
using System.ComponentModel;
using Config.Net;
using Lumina.Data;

namespace Umbra
{
    public interface IPreviousVersion
    {
        string Version { get; set; }
        string DataPath { get; set; }
    }
    
    public interface IUmbraSettings : INotifyPropertyChanged
    {
        [Option( Alias = "Data.Path" )]
        string DataPath { get; set; }
        
        [Option( Alias = "Data.Versions" )]
        IEnumerable< IPreviousVersion > PreviousVersions { get; }

        [Option( Alias = "Data.ExcelLanguage", DefaultValue = Language.English )]
        Language ExcelLanguage { get; set; }
    }
}