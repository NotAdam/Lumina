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
        
        internal BaseFileHandle( GameData gameData, string path )
        {
            GameData = gameData;
            _path = path;
        }

        protected FileState _state = FileState.None;
        protected GameData GameData;
        protected readonly string _path;
        protected object? _instance;

        public FileState State => _state;

        public bool HasValue => State == FileState.Loaded && _instance != null;

        /// <summary>
        /// Loads the underlying <see cref="FileResource"/>
        /// </summary>
        /// <exception cref="System.NotImplementedException"></exception>
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
        internal FileHandle( GameData gameData, string path ) : base( gameData, path )
        {
        }
        
        public override void Load()
        {
            _state = FileState.Loading;
            var file = GameData.GetFile< T >( _path );

            if( file == null )
            {
                _state = FileState.Error;
                return;
            }

            _state = FileState.Loaded;
            _instance = file;
        }

        /// <summary>
        /// Returns the <see cref="FileResource"/> or null if it isn't loaded or failed to load.
        /// </summary>
        public T? Value
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