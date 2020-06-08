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

        public uint Row => _row;

        public LazyRow( Lumina lumina, uint row )
        {
            _lumina = lumina;
            _row = row;
        }

        public LazyRow( Lumina lumina, int row ) : this( lumina, (uint)row )
        {
        }

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

        public bool HasValue => _value != null;
    }
}