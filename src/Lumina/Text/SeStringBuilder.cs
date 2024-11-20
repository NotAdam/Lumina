using System;
using System.Collections.Generic;
using System.IO;
using Lumina.Text.Payloads;
using Lumina.Text.ReadOnly;
using Microsoft.Extensions.ObjectPool;

namespace Lumina.Text;

/// <summary>A builder for <see cref="SeString"/>.</summary>
public sealed partial class SeStringBuilder : IResettable
{
    private readonly List< (StackType Type, int Ident, MemoryStream Stream) > _mss = [];
    private readonly List< MemoryStream > _mssFree = [];
    private readonly ObjectPool< MemoryStream >? _mssPool;

    private enum StackType
    {
        String,
        Payload,
        Expression,
    }

    /// <summary>Initializes a new instance of the <see cref="SeStringBuilder"/> class.</summary>
    public SeStringBuilder() => Clear();

    /// <summary>Initializes a new instance of the <see cref="SeStringBuilder"/> class.</summary>
    /// <param name="memoryStreamPool">Shared memory stream pool to use.</param>
    public SeStringBuilder( ObjectPool< MemoryStream >? memoryStreamPool )
    {
        _mssPool = memoryStreamPool;
        Clear();
    }

    /// <summary>Gets the shared instance of object pool for <see cref="SeStringBuilder"/>.</summary>
    public static ObjectPool< SeStringBuilder > SharedPool { get; } = ObjectPool.Create( new PooledObjectPolicy() );

    /// <summary>Begins a macro.</summary>
    /// <param name="macroCode">The macro code.</param>
    /// <returns>A reference of this instance after the operation is completed.</returns>
    public SeStringBuilder BeginMacro( MacroCode macroCode )
    {
        if( !Enum.IsDefined( macroCode ) )
            throw new ArgumentOutOfRangeException( nameof( macroCode ), macroCode, "Invalid macro code specified." );
        if( _mss[ ^1 ].Type != StackType.String )
            throw new InvalidOperationException( "A payload can be added only in the context of SeString." );

        PushMemoryStreamStack( StackType.Payload, (byte) macroCode );
        return this;
    }

    /// <summary>Ends a macro.</summary>
    /// <returns>A reference of this instance after the operation is completed.</returns>
    public SeStringBuilder EndMacro()
    {
        if( _mss[ ^1 ].Type != StackType.Payload )
            throw new InvalidOperationException( "No payload is currently being built." );

        var span = PopMemoryStreamStack(out var ident);
        Append( new ReadOnlySePayloadSpan( ReadOnlySePayloadType.Macro, (MacroCode) ident, span ) );
        return this;
    }

    /// <summary>Aborts a macro build by discarding the current macro data and exiting the macro scope.</summary>
    /// <returns>A reference of this instance after the operation is completed.</returns>
    public SeStringBuilder AbortMacro()
    {
        if( _mss[ ^1 ].Type != StackType.Payload )
            throw new InvalidOperationException( "No payload is currently being built." );

        PopMemoryStreamStack( out _ );
        return this;
    }

    /// <summary>Clears everything.</summary>
    /// <param name="zeroBuffer">Whether to fill the underlying buffer with zeroes.</param>
    /// <returns>A reference of this instance after the clear operation is completed.</returns>
    public SeStringBuilder Clear( bool zeroBuffer = false )
    {
        while( _mss.Count > 0 )
            PopMemoryStreamStack( out _ );

        if( zeroBuffer )
        {
            foreach( var mss in _mssFree )
                mss.GetBuffer().AsSpan().Clear();
        }

        foreach( var mss in _mssFree )
            _mssPool?.Return( mss );
        _mssFree.Clear();

        PushMemoryStreamStack( StackType.String, 0 );
        return this;
    }

