using System;
using System.Buffers;
using System.IO;
using Microsoft.Win32.SafeHandles;

namespace Lumina.Data;

/// <summary>A buffered, read-only stream over a file handle that is shared between many readers.</summary>
/// <remarks>
/// Reads are positional (<see cref="RandomAccess"/>), so any number of instances can use the same handle concurrently.
/// Disposing the stream does not close the handle; the owner of the handle is responsible for that.
/// </remarks>
internal sealed class SharedHandleStream : Stream
{
    private const int BufferSize = 4096;

    private readonly SafeFileHandle _handle;
    private readonly long _length;

    private byte[]? _buffer;
    private long _bufferStart;
    private int _bufferLength;
    private long _position;
    private bool _disposed;

    public SharedHandleStream( SafeFileHandle handle, long length )
    {
        _handle = handle;
        _length = length;
    }

    public override bool CanRead => !_disposed && !_handle.IsClosed;
    public override bool CanSeek => true;
    public override bool CanWrite => false;
    public override long Length => _length;

    public override long Position
    {
        get => _position;
        set
        {
            ArgumentOutOfRangeException.ThrowIfNegative( value );
            _position = value;
        }
    }

    public override int Read( byte[] buffer, int offset, int count ) => Read( buffer.AsSpan( offset, count ) );

    public override int ReadByte()
    {
        Span< byte > b = stackalloc byte[1];
        return Read( b ) == 1 ? b[ 0 ] : -1;
    }

    public override int Read( Span< byte > destination )
    {
        var total = 0;
        while( !destination.IsEmpty && _position < _length )
        {
            // get from buf if the offset is inside the window
            var bufferOffset = _position - _bufferStart;
            if( _buffer is not null && bufferOffset >= 0 && bufferOffset < _bufferLength )
            {
                var n = Math.Min( _bufferLength - (int)bufferOffset, destination.Length );
                _buffer.AsSpan( (int)bufferOffset, n ).CopyTo( destination );
                destination = destination[ n.. ];
                _position += n;
                total += n;
                continue;
            }

            // large reads skip the buffer and read directly
            if( destination.Length >= BufferSize )
            {
                var n = RandomAccess.Read( _handle, destination, _position );
                if( n == 0 )
                    break;
                destination = destination[ n.. ];
                _position += n;
                total += n;
                continue;
            }

            _buffer ??= ArrayPool< byte >.Shared.Rent( BufferSize );
            _bufferStart = _position;
            _bufferLength = RandomAccess.Read( _handle, _buffer.AsSpan( 0, BufferSize ), _position );
            if( _bufferLength == 0 )
                break;
        }

        return total;
    }

    public override long Seek( long offset, SeekOrigin origin )
    {
        Position = origin switch
        {
            SeekOrigin.Begin => offset,
            SeekOrigin.Current => _position + offset,
            SeekOrigin.End => _length + offset,
            _ => throw new ArgumentOutOfRangeException( nameof( origin ) ),
        };
        return _position;
    }

    public override void Flush()
    {
    }

    public override void SetLength( long value ) => throw new NotSupportedException();

    public override void Write( byte[] buffer, int offset, int count ) => throw new NotSupportedException();

    protected override void Dispose( bool disposing )
    {
        if( disposing && _buffer is { } buffer )
        {
            _buffer = null;
            _bufferLength = 0;
            ArrayPool< byte >.Shared.Return( buffer );
        }

        _disposed = true;

        base.Dispose( disposing );
    }
}
