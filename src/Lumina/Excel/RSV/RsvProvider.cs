using System.Collections.Generic;
using System.IO;
using Lumina.Data;

namespace Lumina.Excel.RSV
{
    using RSVPair = KeyValuePair< string, string >;

    /// <summary>
    /// Stores a mapping so that Lumina can remap _rsv_* values to their actual values when consuming sheet data.
    /// </summary>
    /// <remarks>
    /// 'rsv' means 'retard shit value'. 
    /// </remarks>
    public class RsvProvider
    {
        public RsvProvider()
        {
            _rsvEntries = new();
        }

        private readonly Dictionary< string, string> _rsvEntries;

        /// <summary>
        /// Add a RSV mapping for a language to the collection
        /// </summary>
        /// <param name="rsvEntry">The RSV key and value</param>
        public void Seed( RSVPair rsvEntry )
        {
            _rsvEntries[ rsvEntry.Key ] = rsvEntry.Value;
        }

        /// <summary>
        /// Add RSV mappings from a collection of comma separated values [key],[value]
        /// </summary>
        /// <param name="lines">Each line from the RSV file</param>
        public void ParseLines( IEnumerable< string > lines )
        {
            var delim = new[] { ',' };

            foreach( var entry in lines )
            {
                // ignore anything that isn't assumedly an actual rsv key value pair
                if( !entry.StartsWith( "_rsv_" ) )
                {
                    continue;
                }
                
                var data = entry.Split( delim, 2 );
                var rsvKey = RsvUtil.ParseRsvKey( data[ 0 ] );

                Seed( new RSVPair( data[ 0 ], data[ 1 ] ) );
            }
        }

        /// <summary>
        /// Add RSV mappings from a string to the collection
        /// </summary>
        /// <remarks>
        /// These must be delimited by a unix newline (\n) and not a windows newline (\r\n).
        /// </remarks>
        /// <param name="data">The data to parse.</param>
        public void ParseData( string data )
        {
            var lines = data.Split( '\n' );

            ParseLines( lines );
        }

        /// <summary>
        /// Attempt to find a value for it's rsv key
        /// </summary>
        /// <param name="key">The key name (from the sheet itself)</param>
        /// <returns>The resolved value otherwise null if it wasn't found</returns>
        public string? GetValue( string key )
        {
            if( !_rsvEntries.TryGetValue( key, out var value ) )
            {
                return null;
            }

            return value;
        }
    }
}