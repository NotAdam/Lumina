using Lumina.Data;
using ReactiveUI;

namespace Umbra.ViewModels.Explorer.Files
{
    public class RawFileViewModel : ReactiveObject
    {
        private readonly Lumina.Lumina _lumina;

        public RawFileViewModel( string path, Lumina.Lumina lumina )
        {
            _lumina = lumina;
            Path = path;

            Resource = lumina.GetFile( path );
        }

        public string Path { get; }
        
        public FileResource Resource { get; }
    }
}