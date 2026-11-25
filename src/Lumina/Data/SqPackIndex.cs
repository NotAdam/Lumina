using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Lumina.Data.Structs;

namespace Lumina.Data
{
    public class SqPackIndex : SqPack
    {
        // sorted by hash, so these are binary searched instead of building a dictionary on init
        private IndexHashTableEntry[]? _entries;
        private Index2HashTableEntry[]? _entries2;

        // only built when accessed/used, then used for lookups after that
        // todo: likely not super useful for most people, but provides the same semantics as before. probably should deleto tho
        private Dictionary< ulong, IndexHashTableEntry >? _hashTableEntries;
        private Dictionary< uint, Index2HashTableEntry >? _hashTableEntries2;

        public bool IsIndex2 { get; set; }

        public SqPackIndexHeader IndexHeader { get; private set; }

        public Dictionary< ulong, IndexHashTableEntry > HashTableEntries
        {
            get
            {
                if( _hashTableEntries == null && _entries is { } entries )
                {
                    Interlocked.CompareExchange( ref _hashTableEntries, ToDictionary< IndexHashTableEntry, ulong >( entries ), null );
                }

                return _hashTableEntries!;
            }
            set
            {
                _hashTableEntries = value;
                _entries = null;
            }
        }

        public Dictionary< uint, Index2HashTableEntry > HashTableEntries2
        {
            get
            {
                if( _hashTableEntries2 == null && _entries2 is { } entries )
                {
                    Interlocked.CompareExchange( ref _hashTableEntries2, ToDictionary< Index2HashTableEntry, uint >( entries ), null );
                }

                return _hashTableEntries2!;
            }
            set
            {
                _hashTableEntries2 = value;
                _entries2 = null;
            }
        }

        internal SqPackIndex( FileInfo indexFile, GameData gameData ) : base( indexFile, gameData )
        {
            IsIndex2 = indexFile.Extension == ".index2";

            try
            {
                if( IsIndex2 )
                {
                    _entries2 = LoadEntries< Index2HashTableEntry, uint >();
                }
                else
                {
                    _entries = LoadEntries< IndexHashTableEntry, ulong >();
                }
            }
            finally
            {
                // everything we need is in memory now, no reason to keep the file open
                CloseHandle();
            }
        }

        internal bool TryGetEntry( ulong hash, out IndexHashTableEntry entry ) =>
            _hashTableEntries is { } dict
                ? dict.TryGetValue( hash, out entry )
                : TryFind( _entries, hash, out entry );

        internal bool TryGetEntry( uint hash, out Index2HashTableEntry entry ) =>
            _hashTableEntries2 is { } dict
                ? dict.TryGetValue( hash, out entry )
                : TryFind( _entries2, hash, out entry );

        private T[] LoadEntries< T, THash >()
            where T : unmanaged, IHashTableEntry< THash >
            where THash : struct, IBinaryInteger< THash >
        {
            using var fs = OpenSharedStream();
            using var br = new LuminaBinaryReader( fs, SqPackHeader.platformId );

            // skip og header
            fs.Position = SqPackHeader.size;

            // read index hdr
            IndexHeader = br.ReadStructure< SqPackIndexHeader >();

            // read hashtable entries
            var entries = GC.AllocateUninitializedArray< T >( (int)( IndexHeader.index_data_size / Unsafe.SizeOf< T >() ) );
            fs.Position = IndexHeader.index_data_offset;
            fs.ReadExactly( MemoryMarshal.AsBytes( entries.AsSpan() ) );

            var convertEndianness = br.ConvertEndianness;
            var isPs3 = SqPackHeader.platformId == PlatformId.PS3;
            if( convertEndianness || isPs3 )
            {
                for( var i = 0; i < entries.Length; i++ )
                {
                    ref var entry = ref entries[ i ];
                    if( convertEndianness )
                        entry.ReverseEndianness();
                    if( isPs3 )
                        entry.Data = ConvertPs3Data( entry.Data );
                }
            }

            // retail index are sorted, but given we depend on this and i dont trust TT we validate this anyway
            // dupe hashes resolve back to the same entry as the dict (first entry)
            for( var i = 1; i < entries.Length; i++ )
            {
                if( entries[ i - 1 ].Hash > entries[ i ].Hash )
                {
                    return entries.OrderBy( static e => e.Hash ).ToArray();
                }
            }

            return entries;
        }

        private static Dictionary< THash, T > ToDictionary< T, THash >( T[] entries )
            where T : unmanaged, IHashTableEntry< THash >
            where THash : struct, IBinaryInteger< THash >
        {
            var dict = new Dictionary< THash, T >( entries.Length );
            foreach( var entry in entries )
            {
                dict.TryAdd( entry.Hash, entry );
            }

            return dict;
        }

        // find first entry for the hash
        // same as the old dict lookup where the first wins for dupes
        private static bool TryFind< T, THash >( T[]? entries, THash hash, out T entry )
            where T : unmanaged, IHashTableEntry< THash >
            where THash : struct, IBinaryInteger< THash >
        {
            if( entries != null )
            {
                var lo = 0;
                var hi = entries.Length;
                while( lo < hi )
                {
                    var mid = lo + ( ( hi - lo ) >> 1 );
                    if( entries[ mid ].Hash < hash )
                        lo = mid + 1;
                    else
                        hi = mid;
                }

                if( lo < entries.Length && entries[ lo ].Hash == hash )
                {
                    entry = entries[ lo ];
                    return true;
                }
            }

            entry = default;
            return false;
        }

        private static uint ConvertPs3Data( uint data )
        {
            return ( data << 4 ) | ( ( data & 0x70000000 ) >> 27 ) | ( ( data & 0x80000000 ) >> 31 );
        }
    }
}
