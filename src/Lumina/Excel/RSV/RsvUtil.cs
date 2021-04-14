using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text.RegularExpressions;
using Lumina.Data;

namespace Lumina.Excel.RSV
{
    public class RsvUtil
    {
        /// <summary>
        /// Build a key name for a RSV value
        /// </summary>
        /// <param name="rowId">The sheet row ID</param>
        /// <param name="subRowId">The sheet subrow ID or -1 if not subrow variant</param>
        /// <param name="columnIdx">The column index</param>
        /// <param name="language">The language</param>
        /// <param name="sheetName">The name of the sheet</param>
        /// <returns>The RSV key</returns>
        public static string BuildRsvKeyName( uint rowId, int subRowId, uint columnIdx, Language language, string sheetName )
        {
            return $"_rsv_{rowId}_{subRowId}_{(int)language}_C{columnIdx}_0{sheetName}";
        }

        /// <summary>
        /// Build a key name for a RSV value
        /// </summary>
        /// <param name="rowId">The sheet row ID</param>
        /// <param name="columnIdx">The column index</param>
        /// <param name="language">The language</param>
        /// <param name="sheetName">The name of the sheet</param>
        /// <returns>The RSV key</returns>
        public static string BuildRsvKeyName( uint rowId, uint columnIdx, Language language, string sheetName )
        {
            return BuildRsvKeyName( rowId, -1, columnIdx, language, sheetName );
        }

        private static readonly Regex RsvKeyRegex = new(
            @"_rsv_(\d+)_(-?\d+)_(\d)_C(\d+)_0([\w\d]+)", 
            RegexOptions.Compiled | RegexOptions.IgnoreCase
        );

        /// <summary>
        /// Parse an RSV key to extract its information such as row, sheet, etc.
        /// </summary>
        /// <param name="key">The RSV key</param>
        /// <returns>A <see cref="RsvKeyData"/> object containing its info or null if it failed to parse</returns>
        public static RsvKeyData? ParseRsvKey( string key )
        {
            var results = RsvKeyRegex.Match( key );
            if( results.Groups.Count != 6 )
            {
                return null;
            }

            if( !uint.TryParse( results.Groups[ 1 ].Value, out var rowId ) )
            {
                return null;
            }

            if( !int.TryParse( results.Groups[ 2 ].Value, out var subRowId ) )
            {
                return null;
            }

            if( !Enum.TryParse< Language >( results.Groups[ 3 ].Value, out var language ) )
            {
                return null;
            }

            if( !uint.TryParse( results.Groups[ 4 ].Value, out var columnIndex ) )
            {
                return null;
            }


            return new RsvKeyData
            {
                RowId = rowId,
                SubRowId = subRowId,
                ColumnIndex = columnIndex,
                Language = language,
                SheetName = results.Groups[ 5 ].Value
            };
        }
    }
}