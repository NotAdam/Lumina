using System;

namespace Lumina.Excel;

/// <summary>Exception indicating that the requested row type's column hash is different from game data.</summary>
public sealed class MismatchedColumnHashException( uint typeHash, uint gameHash, string? paramName ) :
    ArgumentException(
        $"The requested row type has a column hash that is different from game data. (Type: {typeHash:X08}, Game: {gameHash:X08})",
        paramName )
{ }