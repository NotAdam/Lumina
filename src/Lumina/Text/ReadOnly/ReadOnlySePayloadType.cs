namespace Lumina.Text.ReadOnly;

/// <summary>Possible types for a payload.</summary>
public enum ReadOnlySePayloadType
{
    /// <summary>Indicates that this payload is either invalid or empty. No field is valid.</summary>
    Invalid = default,

    /// <summary>Indicates that this payload contains text.
    /// <see cref="ReadOnlySePayload.Body"/> is valid.</summary>
    Text = 1,

    /// <summary>Indicates that this payload contains a macro and its arguments.
    /// <see cref="ReadOnlySePayload.Body"/> and <see cref="ReadOnlySePayload.MacroCode"/> is valid.</summary>
    Macro = 2,
}