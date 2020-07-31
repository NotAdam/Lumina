// ReSharper disable InconsistentNaming

namespace Lumina.Data.Parsing.Layer
{
            public enum LayerEntryType
        {
            AssetNone = 0x0,
            BG = 0x1,                     //  //
            Attribute = 0x2,
            LayLight = 0x3,               //  //
            VFX = 0x4,                    //  //
            PositionMarker = 0x5,         //  //
            SharedGroup = 0x6,            //  //
            Sound = 0x7,                  //  //
            EventNPC = 0x8,               //  //
            BattleNPC = 0x9,              //  //
            RoutePath = 0xA,
            Character = 0xB,
            Aetheryte = 0xC,              //  //
            EnvSet = 0xD,                 //  //
            Gathering = 0xE,              //  //
            HelperObject = 0xF,           //
            Treasure = 0x10,              //  //
            Clip = 0x11,
            ClipCtrlPoint = 0x12,
            ClipCamera = 0x13,
            ClipLight = 0x14,
            ClipReserve00 = 0x15,
            ClipReserve01 = 0x16,
            ClipReserve02 = 0x17,
            ClipReserve03 = 0x18,
            ClipReserve04 = 0x19,
            ClipReserve05 = 0x1A,
            ClipReserve06 = 0x1B,
            ClipReserve07 = 0x1C,
            ClipReserve08 = 0x1D,
            ClipReserve09 = 0x1E,
            ClipReserve10 = 0x1F,
            ClipReserve11 = 0x20,
            ClipReserve12 = 0x21,
            ClipReserve13 = 0x22,
            ClipReserve14 = 0x23,
            CutAssetOnlySelectable = 0x24,
            Player = 0x25,
            Monster = 0x26,
            Weapon = 0x27,                    //
            PopRange = 0x28,                  //  //
            ExitRange = 0x29,                 //  //
            LVB = 0x2A,
            MapRange = 0x2B,                  //  //
            NaviMeshRange = 0x2C,             //  //
            EventObject = 0x2D,               //  //
            DemiHuman = 0x2E,
            EnvLocation = 0x2F,               //  //
            ControlPoint = 0x30,
            EventRange = 0x31,                //?     //
            RestBonusRange = 0x32,
            QuestMarker = 0x33,               //      //
            Timeline = 0x34,
            ObjectBehaviorSet = 0x35,
            Movie = 0x36,
            ScenarioExd = 0x37,
            ScenarioText = 0x38,
            CollisionBox = 0x39,              //  //
            DoorRange = 0x3A,                 //
            LineVFX = 0x3B,                   //  //
            SoundEnvSet = 0x3C,
            CutActionTimeline = 0x3D,
            CharaScene = 0x3E,
            CutAction = 0x3F,
            EquipPreset = 0x40,
            ClientPath = 0x41,            //      //
            ServerPath = 0x42,            //      //
            GimmickRange = 0x43,          //      //
            TargetMarker = 0x44,          //      //
            ChairMarker = 0x45,           //      //
            ClickableRange = 0x46,        //
            PrefetchRange = 0x47,         //      //
            FateRange = 0x48,             //      //
            PartyMember = 0x49,
            KeepRange = 0x4A,             //
            SphereCastRange = 0x4B,
            IndoorObject = 0x4C,
            OutdoorObject = 0x4D,
            EditGroup = 0x4E,
            StableChocobo = 0x4F,
            MaxAssetType = 0x50,
        }

        public enum DoorState
        {
            Auto = 0x1,
            Open = 0x2,
            Closed = 0x3,
        }

        public enum RotationState
        {
            Rounding = 0x1,
            Stopped = 0x2,
        }

        public enum TransformState
        {
            TransformStatePlay = 0x0,
            TransformStateStop = 0x1,
            TransformStateReplay = 0x2,
            TransformStateReset = 0x3,
        }

        public enum ColourState
        {
            ColorStatePlay = 0x0,
            ColorStateStop = 0x1,
            ColorStateReplay = 0x2,
            ColorStateReset = 0x3,
        }

