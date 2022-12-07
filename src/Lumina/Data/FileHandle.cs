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
            Path = path;
        }

        public FileState State { get; protected set; } = FileState.None;
        protected readonly GameData GameData;
        protected readonly string Path;
        protected object? Instance;

        public bool HasValue => State == FileState.Loaded && Instance != null;

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
            State = FileState.Loading;
            var file = GameData.GetFile< T >( Path );

            if( file == null )
            {
                State = FileState.Error;
                return;
            }

            State = FileState.Loaded;
            Instance = file;
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
                    return (T?)Instance;
                }

                return null;
            }
        }
    }
}