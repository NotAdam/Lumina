using System;
using System.Buffers;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using Lumina.Misc;
using Lumina.Text.ReadOnly;

namespace Lumina.Text;

public sealed partial class SeStringBuilder
{
    /// <summary>Interpolation handler for <see cref="SeStringBuilder"/>.</summary>
    [InterpolatedStringHandler]
    public readonly ref struct SeStringInterpolatedStringHandler
    {
        private readonly IFormatProvider? _provider;

        /// <summary>Initializes a new instance of the <see cref="SeStringInterpolatedStringHandler"/> struct.</summary>
        /// <param name="literalLength">Number of characters in the literal.</param>
        /// <param name="formattedCount">Number of formatted entries.</param>
        [MethodImpl( MethodImplOptions.AggressiveInlining )]
        [SuppressMessage( "ReSharper", "IntroduceOptionalParameters.Global", Justification = "InterpolatedStringHandlerArgument" )]
        public SeStringInterpolatedStringHandler( int literalLength, int formattedCount )
            : this( literalLength, formattedCount, SharedPool.Get(), null )
        { }

        /// <summary>Initializes a new instance of the <see cref="SeStringInterpolatedStringHandler"/> struct.</summary>
        /// <param name="literalLength">Number of characters in the literal.</param>
        /// <param name="formattedCount">Number of formatted entries.</param>
        /// <param name="provider">Format provider.</param>
        [MethodImpl( MethodImplOptions.AggressiveInlining )]
        [SuppressMessage( "ReSharper", "IntroduceOptionalParameters.Global", Justification = "InterpolatedStringHandlerArgument" )]
        public SeStringInterpolatedStringHandler( int literalLength, int formattedCount, IFormatProvider? provider )
            : this( literalLength, formattedCount, SharedPool.Get(), provider )
        { }

        /// <summary>Initializes a new instance of the <see cref="SeStringInterpolatedStringHandler"/> struct.</summary>
        /// <param name="literalLength">Number of characters in the literal.</param>
        /// <param name="formattedCount">Number of formatted entries.</param>
        /// <param name="builder">Instance of <see cref="SeStringBuilder"/> to append to.</param>
        [MethodImpl( MethodImplOptions.AggressiveInlining )]
        [SuppressMessage( "ReSharper", "IntroduceOptionalParameters.Global", Justification = "InterpolatedStringHandlerArgument" )]
        public SeStringInterpolatedStringHandler( int literalLength, int formattedCount, SeStringBuilder builder )
            : this( literalLength, formattedCount, builder, null )
        { }

        /// <summary>Initializes a new instance of the <see cref="SeStringInterpolatedStringHandler"/> struct.</summary>
        /// <param name="literalLength">Number of characters in the literal.</param>
        /// <param name="formattedCount">Number of formatted entries.</param>
        /// <param name="builder">Instance of <see cref="SeStringBuilder"/> to append to.</param>
        /// <param name="provider">Format provider.</param>
        [MethodImpl( MethodImplOptions.AggressiveInlining )]
        public SeStringInterpolatedStringHandler( int literalLength, int formattedCount, SeStringBuilder builder, IFormatProvider? provider )
        {
            Builder = builder;
            _provider = provider;
            _ = formattedCount;

            builder.ReallocateStringSpan( builder.AllocateStringSpan( literalLength * 4 ).Length, 0 );
        }

        /// <summary>Gets the instance of <see cref="SeStringBuilder"/> that this interpolator is writing to.</summary>
        public SeStringBuilder Builder { get; }

        /// <summary>Writes the specified string to the handler.</summary>
        /// <param name="value">The string to write.</param>
        public void AppendLiteral( string value ) => Builder.Append( value );

        /// <summary>Writes the specified value to the handler.</summary>
        /// <param name="value">The value to write.</param>
        /// <typeparam name="T">The type of the value to write.</typeparam>
        public void AppendFormatted< T >( T value ) => AppendFormatted( value, 0, null );

        /// <summary>Writes the specified value to the handler.</summary>
        /// <param name="value">The value to write.</param>
        /// <param name="format">The format string.</param>
        /// <typeparam name="T">The type of the value to write.</typeparam>
        public void AppendFormatted< T >( T value, string? format ) => AppendFormatted( value, 0, format );

        /// <summary>Writes the specified value to the handler.</summary>
        /// <param name="value">The value to write.</param>
        /// <param name="alignment">The minimum number of characters that should be written for this value. If the value is negative, it indicates left-aligned and the required minimum is the absolute value.</param>
        /// <typeparam name="T">The type of the value to write.</typeparam>
        public void AppendFormatted< T >( T value, int alignment ) => AppendFormatted( value, alignment, null );

        /// <summary>Writes the specified value to the handler.</summary>
        /// <param name="value">The value to write.</param>
        /// <param name="alignment">The minimum number of characters that should be written for this value. If the value is negative, it indicates left-aligned and the required minimum is the absolute value.</param>
        /// <param name="format">The format string.</param>
        /// <typeparam name="T">The type of the value to write.</typeparam>
        public void AppendFormatted< T >( T value, int alignment, string? format )
        {
            var prevLen = Builder.GetStringStream().Length;
            switch( value )
            {
                case string s:
                    AppendFormatted( s.AsSpan(), format );
                    break;

#if NET8_0_OR_GREATER
                case IUtf8SpanFormattable f:
                    AppendSpanFormattableUtf8( f, format );
                    break;
#endif

                case ISpanFormattable f:
                    AppendSpanFormattableUtf16( f, format );
                    break;

                case IFormattable f:
                    Builder.Append( f.ToString( format, _provider ) );
                    break;

                case null:
                    Builder.Append( "null"u8 );
                    break;

                default:
                    Builder.Append( value.ToString() );
                    break;
            }

            FixAlignment( prevLen, alignment );
        }

        /// <inheritdoc cref="AppendFormatted{T}(T)"/>
        public void AppendFormatted( bool value ) => AppendFormatted( value, 0, null );

        /// <inheritdoc cref="AppendFormatted{T}(T, string?)"/>
        public void AppendFormatted( bool value, string? format ) => AppendFormatted( value, 0, format );

        /// <inheritdoc cref="AppendFormatted{T}(T, int)"/>
        public void AppendFormatted( bool value, int alignment ) => AppendFormatted( value, alignment, null );

        /// <inheritdoc cref="AppendFormatted{T}(T, int, string?)"/>
        public void AppendFormatted( bool value, int alignment, string? format )
        {
            _ = format;
            var prevLen = Builder.GetStringStream().Length;
            Builder.Append( value ? "true"u8 : "false"u8 );
            FixAlignment( prevLen, alignment );
        }

        /// <inheritdoc cref="AppendFormatted{T}(T)"/>
        public void AppendFormatted( char value ) => AppendFormatted( value, 0, null );

        /// <inheritdoc cref="AppendFormatted{T}(T, string?)"/>
        public void AppendFormatted( char value, string? format ) => AppendFormatted( value, 0, format );

        /// <inheritdoc cref="AppendFormatted{T}(T, int)"/>
        public void AppendFormatted( char value, int alignment ) => AppendFormatted( value, alignment, null );

        /// <inheritdoc cref="AppendFormatted{T}(T, int, string?)"/>
        public void AppendFormatted( char value, int alignment, string? format )
        {
            var prevLen = Builder.GetStringStream().Length;
            AppendSpanFormattableAuto( value, format );
            FixAlignment( prevLen, alignment );
        }

        /// <inheritdoc cref="AppendFormatted{T}(T)"/>
        public void AppendFormatted( byte value ) => AppendFormatted( value, 0, null );

        /// <inheritdoc cref="AppendFormatted{T}(T, string?)"/>
        public void AppendFormatted( byte value, string? format ) => AppendFormatted( value, 0, format );

        /// <inheritdoc cref="AppendFormatted{T}(T, int)"/>
        public void AppendFormatted( byte value, int alignment ) => AppendFormatted( value, alignment, null );

        /// <inheritdoc cref="AppendFormatted{T}(T, int, string?)"/>
        public void AppendFormatted( byte value, int alignment, string? format )
        {
            var prevLen = Builder.GetStringStream().Length;
            AppendSpanFormattableAuto( value, format );
            FixAlignment( prevLen, alignment );
        }

        /// <inheritdoc cref="AppendFormatted{T}(T)"/>
        public void AppendFormatted( ushort value ) => AppendFormatted( value, 0, null );

        /// <inheritdoc cref="AppendFormatted{T}(T, string?)"/>
        public void AppendFormatted( ushort value, string? format ) => AppendFormatted( value, 0, format );

        /// <inheritdoc cref="AppendFormatted{T}(T, int)"/>
        public void AppendFormatted( ushort value, int alignment ) => AppendFormatted( value, alignment, null );

        /// <inheritdoc cref="AppendFormatted{T}(T, int, string?)"/>
        public void AppendFormatted( ushort value, int alignment, string? format )
        {
            var prevLen = Builder.GetStringStream().Length;
            AppendSpanFormattableAuto( value, format );
            FixAlignment( prevLen, alignment );
        }

        /// <inheritdoc cref="AppendFormatted{T}(T)"/>
        public void AppendFormatted( uint value ) => AppendFormatted( value, 0, null );

        /// <inheritdoc cref="AppendFormatted{T}(T, string?)"/>
        public void AppendFormatted( uint value, string? format ) => AppendFormatted( value, 0, format );

        /// <inheritdoc cref="AppendFormatted{T}(T, int)"/>
        public void AppendFormatted( uint value, int alignment ) => AppendFormatted( value, alignment, null );

        /// <inheritdoc cref="AppendFormatted{T}(T, int, string?)"/>
        public void AppendFormatted( uint value, int alignment, string? format )
        {
            var prevLen = Builder.GetStringStream().Length;
            AppendSpanFormattableAuto( value, format );
            FixAlignment( prevLen, alignment );
        }

        /// <inheritdoc cref="AppendFormatted{T}(T)"/>
        public void AppendFormatted( ulong value ) => AppendFormatted( value, 0, null );

        /// <inheritdoc cref="AppendFormatted{T}(T, string?)"/>
        public void AppendFormatted( ulong value, string? format ) => AppendFormatted( value, 0, format );

        /// <inheritdoc cref="AppendFormatted{T}(T, int)"/>
        public void AppendFormatted( ulong value, int alignment ) => AppendFormatted( value, alignment, null );

        /// <inheritdoc cref="AppendFormatted{T}(T, int, string?)"/>
        public void AppendFormatted( ulong value, int alignment, string? format )
        {
            var prevLen = Builder.GetStringStream().Length;
            AppendSpanFormattableAuto( value, format );
            FixAlignment( prevLen, alignment );
        }

        /// <inheritdoc cref="AppendFormatted{T}(T)"/>
        public void AppendFormatted( nuint value ) => AppendFormatted( value, 0, null );

        /// <inheritdoc cref="AppendFormatted{T}(T, string?)"/>
        public void AppendFormatted( nuint value, string? format ) => AppendFormatted( value, 0, format );

        /// <inheritdoc cref="AppendFormatted{T}(T, int)"/>
        public void AppendFormatted( nuint value, int alignment ) => AppendFormatted( value, alignment, null );

        /// <inheritdoc cref="AppendFormatted{T}(T, int, string?)"/>
        public void AppendFormatted( nuint value, int alignment, string? format )
        {
            var prevLen = Builder.GetStringStream().Length;
            AppendSpanFormattableAuto( value, format );
            FixAlignment( prevLen, alignment );
        }

        /// <inheritdoc cref="AppendFormatted{T}(T)"/>
        public void AppendFormatted( sbyte value ) => AppendFormatted( value, 0, null );

        /// <inheritdoc cref="AppendFormatted{T}(T, string?)"/>
        public void AppendFormatted( sbyte value, string? format ) => AppendFormatted( value, 0, format );

        /// <inheritdoc cref="AppendFormatted{T}(T, int)"/>
        public void AppendFormatted( sbyte value, int alignment ) => AppendFormatted( value, alignment, null );

        /// <inheritdoc cref="AppendFormatted{T}(T, int, string?)"/>
        public void AppendFormatted( sbyte value, int alignment, string? format )
        {
            var prevLen = Builder.GetStringStream().Length;
            AppendSpanFormattableAuto( value, format );
            FixAlignment( prevLen, alignment );
        }

        /// <inheritdoc cref="AppendFormatted{T}(T)"/>
        public void AppendFormatted( short value ) => AppendFormatted( value, 0, null );

        /// <inheritdoc cref="AppendFormatted{T}(T, string?)"/>
        public void AppendFormatted( short value, string? format ) => AppendFormatted( value, 0, format );

        /// <inheritdoc cref="AppendFormatted{T}(T, int)"/>
        public void AppendFormatted( short value, int alignment ) => AppendFormatted( value, alignment, null );

        /// <inheritdoc cref="AppendFormatted{T}(T, int, string?)"/>
        public void AppendFormatted( short value, int alignment, string? format )
        {
            var prevLen = Builder.GetStringStream().Length;
            AppendSpanFormattableAuto( value, format );
            FixAlignment( prevLen, alignment );
        }

        /// <inheritdoc cref="AppendFormatted{T}(T)"/>
        public void AppendFormatted( int value ) => AppendFormatted( value, 0, null );

        /// <inheritdoc cref="AppendFormatted{T}(T, string?)"/>
        public void AppendFormatted( int value, string? format ) => AppendFormatted( value, 0, format );

        /// <inheritdoc cref="AppendFormatted{T}(T, int)"/>
        public void AppendFormatted( int value, int alignment ) => AppendFormatted( value, alignment, null );

        /// <inheritdoc cref="AppendFormatted{T}(T, int, string?)"/>
        public void AppendFormatted( int value, int alignment, string? format )
        {
            var prevLen = Builder.GetStringStream().Length;
            AppendSpanFormattableAuto( value, format );
            FixAlignment( prevLen, alignment );
        }

        /// <inheritdoc cref="AppendFormatted{T}(T)"/>
        public void AppendFormatted( long value ) => AppendFormatted( value, 0, null );

        /// <inheritdoc cref="AppendFormatted{T}(T, string?)"/>
        public void AppendFormatted( long value, string? format ) => AppendFormatted( value, 0, format );

        /// <inheritdoc cref="AppendFormatted{T}(T, int)"/>
        public void AppendFormatted( long value, int alignment ) => AppendFormatted( value, alignment, null );

        /// <inheritdoc cref="AppendFormatted{T}(T, int, string?)"/>
        public void AppendFormatted( long value, int alignment, string? format )
        {
            var prevLen = Builder.GetStringStream().Length;
            AppendSpanFormattableAuto( value, format );
            FixAlignment( prevLen, alignment );
        }

        /// <inheritdoc cref="AppendFormatted{T}(T)"/>
        public void AppendFormatted( nint value ) => AppendFormatted( value, 0, null );

        /// <inheritdoc cref="AppendFormatted{T}(T, string?)"/>
        public void AppendFormatted( nint value, string? format ) => AppendFormatted( value, 0, format );

        /// <inheritdoc cref="AppendFormatted{T}(T, int)"/>
        public void AppendFormatted( nint value, int alignment ) => AppendFormatted( value, alignment, null );

        /// <inheritdoc cref="AppendFormatted{T}(T, int, string?)"/>
        public void AppendFormatted( nint value, int alignment, string? format )
        {
            var prevLen = Builder.GetStringStream().Length;
            AppendSpanFormattableAuto( value, format );
            FixAlignment( prevLen, alignment );
        }

        /// <inheritdoc cref="AppendFormatted{T}(T)"/>
        public unsafe void AppendFormatted( void* value ) => AppendFormatted( value, 0, null );

        /// <inheritdoc cref="AppendFormatted{T}(T, string?)"/>
        public unsafe void AppendFormatted( void* value, string? format ) => AppendFormatted( value, 0, format );

        /// <inheritdoc cref="AppendFormatted{T}(T, int)"/>
        public unsafe void AppendFormatted( void* value, int alignment ) => AppendFormatted( value, alignment, null );

        /// <inheritdoc cref="AppendFormatted{T}(T, int, string?)"/>
        public unsafe void AppendFormatted( void* value, int alignment, string? format )
        {
            var prevLen = Builder.GetStringStream().Length;
            AppendSpanFormattableAuto( (nint) value, format );
            FixAlignment( prevLen, alignment );
        }

        /// <inheritdoc cref="AppendFormatted{T}(T)"/>
        public void AppendFormatted( Half value ) => AppendFormatted( value, 0, null );

        /// <inheritdoc cref="AppendFormatted{T}(T, string?)"/>
        public void AppendFormatted( Half value, string? format ) => AppendFormatted( value, 0, format );

        /// <inheritdoc cref="AppendFormatted{T}(T, int)"/>
        public void AppendFormatted( Half value, int alignment ) => AppendFormatted( value, alignment, null );

        /// <inheritdoc cref="AppendFormatted{T}(T, int, string?)"/>
        public void AppendFormatted( Half value, int alignment, string? format )
        {
            var prevLen = Builder.GetStringStream().Length;
            AppendSpanFormattableAuto( value, format );
            FixAlignment( prevLen, alignment );
        }

        /// <inheritdoc cref="AppendFormatted{T}(T)"/>
        public void AppendFormatted( float value ) => AppendFormatted( value, 0, null );

        /// <inheritdoc cref="AppendFormatted{T}(T, string?)"/>
        public void AppendFormatted( float value, string? format ) => AppendFormatted( value, 0, format );

        /// <inheritdoc cref="AppendFormatted{T}(T, int)"/>
        public void AppendFormatted( float value, int alignment ) => AppendFormatted( value, alignment, null );

        /// <inheritdoc cref="AppendFormatted{T}(T, int, string?)"/>
        public void AppendFormatted( float value, int alignment, string? format )
        {
            var prevLen = Builder.GetStringStream().Length;
            AppendSpanFormattableAuto( value, format );
            FixAlignment( prevLen, alignment );
        }

        /// <inheritdoc cref="AppendFormatted{T}(T)"/>
        public void AppendFormatted( double value ) => AppendFormatted( value, 0, null );

        /// <inheritdoc cref="AppendFormatted{T}(T, string?)"/>
        public void AppendFormatted( double value, string? format ) => AppendFormatted( value, 0, format );

        /// <inheritdoc cref="AppendFormatted{T}(T, int)"/>
        public void AppendFormatted( double value, int alignment ) => AppendFormatted( value, alignment, null );

        /// <inheritdoc cref="AppendFormatted{T}(T, int, string?)"/>
        public void AppendFormatted( double value, int alignment, string? format )
        {
            var prevLen = Builder.GetStringStream().Length;
            AppendSpanFormattableAuto( value, format );
            FixAlignment( prevLen, alignment );
        }

        /// <inheritdoc cref="AppendFormatted{T}(T)"/>
        public void AppendFormatted( scoped in decimal value ) => AppendFormatted( value, 0, null );

        /// <inheritdoc cref="AppendFormatted{T}(T, string?)"/>
        public void AppendFormatted( scoped in decimal value, string? format ) => AppendFormatted( value, 0, format );

        /// <inheritdoc cref="AppendFormatted{T}(T, int)"/>
        public void AppendFormatted( scoped in decimal value, int alignment ) => AppendFormatted( value, alignment, null );

        /// <inheritdoc cref="AppendFormatted{T}(T, int, string?)"/>
        public void AppendFormatted( scoped in decimal value, int alignment, string? format )
        {
            var prevLen = Builder.GetStringStream().Length;
            AppendSpanFormattableAuto( value, format );
            FixAlignment( prevLen, alignment );
        }

        /// <inheritdoc cref="AppendFormatted{T}(T)"/>
        public void AppendFormatted( scoped in System.Numerics.BigInteger value ) => AppendFormatted( value, 0, null );

        /// <inheritdoc cref="AppendFormatted{T}(T, string?)"/>
        public void AppendFormatted( scoped in System.Numerics.BigInteger value, string? format ) => AppendFormatted( value, 0, format );

        /// <inheritdoc cref="AppendFormatted{T}(T, int)"/>
        public void AppendFormatted( scoped in System.Numerics.BigInteger value, int alignment ) => AppendFormatted( value, alignment, null );

        /// <inheritdoc cref="AppendFormatted{T}(T, int, string?)"/>
        public void AppendFormatted( scoped in System.Numerics.BigInteger value, int alignment, string? format )
        {
            var prevLen = Builder.GetStringStream().Length;
            AppendSpanFormattableAuto( value, format );
            FixAlignment( prevLen, alignment );
        }

        /// <inheritdoc cref="AppendFormatted{T}(T)"/>
        public void AppendFormatted( DateOnly value ) => AppendFormatted( value, 0, null );

        /// <inheritdoc cref="AppendFormatted{T}(T, string?)"/>
        public void AppendFormatted( DateOnly value, string? format ) => AppendFormatted( value, 0, format );

        /// <inheritdoc cref="AppendFormatted{T}(T, int)"/>
        public void AppendFormatted( DateOnly value, int alignment ) => AppendFormatted( value, alignment, null );

        /// <inheritdoc cref="AppendFormatted{T}(T, int, string?)"/>
        public void AppendFormatted( DateOnly value, int alignment, string? format )
        {
            var prevLen = Builder.GetStringStream().Length;
            AppendSpanFormattableAuto( value, format );
            FixAlignment( prevLen, alignment );
        }

        /// <inheritdoc cref="AppendFormatted{T}(T)"/>
        public void AppendFormatted( TimeOnly value ) => AppendFormatted( value, 0, null );

        /// <inheritdoc cref="AppendFormatted{T}(T, string?)"/>
        public void AppendFormatted( TimeOnly value, string? format ) => AppendFormatted( value, 0, format );

        /// <inheritdoc cref="AppendFormatted{T}(T, int)"/>
        public void AppendFormatted( TimeOnly value, int alignment ) => AppendFormatted( value, alignment, null );

        /// <inheritdoc cref="AppendFormatted{T}(T, int, string?)"/>
        public void AppendFormatted( TimeOnly value, int alignment, string? format )
        {
            var prevLen = Builder.GetStringStream().Length;
            AppendSpanFormattableAuto( value, format );
            FixAlignment( prevLen, alignment );
        }

        /// <inheritdoc cref="AppendFormatted{T}(T)"/>
        public void AppendFormatted( TimeSpan value ) => AppendFormatted( value, 0, null );

        /// <inheritdoc cref="AppendFormatted{T}(T, string?)"/>
        public void AppendFormatted( TimeSpan value, string? format ) => AppendFormatted( value, 0, format );

        /// <inheritdoc cref="AppendFormatted{T}(T, int)"/>
        public void AppendFormatted( TimeSpan value, int alignment ) => AppendFormatted( value, alignment, null );

        /// <inheritdoc cref="AppendFormatted{T}(T, int, string?)"/>
        public void AppendFormatted( TimeSpan value, int alignment, string? format )
        {
            var prevLen = Builder.GetStringStream().Length;
            AppendSpanFormattableAuto( value, format );
            FixAlignment( prevLen, alignment );
        }

        /// <inheritdoc cref="AppendFormatted{T}(T)"/>
        public void AppendFormatted( DateTime value ) => AppendFormatted( value, 0, null );

        /// <inheritdoc cref="AppendFormatted{T}(T, string?)"/>
        public void AppendFormatted( DateTime value, string? format ) => AppendFormatted( value, 0, format );

        /// <inheritdoc cref="AppendFormatted{T}(T, int)"/>
        public void AppendFormatted( DateTime value, int alignment ) => AppendFormatted( value, alignment, null );

        /// <inheritdoc cref="AppendFormatted{T}(T, int, string?)"/>
        public void AppendFormatted( DateTime value, int alignment, string? format )
        {
            var prevLen = Builder.GetStringStream().Length;
            AppendSpanFormattableAuto( value, format );
            FixAlignment( prevLen, alignment );
        }

        /// <inheritdoc cref="AppendFormatted{T}(T)"/>
        public void AppendFormatted( DateTimeOffset value ) => AppendFormatted( value, 0, null );

        /// <inheritdoc cref="AppendFormatted{T}(T, string?)"/>
        public void AppendFormatted( DateTimeOffset value, string? format ) => AppendFormatted( value, 0, format );

        /// <inheritdoc cref="AppendFormatted{T}(T, int)"/>
        public void AppendFormatted( DateTimeOffset value, int alignment ) => AppendFormatted( value, alignment, null );

        /// <inheritdoc cref="AppendFormatted{T}(T, int, string?)"/>
        public void AppendFormatted( DateTimeOffset value, int alignment, string? format )
        {
            var prevLen = Builder.GetStringStream().Length;
            AppendSpanFormattableAuto( value, format );
            FixAlignment( prevLen, alignment );
        }

#if NET7_0_OR_GREATER
        /// <inheritdoc cref="AppendFormatted{T}(T)"/>
        public void AppendFormatted( scoped in System.Numerics.Complex value ) => AppendFormatted( value, 0, null );

        /// <inheritdoc cref="AppendFormatted{T}(T, string?)"/>
        public void AppendFormatted( scoped in System.Numerics.Complex value, string? format ) => AppendFormatted( value, 0, format );

        /// <inheritdoc cref="AppendFormatted{T}(T, int)"/>
        public void AppendFormatted( scoped in System.Numerics.Complex value, int alignment ) => AppendFormatted( value, alignment, null );

        /// <inheritdoc cref="AppendFormatted{T}(T, int, string?)"/>
        public void AppendFormatted( scoped in System.Numerics.Complex value, int alignment, string? format )
        {
            var prevLen = Builder.GetStringStream().Length;
            AppendSpanFormattableAuto( value, format );
            FixAlignment( prevLen, alignment );
        }
#endif

#if NET8_0_OR_GREATER
        /// <inheritdoc cref="AppendFormatted{T}(T)"/>
        public void AppendFormatted( scoped in UInt128 value ) => AppendFormatted( value, 0, null );

        /// <inheritdoc cref="AppendFormatted{T}(T, string?)"/>
        public void AppendFormatted( scoped in UInt128 value, string? format ) => AppendFormatted( value, 0, format );

        /// <inheritdoc cref="AppendFormatted{T}(T, int)"/>
        public void AppendFormatted( scoped in UInt128 value, int alignment ) => AppendFormatted( value, alignment, null );

        /// <inheritdoc cref="AppendFormatted{T}(T, int, string?)"/>
        public void AppendFormatted( scoped in UInt128 value, int alignment, string? format )
        {
            var prevLen = Builder.GetStringStream().Length;
            AppendSpanFormattableAuto( value, format );
            FixAlignment( prevLen, alignment );
        }

        /// <inheritdoc cref="AppendFormatted{T}(T)"/>
        public void AppendFormatted( scoped in Int128 value ) => AppendFormatted( value, 0, null );

        /// <inheritdoc cref="AppendFormatted{T}(T, string?)"/>
        public void AppendFormatted( scoped in Int128 value, string? format ) => AppendFormatted( value, 0, format );

        /// <inheritdoc cref="AppendFormatted{T}(T, int)"/>
        public void AppendFormatted( scoped in Int128 value, int alignment ) => AppendFormatted( value, alignment, null );

        /// <inheritdoc cref="AppendFormatted{T}(T, int, string?)"/>
        public void AppendFormatted( scoped in Int128 value, int alignment, string? format )
        {
            var prevLen = Builder.GetStringStream().Length;
            AppendSpanFormattableAuto( value, format );
            FixAlignment( prevLen, alignment );
        }

        /// <inheritdoc cref="AppendFormatted{T}(T)"/>
        public void AppendFormatted( System.Net.IPAddress value ) => AppendFormatted( value, 0, null );

        /// <inheritdoc cref="AppendFormatted{T}(T, string?)"/>
        public void AppendFormatted( System.Net.IPAddress value, string? format ) => AppendFormatted( value, 0, format );

        /// <inheritdoc cref="AppendFormatted{T}(T, int)"/>
        public void AppendFormatted( System.Net.IPAddress value, int alignment ) => AppendFormatted( value, alignment, null );

        /// <inheritdoc cref="AppendFormatted{T}(T, int, string?)"/>
        public void AppendFormatted( System.Net.IPAddress value, int alignment, string? format )
        {
            var prevLen = Builder.GetStringStream().Length;
            AppendSpanFormattableAuto( value, format );
            FixAlignment( prevLen, alignment );
        }

        /// <inheritdoc cref="AppendFormatted{T}(T)"/>
        public void AppendFormatted( System.Net.IPNetwork value ) => AppendFormatted( value, 0, null );

        /// <inheritdoc cref="AppendFormatted{T}(T, string?)"/>
        public void AppendFormatted( System.Net.IPNetwork value, string? format ) => AppendFormatted( value, 0, format );

        /// <inheritdoc cref="AppendFormatted{T}(T, int)"/>
        public void AppendFormatted( System.Net.IPNetwork value, int alignment ) => AppendFormatted( value, alignment, null );

        /// <inheritdoc cref="AppendFormatted{T}(T, int, string?)"/>
        public void AppendFormatted( System.Net.IPNetwork value, int alignment, string? format )
        {
            var prevLen = Builder.GetStringStream().Length;
            AppendSpanFormattableAuto( value, format );
            FixAlignment( prevLen, alignment );
        }
#endif

        /// <inheritdoc cref="AppendFormatted{T}(T)"/>
        public void AppendFormatted( ReadOnlySeString value ) => AppendFormatted( value, 0, null );

        /// <inheritdoc cref="AppendFormatted{T}(T, string?)"/>
        public void AppendFormatted( ReadOnlySeString value, string? format ) => AppendFormatted( value, 0, format );

        /// <inheritdoc cref="AppendFormatted{T}(T, int)"/>
        public void AppendFormatted( ReadOnlySeString value, int alignment ) => AppendFormatted( value, alignment, null );

        /// <inheritdoc cref="AppendFormatted{T}(T, int, string?)"/>
        public void AppendFormatted( ReadOnlySeString value, int alignment, string? format )
        {
            var prevLen = Builder.GetStringStream().Length;
            if( string.IsNullOrEmpty( format ) || format == "r" )
                Builder.Append( value );
            else
                Builder.Append( value.ToString( format, _provider ) );
            FixAlignment( prevLen, alignment );
        }

        /// <inheritdoc cref="AppendFormatted{T}(T)"/>
        public void AppendFormatted( ReadOnlySeStringSpan value ) => AppendFormatted( value, 0, null );

        /// <inheritdoc cref="AppendFormatted{T}(T, string?)"/>
        public void AppendFormatted( ReadOnlySeStringSpan value, string? format ) => AppendFormatted( value, 0, format );

        /// <inheritdoc cref="AppendFormatted{T}(T, int)"/>
        public void AppendFormatted( ReadOnlySeStringSpan value, int alignment ) => AppendFormatted( value, alignment, null );

        /// <inheritdoc cref="AppendFormatted{T}(T, int, string?)"/>
        public void AppendFormatted( ReadOnlySeStringSpan value, int alignment, string? format )
        {
            var prevLen = Builder.GetStringStream().Length;
            if( string.IsNullOrEmpty( format ) || format == "r" )
                Builder.Append( value );
            else
                Builder.Append( value.ToString( format, _provider ) );
            FixAlignment( prevLen, alignment );
        }

        /// <inheritdoc cref="AppendFormatted{T}(T)"/>
        public void AppendFormatted( ReadOnlySePayload value ) => AppendFormatted( value, 0, null );

        /// <inheritdoc cref="AppendFormatted{T}(T, string?)"/>
        public void AppendFormatted( ReadOnlySePayload value, string? format ) => AppendFormatted( value, 0, format );

        /// <inheritdoc cref="AppendFormatted{T}(T, int)"/>
        public void AppendFormatted( ReadOnlySePayload value, int alignment ) => AppendFormatted( value, alignment, null );

        /// <inheritdoc cref="AppendFormatted{T}(T, int, string?)"/>
        public void AppendFormatted( ReadOnlySePayload value, int alignment, string? format )
        {
            _ = format;
            var prevLen = Builder.GetStringStream().Length;
            Builder.Append( value );
            FixAlignment( prevLen, alignment );
        }

        /// <inheritdoc cref="AppendFormatted{T}(T)"/>
        public void AppendFormatted( ReadOnlySePayloadSpan value ) => AppendFormatted( value, 0, null );

        /// <inheritdoc cref="AppendFormatted{T}(T, string?)"/>
        public void AppendFormatted( ReadOnlySePayloadSpan value, string? format ) => AppendFormatted( value, 0, format );

        /// <inheritdoc cref="AppendFormatted{T}(T, int)"/>
        public void AppendFormatted( ReadOnlySePayloadSpan value, int alignment ) => AppendFormatted( value, alignment, null );

        /// <inheritdoc cref="AppendFormatted{T}(T, int, string?)"/>
        public void AppendFormatted( ReadOnlySePayloadSpan value, int alignment, string? format )
        {
            _ = format;
            var prevLen = Builder.GetStringStream().Length;
            Builder.Append( value );
            FixAlignment( prevLen, alignment );
        }

        /// <inheritdoc cref="AppendFormatted{T}(T)"/>
        [Obsolete( "Use ReadOnlySeString instead." )]
        public void AppendFormatted( SeString value ) => AppendFormatted( value, 0, null );

        /// <inheritdoc cref="AppendFormatted{T}(T, string?)"/>
        [Obsolete( "Use ReadOnlySeString instead." )]
        public void AppendFormatted( SeString value, string? format ) => AppendFormatted( value, 0, format );

        /// <inheritdoc cref="AppendFormatted{T}(T, int)"/>
        [Obsolete( "Use ReadOnlySeString instead." )]
        public void AppendFormatted( SeString value, int alignment ) => AppendFormatted( value, alignment, null );

        /// <inheritdoc cref="AppendFormatted{T}(T, int, string?)"/>
        [Obsolete( "Use ReadOnlySeString instead." )]
        public void AppendFormatted( SeString value, int alignment, string? format )
        {
            _ = format;
            var prevLen = Builder.GetStringStream().Length;
            Builder.Append( value );
            FixAlignment( prevLen, alignment );
        }

        /// <inheritdoc cref="AppendFormatted{T}(T)"/>
        public void AppendFormatted( ReadOnlySpan< byte > value ) => AppendFormatted( value, 0, null );

        /// <inheritdoc cref="AppendFormatted{T}(T, string?)"/>
        public void AppendFormatted( ReadOnlySpan< byte > value, string? format ) => AppendFormatted( value, 0, format );

        /// <inheritdoc cref="AppendFormatted{T}(T, int)"/>
        public void AppendFormatted( ReadOnlySpan< byte > value, int alignment ) => AppendFormatted( value, alignment, null );

        /// <inheritdoc cref="AppendFormatted{T}(T, int, string?)"/>
        public void AppendFormatted( ReadOnlySpan< byte > value, int alignment, string? format )
        {
            _ = format;
            var prevLen = Builder.GetStringStream().Length;
            if( format?.StartsWith( 'm' ) is true )
                Builder.AppendMacroString( value );
            else
                Builder.Append( value );
            FixAlignment( prevLen, alignment );
        }

        /// <inheritdoc cref="AppendFormatted{T}(T)"/>
        public void AppendFormatted( ReadOnlySpan< char > value ) => AppendFormatted( value, 0, null );

        /// <inheritdoc cref="AppendFormatted{T}(T, string?)"/>
        public void AppendFormatted( ReadOnlySpan< char > value, string? format ) => AppendFormatted( value, 0, format );

        /// <inheritdoc cref="AppendFormatted{T}(T, int)"/>
        public void AppendFormatted( ReadOnlySpan< char > value, int alignment ) => AppendFormatted( value, alignment, null );

        /// <inheritdoc cref="AppendFormatted{T}(T, int, string?)"/>
        public void AppendFormatted( ReadOnlySpan< char > value, int alignment, string? format )
        {
            _ = format;
            var prevLen = Builder.GetStringStream().Length;
            if( format?.StartsWith( 'm' ) is true )
                Builder.AppendMacroString( value );
            else
                Builder.Append( value );
            FixAlignment( prevLen, alignment );
        }

        private void FixAlignment( long prevLen, int alignment )
        {
            if( alignment == 0 )
                return;

            var len = (int) ( Builder.GetStringStream().Length - prevLen );
            if( len >= Math.Abs( alignment ) )
                return;

            if( alignment < 0 )
            {
                // left align
                Builder.AllocateStringSpan( -( len + alignment ) ).Fill( (byte) ' ' );
            }
            else
            {
                // right align
                var span = Builder.ReallocateStringSpan( len, alignment );
                span[ ..len ].CopyTo( span[ ^len.. ] );
                span[ ..^len ].Fill( (byte) ' ' );
            }
        }

#if NET8_0_OR_GREATER
        /// <inheritdoc cref="SeStringBuilder.AppendSpanFormattableUtf8{T}"/>
        [MethodImpl( MethodImplOptions.AggressiveInlining )]
        private void AppendSpanFormattableUtf8< T >( scoped in T value, ReadOnlySpan< char > format ) where T : IUtf8SpanFormattable
        {
            var span = Span< byte >.Empty;
            for( var len = Unsafe.SizeOf< MemoryChunkStorage >(); len < Array.MaxLength >> 1; len *= 2 )
            {
                span = Builder.ReallocateStringSpan( span.Length, len );
                if( value.TryFormat( span, out var written, format, _provider ) )
                {
                    Builder.ReallocateStringSpan( span.Length, written );
                    return;
                }
            }

            throw new OutOfMemoryException();
        }
#endif

        /// <inheritdoc cref="SeStringBuilder.AppendSpanFormattableUtf16{T}"/>
        [MethodImpl( MethodImplOptions.AggressiveInlining )]
        private void AppendSpanFormattableUtf16< T >( scoped in T value, ReadOnlySpan< char > format ) where T : ISpanFormattable
        {
            var span = MemoryChunkStorage.AsSpanUninitialized< char >( out _ );
            if( value.TryFormat( span, out var written, format, _provider ) )
            {
                Builder.Append( span[ ..written ] );
                return;
            }

            for( var len = 2 * Unsafe.SizeOf< MemoryChunkStorage >(); len < Array.MaxLength >> 2; len *= 2 )
            {
                var buf = ArrayPool< char >.Shared.Rent( len );
                if( value.TryFormat( buf, out written, format, _provider ) )
                {
                    Builder.Append( buf[ ..written ] );
                    ArrayPool< char >.Shared.Return( buf );
                    return;
                }

                ArrayPool< char >.Shared.Return( buf );
            }

            throw new OutOfMemoryException();
        }

        /// <inheritdoc cref="SeStringBuilder.AppendSpanFormattableAuto{T}"/>
#if NET8_0_OR_GREATER
        [MethodImpl( MethodImplOptions.AggressiveInlining )]
        private void AppendSpanFormattableAuto< T >( T value, ReadOnlySpan< char > format ) where T : IUtf8SpanFormattable =>
            AppendSpanFormattableUtf8( value, format );
#else
        [MethodImpl( MethodImplOptions.AggressiveInlining )]
        private void AppendSpanFormattableAuto< T >( T value, ReadOnlySpan< char > format ) where T : ISpanFormattable =>
            AppendSpanFormattableUtf16( value, format );
#endif
    }
}