        public enum TriggerBoxShape
        {
            TriggerBoxShapeBox = 0x1,
            TriggerBoxShapeSphere = 0x2,
            TriggerBoxShapeCylinder = 0x3,
            TriggerBoxShapeBoard = 0x4,
            TriggerBoxShapeMesh = 0x5,
            TriggerBoxShapeBoardBothSides = 0x6,
        }

        public enum ModelCollisionType
        {
            None = 0x0,
            Replace = 0x1,
            Box = 0x2,
        }

        public enum LightType
        {
            None = 0x0,
            Directional = 0x1,
            Point = 0x2,
            Spot = 0x3,
            Plane = 0x4,
            Line = 0x5,
            Specular = 0x6,
        }

        public enum PointLightType
        {
            Sphere = 0x0,
            Hemisphere = 0x1,
        }

        public enum PositionMarkerType
        {
            DebugZonePop = 0x1,
            DebugJump = 0x2,
            NaviMesh = 0x3,
            LQEvent = 0x4,
        }

        public enum EnvSetShape
        {
            EnvShapeEllipsoid = 0x1,
            EnvShapeCuboid = 0x2,
            EnvShapeCylinder = 0x3,
        }

        public enum HelperObjectType
        {
            ProxyActor = 0x0,
            NullObject = 0x1,
        }

        public enum TargetType
        {
            None = 0x0,
            ENPCInstanceID = 0x1,
            Player = 0x2,
            PartyMember = 0x3,
            ENPCDirect = 0x4,
            BNPCDirect = 0x5,
            BGObjInstanceID = 0x6,
            SharedGroupInstanceID = 0x7,
            BGObj = 0x8,
            SharedGroup = 0x9,
            Weapon = 0xA,
            StableChocobo = 0xB,
            AllianceMember = 0xC,
            Max = 0xD,
        }

        public enum PopType
        {
            PC = 0x1,
            NPC = 0x2,
            BNPC = 0x2,
            Content = 0x3,
        }

        public enum ExitType
        {
            ZoneLine = 0x1,
        }

        public enum RangeType
        {
            Type01 = 0x1,
            Type02 = 0x2,
            Type03 = 0x3,
            Type04 = 0x4,
            Type05 = 0x5,
            Type06 = 0x6,
            Type07 = 0x7,
        }

        public enum LineStyle
        {
            Red = 0x1,
            Blue = 0x2,
        }

        public enum GimmickType
        {
            Fishing = 0x1,
            Content = 0x2,
            Room = 0x3,
        }

        public enum TargetMarkerType
        {
            UiTarget = 0x0,
            UiNameplate = 0x1,
            LookAt = 0x2,
            BodyDyn = 0x3,
            Root = 0x4,
        }

        //For ChairMarker
        public enum ObjectType
        {
            ObjectChair = 0x0,
            ObjectBed = 0x1,
        }

        public enum CharacterSize : byte
        {
            DefaultSize = 0x0,
            VerySmall = 0x1,
            Small = 0x2,
            Medium = 0x3,
            Large = 0x4,
            VeryLarge = 0x5,
        }

        public enum DrawHeadParts : byte
        {
            Default = 0x0,
            ForceOn = 0x1,
            ForceOff = 0x2,
        }

        public enum RotationType
        {
            NoRotate = 0x0,
            AllAxis = 0x1,
            YAxisOnly = 0x2,
        }

        public enum MovePathMode
        {
	        None = 0x0,
	        SharedGroupAction = 0x1,
	        Timeline = 0x2,
        }

        public enum LayerSetReferencedType
        {
	        All = 0x0,
	        Include = 0x1,
	        Exclude = 0x2,
	        Undetermined = 0x3,
        }

        public enum SoundEffectType
        {
	        Point = 0x3,
	        PointDir = 0x4,
	        Line = 0x5,
	        PolyLine = 0x6,
	        Surface = 0x7,
	        BoardObstruction = 0x8,
	        BoxObstruction = 0x9,
	        PolyLineObstruction = 0xB,
	        PolygonObstruction = 0xC,
	        LineExtController = 0xD,
	        Polygon = 0xE,
        }
}