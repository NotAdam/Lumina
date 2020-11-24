using System;
using Xunit;

namespace Lumina.Tests
{
    public class LuminaTests
    {
        [Theory]
        [InlineData( "bg", "ex3", 13885885343001753777, "bg/ex3/01_nvt_n4/twn/n4t1/bgparts/n4t1_a1_chr03.mdl" )]
        [InlineData( "music", "ex2", 16573140193792963234, "music/ex2/bgm_ex2_system_title.scd" )]
        [InlineData( "chara", "ffxiv", 8982245735269998910, "chara/weapon/w0501/obj/body/b0018/vfx/texture/uv_cryst_128s.atex" )]
        [InlineData( "sound", "ffxiv", 7568289509259556905, "sound/vfx/ability/se_vfx_abi_berserk_c.scd")]
        [InlineData( "exd", "ffxiv", 16400836168543909290, "exd/exportedsg.exh")]
        public void FilePathsAreParsedCorrectly( string category, string repo, ulong hash, string path )
        {
            var parsed = Lumina.ParseFilePath( path );
            
            Assert.Equal( category, parsed.Category );
            Assert.Equal( repo, parsed.Repository );
            Assert.Equal( hash, parsed.IndexHash );
        }
    }
}