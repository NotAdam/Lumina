using System;

namespace Lumina.Excel
{
    /// <summary>
    /// Allows for sheet definitions to contain entries which will lazily load the referenced sheet row
    /// </summary>
    /// <typeparam name="T">The row type to load</typeparam>
    public class LazyRow< T > where T : IExcelRow
    {
        private readonly Lumina _lumina;
        private readonly uint _row;

        private T _value;

        /// <summary>
        /// The backing value/row that was passed through when creating the reference
        /// </summary>
        public uint Row => _row;

        /// <summary>
        /// Construct a new LazyRow instance
        /// </summary>
        /// <param name="lumina">The Lumina instance to load from</param>
        /// <param name="row">The row id to load if/when the value is fetched</param>
        public LazyRow( Lumina lumina, uint row )
        {
            _lumina = lumina;
            _row = row;
        }

        /// <summary>
        /// Construct a new LazyRow instance
        /// </summary>
        /// <param name="lumina">The Lumina instance to load from</param>
        /// <param name="row">The row id to load if/when the value is fetched</param>
        public LazyRow( Lumina lumina, int row ) : this( lumina, (uint)row )
        {
        }

        /// <summary>
        /// Lazily load the referenced sheet/row, otherwise return the existing row.
        /// </summary>
        public T Value
        {
            get
            {
                if( HasValue )
                {
                    return _value;
                }

                _value = _lumina.GetExcelSheet< T >().GetRow( _row );

                return _value;
            }
        }

        /// <summary>
        /// Checks whether something has loaded successfully.
        /// </summary>
        /// <remarks>
        /// If something fails to load, this will still be false regardless.
        /// </remarks>
        public bool HasValue => _value != null;
    }
}