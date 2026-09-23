using DotNext.IO.MemoryMappedFiles;
using System;
using System.Buffers;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Runtime.InteropServices;
using System.Threading;

namespace Lumina.Misc;

public sealed unsafe partial class MappedFile : IDisposable
{
    public FileInfo File { get; }

    private MemoryMappedFile Map { get; }

    private MemoryMappedDirectAccessor Accessor { get; }

    private byte* Pointer => Accessor.Pointer;

    public long Size => Accessor.Size;

    public MappedFile( string path ) : this( new FileInfo( path ) )
    {
    }

    private int _references = 1;

    public MappedFile( FileInfo fileInfo )
    {
        File = fileInfo;

        Map = MemoryMappedFile.CreateFromFile( File.FullName, FileMode.Open, null, 0, MemoryMappedFileAccess.Read );

        Accessor = Map.CreateDirectAccessor( access: MemoryMappedFileAccess.Read );
    }

    /// <summary>
    /// Increments the reference count of this <see cref="MappedFile"/>. The <see cref="MappedFile"/> will not be disposed until all references are released.
    /// </summary>
    /// <exception cref="ObjectDisposedException">Thrown if the <see cref="MappedFile"/> has already been disposed.</exception>
    /// <remarks>
    /// Disposing and not ref-tracking the <see cref="MappedFile"/> can lead to memory corruption and segfaults.
    /// </remarks>
    public void AddReference()
    {
        if( Interlocked.Increment( ref _references ) <= 1 )
            throw new ObjectDisposedException( nameof( MappedFile ) );
    }

    /// <summary>
    /// Decrements the reference count of this <see cref="MappedFile"/>. If the reference count reaches zero, the <see cref="MappedFile"/> will be disposed.
    /// </summary>
    /// <remarks>
    /// Disposing and not ref-tracking the <see cref="MappedFile"/> can lead to memory corruption and segfaults.
    /// </remarks>
    public void Release()
    {
        if( Interlocked.Decrement( ref _references ) != 0 )
            return;

        Accessor.Dispose();
        Map.Dispose();
    }

    public Segment< T > GetSpanAt< T >( long byteOffset, int length ) where T : unmanaged
    {
        ArgumentOutOfRangeException.ThrowIfNegative( byteOffset );
        ArgumentOutOfRangeException.ThrowIfGreaterThan( byteOffset + ( length * sizeof( T ) ), Size );
        return new( this, byteOffset, length );
    }

    public Segment< T > GetByteSpanAt< T >( long byteOffset, long byteSize ) where T : unmanaged
    {
        return GetSpanAt< T >( byteOffset, checked( (int)( byteSize / sizeof( T ) ) ) );
    }

    public ref readonly T GetAt< T >( long byteOffset ) where T : unmanaged
    {
        return ref MemoryMarshal.GetReference( GetSpanAt< T >( byteOffset, 1 ).Span );
    }

    public void Prefetch( long offset, long size )
    {
        if( OperatingSystem.IsWindows() )
        {
            var entries = stackalloc MemoryRangeEntry[1];
            entries[ 0 ] = new MemoryRangeEntry { VirtualAddress = Pointer + offset, NumberOfBytes = (nuint)size };
            if( !PrefetchVirtualMemory( Process.GetCurrentProcess().Handle, 1, entries, 0 ) )
                throw new Win32Exception();
        }
        else
        {
            // page-align the base; madvise refuses an unaligned address
            var pageSize = (long)Environment.SystemPageSize;
            var alignedOffset = offset / pageSize * pageSize;
            MAdvise( Pointer + alignedOffset, (nuint)( size + ( offset - alignedOffset ) ), MADV_WILLNEED );
        }
    }

    private const int MADV_WILLNEED = 3;

    [LibraryImport( "libc", EntryPoint = "madvise", SetLastError = true )]
    private static unsafe partial int MAdvise( void* address, nuint length, int advice );

    [StructLayout( LayoutKind.Sequential )]
    private struct MemoryRangeEntry
    {
        public void* VirtualAddress;
        public nuint NumberOfBytes;
    }

    [LibraryImport( "kernel32.dll", SetLastError = true )]
    [return: MarshalAs( UnmanagedType.Bool )]
    private static unsafe partial bool PrefetchVirtualMemory(
        IntPtr hProcess,
        UIntPtr numberOfEntries,
        MemoryRangeEntry* memoryRanges,
        uint flags );

    public void Dispose() => Release();

    public readonly record struct Segment< T >( MappedFile File, long ByteOffset, int Length ) where T : unmanaged
    {
        public int ByteLength => Length * sizeof( T );

        public ReadOnlySpan< T > Span =>
            new( File.Pointer + ByteOffset, Length );

        public ReadOnlyMemory< T > Memory =>
            new SegmentMemoryManager< T >( File, ByteOffset, Length ).Memory;

        public UnmanagedMemoryStream Stream =>
            new( File.Pointer + ByteOffset, ByteLength );

        public static implicit operator ReadOnlySpan< T >( Segment< T > segment )
        {
            return segment.Span;
        }
    }

    // keeps the mapping alive for as long as the Memory is reachable
    private sealed class SegmentMemoryManager< T >( MappedFile file, long byteOffset, int length )
        : MemoryManager< T > where T : unmanaged
    {
        public override Span< T > GetSpan() => new( file.Pointer + byteOffset, length );

        public override MemoryHandle Pin( int elementIndex = 0 ) =>
            new( file.Pointer + byteOffset + elementIndex * sizeof( T ), default, this );

        public override void Unpin()
        {
        }

        protected override void Dispose( bool disposing )
        {
        }
    }
}
