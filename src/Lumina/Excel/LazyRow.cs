using System;
using System.Collections.Generic;
using System.Linq;
using Lumina.Data;
using Lumina.Data.Files.Excel;
using Lumina.Data.Structs.Excel;

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
        
        public ExcelRow? RawRow { get; }
    }

    public class EmptyLazyRow : ILazyRow
    {
        private static readonly ExcelDataPagination _blankPagination = new();
        private static readonly Dictionary< string, List<Range> > _ranges = new();
        
        public uint Row { get; set; }
        public bool IsValueCreated => false;
        public Language Language => Language.None;
        public ExcelRow? RawRow => null;

        public EmptyLazyRow( uint rowId )
        {
            Row = rowId;
        }
        
        public static ILazyRow GetFirstLazyRowOrEmpty( GameData gameData, uint row, params string[] sheetNames )
        {
            return GetFirstLazyRowOrEmpty( gameData, row, Language.None, sheetNames );
        }
        
        public static ILazyRow GetFirstLazyRowOrEmpty( GameData gameData, uint row, Language language, params string[] sheetNames )
        {
            foreach( var sheetName in sheetNames )
            {
                if( !_ranges.ContainsKey( sheetName ) )
                {
                    var exh = gameData.GetFile< ExcelHeaderFile >( $"exd/{sheetName}.exh" );
                    if( exh == null )
                    {
                        continue;
                    }
                    _ranges.Add( sheetName, exh.DataPages.Select( p => new Range( (int)p.StartId, (int) (p.StartId + p.RowCount) ) ).ToList() );
                }

                foreach( var range in _ranges[sheetName] )
                {
                    if (row < range.Start.Value && row > range.End.Value)
                    {
                        return new LazyRow< ExcelRow >( gameData, row, language );
                    }    
                }
            }
            return new EmptyLazyRow( row );
        }
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

        private T? _value;

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
        /// <param name="language">The language to load the row in</param>
        public LazyRow( GameData gameData, int row, Language language = Language.None ) : this( gameData, (uint)row, language )
        {
        }

        /// <summary>
        /// Lazily load the referenced sheet/row, otherwise return the existing row.
        /// </summary>
        public T? Value
        {
            get
            {
                if( IsValueCreated )
                {
                    return _value;
                }

                _value = _gameData.GetExcelSheet< T >( _language )?.GetRow( _row );

                return _value;
            }
        }

        /// <summary>
        /// Provides access to the raw row without any fuckery, useful for serialisation and etc.
        /// </summary>
        public ExcelRow? RawRow => Value;
        
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