    /// <summary>Gets the view of SeString being built.</summary>
    /// <returns>View of the SeString being built.</returns>
    /// <remarks>
    /// <p>Returned view is invalidated upon any mutation to this builder, including <see cref="Clear"/> and <see cref="Append(string)"/>. If
    /// <see cref="SharedPool"/> is being used, then returning to the pool also will invalidate the returned view.</p>
    /// <p>After the last element (right after the end of the returned memory/span), <c>NUL</c> is present. You can pin the returned value and use the pointer
    /// to the first element as a pointer to null-terminated string.</p>
    /// </remarks>
    public ReadOnlyMemory< byte > GetViewAsMemory()
    {
        if( _mss.Count != 1 )
            throw new InvalidOperationException( "The string is incomplete, due to non-empty stack." );

        var stream = _mss[ 0 ].Stream;

        // Force null termination.
        stream.Capacity = Math.Max( stream.Capacity, (int) stream.Length + 1 );
        stream.GetBuffer()[ stream.Length ] = 0;

        return stream.GetBuffer().AsMemory( 0, (int) stream.Length );
    }

    /// <inheritdoc cref="GetViewAsMemory"/>
    public ReadOnlySpan< byte > GetViewAsSpan() => GetViewAsMemory().Span;

    /// <summary>Gets the SeString as a new byte array.</summary>
    /// <returns>A new byte array.</returns>
    /// <remarks>If the created value does not escape the code scope this function is being called, consider using <see cref="GetViewAsMemory"/> or
    /// <see cref="GetViewAsSpan"/>.</remarks>
    public byte[] ToArray() => GetViewAsMemory().ToArray();

    /// <summary>Gets the SeString as a new instance of <see cref="SeString"/>.</summary>
    /// <returns>A new instance of <see cref="SeString"/>.</returns>
    /// <remarks>If the created value does not escape the code scope this function is being called, consider using <see cref="GetViewAsMemory"/> or
    /// <see cref="GetViewAsSpan"/>.</remarks>
    public SeString ToSeString() => new( ToArray() );

    /// <summary>Gets the SeString as a new instance of <see cref="ReadOnlySeString"/>.</summary>
    /// <returns>A new instance of <see cref="ReadOnlySeString"/>.</returns>
    /// <remarks>If the created value does not escape the code scope this function is being called, consider using <see cref="GetViewAsMemory"/> or
    /// <see cref="GetViewAsSpan"/>.</remarks>
    public ReadOnlySeString ToReadOnlySeString() => ToArray();

    /// <inheritdoc/>
    public bool TryReset()
    {
        Clear();
        return true;
    }

    private void PushMemoryStreamStack(StackType stackType, int ident)
    {
        if (_mssFree.Count is > 0)
        {
            _mss.Add( ( stackType, ident, _mssFree[ ^1 ] ) );
            _mssFree.RemoveAt( _mssFree.Count - 1 );
            return;
        }

        if( _mssPool is not null )
        {
            _mss.Add( ( stackType, ident, _mssPool.Get() ) );
            return;
        }

        _mss.Add( ( stackType, ident, new() ) );
    }

    private Span< byte > PopMemoryStreamStack(out int ident)
    {
        var stream = _mss[ ^1 ].Stream;
        ident = _mss[ ^1 ].Ident;
        _mss.RemoveAt( _mss.Count - 1 );
        var span = stream.GetBuffer().AsSpan( 0, (int) stream.Length );
        stream.SetLength( stream.Position = 0 );
        _mssFree.Add( stream );
        return span;
    }

    /// <summary>Reallocates a byte span from the result of <see cref="GetStringStream"/>.</summary>
    /// <param name="oldLength">Previously allocated span size from <see cref="AllocateStringSpan"/> or <see cref="ReallocateStringSpan"/>.</param>
    /// <param name="length">Number of bytes to allocate.</param>
    /// <returns>The allocated byte span.</returns>
    private Span< byte > ReallocateStringSpan( int oldLength, int length )
    {
        var stream = GetStringStream();
        var offset = unchecked( (int) stream.Position - oldLength );
        stream.SetLength( stream.Position = offset + length );
        return stream.GetBuffer().AsSpan( offset, length );
    }

