namespace Lumina.Text.Expressions;

/// <summary>
/// Number of sub-expressions for an expression.
/// </summary>
public enum ExpressionArity
{
    /// <summary>The expression does not have a use for concept of arity.</summary>
    Invalid,

    /// <summary>The expression does not have any sub-expression.</summary>
    Nullary,

    /// <summary>The expression has one sub-expression.</summary>
    Unary,

    /// <summary>The expression has two sub-expressions.</summary>
    Binary,
}