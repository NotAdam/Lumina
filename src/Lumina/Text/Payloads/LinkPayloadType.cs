namespace Lumina.Text.Payloads;

/// <summary>Known values for the first parameter of <see cref="MacroCode.Link"/>.</summary>
public enum LinkMacroPayloadType
{
    /// <summary>A character is linked.</summary>
    /// <remarks>Parameters: this, unknown(0), ID in the World sheet, reserved(0), character name.</remarks>
    Character = 0x00,

    /// <summary>An item is linked.</summary>
    /// <remarks>Parameters: this, ID in the Item sheet, unknown(1), unknown(0), optional display string.</remarks>
    Item = 0x02,

    /// <summary>A map position is linked.</summary>
    /// <remarks>Parameters: this, packed IDs (<c>TerritoryId &lt;&lt; 16 | MapID</c>), raw X, raw Y, probably an optional display string.</remarks>
    MapPosition = 0x03,

    /// <summary>A quest is linked.</summary>
    /// <remarks>Parameters: this, ID in the Quest sheet, unknown(0), unknown(0), probably an optional display string.</remarks>
    Quest = 0x04,

    /// <summary>An achievement is linked.</summary>
    /// <remarks>Parameters: this, ID in the Achievement sheet, unknown(0), unknown(0), probably an optional display string.</remarks>
    Achievement = 0x05,

    /// <summary>A How-To entry is linked.</summary>
    /// <remarks>Parameters: this, ID in the HowTo sheet, unknown(0), unknown(0), probably an optional display string.</remarks>
    HowTo = 0x06,

    /// <summary>The party finder dialog is linked.</summary>
    /// <remarks>Parameters: this, reserved(0), reserved(0), reserved(0), reserved(&quot;&quot;).</remarks>
    PartyFinderNotification = 0x07,

    /// <summary>A status is linked.</summary>
    /// <remarks>Parameters: this, ID in the Status sheet, unknown(0), unknown(0), probably an optional display string.</remarks>
    Status = 0x08,

    /// <summary>A party finder listing is linked.</summary>
    /// <remarks>
    /// Parameters: this, party finder listing ID, unknown(0), ID in the World sheet(*), probably an optional display string.<br />
    /// *: ID in the World sheet, or 0x10000 if the party finder listing is not cross-world. The high 16 bits might be a flag, where having LSB set means that
    /// there is no World ID attached.</remarks>
    PartyFinder = 0x09,

    /// <summary>An AkatsukiNote entry is linked.</summary>
    /// <remarks>Parameters: this, ID in the AkatsukiNote sheet, unknown(0), unknown(0), probably an optional display string.</remarks>
    AkatsukiNote = 0x0A,

    /// <summary>A Description entry is linked.</summary>
    /// <remarks>Parameters: this, ID in the DescriptionString sheet, unknown(0), ID in the DescriptionStandAlone[Transient] sheet(?), probably an optional display string.</remarks>
    Description = 0x0B,

    /// <summary>A WKSPioneeringTrail entry is linked.</summary>
    /// <remarks>Parameters: this, ID in the WKSPioneeringTrail sheet, SubrowID in the WKSPioneeringTrail sheet, unknown(0), probably an optional display string.</remarks>
    WKSPioneeringTrail = 0x0C,

    /// <summary>A MKDLore entry is linked.</summary>
    /// <remarks>Parameters: this, ID in the MKDLore sheet, unknown(0), unknown(0), probably an optional display string.</remarks>
    MKDLore = 0x0D,

    /// <summary>A link is terminated. Akin to <c>&lt;/a&gt;</c>.</summary>
    /// <remarks>Parameters: this, reserved(0), reserved(0), reserved(0), reserved(&quot;&quot;).</remarks>
    Terminator = 0xCE,
}