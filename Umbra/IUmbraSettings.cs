using System.ComponentModel;
using Config.Net;
using Lumina.Data;

namespace Umbra
{
    public interface IUmbraSettings : INotifyPropertyChanged
    {
        [Option( Alias = "Data.Path" )]
        string DataPath { get; set; }

        [Option( Alias = "Data.ExcelLanguage", DefaultValue = Language.English )]
        Language ExcelLanguage { get; set; }
    }
}