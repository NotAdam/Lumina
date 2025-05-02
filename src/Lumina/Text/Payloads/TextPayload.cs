using System;
using System.IO;
using System.Text;

namespace Lumina.Text.Payloads
{
    /// <summary>
    /// Represent a simple text payload.
    /// </summary>
    [Obsolete( "Use ReadOnlySePayload instead." )]
    public class TextPayload : BasePayload
    {
        /// <inheritdoc />
        public TextPayload()
        {
        }

        /// <inheritdoc />
        public TextPayload( BasePayload from ) : base( from ) => EnsurePayloadTypeOrThrow();

        /// <inheritdoc />
        public TextPayload( byte[] data ) : base( data ) => EnsurePayloadTypeOrThrow();

        /// <summary>
        /// Construct a new TextPayload using the given string.
        /// </summary>
        public TextPayload( string s ) : base( Encoding.UTF8.GetBytes( s ) ) => EnsurePayloadTypeOrThrow();

        /// <inheritdoc />
        public TextPayload( BinaryReader br ) : base( br ) => EnsurePayloadTypeOrThrow();

        /// <inheritdoc />
        public TextPayload( Stream stream ) : base( stream ) => EnsurePayloadTypeOrThrow();

        private void EnsurePayloadTypeOrThrow()
        {
            if( !IsTextPayload )
                throw new ArgumentException( "Given payload is not a text payload." );
        }
    }
}