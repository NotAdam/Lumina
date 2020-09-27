namespace Lumina.Data.Files
{
    public class HwcFile : FileResource
    {
        // Hardware Cursors have a fixed size
        public const int Width = 64;
        public const int Height = 64;
        
        public override void LoadFile()
        {
            // Format should be in ABGR (or possibly ARGB?)
            Data = Reader.ReadBytes( Width * Height * 4 );
        }
    }
}
