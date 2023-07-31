using System;
using System.Buffers.Binary;
using System.IO;
using System.Text;
using Lumina.Data.Structs;

namespace Lumina.Data;

/// <summary>
/// A subclass of <see cref="BinaryWriter"/> that ensures that the values written are in the specified endianness.
/// </summary>
public class LuminaBinaryWriter : BinaryWriter {
    /// <inheritdoc/>
    public LuminaBinaryWriter( Stream stream, PlatformId platformId = PlatformId.Win32 )
        : this( stream, Encoding.UTF8, false, platformId )
    {
    }

    /// <inheritdoc/>
    public LuminaBinaryWriter( Stream stream, Encoding encoding, PlatformId platformId = PlatformId.Win32 )
        : this( stream, encoding, false, platformId )
    {
    }

    /// <inheritdoc/>
    public LuminaBinaryWriter( Stream stream, Encoding encoding, bool leaveOpen, PlatformId platformId = PlatformId.Win32 )
        : base( stream, encoding, leaveOpen )
    {
        PlatformId = platformId;
        IsLittleEndian = platformId != PlatformId.PS3;
    }

    /// <summary>
    /// Target platform for the written data.
    /// </summary>
    /// <remarks>
    /// The value may not correspond to <see cref="IsBigEndian"/>/<see cref="IsLittleEndian"/>, as those properties can be changed on demand.
    /// </remarks>
    public PlatformId PlatformId { get; internal set; }

    /// <summary>
    /// Write values in big endian.
    /// </summary>
    public bool IsBigEndian { get; set; }

    /// <summary>
    /// Write values in little endian.
    /// </summary>
    public bool IsLittleEndian {
        get => !IsBigEndian;
        set => IsBigEndian = !value;
    }

    /// <summary>
    /// Alias of <see cref="BinaryWriter.BaseStream" />.<see cref="Stream.Position"/>.
    /// </summary>
    public long Position {
        get => BaseStream.Position;
        set => BaseStream.Position = value;
    }

    /// <summary>
    /// Alias of <see cref="BinaryWriter.BaseStream" />.<see cref="Stream.Position"/>, but in <see cref="int"/>.
    /// </summary>
    public int PositionI32 {
        get => checked((int) BaseStream.Position);
        set => BaseStream.Position = value;
    }

    /// <summary>
    /// Alias of <see cref="BinaryWriter.BaseStream" />.<see cref="Stream.Length"/>.
    /// </summary>
    public long Length => BaseStream.Length;

    /// <summary>
    /// Alias of <see cref="BinaryWriter.BaseStream" />.<see cref="Stream.Length"/>, but in <see cref="int"/>.
    /// </summary>
    public int LengthI32 => checked((int) BaseStream.Length);

    /// <inheritdoc/>
    public override void Write(decimal value) {
        Span<byte> buffer = stackalloc byte[sizeof(decimal)];
        unsafe {
            fixed (byte* p = &buffer.GetPinnableReference()) {
                Span<int> bufferInts = new(p, buffer.Length / sizeof(int));
                decimal.GetBits(value, bufferInts);
            }
        }

        if (IsBigEndian == BitConverter.IsLittleEndian) {
            for (var i = 0; i < buffer.Length; i += sizeof(int))
                buffer.Slice(i, i + sizeof(int)).Reverse();
        }

        OutStream.Write(buffer);
    }

    /// <inheritdoc/>
    public override void Write(Half value) {
        Span<byte> buffer = stackalloc byte[sizeof(ushort)];
        if (IsBigEndian)
            BinaryPrimitives.WriteHalfBigEndian(buffer, value);
        else
            BinaryPrimitives.WriteHalfLittleEndian(buffer, value);
        OutStream.Write(buffer);
    }

