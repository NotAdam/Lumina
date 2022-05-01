using System;
using System.Collections.Generic;
using System.Linq;

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
        /// <summary>
        /// Construct an empty <see cref="RsvProvider"/>. Will need to be seeded with data before this does anything.
        /// </summary>
        public RsvProvider()
        {
            _rsvEntries = new();
        }

        private readonly Dictionary< string, string > _rsvEntries;

        /// <summary>
        /// Returns true if there's any RSV values present, otherwise false.
        /// </summary>
        public bool HasValues => _rsvEntries.Any();

        /// <summary>
        /// Add a RSV mapping to the collection
        /// </summary>
        /// <param name="rsvEntry">The RSV key and value</param>
        [Obsolete( "use RsvProvider.Add instead" )]
        public void Seed( RSVPair rsvEntry )
        {
            _rsvEntries[ rsvEntry.Key ] = rsvEntry.Value;
        }

        /// <summary>
        /// Add a RSV mapping to the collection
        /// </summary>
        /// <param name="rsvEntry">The RSV key and value</param>
        public void Add( RSVPair rsvEntry )
        {
            _rsvEntries[ rsvEntry.Key ] = rsvEntry.Value;
        }

        /// <summary>
        /// Add a RSV mapping to the collection
        /// </summary>
        /// <param name="key">The RSV key</param>
        /// <param name="value">The RSV value (the original string)</param>
        public void Add( string key, string value )
        {
            _rsvEntries[ key ] = value;
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
                if( rsvKey == null )
                {
                    // todo: log error about invalid key
                    continue;
                }

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