using System;
using System.Collections.Immutable;
using System.IO;
using Lumina.Text.Expressions;

namespace Lumina.Text.Payloads
{
    /// <summary>
    /// Represent a simple text payload.
    /// </summary>
    public class NewlinePayload : BasePayload
    {
        /// <inheritdoc />
        public NewlinePayload() : base( PayloadType.NewLine, ImmutableList< BaseExpression >.Empty ) => EnsurePayloadTypeOrThrow();

        /// <inheritdoc />
        public NewlinePayload( BasePayload from ) : base( from ) => EnsurePayloadTypeOrThrow();

        /// <inheritdoc />
        public NewlinePayload( byte[] data ) : base( data ) => EnsurePayloadTypeOrThrow();

        /// <inheritdoc />
        public NewlinePayload( BinaryReader br ) : base( br ) => EnsurePayloadTypeOrThrow();

        /// <inheritdoc />
        public NewlinePayload( Stream stream ) : base( stream ) => EnsurePayloadTypeOrThrow();

        private void EnsurePayloadTypeOrThrow()
        {
            if( PayloadType != PayloadType.NewLine )
                throw new ArgumentException( $"Given payload is not a {nameof( NewlinePayload )}." );
        }
    }
}