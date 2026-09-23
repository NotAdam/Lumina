using System;

namespace Lumina.Data;

public enum CategoryType : byte
{
    Common = 0x00,
    BgCommon = 0x01,
    Bg = 0x02,
    Cut = 0x03,
    Chara = 0x04,
    Shader = 0x05,
    Ui = 0x06,
    Sound = 0x07,
    Vfx = 0x08,
    UiScript = 0x09,
    Exd = 0x0A,
    GameScript = 0x0B,
    Music = 0x0C,
    SqpackTest = 0x12,
    Debug = 0x13,
}
