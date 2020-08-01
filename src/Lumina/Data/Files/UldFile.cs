using Lumina.Data.Parsing.Uld;
using Lumina.Extensions;

// ReSharper disable NotAccessedField.Global
// ReSharper disable MemberCanBePrivate.Global
namespace Lumina.Data.Files {
    public class UldFile : FileResource {
        public UldRoot.UldHeader CombineHeader;
        public UldRoot.AtkHeader ComponentHeader;
        public UldRoot.PartHeader AssetList;
        public UldRoot.TextureEntry[] AssetData;
        public UldRoot.PartHeader PartList;
        public UldRoot.PartsData[] Parts;
        public UldRoot.PartHeader ComponentList;
        public UldRoot.ComponentData[] Components;
        public UldRoot.PartHeader TimelineList;
        public UldRoot.Timeline[] Timelines;

        public UldRoot.AtkHeader SecondHeader;
        public UldRoot.PartHeader WidgetHeader;
        public UldRoot.WidgetData WidgetData;

        public override void LoadFile() {
            long basePos = Reader.BaseStream.Position;
            CombineHeader = UldRoot.UldHeader.Read( Reader );
            long preComponentPos = Reader.BaseStream.Position;

            ComponentHeader = UldRoot.AtkHeader.Read( Reader );
            Reader.Seek( preComponentPos + ComponentHeader.AssetListOffset );
            AssetList = UldRoot.PartHeader.Read( Reader );
            AssetData = new UldRoot.TextureEntry[AssetList.ElementCount];
            for( int i = 0; i < AssetList.ElementCount; i++ )
                AssetData[ i ] = UldRoot.TextureEntry.Read( Reader );

            Reader.Seek( preComponentPos + ComponentHeader.PartListOffset );
            PartList = UldRoot.PartHeader.Read( Reader );
            Parts = new UldRoot.PartsData[PartList.ElementCount];
            for( int i = 0; i < PartList.ElementCount; i++ )
                Parts[ i ] = UldRoot.PartsData.Read( Reader );

            Reader.Seek( preComponentPos + ComponentHeader.ComponentListOffset );
            ComponentList = UldRoot.PartHeader.Read( Reader );
            Components = new UldRoot.ComponentData[ComponentList.ElementCount];
            for( int i = 0; i < ComponentList.ElementCount; i++ )
                Components[ i ] = UldRoot.ComponentData.Read( Reader, Components );

            Reader.Seek( preComponentPos + ComponentHeader.TimelineListOffset );
            TimelineList = UldRoot.PartHeader.Read( Reader );
            Timelines = new UldRoot.Timeline[TimelineList.ElementCount];
            for( int i = 0; i < TimelineList.ElementCount; i++ )
                Timelines[ i ] = UldRoot.Timeline.Read( Reader );

            long preSecondHeader = Reader.BaseStream.Position;
            Reader.Seek( basePos + CombineHeader.WidgetOffset );
            SecondHeader = UldRoot.AtkHeader.Read( Reader );

            Reader.Seek( preSecondHeader + SecondHeader.WidgetOffset );
            WidgetHeader = UldRoot.PartHeader.Read( Reader );
            WidgetData = UldRoot.WidgetData.Read( Reader, Components );
        }
    }
}