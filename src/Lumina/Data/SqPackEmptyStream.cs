using Lumina.Data.Structs.SqPack;
using Lumina.Misc;
using System.IO;
using System.IO.Compression;

namespace Lumina.Data;

public sealed class SqPackEmptyStream : SqPackStream
{
    public new SqPackFileEmptyHeader Header { get; }

    private byte[] Data { get; }

    public SqPackEmptyStream( MappedFile datFile, long offset, GameData gameData, ulong indexHash ) : base( datFile, offset )
    {
        Header = datFile.GetAt<SqPackFileEmptyHeader>( offset );

        Data = new byte[Header.Base.UncompressedFileSize];

        var compressed = DatFile.GetSpanAt<byte>( Offset + Header.Base.HeaderSize, checked((int)Header.CompressedFileSize) );

        if( !( gameData.Options.RsfResolver?.Invoke( indexHash, out var resolvedHeader ) ?? false ) )
        {
            gameData.Options.Logger?.Error( $"Failed to resolve RSF with {indexHash:X16} index hash." );

            using var stream = compressed.Stream;
            using var zlibStream = new ZLibStream( stream, CompressionMode.Decompress );
            zlibStream.ReadExactly( Data );
        }
        else
        {
            var patched = compressed.Span.ToArray();
            resolvedHeader.Span.CopyTo( patched );

            using var stream = new MemoryStream( patched, false );
            using var zlibStream = new ZLibStream( stream, CompressionMode.Decompress );
            zlibStream.ReadExactly( Data );
        }
    }

    private protected override BlockData? GetCurrentBlock() =>
        BlockIndex == 0 ? new BlockData( Data, Data.Length ) : null;

    private protected override (int BlockIndex, int BlockOffset) ResolveBlockPosition( long offset ) =>
        offset < Data.Length ? (0, checked((int)offset)) : (1, 0);
}