    /// <inheritdoc/>
    public override void Write(float value) {
        Span<byte> buffer = stackalloc byte[sizeof(float)];
        if (IsBigEndian)
            BinaryPrimitives.WriteSingleBigEndian(buffer, value);
        else
            BinaryPrimitives.WriteSingleLittleEndian(buffer, value);
        OutStream.Write(buffer);
    }

    /// <inheritdoc/>
    public override void Write(double value) {
        Span<byte> buffer = stackalloc byte[sizeof(double)];
        if (IsBigEndian)
            BinaryPrimitives.WriteDoubleBigEndian(buffer, value);
        else
            BinaryPrimitives.WriteDoubleLittleEndian(buffer, value);
        OutStream.Write(buffer);
    }

    /// <inheritdoc/>
    public override void Write(short value) {
        Span<byte> buffer = stackalloc byte[sizeof(short)];
        if (IsBigEndian)
            BinaryPrimitives.WriteInt16BigEndian(buffer, value);
        else
            BinaryPrimitives.WriteInt16LittleEndian(buffer, value);
        OutStream.Write(buffer);
    }

    /// <inheritdoc/>
    public override void Write(ushort value) {
        Span<byte> buffer = stackalloc byte[sizeof(ushort)];
        if (IsBigEndian)
            BinaryPrimitives.WriteUInt16BigEndian(buffer, value);
        else
            BinaryPrimitives.WriteUInt16LittleEndian(buffer, value);
        OutStream.Write(buffer);
    }

    /// <inheritdoc/>
    public override void Write(int value) {
        Span<byte> buffer = stackalloc byte[sizeof(int)];
        if (IsBigEndian)
            BinaryPrimitives.WriteInt32BigEndian(buffer, value);
        else
            BinaryPrimitives.WriteInt32LittleEndian(buffer, value);
        OutStream.Write(buffer);
    }

    /// <inheritdoc/>
    public override void Write(uint value) {
        Span<byte> buffer = stackalloc byte[sizeof(uint)];
        if (IsBigEndian)
            BinaryPrimitives.WriteUInt32BigEndian(buffer, value);
        else
            BinaryPrimitives.WriteUInt32LittleEndian(buffer, value);
        OutStream.Write(buffer);
    }

    /// <inheritdoc/>
    public override void Write(long value) {
        Span<byte> buffer = stackalloc byte[sizeof(long)];
        if (IsBigEndian)
            BinaryPrimitives.WriteInt64BigEndian(buffer, value);
        else
            BinaryPrimitives.WriteInt64LittleEndian(buffer, value);
        OutStream.Write(buffer);
    }

    /// <inheritdoc/>
    public override void Write(ulong value) {
        Span<byte> buffer = stackalloc byte[sizeof(ulong)];
        if (IsBigEndian)
            BinaryPrimitives.WriteUInt64BigEndian(buffer, value);
        else
            BinaryPrimitives.WriteUInt64LittleEndian(buffer, value);
        OutStream.Write(buffer);
    }

    /// <summary>
    /// Enforce endianness for the scope (until the disposure of the returned object).
    /// </summary>
    public IDisposable ScopedLittleEndian(bool useLittleEndian = true) {
        var b = new EndiannessRestorer(this);
        IsBigEndian = !useLittleEndian;
        return b;
    }

    /// <summary>
    /// Enforce endianness for the scope (until the disposure of the returned object).
    /// </summary>
    public IDisposable ScopedBigEndian(bool useBigEndian = true) => ScopedLittleEndian(!useBigEndian);

    internal sealed class EndiannessRestorer : IDisposable {
        private readonly bool _previousBigEndian;
        private readonly LuminaBinaryWriter _writer;
        private bool _isDisposed = false;

        public EndiannessRestorer(LuminaBinaryWriter writer) {
            _writer = writer;
            _previousBigEndian = writer.IsBigEndian;
        }

        public void Dispose() {
            if(!_isDisposed)
                _writer.IsBigEndian = _previousBigEndian;
            _isDisposed = true;
        }
    }
}
