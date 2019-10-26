namespace Lumina.Data
{
    public class Dat
    {
        public int Category { get; }

        public int Expansion { get; }
        
        public int Chunk { get; }
        
        public DatPlatform Platform { get; }

        public Index Index { get; }
        
        public Dat( int cat, int ex, int chunk, DatPlatform platform, Index index )
        {
            Category = cat;
            Expansion = ex;
            Chunk = chunk;
            Platform = platform;
            Index = index;
        }
    }
}