using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Quest", columnHash: 0xefffe604 )]
    public class Quest : IExcelRow
    {
        // column defs from Thu, 31 Oct 2019 11:05:37 GMT


        // col: 00 offset: 0000
        public string Name;

        // col: 50 offset: 0004
        public string[] ScriptInstruction;

        // col: 100 offset: 0008
        public uint[] ScriptArg;

        // col: 278 offset: 0194
        public uint[] ActorSpawn;

        // col: 470 offset: 0198
        public uint unknown198;

        // col: 598 offset: 019c
        public ushort unknown19c;

        // col: 150 offset: 019e
        public byte[] ActorSpawnSeq;

        // col: 214 offset: 019f
        public byte[] ActorDespawnSeq;

        // col: 342 offset: 01a0
        public byte[] QuestUInt8A;

        // col: 406 offset: 01a1
        public byte unknown1a1;

        // col: 534 offset: 01a2
        public byte unknown1a2;

        // col: 662 offset: 01a3
        private byte packed1a3;
        public bool packed1a3_1 => ( packed1a3 & 0x1 ) == 0x1;
        public bool packed1a3_2 => ( packed1a3 & 0x2 ) == 0x2;
        public bool packed1a3_4 => ( packed1a3 & 0x4 ) == 0x4;
        public bool packed1a3_8 => ( packed1a3 & 0x8 ) == 0x8;
        public bool packed1a3_10 => ( packed1a3 & 0x10 ) == 0x10;
        public bool packed1a3_20 => ( packed1a3 & 0x20 ) == 0x20;
        public bool packed1a3_40 => ( packed1a3 & 0x40 ) == 0x40;
        public bool packed1a3_80 => ( packed1a3 & 0x80 ) == 0x80;

        // col: 471 offset: 01a8
        public uint unknown1a8;

        // col: 599 offset: 01ac
        public ushort unknown1ac;

        // col: 407 offset: 01b1
        public byte unknown1b1;

        // col: 535 offset: 01b2
        public byte unknown1b2;

        // col: 663 offset: 01b3
        private byte packed1b3;
        public bool packed1b3_1 => ( packed1b3 & 0x1 ) == 0x1;
        public bool packed1b3_2 => ( packed1b3 & 0x2 ) == 0x2;
        public bool packed1b3_4 => ( packed1b3 & 0x4 ) == 0x4;
        public bool packed1b3_8 => ( packed1b3 & 0x8 ) == 0x8;
        public bool packed1b3_10 => ( packed1b3 & 0x10 ) == 0x10;
        public bool packed1b3_20 => ( packed1b3 & 0x20 ) == 0x20;
        public bool packed1b3_40 => ( packed1b3 & 0x40 ) == 0x40;
        public bool packed1b3_80 => ( packed1b3 & 0x80 ) == 0x80;

        // col: 472 offset: 01b8
        public uint unknown1b8;

        // col: 600 offset: 01bc
        public ushort unknown1bc;

        // col: 408 offset: 01c1
        public byte unknown1c1;

        // col: 536 offset: 01c2
        public byte unknown1c2;

        // col: 664 offset: 01c3
        private byte packed1c3;
        public bool packed1c3_1 => ( packed1c3 & 0x1 ) == 0x1;
        public bool packed1c3_2 => ( packed1c3 & 0x2 ) == 0x2;
        public bool packed1c3_4 => ( packed1c3 & 0x4 ) == 0x4;
        public bool packed1c3_8 => ( packed1c3 & 0x8 ) == 0x8;
        public bool packed1c3_10 => ( packed1c3 & 0x10 ) == 0x10;
        public bool packed1c3_20 => ( packed1c3 & 0x20 ) == 0x20;
        public bool packed1c3_40 => ( packed1c3 & 0x40 ) == 0x40;
        public bool packed1c3_80 => ( packed1c3 & 0x80 ) == 0x80;

        // col: 473 offset: 01c8
        public uint unknown1c8;

        // col: 601 offset: 01cc
        public ushort unknown1cc;

        // col: 409 offset: 01d1
        public byte unknown1d1;

        // col: 537 offset: 01d2
        public byte unknown1d2;

        // col: 665 offset: 01d3
        private byte packed1d3;
        public bool packed1d3_1 => ( packed1d3 & 0x1 ) == 0x1;
        public bool packed1d3_2 => ( packed1d3 & 0x2 ) == 0x2;
        public bool packed1d3_4 => ( packed1d3 & 0x4 ) == 0x4;
        public bool packed1d3_8 => ( packed1d3 & 0x8 ) == 0x8;
        public bool packed1d3_10 => ( packed1d3 & 0x10 ) == 0x10;
        public bool packed1d3_20 => ( packed1d3 & 0x20 ) == 0x20;
        public bool packed1d3_40 => ( packed1d3 & 0x40 ) == 0x40;
        public bool packed1d3_80 => ( packed1d3 & 0x80 ) == 0x80;

        // col: 474 offset: 01d8
        public uint unknown1d8;

        // col: 602 offset: 01dc
        public ushort unknown1dc;

        // col: 410 offset: 01e1
        public byte unknown1e1;

        // col: 538 offset: 01e2
        public byte unknown1e2;

        // col: 666 offset: 01e3
        private byte packed1e3;
        public bool packed1e3_1 => ( packed1e3 & 0x1 ) == 0x1;
        public bool packed1e3_2 => ( packed1e3 & 0x2 ) == 0x2;
        public bool packed1e3_4 => ( packed1e3 & 0x4 ) == 0x4;
        public bool packed1e3_8 => ( packed1e3 & 0x8 ) == 0x8;
        public bool packed1e3_10 => ( packed1e3 & 0x10 ) == 0x10;
        public bool packed1e3_20 => ( packed1e3 & 0x20 ) == 0x20;
        public bool packed1e3_40 => ( packed1e3 & 0x40 ) == 0x40;
        public bool packed1e3_80 => ( packed1e3 & 0x80 ) == 0x80;

        // col: 475 offset: 01e8
        public uint unknown1e8;

        // col: 603 offset: 01ec
        public ushort unknown1ec;

        // col: 411 offset: 01f1
        public byte unknown1f1;

        // col: 539 offset: 01f2
        public byte unknown1f2;

        // col: 667 offset: 01f3
        private byte packed1f3;
        public bool packed1f3_1 => ( packed1f3 & 0x1 ) == 0x1;
        public bool packed1f3_2 => ( packed1f3 & 0x2 ) == 0x2;
        public bool packed1f3_4 => ( packed1f3 & 0x4 ) == 0x4;
        public bool packed1f3_8 => ( packed1f3 & 0x8 ) == 0x8;
        public bool packed1f3_10 => ( packed1f3 & 0x10 ) == 0x10;
        public bool packed1f3_20 => ( packed1f3 & 0x20 ) == 0x20;
        public bool packed1f3_40 => ( packed1f3 & 0x40 ) == 0x40;
        public bool packed1f3_80 => ( packed1f3 & 0x80 ) == 0x80;

        // col: 476 offset: 01f8
        public uint unknown1f8;

        // col: 604 offset: 01fc
        public ushort unknown1fc;

        // col: 412 offset: 0201
        public byte unknown201;

        // col: 540 offset: 0202
        public byte unknown202;

        // col: 668 offset: 0203
        private byte packed203;
        public bool packed203_1 => ( packed203 & 0x1 ) == 0x1;
        public bool packed203_2 => ( packed203 & 0x2 ) == 0x2;
        public bool packed203_4 => ( packed203 & 0x4 ) == 0x4;
        public bool packed203_8 => ( packed203 & 0x8 ) == 0x8;
        public bool packed203_10 => ( packed203 & 0x10 ) == 0x10;
        public bool packed203_20 => ( packed203 & 0x20 ) == 0x20;
        public bool packed203_40 => ( packed203 & 0x40 ) == 0x40;
        public bool packed203_80 => ( packed203 & 0x80 ) == 0x80;

        // col: 477 offset: 0208
        public uint unknown208;

        // col: 605 offset: 020c
        public ushort unknown20c;

        // col: 413 offset: 0211
        public byte unknown211;

        // col: 541 offset: 0212
        public byte unknown212;

        // col: 669 offset: 0213
        private byte packed213;
        public bool packed213_1 => ( packed213 & 0x1 ) == 0x1;
        public bool packed213_2 => ( packed213 & 0x2 ) == 0x2;
        public bool packed213_4 => ( packed213 & 0x4 ) == 0x4;
        public bool packed213_8 => ( packed213 & 0x8 ) == 0x8;
        public bool packed213_10 => ( packed213 & 0x10 ) == 0x10;
        public bool packed213_20 => ( packed213 & 0x20 ) == 0x20;
        public bool packed213_40 => ( packed213 & 0x40 ) == 0x40;
        public bool packed213_80 => ( packed213 & 0x80 ) == 0x80;

        // col: 478 offset: 0218
        public uint unknown218;

        // col: 606 offset: 021c
        public ushort unknown21c;

        // col: 414 offset: 0221
        public byte unknown221;

        // col: 542 offset: 0222
        public byte unknown222;

        // col: 670 offset: 0223
        private byte packed223;
        public bool packed223_1 => ( packed223 & 0x1 ) == 0x1;
        public bool packed223_2 => ( packed223 & 0x2 ) == 0x2;
        public bool packed223_4 => ( packed223 & 0x4 ) == 0x4;
        public bool packed223_8 => ( packed223 & 0x8 ) == 0x8;
        public bool packed223_10 => ( packed223 & 0x10 ) == 0x10;
        public bool packed223_20 => ( packed223 & 0x20 ) == 0x20;
        public bool packed223_40 => ( packed223 & 0x40 ) == 0x40;
        public bool packed223_80 => ( packed223 & 0x80 ) == 0x80;

        // col: 479 offset: 0228
        public uint unknown228;

        // col: 607 offset: 022c
        public ushort unknown22c;

        // col: 415 offset: 0231
        public byte unknown231;

        // col: 543 offset: 0232
        public byte unknown232;

        // col: 671 offset: 0233
        private byte packed233;
        public bool packed233_1 => ( packed233 & 0x1 ) == 0x1;
        public bool packed233_2 => ( packed233 & 0x2 ) == 0x2;
        public bool packed233_4 => ( packed233 & 0x4 ) == 0x4;
        public bool packed233_8 => ( packed233 & 0x8 ) == 0x8;
        public bool packed233_10 => ( packed233 & 0x10 ) == 0x10;
        public bool packed233_20 => ( packed233 & 0x20 ) == 0x20;
        public bool packed233_40 => ( packed233 & 0x40 ) == 0x40;
        public bool packed233_80 => ( packed233 & 0x80 ) == 0x80;

        // col: 480 offset: 0238
        public uint unknown238;

        // col: 608 offset: 023c
        public ushort unknown23c;

        // col: 416 offset: 0241
        public byte unknown241;

        // col: 544 offset: 0242
        public byte unknown242;

        // col: 672 offset: 0243
        private byte packed243;
        public bool packed243_1 => ( packed243 & 0x1 ) == 0x1;
        public bool packed243_2 => ( packed243 & 0x2 ) == 0x2;
        public bool packed243_4 => ( packed243 & 0x4 ) == 0x4;
        public bool packed243_8 => ( packed243 & 0x8 ) == 0x8;
        public bool packed243_10 => ( packed243 & 0x10 ) == 0x10;
        public bool packed243_20 => ( packed243 & 0x20 ) == 0x20;
        public bool packed243_40 => ( packed243 & 0x40 ) == 0x40;
        public bool packed243_80 => ( packed243 & 0x80 ) == 0x80;

        // col: 481 offset: 0248
        public uint unknown248;

        // col: 609 offset: 024c
        public ushort unknown24c;

        // col: 417 offset: 0251
        public byte unknown251;

        // col: 545 offset: 0252
        public byte unknown252;

        // col: 673 offset: 0253
        private byte packed253;
        public bool packed253_1 => ( packed253 & 0x1 ) == 0x1;
        public bool packed253_2 => ( packed253 & 0x2 ) == 0x2;
        public bool packed253_4 => ( packed253 & 0x4 ) == 0x4;
        public bool packed253_8 => ( packed253 & 0x8 ) == 0x8;
        public bool packed253_10 => ( packed253 & 0x10 ) == 0x10;
        public bool packed253_20 => ( packed253 & 0x20 ) == 0x20;
        public bool packed253_40 => ( packed253 & 0x40 ) == 0x40;
        public bool packed253_80 => ( packed253 & 0x80 ) == 0x80;

        // col: 482 offset: 0258
        public uint unknown258;

        // col: 610 offset: 025c
        public ushort unknown25c;

        // col: 418 offset: 0261
        public byte unknown261;

        // col: 546 offset: 0262
        public byte unknown262;

        // col: 674 offset: 0263
        private byte packed263;
        public bool packed263_1 => ( packed263 & 0x1 ) == 0x1;
        public bool packed263_2 => ( packed263 & 0x2 ) == 0x2;
        public bool packed263_4 => ( packed263 & 0x4 ) == 0x4;
        public bool packed263_8 => ( packed263 & 0x8 ) == 0x8;
        public bool packed263_10 => ( packed263 & 0x10 ) == 0x10;
        public bool packed263_20 => ( packed263 & 0x20 ) == 0x20;
        public bool packed263_40 => ( packed263 & 0x40 ) == 0x40;
        public bool packed263_80 => ( packed263 & 0x80 ) == 0x80;

        // col: 483 offset: 0268
        public uint unknown268;

        // col: 611 offset: 026c
        public ushort unknown26c;

        // col: 419 offset: 0271
        public byte unknown271;

        // col: 547 offset: 0272
        public byte unknown272;

        // col: 675 offset: 0273
        private byte packed273;
        public bool packed273_1 => ( packed273 & 0x1 ) == 0x1;
        public bool packed273_2 => ( packed273 & 0x2 ) == 0x2;
        public bool packed273_4 => ( packed273 & 0x4 ) == 0x4;
        public bool packed273_8 => ( packed273 & 0x8 ) == 0x8;
        public bool packed273_10 => ( packed273 & 0x10 ) == 0x10;
        public bool packed273_20 => ( packed273 & 0x20 ) == 0x20;
        public bool packed273_40 => ( packed273 & 0x40 ) == 0x40;
        public bool packed273_80 => ( packed273 & 0x80 ) == 0x80;

        // col: 484 offset: 0278
        public uint unknown278;

        // col: 612 offset: 027c
        public ushort unknown27c;

        // col: 420 offset: 0281
        public byte unknown281;

        // col: 548 offset: 0282
        public byte unknown282;

        // col: 676 offset: 0283
        private byte packed283;
        public bool packed283_1 => ( packed283 & 0x1 ) == 0x1;
        public bool packed283_2 => ( packed283 & 0x2 ) == 0x2;
        public bool packed283_4 => ( packed283 & 0x4 ) == 0x4;
        public bool packed283_8 => ( packed283 & 0x8 ) == 0x8;
        public bool packed283_10 => ( packed283 & 0x10 ) == 0x10;
        public bool packed283_20 => ( packed283 & 0x20 ) == 0x20;
        public bool packed283_40 => ( packed283 & 0x40 ) == 0x40;
        public bool packed283_80 => ( packed283 & 0x80 ) == 0x80;

        // col: 485 offset: 0288
        public uint unknown288;

        // col: 613 offset: 028c
        public ushort unknown28c;

        // col: 421 offset: 0291
        public byte unknown291;

        // col: 549 offset: 0292
        public byte unknown292;

        // col: 677 offset: 0293
        private byte packed293;
        public bool packed293_1 => ( packed293 & 0x1 ) == 0x1;
        public bool packed293_2 => ( packed293 & 0x2 ) == 0x2;
        public bool packed293_4 => ( packed293 & 0x4 ) == 0x4;
        public bool packed293_8 => ( packed293 & 0x8 ) == 0x8;
        public bool packed293_10 => ( packed293 & 0x10 ) == 0x10;
        public bool packed293_20 => ( packed293 & 0x20 ) == 0x20;
        public bool packed293_40 => ( packed293 & 0x40 ) == 0x40;
        public bool packed293_80 => ( packed293 & 0x80 ) == 0x80;

        // col: 486 offset: 0298
        public uint unknown298;

        // col: 614 offset: 029c
        public ushort unknown29c;

        // col: 422 offset: 02a1
        public byte unknown2a1;

        // col: 550 offset: 02a2
        public byte unknown2a2;

        // col: 678 offset: 02a3
        private byte packed2a3;
        public bool packed2a3_1 => ( packed2a3 & 0x1 ) == 0x1;
        public bool packed2a3_2 => ( packed2a3 & 0x2 ) == 0x2;
        public bool packed2a3_4 => ( packed2a3 & 0x4 ) == 0x4;
        public bool packed2a3_8 => ( packed2a3 & 0x8 ) == 0x8;
        public bool packed2a3_10 => ( packed2a3 & 0x10 ) == 0x10;
        public bool packed2a3_20 => ( packed2a3 & 0x20 ) == 0x20;
        public bool packed2a3_40 => ( packed2a3 & 0x40 ) == 0x40;
        public bool packed2a3_80 => ( packed2a3 & 0x80 ) == 0x80;

        // col: 487 offset: 02a8
        public uint unknown2a8;

        // col: 615 offset: 02ac
        public ushort unknown2ac;

        // col: 423 offset: 02b1
        public byte unknown2b1;

        // col: 551 offset: 02b2
        public byte unknown2b2;

        // col: 679 offset: 02b3
        private byte packed2b3;
        public bool packed2b3_1 => ( packed2b3 & 0x1 ) == 0x1;
        public bool packed2b3_2 => ( packed2b3 & 0x2 ) == 0x2;
        public bool packed2b3_4 => ( packed2b3 & 0x4 ) == 0x4;
        public bool packed2b3_8 => ( packed2b3 & 0x8 ) == 0x8;
        public bool packed2b3_10 => ( packed2b3 & 0x10 ) == 0x10;
        public bool packed2b3_20 => ( packed2b3 & 0x20 ) == 0x20;
        public bool packed2b3_40 => ( packed2b3 & 0x40 ) == 0x40;
        public bool packed2b3_80 => ( packed2b3 & 0x80 ) == 0x80;

        // col: 488 offset: 02b8
        public uint unknown2b8;

        // col: 616 offset: 02bc
        public ushort unknown2bc;

        // col: 424 offset: 02c1
        public byte unknown2c1;

        // col: 552 offset: 02c2
        public byte unknown2c2;

        // col: 680 offset: 02c3
        private byte packed2c3;
        public bool packed2c3_1 => ( packed2c3 & 0x1 ) == 0x1;
        public bool packed2c3_2 => ( packed2c3 & 0x2 ) == 0x2;
        public bool packed2c3_4 => ( packed2c3 & 0x4 ) == 0x4;
        public bool packed2c3_8 => ( packed2c3 & 0x8 ) == 0x8;
        public bool packed2c3_10 => ( packed2c3 & 0x10 ) == 0x10;
        public bool packed2c3_20 => ( packed2c3 & 0x20 ) == 0x20;
        public bool packed2c3_40 => ( packed2c3 & 0x40 ) == 0x40;
        public bool packed2c3_80 => ( packed2c3 & 0x80 ) == 0x80;

        // col: 489 offset: 02c8
        public uint unknown2c8;

        // col: 617 offset: 02cc
        public ushort unknown2cc;

        // col: 425 offset: 02d1
        public byte unknown2d1;

        // col: 553 offset: 02d2
        public byte unknown2d2;

        // col: 681 offset: 02d3
        private byte packed2d3;
        public bool packed2d3_1 => ( packed2d3 & 0x1 ) == 0x1;
        public bool packed2d3_2 => ( packed2d3 & 0x2 ) == 0x2;
        public bool packed2d3_4 => ( packed2d3 & 0x4 ) == 0x4;
        public bool packed2d3_8 => ( packed2d3 & 0x8 ) == 0x8;
        public bool packed2d3_10 => ( packed2d3 & 0x10 ) == 0x10;
        public bool packed2d3_20 => ( packed2d3 & 0x20 ) == 0x20;
        public bool packed2d3_40 => ( packed2d3 & 0x40 ) == 0x40;
        public bool packed2d3_80 => ( packed2d3 & 0x80 ) == 0x80;

        // col: 490 offset: 02d8
        public uint unknown2d8;

        // col: 618 offset: 02dc
        public ushort unknown2dc;

        // col: 426 offset: 02e1
        public byte unknown2e1;

        // col: 554 offset: 02e2
        public byte unknown2e2;

        // col: 682 offset: 02e3
        private byte packed2e3;
        public bool packed2e3_1 => ( packed2e3 & 0x1 ) == 0x1;
        public bool packed2e3_2 => ( packed2e3 & 0x2 ) == 0x2;
        public bool packed2e3_4 => ( packed2e3 & 0x4 ) == 0x4;
        public bool packed2e3_8 => ( packed2e3 & 0x8 ) == 0x8;
        public bool packed2e3_10 => ( packed2e3 & 0x10 ) == 0x10;
        public bool packed2e3_20 => ( packed2e3 & 0x20 ) == 0x20;
        public bool packed2e3_40 => ( packed2e3 & 0x40 ) == 0x40;
        public bool packed2e3_80 => ( packed2e3 & 0x80 ) == 0x80;

        // col: 491 offset: 02e8
        public uint unknown2e8;

        // col: 619 offset: 02ec
        public ushort unknown2ec;

        // col: 427 offset: 02f1
        public byte unknown2f1;

        // col: 555 offset: 02f2
        public byte unknown2f2;

        // col: 683 offset: 02f3
        private byte packed2f3;
        public bool packed2f3_1 => ( packed2f3 & 0x1 ) == 0x1;
        public bool packed2f3_2 => ( packed2f3 & 0x2 ) == 0x2;
        public bool packed2f3_4 => ( packed2f3 & 0x4 ) == 0x4;
        public bool packed2f3_8 => ( packed2f3 & 0x8 ) == 0x8;
        public bool packed2f3_10 => ( packed2f3 & 0x10 ) == 0x10;
        public bool packed2f3_20 => ( packed2f3 & 0x20 ) == 0x20;
        public bool packed2f3_40 => ( packed2f3 & 0x40 ) == 0x40;
        public bool packed2f3_80 => ( packed2f3 & 0x80 ) == 0x80;

        // col: 492 offset: 02f8
        public uint unknown2f8;

        // col: 620 offset: 02fc
        public ushort unknown2fc;

        // col: 428 offset: 0301
        public byte unknown301;

        // col: 556 offset: 0302
        public byte unknown302;

        // col: 684 offset: 0303
        private byte packed303;
        public bool packed303_1 => ( packed303 & 0x1 ) == 0x1;
        public bool packed303_2 => ( packed303 & 0x2 ) == 0x2;
        public bool packed303_4 => ( packed303 & 0x4 ) == 0x4;
        public bool packed303_8 => ( packed303 & 0x8 ) == 0x8;
        public bool packed303_10 => ( packed303 & 0x10 ) == 0x10;
        public bool packed303_20 => ( packed303 & 0x20 ) == 0x20;
        public bool packed303_40 => ( packed303 & 0x40 ) == 0x40;
        public bool packed303_80 => ( packed303 & 0x80 ) == 0x80;

        // col: 493 offset: 0308
        public uint unknown308;

        // col: 621 offset: 030c
        public ushort unknown30c;

        // col: 429 offset: 0311
        public byte unknown311;

        // col: 557 offset: 0312
        public byte unknown312;

        // col: 685 offset: 0313
        private byte packed313;
        public bool packed313_1 => ( packed313 & 0x1 ) == 0x1;
        public bool packed313_2 => ( packed313 & 0x2 ) == 0x2;
        public bool packed313_4 => ( packed313 & 0x4 ) == 0x4;
        public bool packed313_8 => ( packed313 & 0x8 ) == 0x8;
        public bool packed313_10 => ( packed313 & 0x10 ) == 0x10;
        public bool packed313_20 => ( packed313 & 0x20 ) == 0x20;
        public bool packed313_40 => ( packed313 & 0x40 ) == 0x40;
        public bool packed313_80 => ( packed313 & 0x80 ) == 0x80;

        // col: 494 offset: 0318
        public uint unknown318;

        // col: 622 offset: 031c
        public ushort unknown31c;

        // col: 430 offset: 0321
        public byte unknown321;

        // col: 558 offset: 0322
        public byte unknown322;

        // col: 686 offset: 0323
        private byte packed323;
        public bool packed323_1 => ( packed323 & 0x1 ) == 0x1;
        public bool packed323_2 => ( packed323 & 0x2 ) == 0x2;
        public bool packed323_4 => ( packed323 & 0x4 ) == 0x4;
        public bool packed323_8 => ( packed323 & 0x8 ) == 0x8;
        public bool packed323_10 => ( packed323 & 0x10 ) == 0x10;
        public bool packed323_20 => ( packed323 & 0x20 ) == 0x20;
        public bool packed323_40 => ( packed323 & 0x40 ) == 0x40;
        public bool packed323_80 => ( packed323 & 0x80 ) == 0x80;

        // col: 495 offset: 0328
        public uint unknown328;

        // col: 623 offset: 032c
        public ushort unknown32c;

        // col: 431 offset: 0331
        public byte unknown331;

        // col: 559 offset: 0332
        public byte unknown332;

        // col: 687 offset: 0333
        private byte packed333;
        public bool packed333_1 => ( packed333 & 0x1 ) == 0x1;
        public bool packed333_2 => ( packed333 & 0x2 ) == 0x2;
        public bool packed333_4 => ( packed333 & 0x4 ) == 0x4;
        public bool packed333_8 => ( packed333 & 0x8 ) == 0x8;
        public bool packed333_10 => ( packed333 & 0x10 ) == 0x10;
        public bool packed333_20 => ( packed333 & 0x20 ) == 0x20;
        public bool packed333_40 => ( packed333 & 0x40 ) == 0x40;
        public bool packed333_80 => ( packed333 & 0x80 ) == 0x80;

        // col: 496 offset: 0338
        public uint unknown338;

        // col: 624 offset: 033c
        public ushort unknown33c;

        // col: 432 offset: 0341
        public byte unknown341;

        // col: 560 offset: 0342
        public byte unknown342;

        // col: 688 offset: 0343
        private byte packed343;
        public bool packed343_1 => ( packed343 & 0x1 ) == 0x1;
        public bool packed343_2 => ( packed343 & 0x2 ) == 0x2;
        public bool packed343_4 => ( packed343 & 0x4 ) == 0x4;
        public bool packed343_8 => ( packed343 & 0x8 ) == 0x8;
        public bool packed343_10 => ( packed343 & 0x10 ) == 0x10;
        public bool packed343_20 => ( packed343 & 0x20 ) == 0x20;
        public bool packed343_40 => ( packed343 & 0x40 ) == 0x40;
        public bool packed343_80 => ( packed343 & 0x80 ) == 0x80;

        // col: 497 offset: 0348
        public uint unknown348;

        // col: 625 offset: 034c
        public ushort unknown34c;

        // col: 433 offset: 0351
        public byte unknown351;

        // col: 561 offset: 0352
        public byte unknown352;

        // col: 689 offset: 0353
        private byte packed353;
        public bool packed353_1 => ( packed353 & 0x1 ) == 0x1;
        public bool packed353_2 => ( packed353 & 0x2 ) == 0x2;
        public bool packed353_4 => ( packed353 & 0x4 ) == 0x4;
        public bool packed353_8 => ( packed353 & 0x8 ) == 0x8;
        public bool packed353_10 => ( packed353 & 0x10 ) == 0x10;
        public bool packed353_20 => ( packed353 & 0x20 ) == 0x20;
        public bool packed353_40 => ( packed353 & 0x40 ) == 0x40;
        public bool packed353_80 => ( packed353 & 0x80 ) == 0x80;

        // col: 498 offset: 0358
        public uint unknown358;

        // col: 626 offset: 035c
        public ushort unknown35c;

        // col: 434 offset: 0361
        public byte unknown361;

        // col: 562 offset: 0362
        public byte unknown362;

        // col: 690 offset: 0363
        private byte packed363;
        public bool packed363_1 => ( packed363 & 0x1 ) == 0x1;
        public bool packed363_2 => ( packed363 & 0x2 ) == 0x2;
        public bool packed363_4 => ( packed363 & 0x4 ) == 0x4;
        public bool packed363_8 => ( packed363 & 0x8 ) == 0x8;
        public bool packed363_10 => ( packed363 & 0x10 ) == 0x10;
        public bool packed363_20 => ( packed363 & 0x20 ) == 0x20;
        public bool packed363_40 => ( packed363 & 0x40 ) == 0x40;
        public bool packed363_80 => ( packed363 & 0x80 ) == 0x80;

        // col: 499 offset: 0368
        public uint unknown368;

        // col: 627 offset: 036c
        public ushort unknown36c;

        // col: 435 offset: 0371
        public byte unknown371;

        // col: 563 offset: 0372
        public byte unknown372;

        // col: 691 offset: 0373
        private byte packed373;
        public bool packed373_1 => ( packed373 & 0x1 ) == 0x1;
        public bool packed373_2 => ( packed373 & 0x2 ) == 0x2;
        public bool packed373_4 => ( packed373 & 0x4 ) == 0x4;
        public bool packed373_8 => ( packed373 & 0x8 ) == 0x8;
        public bool packed373_10 => ( packed373 & 0x10 ) == 0x10;
        public bool packed373_20 => ( packed373 & 0x20 ) == 0x20;
        public bool packed373_40 => ( packed373 & 0x40 ) == 0x40;
        public bool packed373_80 => ( packed373 & 0x80 ) == 0x80;

        // col: 500 offset: 0378
        public uint unknown378;

        // col: 628 offset: 037c
        public ushort unknown37c;

        // col: 436 offset: 0381
        public byte unknown381;

        // col: 564 offset: 0382
        public byte unknown382;

        // col: 692 offset: 0383
        private byte packed383;
        public bool packed383_1 => ( packed383 & 0x1 ) == 0x1;
        public bool packed383_2 => ( packed383 & 0x2 ) == 0x2;
        public bool packed383_4 => ( packed383 & 0x4 ) == 0x4;
        public bool packed383_8 => ( packed383 & 0x8 ) == 0x8;
        public bool packed383_10 => ( packed383 & 0x10 ) == 0x10;
        public bool packed383_20 => ( packed383 & 0x20 ) == 0x20;
        public bool packed383_40 => ( packed383 & 0x40 ) == 0x40;
        public bool packed383_80 => ( packed383 & 0x80 ) == 0x80;

        // col: 501 offset: 0388
        public uint unknown388;

        // col: 629 offset: 038c
        public ushort unknown38c;

        // col: 437 offset: 0391
        public byte unknown391;

        // col: 565 offset: 0392
        public byte unknown392;

        // col: 693 offset: 0393
        private byte packed393;
        public bool packed393_1 => ( packed393 & 0x1 ) == 0x1;
        public bool packed393_2 => ( packed393 & 0x2 ) == 0x2;
        public bool packed393_4 => ( packed393 & 0x4 ) == 0x4;
        public bool packed393_8 => ( packed393 & 0x8 ) == 0x8;
        public bool packed393_10 => ( packed393 & 0x10 ) == 0x10;
        public bool packed393_20 => ( packed393 & 0x20 ) == 0x20;
        public bool packed393_40 => ( packed393 & 0x40 ) == 0x40;
        public bool packed393_80 => ( packed393 & 0x80 ) == 0x80;

        // col: 502 offset: 0398
        public uint unknown398;

        // col: 630 offset: 039c
        public ushort unknown39c;

        // col: 374 offset: 03a0
        public byte[] QuestUInt8B;

        // col: 438 offset: 03a1
        public byte unknown3a1;

        // col: 566 offset: 03a2
        public byte unknown3a2;

        // col: 694 offset: 03a3
        private byte packed3a3;
        public bool packed3a3_1 => ( packed3a3 & 0x1 ) == 0x1;
        public bool packed3a3_2 => ( packed3a3 & 0x2 ) == 0x2;
        public bool packed3a3_4 => ( packed3a3 & 0x4 ) == 0x4;
        public bool packed3a3_8 => ( packed3a3 & 0x8 ) == 0x8;
        public bool packed3a3_10 => ( packed3a3 & 0x10 ) == 0x10;
        public bool packed3a3_20 => ( packed3a3 & 0x20 ) == 0x20;
        public bool packed3a3_40 => ( packed3a3 & 0x40 ) == 0x40;
        public bool packed3a3_80 => ( packed3a3 & 0x80 ) == 0x80;

        // col: 503 offset: 03a8
        public uint unknown3a8;

        // col: 631 offset: 03ac
        public ushort unknown3ac;

        // col: 439 offset: 03b1
        public byte unknown3b1;

        // col: 567 offset: 03b2
        public byte unknown3b2;

        // col: 695 offset: 03b3
        private byte packed3b3;
        public bool packed3b3_1 => ( packed3b3 & 0x1 ) == 0x1;
        public bool packed3b3_2 => ( packed3b3 & 0x2 ) == 0x2;
        public bool packed3b3_4 => ( packed3b3 & 0x4 ) == 0x4;
        public bool packed3b3_8 => ( packed3b3 & 0x8 ) == 0x8;
        public bool packed3b3_10 => ( packed3b3 & 0x10 ) == 0x10;
        public bool packed3b3_20 => ( packed3b3 & 0x20 ) == 0x20;
        public bool packed3b3_40 => ( packed3b3 & 0x40 ) == 0x40;
        public bool packed3b3_80 => ( packed3b3 & 0x80 ) == 0x80;

        // col: 504 offset: 03b8
        public uint unknown3b8;

        // col: 632 offset: 03bc
        public ushort unknown3bc;

        // col: 440 offset: 03c1
        public byte unknown3c1;

        // col: 568 offset: 03c2
        public byte unknown3c2;

        // col: 696 offset: 03c3
        private byte packed3c3;
        public bool packed3c3_1 => ( packed3c3 & 0x1 ) == 0x1;
        public bool packed3c3_2 => ( packed3c3 & 0x2 ) == 0x2;
        public bool packed3c3_4 => ( packed3c3 & 0x4 ) == 0x4;
        public bool packed3c3_8 => ( packed3c3 & 0x8 ) == 0x8;
        public bool packed3c3_10 => ( packed3c3 & 0x10 ) == 0x10;
        public bool packed3c3_20 => ( packed3c3 & 0x20 ) == 0x20;
        public bool packed3c3_40 => ( packed3c3 & 0x40 ) == 0x40;
        public bool packed3c3_80 => ( packed3c3 & 0x80 ) == 0x80;

        // col: 505 offset: 03c8
        public uint unknown3c8;

        // col: 633 offset: 03cc
        public ushort unknown3cc;

        // col: 441 offset: 03d1
        public byte unknown3d1;

        // col: 569 offset: 03d2
        public byte unknown3d2;

        // col: 697 offset: 03d3
        private byte packed3d3;
        public bool packed3d3_1 => ( packed3d3 & 0x1 ) == 0x1;
        public bool packed3d3_2 => ( packed3d3 & 0x2 ) == 0x2;
        public bool packed3d3_4 => ( packed3d3 & 0x4 ) == 0x4;
        public bool packed3d3_8 => ( packed3d3 & 0x8 ) == 0x8;
        public bool packed3d3_10 => ( packed3d3 & 0x10 ) == 0x10;
        public bool packed3d3_20 => ( packed3d3 & 0x20 ) == 0x20;
        public bool packed3d3_40 => ( packed3d3 & 0x40 ) == 0x40;
        public bool packed3d3_80 => ( packed3d3 & 0x80 ) == 0x80;

        // col: 506 offset: 03d8
        public uint unknown3d8;

        // col: 634 offset: 03dc
        public ushort unknown3dc;

        // col: 442 offset: 03e1
        public byte unknown3e1;

        // col: 570 offset: 03e2
        public byte unknown3e2;

        // col: 698 offset: 03e3
        private byte packed3e3;
        public bool packed3e3_1 => ( packed3e3 & 0x1 ) == 0x1;
        public bool packed3e3_2 => ( packed3e3 & 0x2 ) == 0x2;
        public bool packed3e3_4 => ( packed3e3 & 0x4 ) == 0x4;
        public bool packed3e3_8 => ( packed3e3 & 0x8 ) == 0x8;
        public bool packed3e3_10 => ( packed3e3 & 0x10 ) == 0x10;
        public bool packed3e3_20 => ( packed3e3 & 0x20 ) == 0x20;
        public bool packed3e3_40 => ( packed3e3 & 0x40 ) == 0x40;
        public bool packed3e3_80 => ( packed3e3 & 0x80 ) == 0x80;

        // col: 507 offset: 03e8
        public uint unknown3e8;

        // col: 635 offset: 03ec
        public ushort unknown3ec;

        // col: 443 offset: 03f1
        public byte unknown3f1;

        // col: 571 offset: 03f2
        public byte unknown3f2;

        // col: 699 offset: 03f3
        private byte packed3f3;
        public bool packed3f3_1 => ( packed3f3 & 0x1 ) == 0x1;
        public bool packed3f3_2 => ( packed3f3 & 0x2 ) == 0x2;
        public bool packed3f3_4 => ( packed3f3 & 0x4 ) == 0x4;
        public bool packed3f3_8 => ( packed3f3 & 0x8 ) == 0x8;
        public bool packed3f3_10 => ( packed3f3 & 0x10 ) == 0x10;
        public bool packed3f3_20 => ( packed3f3 & 0x20 ) == 0x20;
        public bool packed3f3_40 => ( packed3f3 & 0x40 ) == 0x40;
        public bool packed3f3_80 => ( packed3f3 & 0x80 ) == 0x80;

        // col: 508 offset: 03f8
        public uint unknown3f8;

        // col: 636 offset: 03fc
        public ushort unknown3fc;

        // col: 444 offset: 0401
        public byte unknown401;

        // col: 572 offset: 0402
        public byte unknown402;

        // col: 700 offset: 0403
        private byte packed403;
        public bool packed403_1 => ( packed403 & 0x1 ) == 0x1;
        public bool packed403_2 => ( packed403 & 0x2 ) == 0x2;
        public bool packed403_4 => ( packed403 & 0x4 ) == 0x4;
        public bool packed403_8 => ( packed403 & 0x8 ) == 0x8;
        public bool packed403_10 => ( packed403 & 0x10 ) == 0x10;
        public bool packed403_20 => ( packed403 & 0x20 ) == 0x20;
        public bool packed403_40 => ( packed403 & 0x40 ) == 0x40;
        public bool packed403_80 => ( packed403 & 0x80 ) == 0x80;

        // col: 509 offset: 0408
        public uint unknown408;

        // col: 637 offset: 040c
        public ushort unknown40c;

        // col: 445 offset: 0411
        public byte unknown411;

        // col: 573 offset: 0412
        public byte unknown412;

        // col: 701 offset: 0413
        private byte packed413;
        public bool packed413_1 => ( packed413 & 0x1 ) == 0x1;
        public bool packed413_2 => ( packed413 & 0x2 ) == 0x2;
        public bool packed413_4 => ( packed413 & 0x4 ) == 0x4;
        public bool packed413_8 => ( packed413 & 0x8 ) == 0x8;
        public bool packed413_10 => ( packed413 & 0x10 ) == 0x10;
        public bool packed413_20 => ( packed413 & 0x20 ) == 0x20;
        public bool packed413_40 => ( packed413 & 0x40 ) == 0x40;
        public bool packed413_80 => ( packed413 & 0x80 ) == 0x80;

        // col: 510 offset: 0418
        public uint unknown418;

        // col: 638 offset: 041c
        public ushort unknown41c;

        // col: 446 offset: 0421
        public byte unknown421;

        // col: 574 offset: 0422
        public byte unknown422;

        // col: 702 offset: 0423
        private byte packed423;
        public bool packed423_1 => ( packed423 & 0x1 ) == 0x1;
        public bool packed423_2 => ( packed423 & 0x2 ) == 0x2;
        public bool packed423_4 => ( packed423 & 0x4 ) == 0x4;
        public bool packed423_8 => ( packed423 & 0x8 ) == 0x8;
        public bool packed423_10 => ( packed423 & 0x10 ) == 0x10;
        public bool packed423_20 => ( packed423 & 0x20 ) == 0x20;
        public bool packed423_40 => ( packed423 & 0x40 ) == 0x40;
        public bool packed423_80 => ( packed423 & 0x80 ) == 0x80;

        // col: 511 offset: 0428
        public uint unknown428;

        // col: 639 offset: 042c
        public ushort unknown42c;

        // col: 447 offset: 0431
        public byte unknown431;

        // col: 575 offset: 0432
        public byte unknown432;

        // col: 703 offset: 0433
        private byte packed433;
        public bool packed433_1 => ( packed433 & 0x1 ) == 0x1;
        public bool packed433_2 => ( packed433 & 0x2 ) == 0x2;
        public bool packed433_4 => ( packed433 & 0x4 ) == 0x4;
        public bool packed433_8 => ( packed433 & 0x8 ) == 0x8;
        public bool packed433_10 => ( packed433 & 0x10 ) == 0x10;
        public bool packed433_20 => ( packed433 & 0x20 ) == 0x20;
        public bool packed433_40 => ( packed433 & 0x40 ) == 0x40;
        public bool packed433_80 => ( packed433 & 0x80 ) == 0x80;

        // col: 512 offset: 0438
        public uint unknown438;

        // col: 640 offset: 043c
        public ushort unknown43c;

        // col: 448 offset: 0441
        public byte unknown441;

        // col: 576 offset: 0442
        public byte unknown442;

        // col: 704 offset: 0443
        private byte packed443;
        public bool packed443_1 => ( packed443 & 0x1 ) == 0x1;
        public bool packed443_2 => ( packed443 & 0x2 ) == 0x2;
        public bool packed443_4 => ( packed443 & 0x4 ) == 0x4;
        public bool packed443_8 => ( packed443 & 0x8 ) == 0x8;
        public bool packed443_10 => ( packed443 & 0x10 ) == 0x10;
        public bool packed443_20 => ( packed443 & 0x20 ) == 0x20;
        public bool packed443_40 => ( packed443 & 0x40 ) == 0x40;
        public bool packed443_80 => ( packed443 & 0x80 ) == 0x80;

        // col: 513 offset: 0448
        public uint unknown448;

        // col: 641 offset: 044c
        public ushort unknown44c;

        // col: 449 offset: 0451
        public byte unknown451;

        // col: 577 offset: 0452
        public byte unknown452;

        // col: 705 offset: 0453
        private byte packed453;
        public bool packed453_1 => ( packed453 & 0x1 ) == 0x1;
        public bool packed453_2 => ( packed453 & 0x2 ) == 0x2;
        public bool packed453_4 => ( packed453 & 0x4 ) == 0x4;
        public bool packed453_8 => ( packed453 & 0x8 ) == 0x8;
        public bool packed453_10 => ( packed453 & 0x10 ) == 0x10;
        public bool packed453_20 => ( packed453 & 0x20 ) == 0x20;
        public bool packed453_40 => ( packed453 & 0x40 ) == 0x40;
        public bool packed453_80 => ( packed453 & 0x80 ) == 0x80;

        // col: 514 offset: 0458
        public uint unknown458;

        // col: 642 offset: 045c
        public ushort unknown45c;

        // col: 450 offset: 0461
        public byte unknown461;

        // col: 578 offset: 0462
        public byte unknown462;

        // col: 706 offset: 0463
        private byte packed463;
        public bool packed463_1 => ( packed463 & 0x1 ) == 0x1;
        public bool packed463_2 => ( packed463 & 0x2 ) == 0x2;
        public bool packed463_4 => ( packed463 & 0x4 ) == 0x4;
        public bool packed463_8 => ( packed463 & 0x8 ) == 0x8;
        public bool packed463_10 => ( packed463 & 0x10 ) == 0x10;
        public bool packed463_20 => ( packed463 & 0x20 ) == 0x20;
        public bool packed463_40 => ( packed463 & 0x40 ) == 0x40;
        public bool packed463_80 => ( packed463 & 0x80 ) == 0x80;

        // col: 515 offset: 0468
        public uint unknown468;

        // col: 643 offset: 046c
        public ushort unknown46c;

        // col: 451 offset: 0471
        public byte unknown471;

        // col: 579 offset: 0472
        public byte unknown472;

        // col: 707 offset: 0473
        private byte packed473;
        public bool packed473_1 => ( packed473 & 0x1 ) == 0x1;
        public bool packed473_2 => ( packed473 & 0x2 ) == 0x2;
        public bool packed473_4 => ( packed473 & 0x4 ) == 0x4;
        public bool packed473_8 => ( packed473 & 0x8 ) == 0x8;
        public bool packed473_10 => ( packed473 & 0x10 ) == 0x10;
        public bool packed473_20 => ( packed473 & 0x20 ) == 0x20;
        public bool packed473_40 => ( packed473 & 0x40 ) == 0x40;
        public bool packed473_80 => ( packed473 & 0x80 ) == 0x80;

        // col: 516 offset: 0478
        public uint unknown478;

        // col: 644 offset: 047c
        public ushort unknown47c;

        // col: 452 offset: 0481
        public byte unknown481;

        // col: 580 offset: 0482
        public byte unknown482;

        // col: 708 offset: 0483
        private byte packed483;
        public bool packed483_1 => ( packed483 & 0x1 ) == 0x1;
        public bool packed483_2 => ( packed483 & 0x2 ) == 0x2;
        public bool packed483_4 => ( packed483 & 0x4 ) == 0x4;
        public bool packed483_8 => ( packed483 & 0x8 ) == 0x8;
        public bool packed483_10 => ( packed483 & 0x10 ) == 0x10;
        public bool packed483_20 => ( packed483 & 0x20 ) == 0x20;
        public bool packed483_40 => ( packed483 & 0x40 ) == 0x40;
        public bool packed483_80 => ( packed483 & 0x80 ) == 0x80;

        // col: 517 offset: 0488
        public uint unknown488;

        // col: 645 offset: 048c
        public ushort unknown48c;

        // col: 453 offset: 0491
        public byte unknown491;

        // col: 581 offset: 0492
        public byte unknown492;

        // col: 709 offset: 0493
        private byte packed493;
        public bool packed493_1 => ( packed493 & 0x1 ) == 0x1;
        public bool packed493_2 => ( packed493 & 0x2 ) == 0x2;
        public bool packed493_4 => ( packed493 & 0x4 ) == 0x4;
        public bool packed493_8 => ( packed493 & 0x8 ) == 0x8;
        public bool packed493_10 => ( packed493 & 0x10 ) == 0x10;
        public bool packed493_20 => ( packed493 & 0x20 ) == 0x20;
        public bool packed493_40 => ( packed493 & 0x40 ) == 0x40;
        public bool packed493_80 => ( packed493 & 0x80 ) == 0x80;

        // col: 518 offset: 0498
        public uint unknown498;

        // col: 646 offset: 049c
        public ushort unknown49c;

        // col: 454 offset: 04a1
        public byte unknown4a1;

        // col: 582 offset: 04a2
        public byte unknown4a2;

        // col: 710 offset: 04a3
        private byte packed4a3;
        public bool packed4a3_1 => ( packed4a3 & 0x1 ) == 0x1;
        public bool packed4a3_2 => ( packed4a3 & 0x2 ) == 0x2;
        public bool packed4a3_4 => ( packed4a3 & 0x4 ) == 0x4;
        public bool packed4a3_8 => ( packed4a3 & 0x8 ) == 0x8;
        public bool packed4a3_10 => ( packed4a3 & 0x10 ) == 0x10;
        public bool packed4a3_20 => ( packed4a3 & 0x20 ) == 0x20;
        public bool packed4a3_40 => ( packed4a3 & 0x40 ) == 0x40;
        public bool packed4a3_80 => ( packed4a3 & 0x80 ) == 0x80;

        // col: 519 offset: 04a8
        public uint unknown4a8;

        // col: 647 offset: 04ac
        public ushort unknown4ac;

        // col: 455 offset: 04b1
        public byte unknown4b1;

        // col: 583 offset: 04b2
        public byte unknown4b2;

        // col: 711 offset: 04b3
        private byte packed4b3;
        public bool packed4b3_1 => ( packed4b3 & 0x1 ) == 0x1;
        public bool packed4b3_2 => ( packed4b3 & 0x2 ) == 0x2;
        public bool packed4b3_4 => ( packed4b3 & 0x4 ) == 0x4;
        public bool packed4b3_8 => ( packed4b3 & 0x8 ) == 0x8;
        public bool packed4b3_10 => ( packed4b3 & 0x10 ) == 0x10;
        public bool packed4b3_20 => ( packed4b3 & 0x20 ) == 0x20;
        public bool packed4b3_40 => ( packed4b3 & 0x40 ) == 0x40;
        public bool packed4b3_80 => ( packed4b3 & 0x80 ) == 0x80;

        // col: 520 offset: 04b8
        public uint unknown4b8;

        // col: 648 offset: 04bc
        public ushort unknown4bc;

        // col: 456 offset: 04c1
        public byte unknown4c1;

        // col: 584 offset: 04c2
        public byte unknown4c2;

        // col: 712 offset: 04c3
        private byte packed4c3;
        public bool packed4c3_1 => ( packed4c3 & 0x1 ) == 0x1;
        public bool packed4c3_2 => ( packed4c3 & 0x2 ) == 0x2;
        public bool packed4c3_4 => ( packed4c3 & 0x4 ) == 0x4;
        public bool packed4c3_8 => ( packed4c3 & 0x8 ) == 0x8;
        public bool packed4c3_10 => ( packed4c3 & 0x10 ) == 0x10;
        public bool packed4c3_20 => ( packed4c3 & 0x20 ) == 0x20;
        public bool packed4c3_40 => ( packed4c3 & 0x40 ) == 0x40;
        public bool packed4c3_80 => ( packed4c3 & 0x80 ) == 0x80;

        // col: 521 offset: 04c8
        public uint unknown4c8;

        // col: 649 offset: 04cc
        public ushort unknown4cc;

        // col: 457 offset: 04d1
        public byte unknown4d1;

        // col: 585 offset: 04d2
        public byte unknown4d2;

        // col: 713 offset: 04d3
        private byte packed4d3;
        public bool packed4d3_1 => ( packed4d3 & 0x1 ) == 0x1;
        public bool packed4d3_2 => ( packed4d3 & 0x2 ) == 0x2;
        public bool packed4d3_4 => ( packed4d3 & 0x4 ) == 0x4;
        public bool packed4d3_8 => ( packed4d3 & 0x8 ) == 0x8;
        public bool packed4d3_10 => ( packed4d3 & 0x10 ) == 0x10;
        public bool packed4d3_20 => ( packed4d3 & 0x20 ) == 0x20;
        public bool packed4d3_40 => ( packed4d3 & 0x40 ) == 0x40;
        public bool packed4d3_80 => ( packed4d3 & 0x80 ) == 0x80;

        // col: 522 offset: 04d8
        public uint unknown4d8;

        // col: 650 offset: 04dc
        public ushort unknown4dc;

        // col: 458 offset: 04e1
        public byte unknown4e1;

        // col: 586 offset: 04e2
        public byte unknown4e2;

        // col: 714 offset: 04e3
        private byte packed4e3;
        public bool packed4e3_1 => ( packed4e3 & 0x1 ) == 0x1;
        public bool packed4e3_2 => ( packed4e3 & 0x2 ) == 0x2;
        public bool packed4e3_4 => ( packed4e3 & 0x4 ) == 0x4;
        public bool packed4e3_8 => ( packed4e3 & 0x8 ) == 0x8;
        public bool packed4e3_10 => ( packed4e3 & 0x10 ) == 0x10;
        public bool packed4e3_20 => ( packed4e3 & 0x20 ) == 0x20;
        public bool packed4e3_40 => ( packed4e3 & 0x40 ) == 0x40;
        public bool packed4e3_80 => ( packed4e3 & 0x80 ) == 0x80;

        // col: 523 offset: 04e8
        public uint unknown4e8;

        // col: 651 offset: 04ec
        public ushort unknown4ec;

        // col: 459 offset: 04f1
        public byte unknown4f1;

        // col: 587 offset: 04f2
        public byte unknown4f2;

        // col: 715 offset: 04f3
        private byte packed4f3;
        public bool packed4f3_1 => ( packed4f3 & 0x1 ) == 0x1;
        public bool packed4f3_2 => ( packed4f3 & 0x2 ) == 0x2;
        public bool packed4f3_4 => ( packed4f3 & 0x4 ) == 0x4;
        public bool packed4f3_8 => ( packed4f3 & 0x8 ) == 0x8;
        public bool packed4f3_10 => ( packed4f3 & 0x10 ) == 0x10;
        public bool packed4f3_20 => ( packed4f3 & 0x20 ) == 0x20;
        public bool packed4f3_40 => ( packed4f3 & 0x40 ) == 0x40;
        public bool packed4f3_80 => ( packed4f3 & 0x80 ) == 0x80;

        // col: 524 offset: 04f8
        public uint unknown4f8;

        // col: 652 offset: 04fc
        public ushort unknown4fc;

        // col: 460 offset: 0501
        public byte unknown501;

        // col: 588 offset: 0502
        public byte unknown502;

        // col: 716 offset: 0503
        private byte packed503;
        public bool packed503_1 => ( packed503 & 0x1 ) == 0x1;
        public bool packed503_2 => ( packed503 & 0x2 ) == 0x2;
        public bool packed503_4 => ( packed503 & 0x4 ) == 0x4;
        public bool packed503_8 => ( packed503 & 0x8 ) == 0x8;
        public bool packed503_10 => ( packed503 & 0x10 ) == 0x10;
        public bool packed503_20 => ( packed503 & 0x20 ) == 0x20;
        public bool packed503_40 => ( packed503 & 0x40 ) == 0x40;
        public bool packed503_80 => ( packed503 & 0x80 ) == 0x80;

        // col: 525 offset: 0508
        public uint unknown508;

        // col: 653 offset: 050c
        public ushort unknown50c;

        // col: 461 offset: 0511
        public byte unknown511;

        // col: 589 offset: 0512
        public byte unknown512;

        // col: 717 offset: 0513
        private byte packed513;
        public bool packed513_1 => ( packed513 & 0x1 ) == 0x1;
        public bool packed513_2 => ( packed513 & 0x2 ) == 0x2;
        public bool packed513_4 => ( packed513 & 0x4 ) == 0x4;
        public bool packed513_8 => ( packed513 & 0x8 ) == 0x8;
        public bool packed513_10 => ( packed513 & 0x10 ) == 0x10;
        public bool packed513_20 => ( packed513 & 0x20 ) == 0x20;
        public bool packed513_40 => ( packed513 & 0x40 ) == 0x40;
        public bool packed513_80 => ( packed513 & 0x80 ) == 0x80;

        // col: 526 offset: 0518
        public uint unknown518;

        // col: 654 offset: 051c
        public ushort unknown51c;

        // col: 462 offset: 0521
        public byte unknown521;

        // col: 590 offset: 0522
        public byte unknown522;

        // col: 718 offset: 0523
        private byte packed523;
        public bool packed523_1 => ( packed523 & 0x1 ) == 0x1;
        public bool packed523_2 => ( packed523 & 0x2 ) == 0x2;
        public bool packed523_4 => ( packed523 & 0x4 ) == 0x4;
        public bool packed523_8 => ( packed523 & 0x8 ) == 0x8;
        public bool packed523_10 => ( packed523 & 0x10 ) == 0x10;
        public bool packed523_20 => ( packed523 & 0x20 ) == 0x20;
        public bool packed523_40 => ( packed523 & 0x40 ) == 0x40;
        public bool packed523_80 => ( packed523 & 0x80 ) == 0x80;

        // col: 527 offset: 0528
        public uint unknown528;

        // col: 655 offset: 052c
        public ushort unknown52c;

        // col: 463 offset: 0531
        public byte unknown531;

        // col: 591 offset: 0532
        public byte unknown532;

        // col: 719 offset: 0533
        private byte packed533;
        public bool packed533_1 => ( packed533 & 0x1 ) == 0x1;
        public bool packed533_2 => ( packed533 & 0x2 ) == 0x2;
        public bool packed533_4 => ( packed533 & 0x4 ) == 0x4;
        public bool packed533_8 => ( packed533 & 0x8 ) == 0x8;
        public bool packed533_10 => ( packed533 & 0x10 ) == 0x10;
        public bool packed533_20 => ( packed533 & 0x20 ) == 0x20;
        public bool packed533_40 => ( packed533 & 0x40 ) == 0x40;
        public bool packed533_80 => ( packed533 & 0x80 ) == 0x80;

        // col: 528 offset: 0538
        public uint unknown538;

        // col: 656 offset: 053c
        public ushort unknown53c;

        // col: 464 offset: 0541
        public byte unknown541;

        // col: 592 offset: 0542
        public byte unknown542;

        // col: 720 offset: 0543
        private byte packed543;
        public bool packed543_1 => ( packed543 & 0x1 ) == 0x1;
        public bool packed543_2 => ( packed543 & 0x2 ) == 0x2;
        public bool packed543_4 => ( packed543 & 0x4 ) == 0x4;
        public bool packed543_8 => ( packed543 & 0x8 ) == 0x8;
        public bool packed543_10 => ( packed543 & 0x10 ) == 0x10;
        public bool packed543_20 => ( packed543 & 0x20 ) == 0x20;
        public bool packed543_40 => ( packed543 & 0x40 ) == 0x40;
        public bool packed543_80 => ( packed543 & 0x80 ) == 0x80;

        // col: 529 offset: 0548
        public uint unknown548;

        // col: 657 offset: 054c
        public ushort unknown54c;

        // col: 465 offset: 0551
        public byte unknown551;

        // col: 593 offset: 0552
        public byte unknown552;

        // col: 721 offset: 0553
        private byte packed553;
        public bool packed553_1 => ( packed553 & 0x1 ) == 0x1;
        public bool packed553_2 => ( packed553 & 0x2 ) == 0x2;
        public bool packed553_4 => ( packed553 & 0x4 ) == 0x4;
        public bool packed553_8 => ( packed553 & 0x8 ) == 0x8;
        public bool packed553_10 => ( packed553 & 0x10 ) == 0x10;
        public bool packed553_20 => ( packed553 & 0x20 ) == 0x20;
        public bool packed553_40 => ( packed553 & 0x40 ) == 0x40;
        public bool packed553_80 => ( packed553 & 0x80 ) == 0x80;

        // col: 530 offset: 0558
        public uint unknown558;

        // col: 658 offset: 055c
        public ushort unknown55c;

        // col: 466 offset: 0561
        public byte unknown561;

        // col: 594 offset: 0562
        public byte unknown562;

        // col: 722 offset: 0563
        private byte packed563;
        public bool packed563_1 => ( packed563 & 0x1 ) == 0x1;
        public bool packed563_2 => ( packed563 & 0x2 ) == 0x2;
        public bool packed563_4 => ( packed563 & 0x4 ) == 0x4;
        public bool packed563_8 => ( packed563 & 0x8 ) == 0x8;
        public bool packed563_10 => ( packed563 & 0x10 ) == 0x10;
        public bool packed563_20 => ( packed563 & 0x20 ) == 0x20;
        public bool packed563_40 => ( packed563 & 0x40 ) == 0x40;
        public bool packed563_80 => ( packed563 & 0x80 ) == 0x80;

        // col: 531 offset: 0568
        public uint unknown568;

        // col: 659 offset: 056c
        public ushort unknown56c;

        // col: 467 offset: 0571
        public byte unknown571;

        // col: 595 offset: 0572
        public byte unknown572;

        // col: 723 offset: 0573
        private byte packed573;
        public bool packed573_1 => ( packed573 & 0x1 ) == 0x1;
        public bool packed573_2 => ( packed573 & 0x2 ) == 0x2;
        public bool packed573_4 => ( packed573 & 0x4 ) == 0x4;
        public bool packed573_8 => ( packed573 & 0x8 ) == 0x8;
        public bool packed573_10 => ( packed573 & 0x10 ) == 0x10;
        public bool packed573_20 => ( packed573 & 0x20 ) == 0x20;
        public bool packed573_40 => ( packed573 & 0x40 ) == 0x40;
        public bool packed573_80 => ( packed573 & 0x80 ) == 0x80;

        // col: 532 offset: 0578
        public uint unknown578;

        // col: 660 offset: 057c
        public ushort unknown57c;

        // col: 468 offset: 0581
        public byte unknown581;

        // col: 596 offset: 0582
        public byte unknown582;

        // col: 724 offset: 0583
        private byte packed583;
        public bool packed583_1 => ( packed583 & 0x1 ) == 0x1;
        public bool packed583_2 => ( packed583 & 0x2 ) == 0x2;
        public bool packed583_4 => ( packed583 & 0x4 ) == 0x4;
        public bool packed583_8 => ( packed583 & 0x8 ) == 0x8;
        public bool packed583_10 => ( packed583 & 0x10 ) == 0x10;
        public bool packed583_20 => ( packed583 & 0x20 ) == 0x20;
        public bool packed583_40 => ( packed583 & 0x40 ) == 0x40;
        public bool packed583_80 => ( packed583 & 0x80 ) == 0x80;

        // col: 533 offset: 0588
        public uint unknown588;

        // col: 661 offset: 058c
        public ushort unknown58c;

        // col: 469 offset: 0591
        public byte unknown591;

        // col: 597 offset: 0592
        public byte unknown592;

        // col: 725 offset: 0593
        private byte packed593;
        public bool packed593_1 => ( packed593 & 0x1 ) == 0x1;
        public bool packed593_2 => ( packed593 & 0x2 ) == 0x2;
        public bool packed593_4 => ( packed593 & 0x4 ) == 0x4;
        public bool packed593_8 => ( packed593 & 0x8 ) == 0x8;
        public bool packed593_10 => ( packed593 & 0x10 ) == 0x10;
        public bool packed593_20 => ( packed593 & 0x20 ) == 0x20;
        public bool packed593_40 => ( packed593 & 0x40 ) == 0x40;
        public bool packed593_80 => ( packed593 & 0x80 ) == 0x80;

        // col: 1222 offset: 0594
        public uint[] ToDoMainLocation;

        // col: 1246 offset: 0598
        public uint[] unknown598;

        // col: 1270 offset: 059c
        public uint unknown59c;

        // col: 1294 offset: 05a0
        public uint unknown5a0;

        // col: 1318 offset: 05a4
        public uint unknown5a4;

        // col: 1342 offset: 05a8
        public uint unknown5a8;

        // col: 1366 offset: 05ac
        public uint unknown5ac;

        // col: 1390 offset: 05b0
        public uint unknown5b0;

        // col: 1174 offset: 05b4
        public byte[] ToDoCompleteSeq;

        // col: 1198 offset: 05b5
        public byte[] ToDoQty;

        // col: 1414 offset: 05b6
        public byte unknown5b6;

        // col: 1271 offset: 05c0
        public uint unknown5c0;

        // col: 1295 offset: 05c4
        public uint unknown5c4;

        // col: 1319 offset: 05c8
        public uint unknown5c8;

        // col: 1343 offset: 05cc
        public uint unknown5cc;

        // col: 1367 offset: 05d0
        public uint unknown5d0;

        // col: 1391 offset: 05d4
        public uint unknown5d4;

        // col: 1415 offset: 05da
        public byte unknown5da;

        // col: 1272 offset: 05e4
        public uint unknown5e4;

        // col: 1296 offset: 05e8
        public uint unknown5e8;

        // col: 1320 offset: 05ec
        public uint unknown5ec;

        // col: 1344 offset: 05f0
        public uint unknown5f0;

        // col: 1368 offset: 05f4
        public uint unknown5f4;

        // col: 1392 offset: 05f8
        public uint unknown5f8;

        // col: 1416 offset: 05fe
        public byte unknown5fe;

        // col: 1273 offset: 0608
        public uint unknown608;

        // col: 1297 offset: 060c
        public uint unknown60c;

        // col: 1321 offset: 0610
        public uint unknown610;

        // col: 1345 offset: 0614
        public uint unknown614;

        // col: 1369 offset: 0618
        public uint unknown618;

        // col: 1393 offset: 061c
        public uint unknown61c;

        // col: 1417 offset: 0622
        public byte unknown622;

        // col: 1274 offset: 062c
        public uint unknown62c;

        // col: 1298 offset: 0630
        public uint unknown630;

        // col: 1322 offset: 0634
        public uint unknown634;

        // col: 1346 offset: 0638
        public uint unknown638;

        // col: 1370 offset: 063c
        public uint unknown63c;

        // col: 1394 offset: 0640
        public uint unknown640;

        // col: 1418 offset: 0646
        public byte unknown646;

        // col: 1275 offset: 0650
        public uint unknown650;

        // col: 1299 offset: 0654
        public uint unknown654;

        // col: 1323 offset: 0658
        public uint unknown658;

        // col: 1347 offset: 065c
        public uint unknown65c;

        // col: 1371 offset: 0660
        public uint unknown660;

        // col: 1395 offset: 0664
        public uint unknown664;

        // col: 1419 offset: 066a
        public byte unknown66a;

        // col: 1276 offset: 0674
        public uint unknown674;

        // col: 1300 offset: 0678
        public uint unknown678;

        // col: 1324 offset: 067c
        public uint unknown67c;

        // col: 1348 offset: 0680
        public uint unknown680;

        // col: 1372 offset: 0684
        public uint unknown684;

        // col: 1396 offset: 0688
        public uint unknown688;

        // col: 1420 offset: 068e
        public byte unknown68e;

        // col: 1253 offset: 0694
        public uint unknown694;

        // col: 1277 offset: 0698
        public uint unknown698;

        // col: 1301 offset: 069c
        public uint unknown69c;

        // col: 1325 offset: 06a0
        public uint unknown6a0;

        // col: 1349 offset: 06a4
        public uint unknown6a4;

        // col: 1373 offset: 06a8
        public uint unknown6a8;

        // col: 1397 offset: 06ac
        public uint unknown6ac;

        // col: 1421 offset: 06b2
        public byte unknown6b2;

        // col: 1254 offset: 06b8
        public uint unknown6b8;

        // col: 1278 offset: 06bc
        public uint unknown6bc;

        // col: 1302 offset: 06c0
        public uint unknown6c0;

        // col: 1326 offset: 06c4
        public uint unknown6c4;

        // col: 1350 offset: 06c8
        public uint unknown6c8;

        // col: 1374 offset: 06cc
        public uint unknown6cc;

        // col: 1398 offset: 06d0
        public uint unknown6d0;

        // col: 1422 offset: 06d6
        public byte unknown6d6;

        // col: 1255 offset: 06dc
        public uint unknown6dc;

        // col: 1279 offset: 06e0
        public uint unknown6e0;

        // col: 1303 offset: 06e4
        public uint unknown6e4;

        // col: 1327 offset: 06e8
        public uint unknown6e8;

        // col: 1351 offset: 06ec
        public uint unknown6ec;

        // col: 1375 offset: 06f0
        public uint unknown6f0;

        // col: 1399 offset: 06f4
        public uint unknown6f4;

        // col: 1423 offset: 06fa
        public byte unknown6fa;

        // col: 1256 offset: 0700
        public uint unknown700;

        // col: 1280 offset: 0704
        public uint unknown704;

        // col: 1304 offset: 0708
        public uint unknown708;

        // col: 1328 offset: 070c
        public uint unknown70c;

        // col: 1352 offset: 0710
        public uint unknown710;

        // col: 1376 offset: 0714
        public uint unknown714;

        // col: 1400 offset: 0718
        public uint unknown718;

        // col: 1424 offset: 071e
        public byte unknown71e;

        // col: 1257 offset: 0724
        public uint unknown724;

        // col: 1281 offset: 0728
        public uint unknown728;

        // col: 1305 offset: 072c
        public uint unknown72c;

        // col: 1329 offset: 0730
        public uint unknown730;

        // col: 1353 offset: 0734
        public uint unknown734;

        // col: 1377 offset: 0738
        public uint unknown738;

        // col: 1401 offset: 073c
        public uint unknown73c;

        // col: 1425 offset: 0742
        public byte unknown742;

        // col: 1258 offset: 0748
        public uint unknown748;

        // col: 1282 offset: 074c
        public uint unknown74c;

        // col: 1306 offset: 0750
        public uint unknown750;

        // col: 1330 offset: 0754
        public uint unknown754;

        // col: 1354 offset: 0758
        public uint unknown758;

        // col: 1378 offset: 075c
        public uint unknown75c;

        // col: 1402 offset: 0760
        public uint unknown760;

        // col: 1426 offset: 0766
        public byte unknown766;

        // col: 1259 offset: 076c
        public uint unknown76c;

        // col: 1283 offset: 0770
        public uint unknown770;

        // col: 1307 offset: 0774
        public uint unknown774;

        // col: 1331 offset: 0778
        public uint unknown778;

        // col: 1355 offset: 077c
        public uint unknown77c;

        // col: 1379 offset: 0780
        public uint unknown780;

        // col: 1403 offset: 0784
        public uint unknown784;

        // col: 1427 offset: 078a
        public byte unknown78a;

        // col: 1260 offset: 0790
        public uint unknown790;

        // col: 1284 offset: 0794
        public uint unknown794;

        // col: 1308 offset: 0798
        public uint unknown798;

        // col: 1332 offset: 079c
        public uint unknown79c;

        // col: 1356 offset: 07a0
        public uint unknown7a0;

        // col: 1380 offset: 07a4
        public uint unknown7a4;

        // col: 1404 offset: 07a8
        public uint unknown7a8;

        // col: 1428 offset: 07ae
        public byte unknown7ae;

        // col: 1261 offset: 07b4
        public uint unknown7b4;

        // col: 1285 offset: 07b8
        public uint unknown7b8;

        // col: 1309 offset: 07bc
        public uint unknown7bc;

        // col: 1333 offset: 07c0
        public uint unknown7c0;

        // col: 1357 offset: 07c4
        public uint unknown7c4;

        // col: 1381 offset: 07c8
        public uint unknown7c8;

        // col: 1405 offset: 07cc
        public uint unknown7cc;

        // col: 1429 offset: 07d2
        public byte unknown7d2;

        // col: 1262 offset: 07d8
        public uint unknown7d8;

        // col: 1286 offset: 07dc
        public uint unknown7dc;

        // col: 1310 offset: 07e0
        public uint unknown7e0;

        // col: 1334 offset: 07e4
        public uint unknown7e4;

        // col: 1358 offset: 07e8
        public uint unknown7e8;

        // col: 1382 offset: 07ec
        public uint unknown7ec;

        // col: 1406 offset: 07f0
        public uint unknown7f0;

        // col: 1430 offset: 07f6
        public byte unknown7f6;

        // col: 1263 offset: 07fc
        public uint unknown7fc;

        // col: 1287 offset: 0800
        public uint unknown800;

        // col: 1311 offset: 0804
        public uint unknown804;

        // col: 1335 offset: 0808
        public uint unknown808;

        // col: 1359 offset: 080c
        public uint unknown80c;

        // col: 1383 offset: 0810
        public uint unknown810;

        // col: 1407 offset: 0814
        public uint unknown814;

        // col: 1431 offset: 081a
        public byte unknown81a;

        // col: 1264 offset: 0820
        public uint unknown820;

        // col: 1288 offset: 0824
        public uint unknown824;

        // col: 1312 offset: 0828
        public uint unknown828;

        // col: 1336 offset: 082c
        public uint unknown82c;

        // col: 1360 offset: 0830
        public uint unknown830;

        // col: 1384 offset: 0834
        public uint unknown834;

        // col: 1408 offset: 0838
        public uint unknown838;

        // col: 1432 offset: 083e
        public byte unknown83e;

        // col: 1265 offset: 0844
        public uint unknown844;

        // col: 1289 offset: 0848
        public uint unknown848;

        // col: 1313 offset: 084c
        public uint unknown84c;

        // col: 1337 offset: 0850
        public uint unknown850;

        // col: 1361 offset: 0854
        public uint unknown854;

        // col: 1385 offset: 0858
        public uint unknown858;

        // col: 1409 offset: 085c
        public uint unknown85c;

        // col: 1433 offset: 0862
        public byte unknown862;

        // col: 1266 offset: 0868
        public uint unknown868;

        // col: 1290 offset: 086c
        public uint unknown86c;

        // col: 1314 offset: 0870
        public uint unknown870;

        // col: 1338 offset: 0874
        public uint unknown874;

        // col: 1362 offset: 0878
        public uint unknown878;

        // col: 1386 offset: 087c
        public uint unknown87c;

        // col: 1410 offset: 0880
        public uint unknown880;

        // col: 1434 offset: 0886
        public byte unknown886;

        // col: 1267 offset: 088c
        public uint unknown88c;

        // col: 1291 offset: 0890
        public uint unknown890;

        // col: 1315 offset: 0894
        public uint unknown894;

        // col: 1339 offset: 0898
        public uint unknown898;

        // col: 1363 offset: 089c
        public uint unknown89c;

        // col: 1387 offset: 08a0
        public uint unknown8a0;

        // col: 1411 offset: 08a4
        public uint unknown8a4;

        // col: 1435 offset: 08aa
        public byte unknown8aa;

        // col: 1268 offset: 08b0
        public uint unknown8b0;

        // col: 1292 offset: 08b4
        public uint unknown8b4;

        // col: 1316 offset: 08b8
        public uint unknown8b8;

        // col: 1340 offset: 08bc
        public uint unknown8bc;

        // col: 1364 offset: 08c0
        public uint unknown8c0;

        // col: 1388 offset: 08c4
        public uint unknown8c4;

        // col: 1412 offset: 08c8
        public uint unknown8c8;

        // col: 1436 offset: 08ce
        public byte unknown8ce;

        // col: 1269 offset: 08d4
        public uint unknown8d4;

        // col: 1293 offset: 08d8
        public uint unknown8d8;

        // col: 1317 offset: 08dc
        public uint unknown8dc;

        // col: 1341 offset: 08e0
        public uint unknown8e0;

        // col: 1365 offset: 08e4
        public uint unknown8e4;

        // col: 1389 offset: 08e8
        public uint unknown8e8;

        // col: 1413 offset: 08ec
        public uint unknown8ec;

        // col: 1437 offset: 08f2
        public byte unknown8f2;

        // col: 1442 offset: 08f4
        public uint GilReward;

        // col: 1452 offset: 08f8
        public uint[] ItemReward0;

        // col: 1458 offset: 0910
        public uint unknown910;

        // col: 1473 offset: 0914
        public uint[] ItemReward1;

        // col: 1501 offset: 0928
        public uint InstanceContentUnlock;

        // col: 1441 offset: 092c
        public ushort ExpFactor;

        // col: 1444 offset: 092e
        public ushort GCSeals;

        // col: 1494 offset: 0930
        public ushort ActionReward;

        // col: 1497 offset: 0932
        public ushort unknown932;

        // col: 1499 offset: 0934
        public ushort unknown934;

        // col: 1500 offset: 0936
        public ushort unknown936;

        // col: 1443 offset: 0938
        public byte unknown938;

        // col: 1445 offset: 0939
        public byte[] ItemCatalyst;

        // col: 1448 offset: 093c
        public byte[] ItemCountCatalyst;

        // col: 1451 offset: 093f
        public byte ItemRewardType;

        // col: 1459 offset: 0940
        public byte[] ItemCountReward0;

        // col: 1465 offset: 0946
        public byte unknown946;

        // col: 1466 offset: 0947
        public byte[] StainReward0;

        // col: 1472 offset: 094d
        public byte unknown94d;

        // col: 1478 offset: 094e
        public byte[] ItemCountReward1;

        // col: 1488 offset: 0953
        public byte[] StainReward1;

        // col: 1493 offset: 0958
        public byte EmoteReward;

        // col: 1495 offset: 0959
        public byte[] GeneralActionReward;

        // col: 1498 offset: 095b
        public byte OtherReward;

        // col: 1502 offset: 095c
        public byte unknown95c;

        // col: 1503 offset: 095d
        public byte TomestoneReward;

        // col: 1504 offset: 095e
        public byte TomestoneCountReward;

        // col: 1505 offset: 095f
        public byte ReputationReward;

        // col: 1483 offset: 0960
        public bool[] IsHQReward1;

        // col: 01 offset: 0968
        public string Id;

        // col: 09 offset: 096c
        public uint PreviousQuest0;

        // col: 11 offset: 0970
        public uint PreviousQuest1;

        // col: 12 offset: 0974
        public uint PreviousQuest2;

        // col: 14 offset: 0978
        public uint[] QuestLock;

        // col: 23 offset: 0980
        public uint[] InstanceContent;

        // col: 39 offset: 098c
        public uint IssuerStart;

        // col: 40 offset: 0990
        public uint Behavior;

        // col: 42 offset: 0994
        public uint TargetEnd;

        // col: 1509 offset: 0998
        public uint Icon;

        // col: 1510 offset: 099c
        public uint IconSpecial;

        // col: 36 offset: 09a0
        public int MountRequired;

        // col: 04 offset: 09a4
        public ushort ClassJobLevel0;

        // col: 07 offset: 09a6
        public ushort ClassJobLevel1;

        // col: 16 offset: 09a8
        public ushort unknown9a8;

        // col: 29 offset: 09aa
        public ushort BellStart;

        // col: 30 offset: 09ac
        public ushort BellEnd;

        // col: 33 offset: 09ae
        public ushort LevelMax;

        // col: 41 offset: 09b0
        public ushort unknown9b0;

        // col: 49 offset: 09b2
        public ushort QuestClassJobSupply;

        // col: 1506 offset: 09b4
        public ushort PlaceName;

        // col: 1515 offset: 09b6
        public ushort SortKey;

        // col: 02 offset: 09b8
        public byte Expansion;

        // col: 03 offset: 09b9
        public byte ClassJobCategory0;

        // col: 05 offset: 09ba
        public byte QuestLevelOffset;

        // col: 06 offset: 09bb
        public byte ClassJobCategory1;

        // col: 08 offset: 09bc
        public byte PreviousQuestJoin;

        // col: 10 offset: 09bd
        public byte unknown9bd;

        // col: 13 offset: 09be
        public byte QuestLockJoin;

        // col: 17 offset: 09bf
        public byte unknown9bf;

        // col: 18 offset: 09c0
        public byte unknown9c0;

        // col: 19 offset: 09c1
        public byte ClassJobUnlock;

        // col: 20 offset: 09c2
        public byte GrandCompany;

        // col: 21 offset: 09c3
        public byte GrandCompanyRank;

        // col: 22 offset: 09c4
        public byte InstanceContentJoin;

        // col: 26 offset: 09c5
        public byte Festival;

        // col: 27 offset: 09c6
        public byte unknown9c6;

        // col: 28 offset: 09c7
        public byte unknown9c7;

        // col: 31 offset: 09c8
        public byte BeastTribe;

        // col: 32 offset: 09c9
        public byte BeastReputationRank;

        // col: 34 offset: 09ca
        public byte unknown9ca;

        // col: 35 offset: 09cb
        public byte unknown9cb;

        // col: 38 offset: 09cc
        public byte DeliveryQuest;

        // col: 44 offset: 09cd
        public byte RepeatIntervalType;

        // col: 45 offset: 09ce
        public byte QuestRepeatFlag;

        // col: 48 offset: 09cf
        public byte Type;

        // col: 1438 offset: 09d0
        public byte unknown9d0;

        // col: 1439 offset: 09d1
        public byte ClassJobRequired;

        // col: 1440 offset: 09d2
        public byte unknown9d2;

        // col: 1507 offset: 09d3
        public byte JournalGenre;

        // col: 1508 offset: 09d4
        public byte unknown9d4;

        // col: 1513 offset: 09d5
        public byte EventIconType;

        // col: 1514 offset: 09d6
        public byte unknown9d6;

        // col: 37 offset: 09d7
        private byte packed9d7;
        public bool IsHouseRequired => ( packed9d7 & 0x1 ) == 0x1;
        public bool IsRepeatable => ( packed9d7 & 0x2 ) == 0x2;
        public bool UnlocksSystemContent => ( packed9d7 & 0x4 ) == 0x4;
        public bool packed9d7_8 => ( packed9d7 & 0x8 ) == 0x8;
        public bool packed9d7_10 => ( packed9d7 & 0x10 ) == 0x10;
        public bool packed9d7_20 => ( packed9d7 & 0x20 ) == 0x20;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            Name = parser.ReadOffset< string >( 0x0 );

            // col: 50 offset: 0004
            ScriptInstruction = new string[50];
            ScriptInstruction[0] = parser.ReadOffset< string >( 0x4 );
            ScriptInstruction[1] = parser.ReadOffset< string >( 0xc );
            ScriptInstruction[2] = parser.ReadOffset< string >( 0x14 );
            ScriptInstruction[3] = parser.ReadOffset< string >( 0x1c );
            ScriptInstruction[4] = parser.ReadOffset< string >( 0x24 );
            ScriptInstruction[5] = parser.ReadOffset< string >( 0x2c );
            ScriptInstruction[6] = parser.ReadOffset< string >( 0x34 );
            ScriptInstruction[7] = parser.ReadOffset< string >( 0x3c );
            ScriptInstruction[8] = parser.ReadOffset< string >( 0x44 );
            ScriptInstruction[9] = parser.ReadOffset< string >( 0x4c );
            ScriptInstruction[10] = parser.ReadOffset< string >( 0x54 );
            ScriptInstruction[11] = parser.ReadOffset< string >( 0x5c );
            ScriptInstruction[12] = parser.ReadOffset< string >( 0x64 );
            ScriptInstruction[13] = parser.ReadOffset< string >( 0x6c );
            ScriptInstruction[14] = parser.ReadOffset< string >( 0x74 );
            ScriptInstruction[15] = parser.ReadOffset< string >( 0x7c );
            ScriptInstruction[16] = parser.ReadOffset< string >( 0x84 );
            ScriptInstruction[17] = parser.ReadOffset< string >( 0x8c );
            ScriptInstruction[18] = parser.ReadOffset< string >( 0x94 );
            ScriptInstruction[19] = parser.ReadOffset< string >( 0x9c );
            ScriptInstruction[20] = parser.ReadOffset< string >( 0xa4 );
            ScriptInstruction[21] = parser.ReadOffset< string >( 0xac );
            ScriptInstruction[22] = parser.ReadOffset< string >( 0xb4 );
            ScriptInstruction[23] = parser.ReadOffset< string >( 0xbc );
            ScriptInstruction[24] = parser.ReadOffset< string >( 0xc4 );
            ScriptInstruction[25] = parser.ReadOffset< string >( 0xcc );
            ScriptInstruction[26] = parser.ReadOffset< string >( 0xd4 );
            ScriptInstruction[27] = parser.ReadOffset< string >( 0xdc );
            ScriptInstruction[28] = parser.ReadOffset< string >( 0xe4 );
            ScriptInstruction[29] = parser.ReadOffset< string >( 0xec );
            ScriptInstruction[30] = parser.ReadOffset< string >( 0xf4 );
            ScriptInstruction[31] = parser.ReadOffset< string >( 0xfc );
            ScriptInstruction[32] = parser.ReadOffset< string >( 0x104 );
            ScriptInstruction[33] = parser.ReadOffset< string >( 0x10c );
            ScriptInstruction[34] = parser.ReadOffset< string >( 0x114 );
            ScriptInstruction[35] = parser.ReadOffset< string >( 0x11c );
            ScriptInstruction[36] = parser.ReadOffset< string >( 0x124 );
            ScriptInstruction[37] = parser.ReadOffset< string >( 0x12c );
            ScriptInstruction[38] = parser.ReadOffset< string >( 0x134 );
            ScriptInstruction[39] = parser.ReadOffset< string >( 0x13c );
            ScriptInstruction[40] = parser.ReadOffset< string >( 0x144 );
            ScriptInstruction[41] = parser.ReadOffset< string >( 0x14c );
            ScriptInstruction[42] = parser.ReadOffset< string >( 0x154 );
            ScriptInstruction[43] = parser.ReadOffset< string >( 0x15c );
            ScriptInstruction[44] = parser.ReadOffset< string >( 0x164 );
            ScriptInstruction[45] = parser.ReadOffset< string >( 0x16c );
            ScriptInstruction[46] = parser.ReadOffset< string >( 0x174 );
            ScriptInstruction[47] = parser.ReadOffset< string >( 0x17c );
            ScriptInstruction[48] = parser.ReadOffset< string >( 0x184 );
            ScriptInstruction[49] = parser.ReadOffset< string >( 0x18c );

            // col: 100 offset: 0008
            ScriptArg = new uint[50];
            ScriptArg[0] = parser.ReadOffset< uint >( 0x8 );
            ScriptArg[1] = parser.ReadOffset< uint >( 0x10 );
            ScriptArg[2] = parser.ReadOffset< uint >( 0x18 );
            ScriptArg[3] = parser.ReadOffset< uint >( 0x20 );
            ScriptArg[4] = parser.ReadOffset< uint >( 0x28 );
            ScriptArg[5] = parser.ReadOffset< uint >( 0x30 );
            ScriptArg[6] = parser.ReadOffset< uint >( 0x38 );
            ScriptArg[7] = parser.ReadOffset< uint >( 0x40 );
            ScriptArg[8] = parser.ReadOffset< uint >( 0x48 );
            ScriptArg[9] = parser.ReadOffset< uint >( 0x50 );
            ScriptArg[10] = parser.ReadOffset< uint >( 0x58 );
            ScriptArg[11] = parser.ReadOffset< uint >( 0x60 );
            ScriptArg[12] = parser.ReadOffset< uint >( 0x68 );
            ScriptArg[13] = parser.ReadOffset< uint >( 0x70 );
            ScriptArg[14] = parser.ReadOffset< uint >( 0x78 );
            ScriptArg[15] = parser.ReadOffset< uint >( 0x80 );
            ScriptArg[16] = parser.ReadOffset< uint >( 0x88 );
            ScriptArg[17] = parser.ReadOffset< uint >( 0x90 );
            ScriptArg[18] = parser.ReadOffset< uint >( 0x98 );
            ScriptArg[19] = parser.ReadOffset< uint >( 0xa0 );
            ScriptArg[20] = parser.ReadOffset< uint >( 0xa8 );
            ScriptArg[21] = parser.ReadOffset< uint >( 0xb0 );
            ScriptArg[22] = parser.ReadOffset< uint >( 0xb8 );
            ScriptArg[23] = parser.ReadOffset< uint >( 0xc0 );
            ScriptArg[24] = parser.ReadOffset< uint >( 0xc8 );
            ScriptArg[25] = parser.ReadOffset< uint >( 0xd0 );
            ScriptArg[26] = parser.ReadOffset< uint >( 0xd8 );
            ScriptArg[27] = parser.ReadOffset< uint >( 0xe0 );
            ScriptArg[28] = parser.ReadOffset< uint >( 0xe8 );
            ScriptArg[29] = parser.ReadOffset< uint >( 0xf0 );
            ScriptArg[30] = parser.ReadOffset< uint >( 0xf8 );
            ScriptArg[31] = parser.ReadOffset< uint >( 0x100 );
            ScriptArg[32] = parser.ReadOffset< uint >( 0x108 );
            ScriptArg[33] = parser.ReadOffset< uint >( 0x110 );
            ScriptArg[34] = parser.ReadOffset< uint >( 0x118 );
            ScriptArg[35] = parser.ReadOffset< uint >( 0x120 );
            ScriptArg[36] = parser.ReadOffset< uint >( 0x128 );
            ScriptArg[37] = parser.ReadOffset< uint >( 0x130 );
            ScriptArg[38] = parser.ReadOffset< uint >( 0x138 );
            ScriptArg[39] = parser.ReadOffset< uint >( 0x140 );
            ScriptArg[40] = parser.ReadOffset< uint >( 0x148 );
            ScriptArg[41] = parser.ReadOffset< uint >( 0x150 );
            ScriptArg[42] = parser.ReadOffset< uint >( 0x158 );
            ScriptArg[43] = parser.ReadOffset< uint >( 0x160 );
            ScriptArg[44] = parser.ReadOffset< uint >( 0x168 );
            ScriptArg[45] = parser.ReadOffset< uint >( 0x170 );
            ScriptArg[46] = parser.ReadOffset< uint >( 0x178 );
            ScriptArg[47] = parser.ReadOffset< uint >( 0x180 );
            ScriptArg[48] = parser.ReadOffset< uint >( 0x188 );
            ScriptArg[49] = parser.ReadOffset< uint >( 0x190 );

            // col: 278 offset: 0194
            ActorSpawn = new uint[64];
            ActorSpawn[0] = parser.ReadOffset< uint >( 0x194 );
            ActorSpawn[1] = parser.ReadOffset< uint >( 0x1a4 );
            ActorSpawn[2] = parser.ReadOffset< uint >( 0x1b4 );
            ActorSpawn[3] = parser.ReadOffset< uint >( 0x1c4 );
            ActorSpawn[4] = parser.ReadOffset< uint >( 0x1d4 );
            ActorSpawn[5] = parser.ReadOffset< uint >( 0x1e4 );
            ActorSpawn[6] = parser.ReadOffset< uint >( 0x1f4 );
            ActorSpawn[7] = parser.ReadOffset< uint >( 0x204 );
            ActorSpawn[8] = parser.ReadOffset< uint >( 0x214 );
            ActorSpawn[9] = parser.ReadOffset< uint >( 0x224 );
            ActorSpawn[10] = parser.ReadOffset< uint >( 0x234 );
            ActorSpawn[11] = parser.ReadOffset< uint >( 0x244 );
            ActorSpawn[12] = parser.ReadOffset< uint >( 0x254 );
            ActorSpawn[13] = parser.ReadOffset< uint >( 0x264 );
            ActorSpawn[14] = parser.ReadOffset< uint >( 0x274 );
            ActorSpawn[15] = parser.ReadOffset< uint >( 0x284 );
            ActorSpawn[16] = parser.ReadOffset< uint >( 0x294 );
            ActorSpawn[17] = parser.ReadOffset< uint >( 0x2a4 );
            ActorSpawn[18] = parser.ReadOffset< uint >( 0x2b4 );
            ActorSpawn[19] = parser.ReadOffset< uint >( 0x2c4 );
            ActorSpawn[20] = parser.ReadOffset< uint >( 0x2d4 );
            ActorSpawn[21] = parser.ReadOffset< uint >( 0x2e4 );
            ActorSpawn[22] = parser.ReadOffset< uint >( 0x2f4 );
            ActorSpawn[23] = parser.ReadOffset< uint >( 0x304 );
            ActorSpawn[24] = parser.ReadOffset< uint >( 0x314 );
            ActorSpawn[25] = parser.ReadOffset< uint >( 0x324 );
            ActorSpawn[26] = parser.ReadOffset< uint >( 0x334 );
            ActorSpawn[27] = parser.ReadOffset< uint >( 0x344 );
            ActorSpawn[28] = parser.ReadOffset< uint >( 0x354 );
            ActorSpawn[29] = parser.ReadOffset< uint >( 0x364 );
            ActorSpawn[30] = parser.ReadOffset< uint >( 0x374 );
            ActorSpawn[31] = parser.ReadOffset< uint >( 0x384 );
            ActorSpawn[32] = parser.ReadOffset< uint >( 0x394 );
            ActorSpawn[33] = parser.ReadOffset< uint >( 0x3a4 );
            ActorSpawn[34] = parser.ReadOffset< uint >( 0x3b4 );
            ActorSpawn[35] = parser.ReadOffset< uint >( 0x3c4 );
            ActorSpawn[36] = parser.ReadOffset< uint >( 0x3d4 );
            ActorSpawn[37] = parser.ReadOffset< uint >( 0x3e4 );
            ActorSpawn[38] = parser.ReadOffset< uint >( 0x3f4 );
            ActorSpawn[39] = parser.ReadOffset< uint >( 0x404 );
            ActorSpawn[40] = parser.ReadOffset< uint >( 0x414 );
            ActorSpawn[41] = parser.ReadOffset< uint >( 0x424 );
            ActorSpawn[42] = parser.ReadOffset< uint >( 0x434 );
            ActorSpawn[43] = parser.ReadOffset< uint >( 0x444 );
            ActorSpawn[44] = parser.ReadOffset< uint >( 0x454 );
            ActorSpawn[45] = parser.ReadOffset< uint >( 0x464 );
            ActorSpawn[46] = parser.ReadOffset< uint >( 0x474 );
            ActorSpawn[47] = parser.ReadOffset< uint >( 0x484 );
            ActorSpawn[48] = parser.ReadOffset< uint >( 0x494 );
            ActorSpawn[49] = parser.ReadOffset< uint >( 0x4a4 );
            ActorSpawn[50] = parser.ReadOffset< uint >( 0x4b4 );
            ActorSpawn[51] = parser.ReadOffset< uint >( 0x4c4 );
            ActorSpawn[52] = parser.ReadOffset< uint >( 0x4d4 );
            ActorSpawn[53] = parser.ReadOffset< uint >( 0x4e4 );
            ActorSpawn[54] = parser.ReadOffset< uint >( 0x4f4 );
            ActorSpawn[55] = parser.ReadOffset< uint >( 0x504 );
            ActorSpawn[56] = parser.ReadOffset< uint >( 0x514 );
            ActorSpawn[57] = parser.ReadOffset< uint >( 0x524 );
            ActorSpawn[58] = parser.ReadOffset< uint >( 0x534 );
            ActorSpawn[59] = parser.ReadOffset< uint >( 0x544 );
            ActorSpawn[60] = parser.ReadOffset< uint >( 0x554 );
            ActorSpawn[61] = parser.ReadOffset< uint >( 0x564 );
            ActorSpawn[62] = parser.ReadOffset< uint >( 0x574 );
            ActorSpawn[63] = parser.ReadOffset< uint >( 0x584 );

            // col: 470 offset: 0198
            unknown198 = parser.ReadOffset< uint >( 0x198 );

            // col: 598 offset: 019c
            unknown19c = parser.ReadOffset< ushort >( 0x19c );

            // col: 150 offset: 019e
            ActorSpawnSeq = new byte[64];
            ActorSpawnSeq[0] = parser.ReadOffset< byte >( 0x19e );
            ActorSpawnSeq[1] = parser.ReadOffset< byte >( 0x1ae );
            ActorSpawnSeq[2] = parser.ReadOffset< byte >( 0x1be );
            ActorSpawnSeq[3] = parser.ReadOffset< byte >( 0x1ce );
            ActorSpawnSeq[4] = parser.ReadOffset< byte >( 0x1de );
            ActorSpawnSeq[5] = parser.ReadOffset< byte >( 0x1ee );
            ActorSpawnSeq[6] = parser.ReadOffset< byte >( 0x1fe );
            ActorSpawnSeq[7] = parser.ReadOffset< byte >( 0x20e );
            ActorSpawnSeq[8] = parser.ReadOffset< byte >( 0x21e );
            ActorSpawnSeq[9] = parser.ReadOffset< byte >( 0x22e );
            ActorSpawnSeq[10] = parser.ReadOffset< byte >( 0x23e );
            ActorSpawnSeq[11] = parser.ReadOffset< byte >( 0x24e );
            ActorSpawnSeq[12] = parser.ReadOffset< byte >( 0x25e );
            ActorSpawnSeq[13] = parser.ReadOffset< byte >( 0x26e );
            ActorSpawnSeq[14] = parser.ReadOffset< byte >( 0x27e );
            ActorSpawnSeq[15] = parser.ReadOffset< byte >( 0x28e );
            ActorSpawnSeq[16] = parser.ReadOffset< byte >( 0x29e );
            ActorSpawnSeq[17] = parser.ReadOffset< byte >( 0x2ae );
            ActorSpawnSeq[18] = parser.ReadOffset< byte >( 0x2be );
            ActorSpawnSeq[19] = parser.ReadOffset< byte >( 0x2ce );
            ActorSpawnSeq[20] = parser.ReadOffset< byte >( 0x2de );
            ActorSpawnSeq[21] = parser.ReadOffset< byte >( 0x2ee );
            ActorSpawnSeq[22] = parser.ReadOffset< byte >( 0x2fe );
            ActorSpawnSeq[23] = parser.ReadOffset< byte >( 0x30e );
            ActorSpawnSeq[24] = parser.ReadOffset< byte >( 0x31e );
            ActorSpawnSeq[25] = parser.ReadOffset< byte >( 0x32e );
            ActorSpawnSeq[26] = parser.ReadOffset< byte >( 0x33e );
            ActorSpawnSeq[27] = parser.ReadOffset< byte >( 0x34e );
            ActorSpawnSeq[28] = parser.ReadOffset< byte >( 0x35e );
            ActorSpawnSeq[29] = parser.ReadOffset< byte >( 0x36e );
            ActorSpawnSeq[30] = parser.ReadOffset< byte >( 0x37e );
            ActorSpawnSeq[31] = parser.ReadOffset< byte >( 0x38e );
            ActorSpawnSeq[32] = parser.ReadOffset< byte >( 0x39e );
            ActorSpawnSeq[33] = parser.ReadOffset< byte >( 0x3ae );
            ActorSpawnSeq[34] = parser.ReadOffset< byte >( 0x3be );
            ActorSpawnSeq[35] = parser.ReadOffset< byte >( 0x3ce );
            ActorSpawnSeq[36] = parser.ReadOffset< byte >( 0x3de );
            ActorSpawnSeq[37] = parser.ReadOffset< byte >( 0x3ee );
            ActorSpawnSeq[38] = parser.ReadOffset< byte >( 0x3fe );
            ActorSpawnSeq[39] = parser.ReadOffset< byte >( 0x40e );
            ActorSpawnSeq[40] = parser.ReadOffset< byte >( 0x41e );
            ActorSpawnSeq[41] = parser.ReadOffset< byte >( 0x42e );
            ActorSpawnSeq[42] = parser.ReadOffset< byte >( 0x43e );
            ActorSpawnSeq[43] = parser.ReadOffset< byte >( 0x44e );
            ActorSpawnSeq[44] = parser.ReadOffset< byte >( 0x45e );
            ActorSpawnSeq[45] = parser.ReadOffset< byte >( 0x46e );
            ActorSpawnSeq[46] = parser.ReadOffset< byte >( 0x47e );
            ActorSpawnSeq[47] = parser.ReadOffset< byte >( 0x48e );
            ActorSpawnSeq[48] = parser.ReadOffset< byte >( 0x49e );
            ActorSpawnSeq[49] = parser.ReadOffset< byte >( 0x4ae );
            ActorSpawnSeq[50] = parser.ReadOffset< byte >( 0x4be );
            ActorSpawnSeq[51] = parser.ReadOffset< byte >( 0x4ce );
            ActorSpawnSeq[52] = parser.ReadOffset< byte >( 0x4de );
            ActorSpawnSeq[53] = parser.ReadOffset< byte >( 0x4ee );
            ActorSpawnSeq[54] = parser.ReadOffset< byte >( 0x4fe );
            ActorSpawnSeq[55] = parser.ReadOffset< byte >( 0x50e );
            ActorSpawnSeq[56] = parser.ReadOffset< byte >( 0x51e );
            ActorSpawnSeq[57] = parser.ReadOffset< byte >( 0x52e );
            ActorSpawnSeq[58] = parser.ReadOffset< byte >( 0x53e );
            ActorSpawnSeq[59] = parser.ReadOffset< byte >( 0x54e );
            ActorSpawnSeq[60] = parser.ReadOffset< byte >( 0x55e );
            ActorSpawnSeq[61] = parser.ReadOffset< byte >( 0x56e );
            ActorSpawnSeq[62] = parser.ReadOffset< byte >( 0x57e );
            ActorSpawnSeq[63] = parser.ReadOffset< byte >( 0x58e );

            // col: 214 offset: 019f
            ActorDespawnSeq = new byte[64];
            ActorDespawnSeq[0] = parser.ReadOffset< byte >( 0x19f );
            ActorDespawnSeq[1] = parser.ReadOffset< byte >( 0x1af );
            ActorDespawnSeq[2] = parser.ReadOffset< byte >( 0x1bf );
            ActorDespawnSeq[3] = parser.ReadOffset< byte >( 0x1cf );
            ActorDespawnSeq[4] = parser.ReadOffset< byte >( 0x1df );
            ActorDespawnSeq[5] = parser.ReadOffset< byte >( 0x1ef );
            ActorDespawnSeq[6] = parser.ReadOffset< byte >( 0x1ff );
            ActorDespawnSeq[7] = parser.ReadOffset< byte >( 0x20f );
            ActorDespawnSeq[8] = parser.ReadOffset< byte >( 0x21f );
            ActorDespawnSeq[9] = parser.ReadOffset< byte >( 0x22f );
            ActorDespawnSeq[10] = parser.ReadOffset< byte >( 0x23f );
            ActorDespawnSeq[11] = parser.ReadOffset< byte >( 0x24f );
            ActorDespawnSeq[12] = parser.ReadOffset< byte >( 0x25f );
            ActorDespawnSeq[13] = parser.ReadOffset< byte >( 0x26f );
            ActorDespawnSeq[14] = parser.ReadOffset< byte >( 0x27f );
            ActorDespawnSeq[15] = parser.ReadOffset< byte >( 0x28f );
            ActorDespawnSeq[16] = parser.ReadOffset< byte >( 0x29f );
            ActorDespawnSeq[17] = parser.ReadOffset< byte >( 0x2af );
            ActorDespawnSeq[18] = parser.ReadOffset< byte >( 0x2bf );
            ActorDespawnSeq[19] = parser.ReadOffset< byte >( 0x2cf );
            ActorDespawnSeq[20] = parser.ReadOffset< byte >( 0x2df );
            ActorDespawnSeq[21] = parser.ReadOffset< byte >( 0x2ef );
            ActorDespawnSeq[22] = parser.ReadOffset< byte >( 0x2ff );
            ActorDespawnSeq[23] = parser.ReadOffset< byte >( 0x30f );
            ActorDespawnSeq[24] = parser.ReadOffset< byte >( 0x31f );
            ActorDespawnSeq[25] = parser.ReadOffset< byte >( 0x32f );
            ActorDespawnSeq[26] = parser.ReadOffset< byte >( 0x33f );
            ActorDespawnSeq[27] = parser.ReadOffset< byte >( 0x34f );
            ActorDespawnSeq[28] = parser.ReadOffset< byte >( 0x35f );
            ActorDespawnSeq[29] = parser.ReadOffset< byte >( 0x36f );
            ActorDespawnSeq[30] = parser.ReadOffset< byte >( 0x37f );
            ActorDespawnSeq[31] = parser.ReadOffset< byte >( 0x38f );
            ActorDespawnSeq[32] = parser.ReadOffset< byte >( 0x39f );
            ActorDespawnSeq[33] = parser.ReadOffset< byte >( 0x3af );
            ActorDespawnSeq[34] = parser.ReadOffset< byte >( 0x3bf );
            ActorDespawnSeq[35] = parser.ReadOffset< byte >( 0x3cf );
            ActorDespawnSeq[36] = parser.ReadOffset< byte >( 0x3df );
            ActorDespawnSeq[37] = parser.ReadOffset< byte >( 0x3ef );
            ActorDespawnSeq[38] = parser.ReadOffset< byte >( 0x3ff );
            ActorDespawnSeq[39] = parser.ReadOffset< byte >( 0x40f );
            ActorDespawnSeq[40] = parser.ReadOffset< byte >( 0x41f );
            ActorDespawnSeq[41] = parser.ReadOffset< byte >( 0x42f );
            ActorDespawnSeq[42] = parser.ReadOffset< byte >( 0x43f );
            ActorDespawnSeq[43] = parser.ReadOffset< byte >( 0x44f );
            ActorDespawnSeq[44] = parser.ReadOffset< byte >( 0x45f );
            ActorDespawnSeq[45] = parser.ReadOffset< byte >( 0x46f );
            ActorDespawnSeq[46] = parser.ReadOffset< byte >( 0x47f );
            ActorDespawnSeq[47] = parser.ReadOffset< byte >( 0x48f );
            ActorDespawnSeq[48] = parser.ReadOffset< byte >( 0x49f );
            ActorDespawnSeq[49] = parser.ReadOffset< byte >( 0x4af );
            ActorDespawnSeq[50] = parser.ReadOffset< byte >( 0x4bf );
            ActorDespawnSeq[51] = parser.ReadOffset< byte >( 0x4cf );
            ActorDespawnSeq[52] = parser.ReadOffset< byte >( 0x4df );
            ActorDespawnSeq[53] = parser.ReadOffset< byte >( 0x4ef );
            ActorDespawnSeq[54] = parser.ReadOffset< byte >( 0x4ff );
            ActorDespawnSeq[55] = parser.ReadOffset< byte >( 0x50f );
            ActorDespawnSeq[56] = parser.ReadOffset< byte >( 0x51f );
            ActorDespawnSeq[57] = parser.ReadOffset< byte >( 0x52f );
            ActorDespawnSeq[58] = parser.ReadOffset< byte >( 0x53f );
            ActorDespawnSeq[59] = parser.ReadOffset< byte >( 0x54f );
            ActorDespawnSeq[60] = parser.ReadOffset< byte >( 0x55f );
            ActorDespawnSeq[61] = parser.ReadOffset< byte >( 0x56f );
            ActorDespawnSeq[62] = parser.ReadOffset< byte >( 0x57f );
            ActorDespawnSeq[63] = parser.ReadOffset< byte >( 0x58f );

            // col: 342 offset: 01a0
            QuestUInt8A = new byte[32];
            QuestUInt8A[0] = parser.ReadOffset< byte >( 0x1a0 );
            QuestUInt8A[1] = parser.ReadOffset< byte >( 0x1b0 );
            QuestUInt8A[2] = parser.ReadOffset< byte >( 0x1c0 );
            QuestUInt8A[3] = parser.ReadOffset< byte >( 0x1d0 );
            QuestUInt8A[4] = parser.ReadOffset< byte >( 0x1e0 );
            QuestUInt8A[5] = parser.ReadOffset< byte >( 0x1f0 );
            QuestUInt8A[6] = parser.ReadOffset< byte >( 0x200 );
            QuestUInt8A[7] = parser.ReadOffset< byte >( 0x210 );
            QuestUInt8A[8] = parser.ReadOffset< byte >( 0x220 );
            QuestUInt8A[9] = parser.ReadOffset< byte >( 0x230 );
            QuestUInt8A[10] = parser.ReadOffset< byte >( 0x240 );
            QuestUInt8A[11] = parser.ReadOffset< byte >( 0x250 );
            QuestUInt8A[12] = parser.ReadOffset< byte >( 0x260 );
            QuestUInt8A[13] = parser.ReadOffset< byte >( 0x270 );
            QuestUInt8A[14] = parser.ReadOffset< byte >( 0x280 );
            QuestUInt8A[15] = parser.ReadOffset< byte >( 0x290 );
            QuestUInt8A[16] = parser.ReadOffset< byte >( 0x2a0 );
            QuestUInt8A[17] = parser.ReadOffset< byte >( 0x2b0 );
            QuestUInt8A[18] = parser.ReadOffset< byte >( 0x2c0 );
            QuestUInt8A[19] = parser.ReadOffset< byte >( 0x2d0 );
            QuestUInt8A[20] = parser.ReadOffset< byte >( 0x2e0 );
            QuestUInt8A[21] = parser.ReadOffset< byte >( 0x2f0 );
            QuestUInt8A[22] = parser.ReadOffset< byte >( 0x300 );
            QuestUInt8A[23] = parser.ReadOffset< byte >( 0x310 );
            QuestUInt8A[24] = parser.ReadOffset< byte >( 0x320 );
            QuestUInt8A[25] = parser.ReadOffset< byte >( 0x330 );
            QuestUInt8A[26] = parser.ReadOffset< byte >( 0x340 );
            QuestUInt8A[27] = parser.ReadOffset< byte >( 0x350 );
            QuestUInt8A[28] = parser.ReadOffset< byte >( 0x360 );
            QuestUInt8A[29] = parser.ReadOffset< byte >( 0x370 );
            QuestUInt8A[30] = parser.ReadOffset< byte >( 0x380 );
            QuestUInt8A[31] = parser.ReadOffset< byte >( 0x390 );

            // col: 406 offset: 01a1
            unknown1a1 = parser.ReadOffset< byte >( 0x1a1 );

            // col: 534 offset: 01a2
            unknown1a2 = parser.ReadOffset< byte >( 0x1a2 );

            // col: 662 offset: 01a3
            packed1a3 = parser.ReadOffset< byte >( 0x1a3, ExcelColumnDataType.UInt8 );

            // col: 471 offset: 01a8
            unknown1a8 = parser.ReadOffset< uint >( 0x1a8 );

            // col: 599 offset: 01ac
            unknown1ac = parser.ReadOffset< ushort >( 0x1ac );

            // col: 407 offset: 01b1
            unknown1b1 = parser.ReadOffset< byte >( 0x1b1 );

            // col: 535 offset: 01b2
            unknown1b2 = parser.ReadOffset< byte >( 0x1b2 );

            // col: 663 offset: 01b3
            packed1b3 = parser.ReadOffset< byte >( 0x1b3, ExcelColumnDataType.UInt8 );

            // col: 472 offset: 01b8
            unknown1b8 = parser.ReadOffset< uint >( 0x1b8 );

            // col: 600 offset: 01bc
            unknown1bc = parser.ReadOffset< ushort >( 0x1bc );

            // col: 408 offset: 01c1
            unknown1c1 = parser.ReadOffset< byte >( 0x1c1 );

            // col: 536 offset: 01c2
            unknown1c2 = parser.ReadOffset< byte >( 0x1c2 );

            // col: 664 offset: 01c3
            packed1c3 = parser.ReadOffset< byte >( 0x1c3, ExcelColumnDataType.UInt8 );

            // col: 473 offset: 01c8
            unknown1c8 = parser.ReadOffset< uint >( 0x1c8 );

            // col: 601 offset: 01cc
            unknown1cc = parser.ReadOffset< ushort >( 0x1cc );

            // col: 409 offset: 01d1
            unknown1d1 = parser.ReadOffset< byte >( 0x1d1 );

            // col: 537 offset: 01d2
            unknown1d2 = parser.ReadOffset< byte >( 0x1d2 );

            // col: 665 offset: 01d3
            packed1d3 = parser.ReadOffset< byte >( 0x1d3, ExcelColumnDataType.UInt8 );

            // col: 474 offset: 01d8
            unknown1d8 = parser.ReadOffset< uint >( 0x1d8 );

            // col: 602 offset: 01dc
            unknown1dc = parser.ReadOffset< ushort >( 0x1dc );

            // col: 410 offset: 01e1
            unknown1e1 = parser.ReadOffset< byte >( 0x1e1 );

            // col: 538 offset: 01e2
            unknown1e2 = parser.ReadOffset< byte >( 0x1e2 );

            // col: 666 offset: 01e3
            packed1e3 = parser.ReadOffset< byte >( 0x1e3, ExcelColumnDataType.UInt8 );

            // col: 475 offset: 01e8
            unknown1e8 = parser.ReadOffset< uint >( 0x1e8 );

            // col: 603 offset: 01ec
            unknown1ec = parser.ReadOffset< ushort >( 0x1ec );

            // col: 411 offset: 01f1
            unknown1f1 = parser.ReadOffset< byte >( 0x1f1 );

            // col: 539 offset: 01f2
            unknown1f2 = parser.ReadOffset< byte >( 0x1f2 );

            // col: 667 offset: 01f3
            packed1f3 = parser.ReadOffset< byte >( 0x1f3, ExcelColumnDataType.UInt8 );

            // col: 476 offset: 01f8
            unknown1f8 = parser.ReadOffset< uint >( 0x1f8 );

            // col: 604 offset: 01fc
            unknown1fc = parser.ReadOffset< ushort >( 0x1fc );

            // col: 412 offset: 0201
            unknown201 = parser.ReadOffset< byte >( 0x201 );

            // col: 540 offset: 0202
            unknown202 = parser.ReadOffset< byte >( 0x202 );

            // col: 668 offset: 0203
            packed203 = parser.ReadOffset< byte >( 0x203, ExcelColumnDataType.UInt8 );

            // col: 477 offset: 0208
            unknown208 = parser.ReadOffset< uint >( 0x208 );

            // col: 605 offset: 020c
            unknown20c = parser.ReadOffset< ushort >( 0x20c );

            // col: 413 offset: 0211
            unknown211 = parser.ReadOffset< byte >( 0x211 );

            // col: 541 offset: 0212
            unknown212 = parser.ReadOffset< byte >( 0x212 );

            // col: 669 offset: 0213
            packed213 = parser.ReadOffset< byte >( 0x213, ExcelColumnDataType.UInt8 );

            // col: 478 offset: 0218
            unknown218 = parser.ReadOffset< uint >( 0x218 );

            // col: 606 offset: 021c
            unknown21c = parser.ReadOffset< ushort >( 0x21c );

            // col: 414 offset: 0221
            unknown221 = parser.ReadOffset< byte >( 0x221 );

            // col: 542 offset: 0222
            unknown222 = parser.ReadOffset< byte >( 0x222 );

            // col: 670 offset: 0223
            packed223 = parser.ReadOffset< byte >( 0x223, ExcelColumnDataType.UInt8 );

            // col: 479 offset: 0228
            unknown228 = parser.ReadOffset< uint >( 0x228 );

            // col: 607 offset: 022c
            unknown22c = parser.ReadOffset< ushort >( 0x22c );

            // col: 415 offset: 0231
            unknown231 = parser.ReadOffset< byte >( 0x231 );

            // col: 543 offset: 0232
            unknown232 = parser.ReadOffset< byte >( 0x232 );

            // col: 671 offset: 0233
            packed233 = parser.ReadOffset< byte >( 0x233, ExcelColumnDataType.UInt8 );

            // col: 480 offset: 0238
            unknown238 = parser.ReadOffset< uint >( 0x238 );

            // col: 608 offset: 023c
            unknown23c = parser.ReadOffset< ushort >( 0x23c );

            // col: 416 offset: 0241
            unknown241 = parser.ReadOffset< byte >( 0x241 );

            // col: 544 offset: 0242
            unknown242 = parser.ReadOffset< byte >( 0x242 );

            // col: 672 offset: 0243
            packed243 = parser.ReadOffset< byte >( 0x243, ExcelColumnDataType.UInt8 );

            // col: 481 offset: 0248
            unknown248 = parser.ReadOffset< uint >( 0x248 );

            // col: 609 offset: 024c
            unknown24c = parser.ReadOffset< ushort >( 0x24c );

            // col: 417 offset: 0251
            unknown251 = parser.ReadOffset< byte >( 0x251 );

            // col: 545 offset: 0252
            unknown252 = parser.ReadOffset< byte >( 0x252 );

            // col: 673 offset: 0253
            packed253 = parser.ReadOffset< byte >( 0x253, ExcelColumnDataType.UInt8 );

            // col: 482 offset: 0258
            unknown258 = parser.ReadOffset< uint >( 0x258 );

            // col: 610 offset: 025c
            unknown25c = parser.ReadOffset< ushort >( 0x25c );

            // col: 418 offset: 0261
            unknown261 = parser.ReadOffset< byte >( 0x261 );

            // col: 546 offset: 0262
            unknown262 = parser.ReadOffset< byte >( 0x262 );

            // col: 674 offset: 0263
            packed263 = parser.ReadOffset< byte >( 0x263, ExcelColumnDataType.UInt8 );

            // col: 483 offset: 0268
            unknown268 = parser.ReadOffset< uint >( 0x268 );

            // col: 611 offset: 026c
            unknown26c = parser.ReadOffset< ushort >( 0x26c );

            // col: 419 offset: 0271
            unknown271 = parser.ReadOffset< byte >( 0x271 );

            // col: 547 offset: 0272
            unknown272 = parser.ReadOffset< byte >( 0x272 );

            // col: 675 offset: 0273
            packed273 = parser.ReadOffset< byte >( 0x273, ExcelColumnDataType.UInt8 );

            // col: 484 offset: 0278
            unknown278 = parser.ReadOffset< uint >( 0x278 );

            // col: 612 offset: 027c
            unknown27c = parser.ReadOffset< ushort >( 0x27c );

            // col: 420 offset: 0281
            unknown281 = parser.ReadOffset< byte >( 0x281 );

            // col: 548 offset: 0282
            unknown282 = parser.ReadOffset< byte >( 0x282 );

            // col: 676 offset: 0283
            packed283 = parser.ReadOffset< byte >( 0x283, ExcelColumnDataType.UInt8 );

            // col: 485 offset: 0288
            unknown288 = parser.ReadOffset< uint >( 0x288 );

            // col: 613 offset: 028c
            unknown28c = parser.ReadOffset< ushort >( 0x28c );

            // col: 421 offset: 0291
            unknown291 = parser.ReadOffset< byte >( 0x291 );

            // col: 549 offset: 0292
            unknown292 = parser.ReadOffset< byte >( 0x292 );

            // col: 677 offset: 0293
            packed293 = parser.ReadOffset< byte >( 0x293, ExcelColumnDataType.UInt8 );

            // col: 486 offset: 0298
            unknown298 = parser.ReadOffset< uint >( 0x298 );

            // col: 614 offset: 029c
            unknown29c = parser.ReadOffset< ushort >( 0x29c );

            // col: 422 offset: 02a1
            unknown2a1 = parser.ReadOffset< byte >( 0x2a1 );

            // col: 550 offset: 02a2
            unknown2a2 = parser.ReadOffset< byte >( 0x2a2 );

            // col: 678 offset: 02a3
            packed2a3 = parser.ReadOffset< byte >( 0x2a3, ExcelColumnDataType.UInt8 );

            // col: 487 offset: 02a8
            unknown2a8 = parser.ReadOffset< uint >( 0x2a8 );

            // col: 615 offset: 02ac
            unknown2ac = parser.ReadOffset< ushort >( 0x2ac );

            // col: 423 offset: 02b1
            unknown2b1 = parser.ReadOffset< byte >( 0x2b1 );

            // col: 551 offset: 02b2
            unknown2b2 = parser.ReadOffset< byte >( 0x2b2 );

            // col: 679 offset: 02b3
            packed2b3 = parser.ReadOffset< byte >( 0x2b3, ExcelColumnDataType.UInt8 );

            // col: 488 offset: 02b8
            unknown2b8 = parser.ReadOffset< uint >( 0x2b8 );

            // col: 616 offset: 02bc
            unknown2bc = parser.ReadOffset< ushort >( 0x2bc );

            // col: 424 offset: 02c1
            unknown2c1 = parser.ReadOffset< byte >( 0x2c1 );

            // col: 552 offset: 02c2
            unknown2c2 = parser.ReadOffset< byte >( 0x2c2 );

            // col: 680 offset: 02c3
            packed2c3 = parser.ReadOffset< byte >( 0x2c3, ExcelColumnDataType.UInt8 );

            // col: 489 offset: 02c8
            unknown2c8 = parser.ReadOffset< uint >( 0x2c8 );

            // col: 617 offset: 02cc
            unknown2cc = parser.ReadOffset< ushort >( 0x2cc );

            // col: 425 offset: 02d1
            unknown2d1 = parser.ReadOffset< byte >( 0x2d1 );

            // col: 553 offset: 02d2
            unknown2d2 = parser.ReadOffset< byte >( 0x2d2 );

            // col: 681 offset: 02d3
            packed2d3 = parser.ReadOffset< byte >( 0x2d3, ExcelColumnDataType.UInt8 );

            // col: 490 offset: 02d8
            unknown2d8 = parser.ReadOffset< uint >( 0x2d8 );

            // col: 618 offset: 02dc
            unknown2dc = parser.ReadOffset< ushort >( 0x2dc );

            // col: 426 offset: 02e1
            unknown2e1 = parser.ReadOffset< byte >( 0x2e1 );

            // col: 554 offset: 02e2
            unknown2e2 = parser.ReadOffset< byte >( 0x2e2 );

            // col: 682 offset: 02e3
            packed2e3 = parser.ReadOffset< byte >( 0x2e3, ExcelColumnDataType.UInt8 );

            // col: 491 offset: 02e8
            unknown2e8 = parser.ReadOffset< uint >( 0x2e8 );

            // col: 619 offset: 02ec
            unknown2ec = parser.ReadOffset< ushort >( 0x2ec );

            // col: 427 offset: 02f1
            unknown2f1 = parser.ReadOffset< byte >( 0x2f1 );

            // col: 555 offset: 02f2
            unknown2f2 = parser.ReadOffset< byte >( 0x2f2 );

            // col: 683 offset: 02f3
            packed2f3 = parser.ReadOffset< byte >( 0x2f3, ExcelColumnDataType.UInt8 );

            // col: 492 offset: 02f8
            unknown2f8 = parser.ReadOffset< uint >( 0x2f8 );

            // col: 620 offset: 02fc
            unknown2fc = parser.ReadOffset< ushort >( 0x2fc );

            // col: 428 offset: 0301
            unknown301 = parser.ReadOffset< byte >( 0x301 );

            // col: 556 offset: 0302
            unknown302 = parser.ReadOffset< byte >( 0x302 );

            // col: 684 offset: 0303
            packed303 = parser.ReadOffset< byte >( 0x303, ExcelColumnDataType.UInt8 );

            // col: 493 offset: 0308
            unknown308 = parser.ReadOffset< uint >( 0x308 );

            // col: 621 offset: 030c
            unknown30c = parser.ReadOffset< ushort >( 0x30c );

            // col: 429 offset: 0311
            unknown311 = parser.ReadOffset< byte >( 0x311 );

            // col: 557 offset: 0312
            unknown312 = parser.ReadOffset< byte >( 0x312 );

            // col: 685 offset: 0313
            packed313 = parser.ReadOffset< byte >( 0x313, ExcelColumnDataType.UInt8 );

            // col: 494 offset: 0318
            unknown318 = parser.ReadOffset< uint >( 0x318 );

            // col: 622 offset: 031c
            unknown31c = parser.ReadOffset< ushort >( 0x31c );

            // col: 430 offset: 0321
            unknown321 = parser.ReadOffset< byte >( 0x321 );

            // col: 558 offset: 0322
            unknown322 = parser.ReadOffset< byte >( 0x322 );

            // col: 686 offset: 0323
            packed323 = parser.ReadOffset< byte >( 0x323, ExcelColumnDataType.UInt8 );

            // col: 495 offset: 0328
            unknown328 = parser.ReadOffset< uint >( 0x328 );

            // col: 623 offset: 032c
            unknown32c = parser.ReadOffset< ushort >( 0x32c );

            // col: 431 offset: 0331
            unknown331 = parser.ReadOffset< byte >( 0x331 );

            // col: 559 offset: 0332
            unknown332 = parser.ReadOffset< byte >( 0x332 );

            // col: 687 offset: 0333
            packed333 = parser.ReadOffset< byte >( 0x333, ExcelColumnDataType.UInt8 );

            // col: 496 offset: 0338
            unknown338 = parser.ReadOffset< uint >( 0x338 );

            // col: 624 offset: 033c
            unknown33c = parser.ReadOffset< ushort >( 0x33c );

            // col: 432 offset: 0341
            unknown341 = parser.ReadOffset< byte >( 0x341 );

            // col: 560 offset: 0342
            unknown342 = parser.ReadOffset< byte >( 0x342 );

            // col: 688 offset: 0343
            packed343 = parser.ReadOffset< byte >( 0x343, ExcelColumnDataType.UInt8 );

            // col: 497 offset: 0348
            unknown348 = parser.ReadOffset< uint >( 0x348 );

            // col: 625 offset: 034c
            unknown34c = parser.ReadOffset< ushort >( 0x34c );

            // col: 433 offset: 0351
            unknown351 = parser.ReadOffset< byte >( 0x351 );

            // col: 561 offset: 0352
            unknown352 = parser.ReadOffset< byte >( 0x352 );

            // col: 689 offset: 0353
            packed353 = parser.ReadOffset< byte >( 0x353, ExcelColumnDataType.UInt8 );

            // col: 498 offset: 0358
            unknown358 = parser.ReadOffset< uint >( 0x358 );

            // col: 626 offset: 035c
            unknown35c = parser.ReadOffset< ushort >( 0x35c );

            // col: 434 offset: 0361
            unknown361 = parser.ReadOffset< byte >( 0x361 );

            // col: 562 offset: 0362
            unknown362 = parser.ReadOffset< byte >( 0x362 );

            // col: 690 offset: 0363
            packed363 = parser.ReadOffset< byte >( 0x363, ExcelColumnDataType.UInt8 );

            // col: 499 offset: 0368
            unknown368 = parser.ReadOffset< uint >( 0x368 );

            // col: 627 offset: 036c
            unknown36c = parser.ReadOffset< ushort >( 0x36c );

            // col: 435 offset: 0371
            unknown371 = parser.ReadOffset< byte >( 0x371 );

            // col: 563 offset: 0372
            unknown372 = parser.ReadOffset< byte >( 0x372 );

            // col: 691 offset: 0373
            packed373 = parser.ReadOffset< byte >( 0x373, ExcelColumnDataType.UInt8 );

            // col: 500 offset: 0378
            unknown378 = parser.ReadOffset< uint >( 0x378 );

            // col: 628 offset: 037c
            unknown37c = parser.ReadOffset< ushort >( 0x37c );

            // col: 436 offset: 0381
            unknown381 = parser.ReadOffset< byte >( 0x381 );

            // col: 564 offset: 0382
            unknown382 = parser.ReadOffset< byte >( 0x382 );

            // col: 692 offset: 0383
            packed383 = parser.ReadOffset< byte >( 0x383, ExcelColumnDataType.UInt8 );

            // col: 501 offset: 0388
            unknown388 = parser.ReadOffset< uint >( 0x388 );

            // col: 629 offset: 038c
            unknown38c = parser.ReadOffset< ushort >( 0x38c );

            // col: 437 offset: 0391
            unknown391 = parser.ReadOffset< byte >( 0x391 );

            // col: 565 offset: 0392
            unknown392 = parser.ReadOffset< byte >( 0x392 );

            // col: 693 offset: 0393
            packed393 = parser.ReadOffset< byte >( 0x393, ExcelColumnDataType.UInt8 );

            // col: 502 offset: 0398
            unknown398 = parser.ReadOffset< uint >( 0x398 );

            // col: 630 offset: 039c
            unknown39c = parser.ReadOffset< ushort >( 0x39c );

            // col: 374 offset: 03a0
            QuestUInt8B = new byte[32];
            QuestUInt8B[0] = parser.ReadOffset< byte >( 0x3a0 );
            QuestUInt8B[1] = parser.ReadOffset< byte >( 0x3b0 );
            QuestUInt8B[2] = parser.ReadOffset< byte >( 0x3c0 );
            QuestUInt8B[3] = parser.ReadOffset< byte >( 0x3d0 );
            QuestUInt8B[4] = parser.ReadOffset< byte >( 0x3e0 );
            QuestUInt8B[5] = parser.ReadOffset< byte >( 0x3f0 );
            QuestUInt8B[6] = parser.ReadOffset< byte >( 0x400 );
            QuestUInt8B[7] = parser.ReadOffset< byte >( 0x410 );
            QuestUInt8B[8] = parser.ReadOffset< byte >( 0x420 );
            QuestUInt8B[9] = parser.ReadOffset< byte >( 0x430 );
            QuestUInt8B[10] = parser.ReadOffset< byte >( 0x440 );
            QuestUInt8B[11] = parser.ReadOffset< byte >( 0x450 );
            QuestUInt8B[12] = parser.ReadOffset< byte >( 0x460 );
            QuestUInt8B[13] = parser.ReadOffset< byte >( 0x470 );
            QuestUInt8B[14] = parser.ReadOffset< byte >( 0x480 );
            QuestUInt8B[15] = parser.ReadOffset< byte >( 0x490 );
            QuestUInt8B[16] = parser.ReadOffset< byte >( 0x4a0 );
            QuestUInt8B[17] = parser.ReadOffset< byte >( 0x4b0 );
            QuestUInt8B[18] = parser.ReadOffset< byte >( 0x4c0 );
            QuestUInt8B[19] = parser.ReadOffset< byte >( 0x4d0 );
            QuestUInt8B[20] = parser.ReadOffset< byte >( 0x4e0 );
            QuestUInt8B[21] = parser.ReadOffset< byte >( 0x4f0 );
            QuestUInt8B[22] = parser.ReadOffset< byte >( 0x500 );
            QuestUInt8B[23] = parser.ReadOffset< byte >( 0x510 );
            QuestUInt8B[24] = parser.ReadOffset< byte >( 0x520 );
            QuestUInt8B[25] = parser.ReadOffset< byte >( 0x530 );
            QuestUInt8B[26] = parser.ReadOffset< byte >( 0x540 );
            QuestUInt8B[27] = parser.ReadOffset< byte >( 0x550 );
            QuestUInt8B[28] = parser.ReadOffset< byte >( 0x560 );
            QuestUInt8B[29] = parser.ReadOffset< byte >( 0x570 );
            QuestUInt8B[30] = parser.ReadOffset< byte >( 0x580 );
            QuestUInt8B[31] = parser.ReadOffset< byte >( 0x590 );

            // col: 438 offset: 03a1
            unknown3a1 = parser.ReadOffset< byte >( 0x3a1 );

            // col: 566 offset: 03a2
            unknown3a2 = parser.ReadOffset< byte >( 0x3a2 );

            // col: 694 offset: 03a3
            packed3a3 = parser.ReadOffset< byte >( 0x3a3, ExcelColumnDataType.UInt8 );

            // col: 503 offset: 03a8
            unknown3a8 = parser.ReadOffset< uint >( 0x3a8 );

            // col: 631 offset: 03ac
            unknown3ac = parser.ReadOffset< ushort >( 0x3ac );

            // col: 439 offset: 03b1
            unknown3b1 = parser.ReadOffset< byte >( 0x3b1 );

            // col: 567 offset: 03b2
            unknown3b2 = parser.ReadOffset< byte >( 0x3b2 );

            // col: 695 offset: 03b3
            packed3b3 = parser.ReadOffset< byte >( 0x3b3, ExcelColumnDataType.UInt8 );

            // col: 504 offset: 03b8
            unknown3b8 = parser.ReadOffset< uint >( 0x3b8 );

            // col: 632 offset: 03bc
            unknown3bc = parser.ReadOffset< ushort >( 0x3bc );

            // col: 440 offset: 03c1
            unknown3c1 = parser.ReadOffset< byte >( 0x3c1 );

            // col: 568 offset: 03c2
            unknown3c2 = parser.ReadOffset< byte >( 0x3c2 );

            // col: 696 offset: 03c3
            packed3c3 = parser.ReadOffset< byte >( 0x3c3, ExcelColumnDataType.UInt8 );

            // col: 505 offset: 03c8
            unknown3c8 = parser.ReadOffset< uint >( 0x3c8 );

            // col: 633 offset: 03cc
            unknown3cc = parser.ReadOffset< ushort >( 0x3cc );

            // col: 441 offset: 03d1
            unknown3d1 = parser.ReadOffset< byte >( 0x3d1 );

            // col: 569 offset: 03d2
            unknown3d2 = parser.ReadOffset< byte >( 0x3d2 );

            // col: 697 offset: 03d3
            packed3d3 = parser.ReadOffset< byte >( 0x3d3, ExcelColumnDataType.UInt8 );

            // col: 506 offset: 03d8
            unknown3d8 = parser.ReadOffset< uint >( 0x3d8 );

            // col: 634 offset: 03dc
            unknown3dc = parser.ReadOffset< ushort >( 0x3dc );

            // col: 442 offset: 03e1
            unknown3e1 = parser.ReadOffset< byte >( 0x3e1 );

            // col: 570 offset: 03e2
            unknown3e2 = parser.ReadOffset< byte >( 0x3e2 );

            // col: 698 offset: 03e3
            packed3e3 = parser.ReadOffset< byte >( 0x3e3, ExcelColumnDataType.UInt8 );

            // col: 507 offset: 03e8
            unknown3e8 = parser.ReadOffset< uint >( 0x3e8 );

            // col: 635 offset: 03ec
            unknown3ec = parser.ReadOffset< ushort >( 0x3ec );

            // col: 443 offset: 03f1
            unknown3f1 = parser.ReadOffset< byte >( 0x3f1 );

            // col: 571 offset: 03f2
            unknown3f2 = parser.ReadOffset< byte >( 0x3f2 );

            // col: 699 offset: 03f3
            packed3f3 = parser.ReadOffset< byte >( 0x3f3, ExcelColumnDataType.UInt8 );

            // col: 508 offset: 03f8
            unknown3f8 = parser.ReadOffset< uint >( 0x3f8 );

            // col: 636 offset: 03fc
            unknown3fc = parser.ReadOffset< ushort >( 0x3fc );

            // col: 444 offset: 0401
            unknown401 = parser.ReadOffset< byte >( 0x401 );

            // col: 572 offset: 0402
            unknown402 = parser.ReadOffset< byte >( 0x402 );

            // col: 700 offset: 0403
            packed403 = parser.ReadOffset< byte >( 0x403, ExcelColumnDataType.UInt8 );

            // col: 509 offset: 0408
            unknown408 = parser.ReadOffset< uint >( 0x408 );

            // col: 637 offset: 040c
            unknown40c = parser.ReadOffset< ushort >( 0x40c );

            // col: 445 offset: 0411
            unknown411 = parser.ReadOffset< byte >( 0x411 );

            // col: 573 offset: 0412
            unknown412 = parser.ReadOffset< byte >( 0x412 );

            // col: 701 offset: 0413
            packed413 = parser.ReadOffset< byte >( 0x413, ExcelColumnDataType.UInt8 );

            // col: 510 offset: 0418
            unknown418 = parser.ReadOffset< uint >( 0x418 );

            // col: 638 offset: 041c
            unknown41c = parser.ReadOffset< ushort >( 0x41c );

            // col: 446 offset: 0421
            unknown421 = parser.ReadOffset< byte >( 0x421 );

            // col: 574 offset: 0422
            unknown422 = parser.ReadOffset< byte >( 0x422 );

            // col: 702 offset: 0423
            packed423 = parser.ReadOffset< byte >( 0x423, ExcelColumnDataType.UInt8 );

            // col: 511 offset: 0428
            unknown428 = parser.ReadOffset< uint >( 0x428 );

            // col: 639 offset: 042c
            unknown42c = parser.ReadOffset< ushort >( 0x42c );

            // col: 447 offset: 0431
            unknown431 = parser.ReadOffset< byte >( 0x431 );

            // col: 575 offset: 0432
            unknown432 = parser.ReadOffset< byte >( 0x432 );

            // col: 703 offset: 0433
            packed433 = parser.ReadOffset< byte >( 0x433, ExcelColumnDataType.UInt8 );

            // col: 512 offset: 0438
            unknown438 = parser.ReadOffset< uint >( 0x438 );

            // col: 640 offset: 043c
            unknown43c = parser.ReadOffset< ushort >( 0x43c );

            // col: 448 offset: 0441
            unknown441 = parser.ReadOffset< byte >( 0x441 );

            // col: 576 offset: 0442
            unknown442 = parser.ReadOffset< byte >( 0x442 );

            // col: 704 offset: 0443
            packed443 = parser.ReadOffset< byte >( 0x443, ExcelColumnDataType.UInt8 );

            // col: 513 offset: 0448
            unknown448 = parser.ReadOffset< uint >( 0x448 );

            // col: 641 offset: 044c
            unknown44c = parser.ReadOffset< ushort >( 0x44c );

            // col: 449 offset: 0451
            unknown451 = parser.ReadOffset< byte >( 0x451 );

            // col: 577 offset: 0452
            unknown452 = parser.ReadOffset< byte >( 0x452 );

            // col: 705 offset: 0453
            packed453 = parser.ReadOffset< byte >( 0x453, ExcelColumnDataType.UInt8 );

            // col: 514 offset: 0458
            unknown458 = parser.ReadOffset< uint >( 0x458 );

            // col: 642 offset: 045c
            unknown45c = parser.ReadOffset< ushort >( 0x45c );

            // col: 450 offset: 0461
            unknown461 = parser.ReadOffset< byte >( 0x461 );

            // col: 578 offset: 0462
            unknown462 = parser.ReadOffset< byte >( 0x462 );

            // col: 706 offset: 0463
            packed463 = parser.ReadOffset< byte >( 0x463, ExcelColumnDataType.UInt8 );

            // col: 515 offset: 0468
            unknown468 = parser.ReadOffset< uint >( 0x468 );

            // col: 643 offset: 046c
            unknown46c = parser.ReadOffset< ushort >( 0x46c );

            // col: 451 offset: 0471
            unknown471 = parser.ReadOffset< byte >( 0x471 );

            // col: 579 offset: 0472
            unknown472 = parser.ReadOffset< byte >( 0x472 );

            // col: 707 offset: 0473
            packed473 = parser.ReadOffset< byte >( 0x473, ExcelColumnDataType.UInt8 );

            // col: 516 offset: 0478
            unknown478 = parser.ReadOffset< uint >( 0x478 );

            // col: 644 offset: 047c
            unknown47c = parser.ReadOffset< ushort >( 0x47c );

            // col: 452 offset: 0481
            unknown481 = parser.ReadOffset< byte >( 0x481 );

            // col: 580 offset: 0482
            unknown482 = parser.ReadOffset< byte >( 0x482 );

            // col: 708 offset: 0483
            packed483 = parser.ReadOffset< byte >( 0x483, ExcelColumnDataType.UInt8 );

            // col: 517 offset: 0488
            unknown488 = parser.ReadOffset< uint >( 0x488 );

            // col: 645 offset: 048c
            unknown48c = parser.ReadOffset< ushort >( 0x48c );

            // col: 453 offset: 0491
            unknown491 = parser.ReadOffset< byte >( 0x491 );

            // col: 581 offset: 0492
            unknown492 = parser.ReadOffset< byte >( 0x492 );

            // col: 709 offset: 0493
            packed493 = parser.ReadOffset< byte >( 0x493, ExcelColumnDataType.UInt8 );

            // col: 518 offset: 0498
            unknown498 = parser.ReadOffset< uint >( 0x498 );

            // col: 646 offset: 049c
            unknown49c = parser.ReadOffset< ushort >( 0x49c );

            // col: 454 offset: 04a1
            unknown4a1 = parser.ReadOffset< byte >( 0x4a1 );

            // col: 582 offset: 04a2
            unknown4a2 = parser.ReadOffset< byte >( 0x4a2 );

            // col: 710 offset: 04a3
            packed4a3 = parser.ReadOffset< byte >( 0x4a3, ExcelColumnDataType.UInt8 );

            // col: 519 offset: 04a8
            unknown4a8 = parser.ReadOffset< uint >( 0x4a8 );

            // col: 647 offset: 04ac
            unknown4ac = parser.ReadOffset< ushort >( 0x4ac );

            // col: 455 offset: 04b1
            unknown4b1 = parser.ReadOffset< byte >( 0x4b1 );

            // col: 583 offset: 04b2
            unknown4b2 = parser.ReadOffset< byte >( 0x4b2 );

            // col: 711 offset: 04b3
            packed4b3 = parser.ReadOffset< byte >( 0x4b3, ExcelColumnDataType.UInt8 );

            // col: 520 offset: 04b8
            unknown4b8 = parser.ReadOffset< uint >( 0x4b8 );

            // col: 648 offset: 04bc
            unknown4bc = parser.ReadOffset< ushort >( 0x4bc );

            // col: 456 offset: 04c1
            unknown4c1 = parser.ReadOffset< byte >( 0x4c1 );

            // col: 584 offset: 04c2
            unknown4c2 = parser.ReadOffset< byte >( 0x4c2 );

            // col: 712 offset: 04c3
            packed4c3 = parser.ReadOffset< byte >( 0x4c3, ExcelColumnDataType.UInt8 );

            // col: 521 offset: 04c8
            unknown4c8 = parser.ReadOffset< uint >( 0x4c8 );

            // col: 649 offset: 04cc
            unknown4cc = parser.ReadOffset< ushort >( 0x4cc );

            // col: 457 offset: 04d1
            unknown4d1 = parser.ReadOffset< byte >( 0x4d1 );

            // col: 585 offset: 04d2
            unknown4d2 = parser.ReadOffset< byte >( 0x4d2 );

            // col: 713 offset: 04d3
            packed4d3 = parser.ReadOffset< byte >( 0x4d3, ExcelColumnDataType.UInt8 );

            // col: 522 offset: 04d8
            unknown4d8 = parser.ReadOffset< uint >( 0x4d8 );

            // col: 650 offset: 04dc
            unknown4dc = parser.ReadOffset< ushort >( 0x4dc );

            // col: 458 offset: 04e1
            unknown4e1 = parser.ReadOffset< byte >( 0x4e1 );

            // col: 586 offset: 04e2
            unknown4e2 = parser.ReadOffset< byte >( 0x4e2 );

            // col: 714 offset: 04e3
            packed4e3 = parser.ReadOffset< byte >( 0x4e3, ExcelColumnDataType.UInt8 );

            // col: 523 offset: 04e8
            unknown4e8 = parser.ReadOffset< uint >( 0x4e8 );

            // col: 651 offset: 04ec
            unknown4ec = parser.ReadOffset< ushort >( 0x4ec );

            // col: 459 offset: 04f1
            unknown4f1 = parser.ReadOffset< byte >( 0x4f1 );

            // col: 587 offset: 04f2
            unknown4f2 = parser.ReadOffset< byte >( 0x4f2 );

            // col: 715 offset: 04f3
            packed4f3 = parser.ReadOffset< byte >( 0x4f3, ExcelColumnDataType.UInt8 );

            // col: 524 offset: 04f8
            unknown4f8 = parser.ReadOffset< uint >( 0x4f8 );

            // col: 652 offset: 04fc
            unknown4fc = parser.ReadOffset< ushort >( 0x4fc );

            // col: 460 offset: 0501
            unknown501 = parser.ReadOffset< byte >( 0x501 );

            // col: 588 offset: 0502
            unknown502 = parser.ReadOffset< byte >( 0x502 );

            // col: 716 offset: 0503
            packed503 = parser.ReadOffset< byte >( 0x503, ExcelColumnDataType.UInt8 );

            // col: 525 offset: 0508
            unknown508 = parser.ReadOffset< uint >( 0x508 );

            // col: 653 offset: 050c
            unknown50c = parser.ReadOffset< ushort >( 0x50c );

            // col: 461 offset: 0511
            unknown511 = parser.ReadOffset< byte >( 0x511 );

            // col: 589 offset: 0512
            unknown512 = parser.ReadOffset< byte >( 0x512 );

            // col: 717 offset: 0513
            packed513 = parser.ReadOffset< byte >( 0x513, ExcelColumnDataType.UInt8 );

            // col: 526 offset: 0518
            unknown518 = parser.ReadOffset< uint >( 0x518 );

            // col: 654 offset: 051c
            unknown51c = parser.ReadOffset< ushort >( 0x51c );

            // col: 462 offset: 0521
            unknown521 = parser.ReadOffset< byte >( 0x521 );

            // col: 590 offset: 0522
            unknown522 = parser.ReadOffset< byte >( 0x522 );

            // col: 718 offset: 0523
            packed523 = parser.ReadOffset< byte >( 0x523, ExcelColumnDataType.UInt8 );

            // col: 527 offset: 0528
            unknown528 = parser.ReadOffset< uint >( 0x528 );

            // col: 655 offset: 052c
            unknown52c = parser.ReadOffset< ushort >( 0x52c );

            // col: 463 offset: 0531
            unknown531 = parser.ReadOffset< byte >( 0x531 );

            // col: 591 offset: 0532
            unknown532 = parser.ReadOffset< byte >( 0x532 );

            // col: 719 offset: 0533
            packed533 = parser.ReadOffset< byte >( 0x533, ExcelColumnDataType.UInt8 );

            // col: 528 offset: 0538
            unknown538 = parser.ReadOffset< uint >( 0x538 );

            // col: 656 offset: 053c
            unknown53c = parser.ReadOffset< ushort >( 0x53c );

            // col: 464 offset: 0541
            unknown541 = parser.ReadOffset< byte >( 0x541 );

            // col: 592 offset: 0542
            unknown542 = parser.ReadOffset< byte >( 0x542 );

            // col: 720 offset: 0543
            packed543 = parser.ReadOffset< byte >( 0x543, ExcelColumnDataType.UInt8 );

            // col: 529 offset: 0548
            unknown548 = parser.ReadOffset< uint >( 0x548 );

            // col: 657 offset: 054c
            unknown54c = parser.ReadOffset< ushort >( 0x54c );

            // col: 465 offset: 0551
            unknown551 = parser.ReadOffset< byte >( 0x551 );

            // col: 593 offset: 0552
            unknown552 = parser.ReadOffset< byte >( 0x552 );

            // col: 721 offset: 0553
            packed553 = parser.ReadOffset< byte >( 0x553, ExcelColumnDataType.UInt8 );

            // col: 530 offset: 0558
            unknown558 = parser.ReadOffset< uint >( 0x558 );

            // col: 658 offset: 055c
            unknown55c = parser.ReadOffset< ushort >( 0x55c );

            // col: 466 offset: 0561
            unknown561 = parser.ReadOffset< byte >( 0x561 );

            // col: 594 offset: 0562
            unknown562 = parser.ReadOffset< byte >( 0x562 );

            // col: 722 offset: 0563
            packed563 = parser.ReadOffset< byte >( 0x563, ExcelColumnDataType.UInt8 );

            // col: 531 offset: 0568
            unknown568 = parser.ReadOffset< uint >( 0x568 );

            // col: 659 offset: 056c
            unknown56c = parser.ReadOffset< ushort >( 0x56c );

            // col: 467 offset: 0571
            unknown571 = parser.ReadOffset< byte >( 0x571 );

            // col: 595 offset: 0572
            unknown572 = parser.ReadOffset< byte >( 0x572 );

            // col: 723 offset: 0573
            packed573 = parser.ReadOffset< byte >( 0x573, ExcelColumnDataType.UInt8 );

            // col: 532 offset: 0578
            unknown578 = parser.ReadOffset< uint >( 0x578 );

            // col: 660 offset: 057c
            unknown57c = parser.ReadOffset< ushort >( 0x57c );

            // col: 468 offset: 0581
            unknown581 = parser.ReadOffset< byte >( 0x581 );

            // col: 596 offset: 0582
            unknown582 = parser.ReadOffset< byte >( 0x582 );

            // col: 724 offset: 0583
            packed583 = parser.ReadOffset< byte >( 0x583, ExcelColumnDataType.UInt8 );

            // col: 533 offset: 0588
            unknown588 = parser.ReadOffset< uint >( 0x588 );

            // col: 661 offset: 058c
            unknown58c = parser.ReadOffset< ushort >( 0x58c );

            // col: 469 offset: 0591
            unknown591 = parser.ReadOffset< byte >( 0x591 );

            // col: 597 offset: 0592
            unknown592 = parser.ReadOffset< byte >( 0x592 );

            // col: 725 offset: 0593
            packed593 = parser.ReadOffset< byte >( 0x593, ExcelColumnDataType.UInt8 );

            // col: 1222 offset: 0594
            ToDoMainLocation = new uint[24];
            ToDoMainLocation[0] = parser.ReadOffset< uint >( 0x594 );
            ToDoMainLocation[1] = parser.ReadOffset< uint >( 0x5b8 );
            ToDoMainLocation[2] = parser.ReadOffset< uint >( 0x5dc );
            ToDoMainLocation[3] = parser.ReadOffset< uint >( 0x600 );
            ToDoMainLocation[4] = parser.ReadOffset< uint >( 0x624 );
            ToDoMainLocation[5] = parser.ReadOffset< uint >( 0x648 );
            ToDoMainLocation[6] = parser.ReadOffset< uint >( 0x66c );
            ToDoMainLocation[7] = parser.ReadOffset< uint >( 0x690 );
            ToDoMainLocation[8] = parser.ReadOffset< uint >( 0x6b4 );
            ToDoMainLocation[9] = parser.ReadOffset< uint >( 0x6d8 );
            ToDoMainLocation[10] = parser.ReadOffset< uint >( 0x6fc );
            ToDoMainLocation[11] = parser.ReadOffset< uint >( 0x720 );
            ToDoMainLocation[12] = parser.ReadOffset< uint >( 0x744 );
            ToDoMainLocation[13] = parser.ReadOffset< uint >( 0x768 );
            ToDoMainLocation[14] = parser.ReadOffset< uint >( 0x78c );
            ToDoMainLocation[15] = parser.ReadOffset< uint >( 0x7b0 );
            ToDoMainLocation[16] = parser.ReadOffset< uint >( 0x7d4 );
            ToDoMainLocation[17] = parser.ReadOffset< uint >( 0x7f8 );
            ToDoMainLocation[18] = parser.ReadOffset< uint >( 0x81c );
            ToDoMainLocation[19] = parser.ReadOffset< uint >( 0x840 );
            ToDoMainLocation[20] = parser.ReadOffset< uint >( 0x864 );
            ToDoMainLocation[21] = parser.ReadOffset< uint >( 0x888 );
            ToDoMainLocation[22] = parser.ReadOffset< uint >( 0x8ac );
            ToDoMainLocation[23] = parser.ReadOffset< uint >( 0x8d0 );

            // col: 1246 offset: 0598
            unknown598 = new uint[7];
            unknown598[0] = parser.ReadOffset< uint >( 0x598 );
            unknown598[1] = parser.ReadOffset< uint >( 0x5bc );
            unknown598[2] = parser.ReadOffset< uint >( 0x5e0 );
            unknown598[3] = parser.ReadOffset< uint >( 0x604 );
            unknown598[4] = parser.ReadOffset< uint >( 0x628 );
            unknown598[5] = parser.ReadOffset< uint >( 0x64c );
            unknown598[6] = parser.ReadOffset< uint >( 0x670 );

            // col: 1270 offset: 059c
            unknown59c = parser.ReadOffset< uint >( 0x59c );

            // col: 1294 offset: 05a0
            unknown5a0 = parser.ReadOffset< uint >( 0x5a0 );

            // col: 1318 offset: 05a4
            unknown5a4 = parser.ReadOffset< uint >( 0x5a4 );

            // col: 1342 offset: 05a8
            unknown5a8 = parser.ReadOffset< uint >( 0x5a8 );

            // col: 1366 offset: 05ac
            unknown5ac = parser.ReadOffset< uint >( 0x5ac );

            // col: 1390 offset: 05b0
            unknown5b0 = parser.ReadOffset< uint >( 0x5b0 );

            // col: 1174 offset: 05b4
            ToDoCompleteSeq = new byte[24];
            ToDoCompleteSeq[0] = parser.ReadOffset< byte >( 0x5b4 );
            ToDoCompleteSeq[1] = parser.ReadOffset< byte >( 0x5d8 );
            ToDoCompleteSeq[2] = parser.ReadOffset< byte >( 0x5fc );
            ToDoCompleteSeq[3] = parser.ReadOffset< byte >( 0x620 );
            ToDoCompleteSeq[4] = parser.ReadOffset< byte >( 0x644 );
            ToDoCompleteSeq[5] = parser.ReadOffset< byte >( 0x668 );
            ToDoCompleteSeq[6] = parser.ReadOffset< byte >( 0x68c );
            ToDoCompleteSeq[7] = parser.ReadOffset< byte >( 0x6b0 );
            ToDoCompleteSeq[8] = parser.ReadOffset< byte >( 0x6d4 );
            ToDoCompleteSeq[9] = parser.ReadOffset< byte >( 0x6f8 );
            ToDoCompleteSeq[10] = parser.ReadOffset< byte >( 0x71c );
            ToDoCompleteSeq[11] = parser.ReadOffset< byte >( 0x740 );
            ToDoCompleteSeq[12] = parser.ReadOffset< byte >( 0x764 );
            ToDoCompleteSeq[13] = parser.ReadOffset< byte >( 0x788 );
            ToDoCompleteSeq[14] = parser.ReadOffset< byte >( 0x7ac );
            ToDoCompleteSeq[15] = parser.ReadOffset< byte >( 0x7d0 );
            ToDoCompleteSeq[16] = parser.ReadOffset< byte >( 0x7f4 );
            ToDoCompleteSeq[17] = parser.ReadOffset< byte >( 0x818 );
            ToDoCompleteSeq[18] = parser.ReadOffset< byte >( 0x83c );
            ToDoCompleteSeq[19] = parser.ReadOffset< byte >( 0x860 );
            ToDoCompleteSeq[20] = parser.ReadOffset< byte >( 0x884 );
            ToDoCompleteSeq[21] = parser.ReadOffset< byte >( 0x8a8 );
            ToDoCompleteSeq[22] = parser.ReadOffset< byte >( 0x8cc );
            ToDoCompleteSeq[23] = parser.ReadOffset< byte >( 0x8f0 );

            // col: 1198 offset: 05b5
            ToDoQty = new byte[24];
            ToDoQty[0] = parser.ReadOffset< byte >( 0x5b5 );
            ToDoQty[1] = parser.ReadOffset< byte >( 0x5d9 );
            ToDoQty[2] = parser.ReadOffset< byte >( 0x5fd );
            ToDoQty[3] = parser.ReadOffset< byte >( 0x621 );
            ToDoQty[4] = parser.ReadOffset< byte >( 0x645 );
            ToDoQty[5] = parser.ReadOffset< byte >( 0x669 );
            ToDoQty[6] = parser.ReadOffset< byte >( 0x68d );
            ToDoQty[7] = parser.ReadOffset< byte >( 0x6b1 );
            ToDoQty[8] = parser.ReadOffset< byte >( 0x6d5 );
            ToDoQty[9] = parser.ReadOffset< byte >( 0x6f9 );
            ToDoQty[10] = parser.ReadOffset< byte >( 0x71d );
            ToDoQty[11] = parser.ReadOffset< byte >( 0x741 );
            ToDoQty[12] = parser.ReadOffset< byte >( 0x765 );
            ToDoQty[13] = parser.ReadOffset< byte >( 0x789 );
            ToDoQty[14] = parser.ReadOffset< byte >( 0x7ad );
            ToDoQty[15] = parser.ReadOffset< byte >( 0x7d1 );
            ToDoQty[16] = parser.ReadOffset< byte >( 0x7f5 );
            ToDoQty[17] = parser.ReadOffset< byte >( 0x819 );
            ToDoQty[18] = parser.ReadOffset< byte >( 0x83d );
            ToDoQty[19] = parser.ReadOffset< byte >( 0x861 );
            ToDoQty[20] = parser.ReadOffset< byte >( 0x885 );
            ToDoQty[21] = parser.ReadOffset< byte >( 0x8a9 );
            ToDoQty[22] = parser.ReadOffset< byte >( 0x8cd );
            ToDoQty[23] = parser.ReadOffset< byte >( 0x8f1 );

            // col: 1414 offset: 05b6
            unknown5b6 = parser.ReadOffset< byte >( 0x5b6 );

            // col: 1271 offset: 05c0
            unknown5c0 = parser.ReadOffset< uint >( 0x5c0 );

            // col: 1295 offset: 05c4
            unknown5c4 = parser.ReadOffset< uint >( 0x5c4 );

            // col: 1319 offset: 05c8
            unknown5c8 = parser.ReadOffset< uint >( 0x5c8 );

            // col: 1343 offset: 05cc
            unknown5cc = parser.ReadOffset< uint >( 0x5cc );

            // col: 1367 offset: 05d0
            unknown5d0 = parser.ReadOffset< uint >( 0x5d0 );

            // col: 1391 offset: 05d4
            unknown5d4 = parser.ReadOffset< uint >( 0x5d4 );

            // col: 1415 offset: 05da
            unknown5da = parser.ReadOffset< byte >( 0x5da );

            // col: 1272 offset: 05e4
            unknown5e4 = parser.ReadOffset< uint >( 0x5e4 );

            // col: 1296 offset: 05e8
            unknown5e8 = parser.ReadOffset< uint >( 0x5e8 );

            // col: 1320 offset: 05ec
            unknown5ec = parser.ReadOffset< uint >( 0x5ec );

            // col: 1344 offset: 05f0
            unknown5f0 = parser.ReadOffset< uint >( 0x5f0 );

            // col: 1368 offset: 05f4
            unknown5f4 = parser.ReadOffset< uint >( 0x5f4 );

            // col: 1392 offset: 05f8
            unknown5f8 = parser.ReadOffset< uint >( 0x5f8 );

            // col: 1416 offset: 05fe
            unknown5fe = parser.ReadOffset< byte >( 0x5fe );

            // col: 1273 offset: 0608
            unknown608 = parser.ReadOffset< uint >( 0x608 );

            // col: 1297 offset: 060c
            unknown60c = parser.ReadOffset< uint >( 0x60c );

            // col: 1321 offset: 0610
            unknown610 = parser.ReadOffset< uint >( 0x610 );

            // col: 1345 offset: 0614
            unknown614 = parser.ReadOffset< uint >( 0x614 );

            // col: 1369 offset: 0618
            unknown618 = parser.ReadOffset< uint >( 0x618 );

            // col: 1393 offset: 061c
            unknown61c = parser.ReadOffset< uint >( 0x61c );

            // col: 1417 offset: 0622
            unknown622 = parser.ReadOffset< byte >( 0x622 );

            // col: 1274 offset: 062c
            unknown62c = parser.ReadOffset< uint >( 0x62c );

            // col: 1298 offset: 0630
            unknown630 = parser.ReadOffset< uint >( 0x630 );

            // col: 1322 offset: 0634
            unknown634 = parser.ReadOffset< uint >( 0x634 );

            // col: 1346 offset: 0638
            unknown638 = parser.ReadOffset< uint >( 0x638 );

            // col: 1370 offset: 063c
            unknown63c = parser.ReadOffset< uint >( 0x63c );

            // col: 1394 offset: 0640
            unknown640 = parser.ReadOffset< uint >( 0x640 );

            // col: 1418 offset: 0646
            unknown646 = parser.ReadOffset< byte >( 0x646 );

            // col: 1275 offset: 0650
            unknown650 = parser.ReadOffset< uint >( 0x650 );

            // col: 1299 offset: 0654
            unknown654 = parser.ReadOffset< uint >( 0x654 );

            // col: 1323 offset: 0658
            unknown658 = parser.ReadOffset< uint >( 0x658 );

            // col: 1347 offset: 065c
            unknown65c = parser.ReadOffset< uint >( 0x65c );

            // col: 1371 offset: 0660
            unknown660 = parser.ReadOffset< uint >( 0x660 );

            // col: 1395 offset: 0664
            unknown664 = parser.ReadOffset< uint >( 0x664 );

            // col: 1419 offset: 066a
            unknown66a = parser.ReadOffset< byte >( 0x66a );

            // col: 1276 offset: 0674
            unknown674 = parser.ReadOffset< uint >( 0x674 );

            // col: 1300 offset: 0678
            unknown678 = parser.ReadOffset< uint >( 0x678 );

            // col: 1324 offset: 067c
            unknown67c = parser.ReadOffset< uint >( 0x67c );

            // col: 1348 offset: 0680
            unknown680 = parser.ReadOffset< uint >( 0x680 );

            // col: 1372 offset: 0684
            unknown684 = parser.ReadOffset< uint >( 0x684 );

            // col: 1396 offset: 0688
            unknown688 = parser.ReadOffset< uint >( 0x688 );

            // col: 1420 offset: 068e
            unknown68e = parser.ReadOffset< byte >( 0x68e );

            // col: 1253 offset: 0694
            unknown694 = parser.ReadOffset< uint >( 0x694 );

            // col: 1277 offset: 0698
            unknown698 = parser.ReadOffset< uint >( 0x698 );

            // col: 1301 offset: 069c
            unknown69c = parser.ReadOffset< uint >( 0x69c );

            // col: 1325 offset: 06a0
            unknown6a0 = parser.ReadOffset< uint >( 0x6a0 );

            // col: 1349 offset: 06a4
            unknown6a4 = parser.ReadOffset< uint >( 0x6a4 );

            // col: 1373 offset: 06a8
            unknown6a8 = parser.ReadOffset< uint >( 0x6a8 );

            // col: 1397 offset: 06ac
            unknown6ac = parser.ReadOffset< uint >( 0x6ac );

            // col: 1421 offset: 06b2
            unknown6b2 = parser.ReadOffset< byte >( 0x6b2 );

            // col: 1254 offset: 06b8
            unknown6b8 = parser.ReadOffset< uint >( 0x6b8 );

            // col: 1278 offset: 06bc
            unknown6bc = parser.ReadOffset< uint >( 0x6bc );

            // col: 1302 offset: 06c0
            unknown6c0 = parser.ReadOffset< uint >( 0x6c0 );

            // col: 1326 offset: 06c4
            unknown6c4 = parser.ReadOffset< uint >( 0x6c4 );

            // col: 1350 offset: 06c8
            unknown6c8 = parser.ReadOffset< uint >( 0x6c8 );

            // col: 1374 offset: 06cc
            unknown6cc = parser.ReadOffset< uint >( 0x6cc );

            // col: 1398 offset: 06d0
            unknown6d0 = parser.ReadOffset< uint >( 0x6d0 );

            // col: 1422 offset: 06d6
            unknown6d6 = parser.ReadOffset< byte >( 0x6d6 );

            // col: 1255 offset: 06dc
            unknown6dc = parser.ReadOffset< uint >( 0x6dc );

            // col: 1279 offset: 06e0
            unknown6e0 = parser.ReadOffset< uint >( 0x6e0 );

            // col: 1303 offset: 06e4
            unknown6e4 = parser.ReadOffset< uint >( 0x6e4 );

            // col: 1327 offset: 06e8
            unknown6e8 = parser.ReadOffset< uint >( 0x6e8 );

            // col: 1351 offset: 06ec
            unknown6ec = parser.ReadOffset< uint >( 0x6ec );

            // col: 1375 offset: 06f0
            unknown6f0 = parser.ReadOffset< uint >( 0x6f0 );

            // col: 1399 offset: 06f4
            unknown6f4 = parser.ReadOffset< uint >( 0x6f4 );

            // col: 1423 offset: 06fa
            unknown6fa = parser.ReadOffset< byte >( 0x6fa );

            // col: 1256 offset: 0700
            unknown700 = parser.ReadOffset< uint >( 0x700 );

            // col: 1280 offset: 0704
            unknown704 = parser.ReadOffset< uint >( 0x704 );

            // col: 1304 offset: 0708
            unknown708 = parser.ReadOffset< uint >( 0x708 );

            // col: 1328 offset: 070c
            unknown70c = parser.ReadOffset< uint >( 0x70c );

            // col: 1352 offset: 0710
            unknown710 = parser.ReadOffset< uint >( 0x710 );

            // col: 1376 offset: 0714
            unknown714 = parser.ReadOffset< uint >( 0x714 );

            // col: 1400 offset: 0718
            unknown718 = parser.ReadOffset< uint >( 0x718 );

            // col: 1424 offset: 071e
            unknown71e = parser.ReadOffset< byte >( 0x71e );

            // col: 1257 offset: 0724
            unknown724 = parser.ReadOffset< uint >( 0x724 );

            // col: 1281 offset: 0728
            unknown728 = parser.ReadOffset< uint >( 0x728 );

            // col: 1305 offset: 072c
            unknown72c = parser.ReadOffset< uint >( 0x72c );

            // col: 1329 offset: 0730
            unknown730 = parser.ReadOffset< uint >( 0x730 );

            // col: 1353 offset: 0734
            unknown734 = parser.ReadOffset< uint >( 0x734 );

            // col: 1377 offset: 0738
            unknown738 = parser.ReadOffset< uint >( 0x738 );

            // col: 1401 offset: 073c
            unknown73c = parser.ReadOffset< uint >( 0x73c );

            // col: 1425 offset: 0742
            unknown742 = parser.ReadOffset< byte >( 0x742 );

            // col: 1258 offset: 0748
            unknown748 = parser.ReadOffset< uint >( 0x748 );

            // col: 1282 offset: 074c
            unknown74c = parser.ReadOffset< uint >( 0x74c );

            // col: 1306 offset: 0750
            unknown750 = parser.ReadOffset< uint >( 0x750 );

            // col: 1330 offset: 0754
            unknown754 = parser.ReadOffset< uint >( 0x754 );

            // col: 1354 offset: 0758
            unknown758 = parser.ReadOffset< uint >( 0x758 );

            // col: 1378 offset: 075c
            unknown75c = parser.ReadOffset< uint >( 0x75c );

            // col: 1402 offset: 0760
            unknown760 = parser.ReadOffset< uint >( 0x760 );

            // col: 1426 offset: 0766
            unknown766 = parser.ReadOffset< byte >( 0x766 );

            // col: 1259 offset: 076c
            unknown76c = parser.ReadOffset< uint >( 0x76c );

            // col: 1283 offset: 0770
            unknown770 = parser.ReadOffset< uint >( 0x770 );

            // col: 1307 offset: 0774
            unknown774 = parser.ReadOffset< uint >( 0x774 );

            // col: 1331 offset: 0778
            unknown778 = parser.ReadOffset< uint >( 0x778 );

            // col: 1355 offset: 077c
            unknown77c = parser.ReadOffset< uint >( 0x77c );

            // col: 1379 offset: 0780
            unknown780 = parser.ReadOffset< uint >( 0x780 );

            // col: 1403 offset: 0784
            unknown784 = parser.ReadOffset< uint >( 0x784 );

            // col: 1427 offset: 078a
            unknown78a = parser.ReadOffset< byte >( 0x78a );

            // col: 1260 offset: 0790
            unknown790 = parser.ReadOffset< uint >( 0x790 );

            // col: 1284 offset: 0794
            unknown794 = parser.ReadOffset< uint >( 0x794 );

            // col: 1308 offset: 0798
            unknown798 = parser.ReadOffset< uint >( 0x798 );

            // col: 1332 offset: 079c
            unknown79c = parser.ReadOffset< uint >( 0x79c );

            // col: 1356 offset: 07a0
            unknown7a0 = parser.ReadOffset< uint >( 0x7a0 );

            // col: 1380 offset: 07a4
            unknown7a4 = parser.ReadOffset< uint >( 0x7a4 );

            // col: 1404 offset: 07a8
            unknown7a8 = parser.ReadOffset< uint >( 0x7a8 );

            // col: 1428 offset: 07ae
            unknown7ae = parser.ReadOffset< byte >( 0x7ae );

            // col: 1261 offset: 07b4
            unknown7b4 = parser.ReadOffset< uint >( 0x7b4 );

            // col: 1285 offset: 07b8
            unknown7b8 = parser.ReadOffset< uint >( 0x7b8 );

            // col: 1309 offset: 07bc
            unknown7bc = parser.ReadOffset< uint >( 0x7bc );

            // col: 1333 offset: 07c0
            unknown7c0 = parser.ReadOffset< uint >( 0x7c0 );

            // col: 1357 offset: 07c4
            unknown7c4 = parser.ReadOffset< uint >( 0x7c4 );

            // col: 1381 offset: 07c8
            unknown7c8 = parser.ReadOffset< uint >( 0x7c8 );

            // col: 1405 offset: 07cc
            unknown7cc = parser.ReadOffset< uint >( 0x7cc );

            // col: 1429 offset: 07d2
            unknown7d2 = parser.ReadOffset< byte >( 0x7d2 );

            // col: 1262 offset: 07d8
            unknown7d8 = parser.ReadOffset< uint >( 0x7d8 );

            // col: 1286 offset: 07dc
            unknown7dc = parser.ReadOffset< uint >( 0x7dc );

            // col: 1310 offset: 07e0
            unknown7e0 = parser.ReadOffset< uint >( 0x7e0 );

            // col: 1334 offset: 07e4
            unknown7e4 = parser.ReadOffset< uint >( 0x7e4 );

            // col: 1358 offset: 07e8
            unknown7e8 = parser.ReadOffset< uint >( 0x7e8 );

            // col: 1382 offset: 07ec
            unknown7ec = parser.ReadOffset< uint >( 0x7ec );

            // col: 1406 offset: 07f0
            unknown7f0 = parser.ReadOffset< uint >( 0x7f0 );

            // col: 1430 offset: 07f6
            unknown7f6 = parser.ReadOffset< byte >( 0x7f6 );

            // col: 1263 offset: 07fc
            unknown7fc = parser.ReadOffset< uint >( 0x7fc );

            // col: 1287 offset: 0800
            unknown800 = parser.ReadOffset< uint >( 0x800 );

            // col: 1311 offset: 0804
            unknown804 = parser.ReadOffset< uint >( 0x804 );

            // col: 1335 offset: 0808
            unknown808 = parser.ReadOffset< uint >( 0x808 );

            // col: 1359 offset: 080c
            unknown80c = parser.ReadOffset< uint >( 0x80c );

            // col: 1383 offset: 0810
            unknown810 = parser.ReadOffset< uint >( 0x810 );

            // col: 1407 offset: 0814
            unknown814 = parser.ReadOffset< uint >( 0x814 );

            // col: 1431 offset: 081a
            unknown81a = parser.ReadOffset< byte >( 0x81a );

            // col: 1264 offset: 0820
            unknown820 = parser.ReadOffset< uint >( 0x820 );

            // col: 1288 offset: 0824
            unknown824 = parser.ReadOffset< uint >( 0x824 );

            // col: 1312 offset: 0828
            unknown828 = parser.ReadOffset< uint >( 0x828 );

            // col: 1336 offset: 082c
            unknown82c = parser.ReadOffset< uint >( 0x82c );

            // col: 1360 offset: 0830
            unknown830 = parser.ReadOffset< uint >( 0x830 );

            // col: 1384 offset: 0834
            unknown834 = parser.ReadOffset< uint >( 0x834 );

            // col: 1408 offset: 0838
            unknown838 = parser.ReadOffset< uint >( 0x838 );

            // col: 1432 offset: 083e
            unknown83e = parser.ReadOffset< byte >( 0x83e );

            // col: 1265 offset: 0844
            unknown844 = parser.ReadOffset< uint >( 0x844 );

            // col: 1289 offset: 0848
            unknown848 = parser.ReadOffset< uint >( 0x848 );

            // col: 1313 offset: 084c
            unknown84c = parser.ReadOffset< uint >( 0x84c );

            // col: 1337 offset: 0850
            unknown850 = parser.ReadOffset< uint >( 0x850 );

            // col: 1361 offset: 0854
            unknown854 = parser.ReadOffset< uint >( 0x854 );

            // col: 1385 offset: 0858
            unknown858 = parser.ReadOffset< uint >( 0x858 );

            // col: 1409 offset: 085c
            unknown85c = parser.ReadOffset< uint >( 0x85c );

            // col: 1433 offset: 0862
            unknown862 = parser.ReadOffset< byte >( 0x862 );

            // col: 1266 offset: 0868
            unknown868 = parser.ReadOffset< uint >( 0x868 );

            // col: 1290 offset: 086c
            unknown86c = parser.ReadOffset< uint >( 0x86c );

            // col: 1314 offset: 0870
            unknown870 = parser.ReadOffset< uint >( 0x870 );

            // col: 1338 offset: 0874
            unknown874 = parser.ReadOffset< uint >( 0x874 );

            // col: 1362 offset: 0878
            unknown878 = parser.ReadOffset< uint >( 0x878 );

            // col: 1386 offset: 087c
            unknown87c = parser.ReadOffset< uint >( 0x87c );

            // col: 1410 offset: 0880
            unknown880 = parser.ReadOffset< uint >( 0x880 );

            // col: 1434 offset: 0886
            unknown886 = parser.ReadOffset< byte >( 0x886 );

            // col: 1267 offset: 088c
            unknown88c = parser.ReadOffset< uint >( 0x88c );

            // col: 1291 offset: 0890
            unknown890 = parser.ReadOffset< uint >( 0x890 );

            // col: 1315 offset: 0894
            unknown894 = parser.ReadOffset< uint >( 0x894 );

            // col: 1339 offset: 0898
            unknown898 = parser.ReadOffset< uint >( 0x898 );

            // col: 1363 offset: 089c
            unknown89c = parser.ReadOffset< uint >( 0x89c );

            // col: 1387 offset: 08a0
            unknown8a0 = parser.ReadOffset< uint >( 0x8a0 );

            // col: 1411 offset: 08a4
            unknown8a4 = parser.ReadOffset< uint >( 0x8a4 );

            // col: 1435 offset: 08aa
            unknown8aa = parser.ReadOffset< byte >( 0x8aa );

            // col: 1268 offset: 08b0
            unknown8b0 = parser.ReadOffset< uint >( 0x8b0 );

            // col: 1292 offset: 08b4
            unknown8b4 = parser.ReadOffset< uint >( 0x8b4 );

            // col: 1316 offset: 08b8
            unknown8b8 = parser.ReadOffset< uint >( 0x8b8 );

            // col: 1340 offset: 08bc
            unknown8bc = parser.ReadOffset< uint >( 0x8bc );

            // col: 1364 offset: 08c0
            unknown8c0 = parser.ReadOffset< uint >( 0x8c0 );

            // col: 1388 offset: 08c4
            unknown8c4 = parser.ReadOffset< uint >( 0x8c4 );

            // col: 1412 offset: 08c8
            unknown8c8 = parser.ReadOffset< uint >( 0x8c8 );

            // col: 1436 offset: 08ce
            unknown8ce = parser.ReadOffset< byte >( 0x8ce );

            // col: 1269 offset: 08d4
            unknown8d4 = parser.ReadOffset< uint >( 0x8d4 );

            // col: 1293 offset: 08d8
            unknown8d8 = parser.ReadOffset< uint >( 0x8d8 );

            // col: 1317 offset: 08dc
            unknown8dc = parser.ReadOffset< uint >( 0x8dc );

            // col: 1341 offset: 08e0
            unknown8e0 = parser.ReadOffset< uint >( 0x8e0 );

            // col: 1365 offset: 08e4
            unknown8e4 = parser.ReadOffset< uint >( 0x8e4 );

            // col: 1389 offset: 08e8
            unknown8e8 = parser.ReadOffset< uint >( 0x8e8 );

            // col: 1413 offset: 08ec
            unknown8ec = parser.ReadOffset< uint >( 0x8ec );

            // col: 1437 offset: 08f2
            unknown8f2 = parser.ReadOffset< byte >( 0x8f2 );

            // col: 1442 offset: 08f4
            GilReward = parser.ReadOffset< uint >( 0x8f4 );

            // col: 1452 offset: 08f8
            ItemReward0 = new uint[6];
            ItemReward0[0] = parser.ReadOffset< uint >( 0x8f8 );
            ItemReward0[1] = parser.ReadOffset< uint >( 0x8fc );
            ItemReward0[2] = parser.ReadOffset< uint >( 0x900 );
            ItemReward0[3] = parser.ReadOffset< uint >( 0x904 );
            ItemReward0[4] = parser.ReadOffset< uint >( 0x908 );
            ItemReward0[5] = parser.ReadOffset< uint >( 0x90c );

            // col: 1458 offset: 0910
            unknown910 = parser.ReadOffset< uint >( 0x910 );

            // col: 1473 offset: 0914
            ItemReward1 = new uint[5];
            ItemReward1[0] = parser.ReadOffset< uint >( 0x914 );
            ItemReward1[1] = parser.ReadOffset< uint >( 0x918 );
            ItemReward1[2] = parser.ReadOffset< uint >( 0x91c );
            ItemReward1[3] = parser.ReadOffset< uint >( 0x920 );
            ItemReward1[4] = parser.ReadOffset< uint >( 0x924 );

            // col: 1501 offset: 0928
            InstanceContentUnlock = parser.ReadOffset< uint >( 0x928 );

            // col: 1441 offset: 092c
            ExpFactor = parser.ReadOffset< ushort >( 0x92c );

            // col: 1444 offset: 092e
            GCSeals = parser.ReadOffset< ushort >( 0x92e );

            // col: 1494 offset: 0930
            ActionReward = parser.ReadOffset< ushort >( 0x930 );

            // col: 1497 offset: 0932
            unknown932 = parser.ReadOffset< ushort >( 0x932 );

            // col: 1499 offset: 0934
            unknown934 = parser.ReadOffset< ushort >( 0x934 );

            // col: 1500 offset: 0936
            unknown936 = parser.ReadOffset< ushort >( 0x936 );

            // col: 1443 offset: 0938
            unknown938 = parser.ReadOffset< byte >( 0x938 );

            // col: 1445 offset: 0939
            ItemCatalyst = new byte[3];
            ItemCatalyst[0] = parser.ReadOffset< byte >( 0x939 );
            ItemCatalyst[1] = parser.ReadOffset< byte >( 0x93a );
            ItemCatalyst[2] = parser.ReadOffset< byte >( 0x93b );

            // col: 1448 offset: 093c
            ItemCountCatalyst = new byte[3];
            ItemCountCatalyst[0] = parser.ReadOffset< byte >( 0x93c );
            ItemCountCatalyst[1] = parser.ReadOffset< byte >( 0x93d );
            ItemCountCatalyst[2] = parser.ReadOffset< byte >( 0x93e );

            // col: 1451 offset: 093f
            ItemRewardType = parser.ReadOffset< byte >( 0x93f );

            // col: 1459 offset: 0940
            ItemCountReward0 = new byte[6];
            ItemCountReward0[0] = parser.ReadOffset< byte >( 0x940 );
            ItemCountReward0[1] = parser.ReadOffset< byte >( 0x941 );
            ItemCountReward0[2] = parser.ReadOffset< byte >( 0x942 );
            ItemCountReward0[3] = parser.ReadOffset< byte >( 0x943 );
            ItemCountReward0[4] = parser.ReadOffset< byte >( 0x944 );
            ItemCountReward0[5] = parser.ReadOffset< byte >( 0x945 );

            // col: 1465 offset: 0946
            unknown946 = parser.ReadOffset< byte >( 0x946 );

            // col: 1466 offset: 0947
            StainReward0 = new byte[6];
            StainReward0[0] = parser.ReadOffset< byte >( 0x947 );
            StainReward0[1] = parser.ReadOffset< byte >( 0x948 );
            StainReward0[2] = parser.ReadOffset< byte >( 0x949 );
            StainReward0[3] = parser.ReadOffset< byte >( 0x94a );
            StainReward0[4] = parser.ReadOffset< byte >( 0x94b );
            StainReward0[5] = parser.ReadOffset< byte >( 0x94c );

            // col: 1472 offset: 094d
            unknown94d = parser.ReadOffset< byte >( 0x94d );

            // col: 1478 offset: 094e
            ItemCountReward1 = new byte[5];
            ItemCountReward1[0] = parser.ReadOffset< byte >( 0x94e );
            ItemCountReward1[1] = parser.ReadOffset< byte >( 0x94f );
            ItemCountReward1[2] = parser.ReadOffset< byte >( 0x950 );
            ItemCountReward1[3] = parser.ReadOffset< byte >( 0x951 );
            ItemCountReward1[4] = parser.ReadOffset< byte >( 0x952 );

            // col: 1488 offset: 0953
            StainReward1 = new byte[5];
            StainReward1[0] = parser.ReadOffset< byte >( 0x953 );
            StainReward1[1] = parser.ReadOffset< byte >( 0x954 );
            StainReward1[2] = parser.ReadOffset< byte >( 0x955 );
            StainReward1[3] = parser.ReadOffset< byte >( 0x956 );
            StainReward1[4] = parser.ReadOffset< byte >( 0x957 );

            // col: 1493 offset: 0958
            EmoteReward = parser.ReadOffset< byte >( 0x958 );

            // col: 1495 offset: 0959
            GeneralActionReward = new byte[2];
            GeneralActionReward[0] = parser.ReadOffset< byte >( 0x959 );
            GeneralActionReward[1] = parser.ReadOffset< byte >( 0x95a );

            // col: 1498 offset: 095b
            OtherReward = parser.ReadOffset< byte >( 0x95b );

            // col: 1502 offset: 095c
            unknown95c = parser.ReadOffset< byte >( 0x95c );

            // col: 1503 offset: 095d
            TomestoneReward = parser.ReadOffset< byte >( 0x95d );

            // col: 1504 offset: 095e
            TomestoneCountReward = parser.ReadOffset< byte >( 0x95e );

            // col: 1505 offset: 095f
            ReputationReward = parser.ReadOffset< byte >( 0x95f );

            // col: 1483 offset: 0960
            IsHQReward1 = new bool[5];
            IsHQReward1[0] = parser.ReadOffset< bool >( 0x960 );
            IsHQReward1[1] = parser.ReadOffset< bool >( 0x961 );
            IsHQReward1[2] = parser.ReadOffset< bool >( 0x962 );
            IsHQReward1[3] = parser.ReadOffset< bool >( 0x963 );
            IsHQReward1[4] = parser.ReadOffset< bool >( 0x964 );

            // col: 1 offset: 0968
            Id = parser.ReadOffset< string >( 0x968 );

            // col: 9 offset: 096c
            PreviousQuest0 = parser.ReadOffset< uint >( 0x96c );

            // col: 11 offset: 0970
            PreviousQuest1 = parser.ReadOffset< uint >( 0x970 );

            // col: 12 offset: 0974
            PreviousQuest2 = parser.ReadOffset< uint >( 0x974 );

            // col: 14 offset: 0978
            QuestLock = new uint[2];
            QuestLock[0] = parser.ReadOffset< uint >( 0x978 );
            QuestLock[1] = parser.ReadOffset< uint >( 0x97c );

            // col: 23 offset: 0980
            InstanceContent = new uint[3];
            InstanceContent[0] = parser.ReadOffset< uint >( 0x980 );
            InstanceContent[1] = parser.ReadOffset< uint >( 0x984 );
            InstanceContent[2] = parser.ReadOffset< uint >( 0x988 );

            // col: 39 offset: 098c
            IssuerStart = parser.ReadOffset< uint >( 0x98c );

            // col: 40 offset: 0990
            Behavior = parser.ReadOffset< uint >( 0x990 );

            // col: 42 offset: 0994
            TargetEnd = parser.ReadOffset< uint >( 0x994 );

            // col: 1509 offset: 0998
            Icon = parser.ReadOffset< uint >( 0x998 );

            // col: 1510 offset: 099c
            IconSpecial = parser.ReadOffset< uint >( 0x99c );

            // col: 36 offset: 09a0
            MountRequired = parser.ReadOffset< int >( 0x9a0 );

            // col: 4 offset: 09a4
            ClassJobLevel0 = parser.ReadOffset< ushort >( 0x9a4 );

            // col: 7 offset: 09a6
            ClassJobLevel1 = parser.ReadOffset< ushort >( 0x9a6 );

            // col: 16 offset: 09a8
            unknown9a8 = parser.ReadOffset< ushort >( 0x9a8 );

            // col: 29 offset: 09aa
            BellStart = parser.ReadOffset< ushort >( 0x9aa );

            // col: 30 offset: 09ac
            BellEnd = parser.ReadOffset< ushort >( 0x9ac );

            // col: 33 offset: 09ae
            LevelMax = parser.ReadOffset< ushort >( 0x9ae );

            // col: 41 offset: 09b0
            unknown9b0 = parser.ReadOffset< ushort >( 0x9b0 );

            // col: 49 offset: 09b2
            QuestClassJobSupply = parser.ReadOffset< ushort >( 0x9b2 );

            // col: 1506 offset: 09b4
            PlaceName = parser.ReadOffset< ushort >( 0x9b4 );

            // col: 1515 offset: 09b6
            SortKey = parser.ReadOffset< ushort >( 0x9b6 );

            // col: 2 offset: 09b8
            Expansion = parser.ReadOffset< byte >( 0x9b8 );

            // col: 3 offset: 09b9
            ClassJobCategory0 = parser.ReadOffset< byte >( 0x9b9 );

            // col: 5 offset: 09ba
            QuestLevelOffset = parser.ReadOffset< byte >( 0x9ba );

            // col: 6 offset: 09bb
            ClassJobCategory1 = parser.ReadOffset< byte >( 0x9bb );

            // col: 8 offset: 09bc
            PreviousQuestJoin = parser.ReadOffset< byte >( 0x9bc );

            // col: 10 offset: 09bd
            unknown9bd = parser.ReadOffset< byte >( 0x9bd );

            // col: 13 offset: 09be
            QuestLockJoin = parser.ReadOffset< byte >( 0x9be );

            // col: 17 offset: 09bf
            unknown9bf = parser.ReadOffset< byte >( 0x9bf );

            // col: 18 offset: 09c0
            unknown9c0 = parser.ReadOffset< byte >( 0x9c0 );

            // col: 19 offset: 09c1
            ClassJobUnlock = parser.ReadOffset< byte >( 0x9c1 );

            // col: 20 offset: 09c2
            GrandCompany = parser.ReadOffset< byte >( 0x9c2 );

            // col: 21 offset: 09c3
            GrandCompanyRank = parser.ReadOffset< byte >( 0x9c3 );

            // col: 22 offset: 09c4
            InstanceContentJoin = parser.ReadOffset< byte >( 0x9c4 );

            // col: 26 offset: 09c5
            Festival = parser.ReadOffset< byte >( 0x9c5 );

            // col: 27 offset: 09c6
            unknown9c6 = parser.ReadOffset< byte >( 0x9c6 );

            // col: 28 offset: 09c7
            unknown9c7 = parser.ReadOffset< byte >( 0x9c7 );

            // col: 31 offset: 09c8
            BeastTribe = parser.ReadOffset< byte >( 0x9c8 );

            // col: 32 offset: 09c9
            BeastReputationRank = parser.ReadOffset< byte >( 0x9c9 );

            // col: 34 offset: 09ca
            unknown9ca = parser.ReadOffset< byte >( 0x9ca );

            // col: 35 offset: 09cb
            unknown9cb = parser.ReadOffset< byte >( 0x9cb );

            // col: 38 offset: 09cc
            DeliveryQuest = parser.ReadOffset< byte >( 0x9cc );

            // col: 44 offset: 09cd
            RepeatIntervalType = parser.ReadOffset< byte >( 0x9cd );

            // col: 45 offset: 09ce
            QuestRepeatFlag = parser.ReadOffset< byte >( 0x9ce );

            // col: 48 offset: 09cf
            Type = parser.ReadOffset< byte >( 0x9cf );

            // col: 1438 offset: 09d0
            unknown9d0 = parser.ReadOffset< byte >( 0x9d0 );

            // col: 1439 offset: 09d1
            ClassJobRequired = parser.ReadOffset< byte >( 0x9d1 );

            // col: 1440 offset: 09d2
            unknown9d2 = parser.ReadOffset< byte >( 0x9d2 );

            // col: 1507 offset: 09d3
            JournalGenre = parser.ReadOffset< byte >( 0x9d3 );

            // col: 1508 offset: 09d4
            unknown9d4 = parser.ReadOffset< byte >( 0x9d4 );

            // col: 1513 offset: 09d5
            EventIconType = parser.ReadOffset< byte >( 0x9d5 );

            // col: 1514 offset: 09d6
            unknown9d6 = parser.ReadOffset< byte >( 0x9d6 );

            // col: 37 offset: 09d7
            packed9d7 = parser.ReadOffset< byte >( 0x9d7, ExcelColumnDataType.UInt8 );


        }
    }
}