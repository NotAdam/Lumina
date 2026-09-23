using Lumina.Data.Structs.SqPack;
using Lumina.Misc;
using System;
using System.IO;
using System.IO.Compression;
using System.Threading;

namespace Lumina.Data;

public abstract class SqPackStream : Stream
{
    public MappedFile DatFile { get; }

    public long Offset { get; }

    public SqPackFileHeader Header { get; }

    public override bool CanRead => true;
    public override bool CanSeek => true;
    public override bool CanWrite => false;
    public override long Length => Header.UncompressedFileSize;

    private protected readonly bool BigEndian;

    protected internal SqPackStream( MappedFile datFile, long offset, bool bigEndian = false )
    {
        datFile.AddReference();
        DatFile = datFile;
        Offset = offset;
        BigEndian = bigEndian;
        Header = bigEndian
            ? datFile.GetAt< SqPackFileHeader >( offset ).ReverseEndianness()
            : datFile.GetAt< SqPackFileHeader >( offset );
    }

    private int _disposed;

    protected override void Dispose( bool disposing )
    {
        if( Interlocked.Exchange( ref _disposed, 1 ) == 0 )
            DatFile.Release();

        base.Dispose( disposing );
    }

    protected (MappedFile.Segment< byte > Data, int? DecompressedSize) GetBlockInfo( long offset )
    {
        var blockOffset = Offset + Header.HeaderSize + offset;
        var blockHeader = DatFile.GetAt< SqPackBlockHeader >( blockOffset );
        if( BigEndian )
            blockHeader = blockHeader.ReverseEndianness();
        if( blockHeader.DataSize == 0 )
            throw new InvalidOperationException( "Empty block" );

        var dataOffset = blockOffset + blockHeader.HeaderSize;
        if( blockHeader.CompressedSize == 32000 ) // Uncompressed
            return ( DatFile.GetSpanAt< byte >( dataOffset, checked( (int)blockHeader.DataSize ) ), null );
        else
            return ( DatFile.GetSpanAt< byte >( dataOffset, checked( (int)blockHeader.CompressedSize ) ),
                checked( (int)blockHeader.DataSize ) );
    }

    protected readonly record struct BlockData( byte[]? RawData, int RawLength, MappedFile.Segment< byte >? FileData )
    {
        public BlockData( byte[] rawData, int length ) : this( rawData, length, null )
        {
        }

        public BlockData( MappedFile.Segment< byte > fileData ) : this( null, 0, fileData )
        {
        }

        public ReadOnlySpan< byte > Span =>
            RawData == null ? FileData!.Value.Span : RawData.AsSpan( 0, RawLength );
    }

    // only one decompressed block is live at a time, so the whole file reuses a single buffer
    // rather than allocating one byte[] per 16KB block
    private byte[]? blockBuffer;

    protected BlockData GetBlock( long offset )
    {
        ( var data, int? uncompSize ) = GetBlockInfo( offset );
        if( uncompSize is not { } length )
            return new( data );

        // grow to the largest block seen
        if( blockBuffer is null || blockBuffer.Length < length )
            blockBuffer =
                GC.AllocateUninitializedArray< byte >( Math.Max( length,
                    blockBuffer is null ? 0 : blockBuffer.Length * 2 ) );

        using UnmanagedMemoryStream stream = data.Stream;
        using DeflateStream zlibStream = new( stream, CompressionMode.Decompress );
        zlibStream.ReadExactly( blockBuffer.AsSpan( 0, length ) );

        return new( blockBuffer, length );
    }

    private protected long BytePosition { get; set; }
    private protected int BlockIndex { get; set; }
    private protected int BlockOffset { get; set; }
    private protected BlockData? BlockInfo { get; set; }

    private protected abstract BlockData? GetCurrentBlock();

