using System;
using Lumina.Data.Structs;

namespace Lumina.Data
{
    public class FileResource
    {
        public IndexHashTableEntry HashTableEntry { get; private set; }

        public Category Category { get; private set; }

        public FileResource( Category category, IndexHashTableEntry hashTableEntry )
        {
            Category = category;
            HashTableEntry = hashTableEntry;
        }
    }
}