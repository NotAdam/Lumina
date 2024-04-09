using System.Reflection;

namespace Lumina.Text.Expressions;

/// <summary>Extension methods for <see cref="ExpressionType"/>.</summary>
public static class ExpressionTypeExtensions
{
    private static readonly string?[] NativeNames;
    private static readonly ExpressionArity[] Arities;

    static ExpressionTypeExtensions()
    {
        NativeNames = new string?[256];
        Arities = new ExpressionArity[256];
        foreach( var v in typeof( ExpressionType ).GetFields( BindingFlags.Static | BindingFlags.Public ) )
        {
            if( v.GetRawConstantValue() is not byte b )
                continue;
            if( v.GetCustomAttribute< ExpressionDataAttribute >() is not { } eda )
                continue;
            NativeNames[ b ] = eda.NativeName;
            Arities[ b ] = eda.Arity;
        }
    }

    /// <summary>Gets the native name for an expression type, if available.</summary>
    /// <param name="v">The expression type.</param>
    /// <returns>The native name of the expression type, or <c>null</c> if not available.</returns>
    public static string? GetNativeName( this ExpressionType v ) => NativeNames[ (int) v ];

    /// <summary>Gets the arity for an expression type, if applicable.</summary>
    /// <param name="v">The expression type.</param>
    /// <returns>The arity of the expression type, or <see cref="ExpressionArity.Invalid"/> if not applicable.</returns>
    public static ExpressionArity GetArity( this ExpressionType v ) => Arities[ (int) v ];
}