    /// <summary>
    /// Restores the cursor position of a <see cref="SqPackStream"/> to its state when the <see cref="CursorScope"/> was created.
    /// This is useful for temporarily seeking to inspect a block without affecting the caller's current read position.
    /// </summary>
    /// <param name="stream">The <see cref="SqPackStream"/> instance whose cursor position will be restored.</param>
    private protected readonly ref struct CursorScope( SqPackStream stream )
    {
        private readonly long position = stream.BytePosition;
        private readonly int index = stream.BlockIndex;
        private readonly int offset = stream.BlockOffset;
        private readonly BlockData? info = stream.BlockInfo;

        public void Dispose()
        {
            stream.BytePosition = position;
            stream.BlockIndex = index;
            stream.BlockOffset = offset;
            stream.BlockInfo = info;
        }
    }

    /// <summary>
    /// Attempts to retrieve a mapped memory segment from the <see cref="SqPackStream"/> for the specified offset and length.
    /// </summary>
    /// <param name="offset">The offset within the stream from which to start reading.</param>
    /// <param name="length">The number of bytes to read from the specified offset.</param>
    /// <returns>A <see cref="ReadOnlyMemory{byte}"/> representing the mapped memory segment if the range lies within a single uncompressed block; otherwise, returns <see langword="null"/>.</returns>
    public virtual ReadOnlyMemory< byte >? TryGetMappedMemory( long offset, int length )
    {
        using var cursor = new CursorScope( this );

        Seek( offset, SeekOrigin.Begin );
        if( GetCurrentBlock() is not { FileData: { } mapped } )
            return null;
        if( BlockOffset + length > mapped.Length )
            return null;

        return mapped.Memory.Slice( BlockOffset, length );
    }

    private protected abstract (int BlockIndex, int BlockOffset) ResolveBlockPosition( long offset );

    public override long Position {
        get => BytePosition;
        set => Seek( value, SeekOrigin.Begin );
    }

    public override int Read( byte[] buffer, int offset, int count ) =>
        Read( buffer.AsSpan( offset, count ) );

    public override int Read( Span< byte > buffer )
    {
        var total = buffer.Length;
        while( !buffer.IsEmpty )
        {
            if( GetCurrentBlock() is not { } blockData )
                break;
            var data = blockData.Span;
            var toCopy = Math.Min( data.Length - BlockOffset, buffer.Length );
            data.Slice( BlockOffset, toCopy ).CopyTo( buffer );
            buffer = buffer[ toCopy.. ];

            BlockOffset += toCopy;
            BytePosition += toCopy;
            if( BlockOffset >= data.Length )
            {
                BlockIndex++;
                BlockOffset = 0;
                BlockInfo = null;
            }
        }

        return total - buffer.Length;
    }

    public override long Seek( long offset, SeekOrigin origin )
    {
        offset = origin switch
        {
            SeekOrigin.Begin => offset,
            SeekOrigin.Current => BytePosition + offset,
            SeekOrigin.End => Length + offset,
            _ => throw new ArgumentOutOfRangeException( nameof( origin ) )
        };

        ( var idx, BlockOffset ) = ResolveBlockPosition( offset );
        if( idx != BlockIndex )
        {
            BlockIndex = idx;
            BlockInfo = null;
        }

        return BytePosition = offset;
    }

    public override void Flush()
    {
        throw new NotSupportedException();
    }

    public override void SetLength( long value )
    {
        throw new NotSupportedException();
    }

    public override void Write( byte[] buffer, int offset, int count )
    {
        throw new NotSupportedException();
    }

    public static SqPackStream Create( MappedFile datFile, long offset, GameData gameData,
        in HashedFilePath hashedPath )
    {
        var bigEndian = gameData.Options.CurrentPlatform == PlatformType.PS3;
        var header = datFile.GetAt< SqPackFileHeader >( offset );
        if( bigEndian )
            header = header.ReverseEndianness();

        return header.Type switch
        {
            SqPackFileType.Empty => new SqPackEmptyStream( datFile, offset, gameData, hashedPath.OldHash ),
            SqPackFileType.Standard => new SqPackStandardStream( datFile, offset, bigEndian ),
            SqPackFileType.Model => new SqPackModelStream( datFile, offset ),
            SqPackFileType.Texture => new SqPackTextureStream( datFile, offset ),
            _ => throw new InvalidDataException( "Invalid header type" )
        };
    }
}