    /// <summary>Allocates a byte span from the result of <see cref="GetStringStream"/>.</summary>
    /// <param name="length">Number of bytes to allocate.</param>
    /// <returns>The allocated byte span.</returns>
    private Span< byte > AllocateStringSpan( int length )
    {
        var stream = GetStringStream();
        var offset = unchecked( (int) stream.Position );
        stream.SetLength( stream.Position = offset + length );
        return stream.GetBuffer().AsSpan( offset, length );
    }

    /// <summary>Allocates a byte span from the result of <see cref="GetStringStream"/>.</summary>
    /// <param name="length">Number of bytes to allocate.</param>
    /// <returns>The allocated byte span.</returns>
    private Span< byte > AllocateExpressionSpan( int length )
    {
        var stream = GetExpressionStream();
        var offset = unchecked( (int) stream.Position );
        stream.SetLength( stream.Position = offset + length );
        return stream.GetBuffer().AsSpan( offset, length );
    }

    /// <summary>Ensures that the current stack top is a string.</summary>
    /// <returns>The string stream.</returns>
    private MemoryStream GetStringStream()
    {
        if( _mss[ ^1 ].Type != StackType.String )
            throw new InvalidOperationException( "Strings may not be appended in current state." );
        return _mss[ ^1 ].Stream;
    }

    /// <summary>Ensures that the current stack top is an expression or payload.</summary>
    /// <returns>The string stream.</returns>
    private MemoryStream GetExpressionStream()
    {
        if( _mss[ ^1 ].Type is not StackType.Payload and not StackType.Expression )
            throw new InvalidOperationException( "Expressions may not be appended in current state." );
        if( _mss[ ^1 ].Type is StackType.Expression && _mss[ ^1 ].Ident <= 0 )
            throw new InvalidOperationException( $"No more expressions may be written. Call {nameof( EndExpression )}." );
        return _mss[ ^1 ].Stream;
    }

    private void OneExpressionWritten()
    {
        if( _mss[ ^1 ].Type is StackType.Expression )
            _mss[ ^1 ] = _mss[ ^1 ] with { Ident = _mss[ ^1 ].Ident - 1 };
    }

    /// <summary>Pooled object policy for <see cref="SeStringBuilder"/>.</summary>
    public sealed class PooledObjectPolicy : PooledObjectPolicy< SeStringBuilder >
    {
        private readonly ObjectPool< MemoryStream > _memoryStreamPool;

        /// <summary>Initializes a new instance of the <see cref="PooledObjectPolicy"/> class.</summary>
        public PooledObjectPolicy() => _memoryStreamPool = ObjectPool.Create( new MemoryStreamPolicy() );

        /// <summary>Initializes a new instance of the <see cref="PooledObjectPolicy"/> class.</summary>
        /// <param name="memoryStreamPooledObjectPolicy">Memory stream pool policy to use.</param>
        public PooledObjectPolicy( PooledObjectPolicy< MemoryStream > memoryStreamPooledObjectPolicy ) =>
            _memoryStreamPool = ObjectPool.Create(
                memoryStreamPooledObjectPolicy ?? throw new ArgumentNullException( nameof( memoryStreamPooledObjectPolicy ) ) );

        /// <summary>Initializes a new instance of the <see cref="PooledObjectPolicy"/> class.</summary>
        /// <param name="memoryStreamPool">Memory stream pool to use.</param>
        public PooledObjectPolicy( ObjectPool< MemoryStream > memoryStreamPool ) =>
            _memoryStreamPool = memoryStreamPool ?? throw new ArgumentNullException( nameof( memoryStreamPool ) );

        /// <inheritdoc/>
        public override SeStringBuilder Create() => new(_memoryStreamPool);

        /// <inheritdoc/>
        public override bool Return( SeStringBuilder obj ) => obj.TryReset();

        private sealed class MemoryStreamPolicy : PooledObjectPolicy< MemoryStream >
        {
            public int MemoryStreamCapacity { get; set; } = 4096;

            public override MemoryStream Create() => new( MemoryStreamCapacity );

            public override bool Return( MemoryStream obj )
            {
                if( obj.Capacity > MemoryStreamCapacity )
                    return false;

                obj.SetLength( obj.Position = 0 );
                return true;
            }
        }
    }
}