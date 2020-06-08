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
        private readonly uint _subrow;

        private T _value;

        public uint Row => _row;
        public uint SubRow => _subrow;


        public LazyRow( Lumina lumina, uint row, uint subrow = UInt32.MaxValue )
        {
            _lumina = lumina;
            _row = row;
            _subrow = subrow;
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