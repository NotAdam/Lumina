using System;
using Lumina.Data;

namespace Lumina.Excel
{
    public interface ILazyRow
    {
        /// <summary>
        /// The backing value/row that was passed through when creating the reference
        /// </summary>
        public uint Row { get; }
        
        /// <summary>
        /// Checks whether something has loaded successfully.
        /// </summary>
        /// <remarks>
        /// If something fails to load, this will still be false regardless.
        /// </remarks>
        public bool IsValueCreated { get; }
        
        public Language Language { get; }
        
        public ExcelRow RawRow { get; }
    }

    /// <summary>
    /// Allows for sheet definitions to contain entries which will lazily load the referenced sheet row
    /// </summary>
    /// <typeparam name="T">The row type to load</typeparam>
    public class LazyRow< T > : ILazyRow where T : ExcelRow
    {
        private readonly GameData _gameData;
        private readonly uint _row;
        private readonly Language _language;

        private T _value;

        /// <summary>
        /// The backing value/row that was passed through when creating the reference
        /// </summary>
        public uint Row => _row;

        public Language Language => _language;

        /// <summary>
        /// Construct a new LazyRow instance
        /// </summary>
        /// <param name="gameData">The Lumina instance to load from</param>
        /// <param name="row">The row id to load if/when the value is fetched</param>
        /// <param name="language">The requested language to use when resolving row references</param>
        public LazyRow( GameData gameData, uint row, Language language = Language.None )
        {
            _gameData = gameData;
            _row = row;
            _language = language;
        }

        /// <summary>
        /// Construct a new LazyRow instance
        /// </summary>
        /// <param name="gameData">The Lumina instance to load from</param>
        /// <param name="row">The row id to load if/when the value is fetched</param>
        public LazyRow( GameData gameData, int row, Language language = Language.None ) : this( gameData, (uint)row, language )
        {
        }

        /// <summary>
        /// Lazily load the referenced sheet/row, otherwise return the existing row.
        /// </summary>
        public T Value
        {
            get
            {
                if( IsValueCreated )
                {
                    return _value;
                }

                _value = _gameData.GetExcelSheet< T >( _language ).GetRow( _row );

                return _value;
            }
        }

        /// <summary>
        /// Provides access to the raw row without any fuckery, useful for serialisation and etc.
        /// </summary>
        public ExcelRow RawRow => Value;
        
        /// <summary>
        /// Checks whether something has loaded successfully.
        /// </summary>
        /// <remarks>
        /// If something fails to load, this will still be false regardless.
        /// </remarks>
        [Obsolete( "Use IsValueCreated instead - HasValue is too ambiguous" )]
        public bool HasValue => _value != null;


        /// <summary>
        /// Checks whether something has loaded successfully.
        /// </summary>
        /// <remarks>
        /// If something fails to load, this will still be false regardless.
        /// </remarks>
        public bool IsValueCreated => _value != null;

        public override string ToString()
        {
            return $"{typeof( T ).FullName}#{_row}";
        }
    }
}