using System;

namespace Lumina.Text.Payloads;

/// <summary>Attaches extra data for <see cref="MacroCode"/>.</summary>
[AttributeUsage( AttributeTargets.Field )]
internal sealed class MacroCodeDataAttribute : Attribute
{
    public MacroCodeDataAttribute( string? encodedName, string parameterDefinition )
    {
        EncodedName = encodedName;
        ParameterDefinition = parameterDefinition;
    }

    /// <summary>Gets the name to use instead when encoding to the text representation of SeString.</summary>
    public string? EncodedName { get; }

    /// <summary>Gets the parameter definition.</summary>
    public string ParameterDefinition { get; }
}