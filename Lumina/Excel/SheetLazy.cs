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
        private readonly int _row;
        private readonly int _subrow;

        private T _value;

        public int Row => _row;
        public int SubRow => _subrow;


        public LazyRow( Lumina lumina, int row, int subrow = Int32.MaxValue )
        {
            _lumina = lumina;
            _row = row;
            _subrow = subrow;
        }

        public LazyRow( Lumina lumina, uint row ) : this( lumina, (int)row )
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

                _value = _lumina.GetExcelSheet< T >().GetRow( _row, _subrow );

                return _value;
            }
        }

        public bool HasValue => _value != null;
    }
}