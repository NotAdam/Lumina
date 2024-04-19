using System;

namespace Lumina.Text.Expressions;

/// <summary>Attaches extra data for <see cref="ExpressionType"/>.</summary>
[AttributeUsage( AttributeTargets.Field )]
internal sealed class ExpressionDataAttribute : Attribute
{
    /// <summary>Initializes a new instance of <see cref="ExpressionDataAttribute"/> class.</summary>
    /// <param name="arity">The arity.</param>
    /// <param name="nativeName">The native name.</param>
    public ExpressionDataAttribute( ExpressionArity arity, string nativeName )
    {
        Arity = arity;
        NativeName = nativeName;
    }

    /// <summary>Gets the arity.</summary>
    public ExpressionArity Arity { get; }

    /// <summary>Gets the native name.</summary>
    public string NativeName { get; }
}