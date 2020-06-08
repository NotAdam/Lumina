namespace Lumina.Data
{
    public abstract class BaseFileHandle
    {
        public enum FileState
        {
            None,
            Loading,
            Loaded,
            Error
        }

        protected FileState _state;
        protected Lumina _lumina;
        protected string _path;
        protected object _instance;

        public FileState State => _state;

        public bool HasValue => State == FileState.Loaded && _instance != null;

        public virtual void Load()
        {
            throw new System.NotImplementedException();
        }
    }

    /// <summary>
    /// A wrapper object for game files allowing for asynchronous loading without bullshit 
    /// </summary>
    /// <typeparam name="T">The type of FileResource to wrap</typeparam>
    public class FileHandle< T > : BaseFileHandle where T : FileResource
    {
        /// <summary>
        /// The file handle state.
        /// </summary>
        internal FileHandle( Lumina lumina, string path )
        {
            _lumina = lumina;
            _path = path;
        }

        public override void Load()
        {
            _state = FileState.Loading;
            var file = _lumina.GetFile< T >( _path );

            if( file == null )
            {
                _state = FileState.Error;
                return;
            }

            _state = FileState.Loaded;
            _instance = file;
        }

        public T Value
        {
            get
            {
                if( HasValue )
                {
                    return (T)_instance;
                }

                return null;
            }
        }
    }
}