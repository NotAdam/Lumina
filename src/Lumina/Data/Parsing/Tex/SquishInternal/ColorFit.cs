using System;

namespace Lumina.Data.Parsing.Tex.SquishInternal;

internal abstract class ColorFit
{
    public readonly SquishOptions2 Options;
    public readonly ColorSet Colors;

    protected ColorFit( ColorSet colors, SquishOptions2 options )
    {
        Colors = colors;
        Options = options;
    }

    public void Compress( Span< byte > block )
    {
        Reset();
        if( Options.Method == SquishMethod.Dxt1 )
        {
            Compress3( block );
            if( !Colors.IsTransparent )
                Compress4( block );
        }
        else
            Compress4( block );
    }

    protected abstract void Reset();
    protected abstract void Compress3( Span< byte > block );
    protected abstract void Compress4( Span< byte > block );
}