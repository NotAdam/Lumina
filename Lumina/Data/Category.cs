using System;
using System.Linq;

namespace Lumina.Data
{
    public class Category
    {
        public int CategoryId { get; }

        public int Expansion { get; }

        public int Chunk { get; }

        public Structs.PlatformId Platform { get; }

        public SqPackIndex SqPackIndex { get; }

        public Category( int category, int expansion, int chunk, Structs.PlatformId platform, SqPackIndex sqPackIndex )
        {
            CategoryId = category;
            Expansion = expansion;
            Chunk = chunk;
            Platform = platform;
            SqPackIndex = sqPackIndex;
        }

        public FileResource GetFile( UInt64 hash )
        {
            var status = SqPackIndex.HashTableEntries.TryGetValue( hash, out var hashTableEntry );

            if( !status )
            {
                return null;
            }
            
            return new FileResource( this, hashTableEntry );
        }
    }
}