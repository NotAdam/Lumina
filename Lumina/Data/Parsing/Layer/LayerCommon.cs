using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using Lumina.Extensions;
using Vector3 = Lumina.Data.Parsing.Common.Vector3;
using Transformation = Lumina.Data.Parsing.Common.Transformation;

// x field is never used warning
#pragma warning disable 169

namespace Lumina.Data.Parsing.Layer
{
    public class LayerCommon
    {
        public interface IInstanceObject
        {
            //TODO consider refactoring to classes for real inheritance
//            IInstanceObject Read();
        }

        public enum eAssetTypeLayer
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
            ScenarioEXD = 0x37,
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

        public enum eDoorStateLayer
        {
            Auto_0 = 0x1,
            Open = 0x2,
            Closed = 0x3,
        }

        public enum eRotationStateLayer
        {
            Rounding = 0x1,
            Stopped = 0x2,
        }

        public enum eTransformStateLayer
        {
            TransformStatePlay = 0x0,
            TransformStateStop = 0x1,
            TransformStateReplay = 0x2,
            TransformStateReset = 0x3,
        }

        public enum eColorStateLayer
        {
            ColorStatePlay = 0x0,
            ColorStateStop = 0x1,
            ColorStateReplay = 0x2,
            ColorStateReset = 0x3,
        }

        public enum eTriggerBoxShapeLayer
        {
            TriggerBoxShapeBox = 0x1,
            TriggerBoxShapeSphere = 0x2,
            TriggerBoxShapeCylinder = 0x3,
            TriggerBoxShapeBoard = 0x4,
            TriggerBoxShapeMesh = 0x5,
            TriggerBoxShapeBoardBothSides = 0x6,
        }

        public enum eModelConfigCollisionTypeLayer
        {
            COLLISION_ATTRIBUTE_TYPE_None = 0x0,
            COLLISION_ATTRIBUTE_TYPE_Replace = 0x1,
            COLLISION_ATTRIBUTE_TYPE_Box = 0x2,
        }

        public enum eLightTypeLayer
        {
            LightTypeNone = 0x0,
            LightTypeDirectional = 0x1,
            LightTypePoint = 0x2,
            LightTypeSpot = 0x3,
            LightTypePlane = 0x4,
            LightTypeLine = 0x5,
            LightTypeFakeSpecular = 0x6,
        }

        public enum ePointLightTypeLayer
        {
            PointLightTypeSphere = 0x0,
            PointLightTypeHalfSphere = 0x1,
        }

        public enum ePositionMarkerTypeLayer
        {
            DebugZonePop = 0x1,
            DebugJump = 0x2,
            NaviMesh = 0x3,
            LQEvent = 0x4,
        }

        public enum eEnvSetShapeLayer
        {
            EnvShapeEllipsoid = 0x1,
            EnvShapeCuboid = 0x2,
            EnvShapeCylinder = 0x3,
        }

        public enum eHelperObjectTypeLayer
        {
            ProxyActor = 0x0,
            NullObject = 0x1,
        }

        public enum eTargetTypeLayer
        {
            TargetTypeNone = 0x0,
            TargetTypeENPCInstanceID = 0x1,
            TargetTypePlayer = 0x2,
            TargetTypePartyMember = 0x3,
            TargetTypeENPCDirect = 0x4,
            TargetTypeBNPCDirect = 0x5,
            TargetTypeBGObjInstanceID = 0x6,
            TargetTypeSharedGroupInstanceID = 0x7,
            TargetTypeBGObj = 0x8,
            TargetTypeSharedGroup = 0x9,
            TargetTypeWeapon = 0xA,
            TargetTypeStableChocobo = 0xB,
            TargetTypeAllianceMember = 0xC,
            TargetTypeMax = 0xD,
        }

        public enum ePopTypeLayer
        {
            PopTypePC = 0x1,
            PopTypeNPC = 0x2,
            PopTypeBNPC = 0x2,
            PopTypeContent = 0x3,
        }

        public enum eExitTypeLayer
        {
            ExitTypeZone = 0x1,
        }

        public enum eRangeTypeLayer
        {
            Type01_0 = 0x1,
            Type02_0 = 0x2,
            Type03_0 = 0x3,
            Type04_0 = 0x4,
            Type05_0 = 0x5,
            Type06_0 = 0x6,
            Type07_0 = 0x7,
        }

        public enum eLineStyleLayer
        {
            Red_0 = 0x1,
            Blue_0 = 0x2,
        }

        public enum eGimmickTypeLayer
        {
            Fishing_0 = 0x1,
            Content_0 = 0x2,
            Room_0 = 0x3,
        }

        public enum eTargetMarkerTypeLayer
        {
            UI_TARGET_0 = 0x0,
            UI_NAMEPLATE_0 = 0x1,
            LOOK_AT_0 = 0x2,
            BODY_DYN_0 = 0x3,
            ROOT_0 = 0x4,
        }

        //For ChairMarker
        public enum eObjectTypeLayer
        {
            ObjectChair = 0x0,
            ObjectBed = 0x1,
        }

        public enum eCharacterSizeLayer : byte
        {
            DefaultSize = 0x0,
            SIZE_SS = 0x1,
            SIZE_S = 0x2,
            SIZE_M = 0x3,
            SIZE_L = 0x4,
            SIZE_LL = 0x5,
        }

        public enum eDrawHeadPartsLayer : byte
        {
            Default = 0x0,
            ForceON = 0x1,
            ForceOff = 0x2,
        }

        public enum eRotationTypeLayer
        {
            NoRotate = 0x0,
            AllAxis = 0x1,
            YAxisOnly = 0x2,
        }

        public enum eMovePathModeLayer
        {
	        None_4 = 0x0,
	        SGAction = 0x1,
	        Timeline_1 = 0x2,
        }

        public enum LayerSetReferencedType
        {
	        All = 0x0,
	        Include = 0x1,
	        Exclude = 0x2,
	        Undetermined = 0x3,
        }

        public enum eSETypeLayer
        {
	        SETypePoint = 0x3,
	        SETypePointDir = 0x4,
	        SETypeLine = 0x5,
	        SETypePolyLine = 0x6,
	        SETypeSurface = 0x7,
	        SETypeBoardObstruction = 0x8,
	        SETypeBoxObstruction = 0x9,
	        SETypePolyLineObstruction = 0xB,
	        SETypePolygonObstruction = 0xC,
	        SETypeLineExtController = 0xD,
	        SETypePolygon = 0xE,
        }

        public struct LayerChunk
        {
            public char[] ChunkID; //[4]
            public int ChunkSize;
            public int LayerGroupID;
            public int Name;
            public int Layers;
            public int LayersCount;

            public string strName;

            public static LayerChunk Read( BinaryReader br )
            {
                LayerChunk ret = new LayerChunk();

                ret.ChunkID = br.ReadChars( 4 );
                ret.ChunkSize = br.ReadInt32();

                long start = br.BaseStream.Position;
                ret.LayerGroupID = br.ReadInt32();
                ret.Name = br.ReadInt32();
                ret.Layers = br.ReadInt32();
                ret.LayersCount = br.ReadInt32();

                ret.strName = br.ReadStringOffset( start + ret.Name );

                return ret;
            }
        }

        /* Base classes */
        public struct TriggerBoxInstanceObject
        {
	        public eTriggerBoxShapeLayer TriggerBoxShape;
	        public short Priority;
            public byte Enabled;
            public byte Padding00;
            public uint Reserved1;

            public static TriggerBoxInstanceObject Read( BinaryReader br )
            {
                return new TriggerBoxInstanceObject
                {
                    TriggerBoxShape = (eTriggerBoxShapeLayer)br.ReadInt32(),
                    Priority = br.ReadInt16(),
                    Enabled = br.ReadByte(),
                    Padding00 = br.ReadByte(),
                    Reserved1 = br.ReadUInt32()
                };
            }
        }

        public struct GameInstanceObject
        {
            public uint BaseId;

            public static GameInstanceObject Read( BinaryReader br )
            {
                return new GameInstanceObject() { BaseId = br.ReadUInt32() };
            }
        }

        public struct NPCInstanceObject
        {
            public GameInstanceObject ParentData;

            public uint PopWeather;
            public byte PopTimeStart;
            public byte PopTimeEnd;
            public byte[] Padding00; //[2]
            public uint MoveAI;
            public byte WanderingRange;
            public byte Route;
            public ushort EventGroup;
            public uint Reserved1;
            public uint Reserved2;

            public static NPCInstanceObject Read( BinaryReader br )
            {
                return new NPCInstanceObject
                {
                    ParentData = GameInstanceObject.Read( br ),
                    PopWeather = br.ReadUInt32(),
                    PopTimeStart = br.ReadByte(),
                    PopTimeEnd = br.ReadByte(),
                    Padding00 = br.ReadBytes( 2 ),
                    MoveAI = br.ReadUInt32(),
                    WanderingRange = br.ReadByte(),
                    Route = br.ReadByte(),
                    EventGroup = br.ReadUInt16(),
                    Reserved1 = br.ReadUInt32(),
                    Reserved2 = br.ReadUInt32()
                };
            }
        }

        public struct CollisionAttribute
        {
            public byte CollisionExist;
            public byte AttributeEnable;
            public byte[] Padding00; //[2]
            public uint ID_Pallet;
            public uint EnvSet;
            public byte NaviMeshCollisionDisabled;
            public byte WaterSurface;
            public byte CameraCollision;
            public byte CharacterCollision;
            public byte EyesCollision;
            public byte Fishing;
            public byte Sheat;
            public byte Chocobo;
            public byte Gimmick;
            public byte Room;
            public byte Table;
            public byte Wall;

            public static CollisionAttribute Read( BinaryReader br )
            {
                return new CollisionAttribute()
                {
                    CollisionExist = br.ReadByte(),
                    AttributeEnable = br.ReadByte(),
                    Padding00 = br.ReadBytes( 2 ),
                    ID_Pallet = br.ReadUInt32(),
                    EnvSet = br.ReadUInt32(),
                    NaviMeshCollisionDisabled = br.ReadByte(),
                    WaterSurface = br.ReadByte(),
                    CameraCollision = br.ReadByte(),
                    CharacterCollision = br.ReadByte(),
                    EyesCollision = br.ReadByte(),
                    Fishing = br.ReadByte(),
                    Sheat = br.ReadByte(),
                    Chocobo = br.ReadByte(),
                    Gimmick = br.ReadByte(),
                    Room = br.ReadByte(),
                    Table = br.ReadByte(),
                    Wall = br.ReadByte()
                };
            }
        }

        struct CreationParamsBase
        {
            public byte Enabled;
            public byte[] Padding00; //[3]
            public uint Reserved1;
            public uint Reserved2;

            public static CreationParamsBase Read( BinaryReader br )
            {
                CreationParamsBase ret = new CreationParamsBase();

                ret.Enabled = br.ReadByte();
                ret.Padding00 = br.ReadBytes( 3 );
                ret.Reserved1 = br.ReadUInt32();
                ret.Reserved2 = br.ReadUInt32();

                return ret;
            }
        }

        public struct CreationParams// : CreationParamsBase
        {
            public CollisionAttribute CollisionAttribute;

            public static CreationParams Read( BinaryReader br )
            {
                return new CreationParams { CollisionAttribute = CollisionAttribute.Read( br ) };
            }
        }

        public struct PathControlPoint
        {
            public Vector3 Translation;
            public ushort PointID;
            public byte Select;
            public byte Padding00;

            public static PathControlPoint Read( BinaryReader br )
            {
                PathControlPoint ret = new PathControlPoint();

                ret.Translation = Vector3.Read( br );
                ret.PointID = br.ReadUInt16();
                ret.Select = br.ReadByte();
                ret.Padding00 = br.ReadByte();

                return ret;
            }
        }

        public struct PathInstanceObject
        {
            public int ControlPoints;
            public int ControlPointCount;
            public uint Reserved1;
            public uint Reserved2;

            public PathControlPoint[] ControlPointsArray;

            public static PathInstanceObject Read( BinaryReader br )
            {
                PathInstanceObject ret = new PathInstanceObject();

                // todo: pass baseoffsets of instanceobjects to all composition classes
                long start = br.BaseStream.Position - 48;

                ret.ControlPoints = br.ReadInt32();
                ret.ControlPointCount = br.ReadInt32();
                ret.Reserved1 = br.ReadUInt32();
                ret.Reserved2 = br.ReadUInt32();
                long end = br.BaseStream.Position;

                ret.ControlPointsArray = new PathControlPoint[ret.ControlPointCount];

                br.BaseStream.Position = start + ret.ControlPoints;
                for( int i = 0; i < ret.ControlPointCount; i++ )
                    ret.ControlPointsArray[ i ] = PathControlPoint.Read( br );
                br.BaseStream.Position = end;

                return ret;
            }
        }

        /* Composition clases */
        public struct RelativePositions
        {
            public int Pos;
            public int PosCount;

            public static RelativePositions Read( BinaryReader br )
            {
                RelativePositions ret = new RelativePositions();

                ret.Pos = br.ReadInt32();
                ret.PosCount = br.ReadInt32();

                return ret;
            }
        }

        public struct WeaponModel
        {
            public ushort SkeletonId;
            public ushort PatternId;
            public ushort ImageChangeId;
            public ushort StainingId;

            public static WeaponModel Read( BinaryReader br )
            {
                WeaponModel ret = new WeaponModel();

                ret.SkeletonId = br.ReadUInt16();
                ret.PatternId = br.ReadUInt16();
                ret.ImageChangeId = br.ReadUInt16();
                ret.StainingId = br.ReadUInt16();

                return ret;
            }
        }

        public struct ColorHDRI
        {
            public byte Red;
            public byte Green;
            public byte Blue;
            public byte Alpha;
            public float Intensity;

            public static ColorHDRI Read( BinaryReader br )
            {
                ColorHDRI ret = new ColorHDRI();

                ret.Red = br.ReadByte();
                ret.Green = br.ReadByte();
                ret.Blue = br.ReadByte();
                ret.Alpha = br.ReadByte();
                ret.Intensity = br.ReadSingle();

                return ret;
            }
        }

        public struct Color
        {
            public byte Red;
            public byte Green;
            public byte Blue;
            public byte Alpha;

            public static Color Read( BinaryReader br )
            {
                Color ret = new Color();

                ret.Red = br.ReadByte();
                ret.Green = br.ReadByte();
                ret.Blue = br.ReadByte();
                ret.Alpha = br.ReadByte();

                return ret;
            }
        }

        public struct MovePathSettings
        {
	        public eMovePathModeLayer Mode;
            public byte AutoPlay;
            public byte Padding00;
            public ushort Time;
            public byte Loop;
            public byte Reverse;
            public byte[] Padding01; //[2]
            public eRotationTypeLayer Rotation;
            public ushort AccelerateTime;
            public ushort DecelerateTime;
            public float[] VerticalSwingRange; //[2]
            public float[] HorizontalSwingRange; //[2]
            public float[] SwingMoveSpeedRange; //[2]
            public float[] SwingRotation; //[2]
            public float[] SwingRotationSpeedRange; //[2]

            public static MovePathSettings Read( BinaryReader br )
            {
                MovePathSettings ret = new MovePathSettings();

                ret.Mode = (eMovePathModeLayer) br.ReadInt32();
                ret.AutoPlay = br.ReadByte();
                ret.Padding00 = br.ReadByte();
                ret.Time = br.ReadUInt16();
                ret.Loop = br.ReadByte();
                ret.Reverse = br.ReadByte();
                ret.Padding01 = br.ReadBytes( 2 );
                ret.Rotation = (eRotationTypeLayer) br.ReadUInt32();
                ret.AccelerateTime = br.ReadUInt16();
                ret.DecelerateTime = br.ReadUInt16();

                // TODO: verify this works lol
                ret.VerticalSwingRange = br.ReadStructures< float >( 2 ).ToArray();
                ret.HorizontalSwingRange = br.ReadStructures< float >( 2 ).ToArray();
                ret.SwingMoveSpeedRange = br.ReadStructures< float >( 2 ).ToArray();
                ret.SwingRotation = br.ReadStructures< float >( 2 ).ToArray();
                ret.SwingRotationSpeedRange = br.ReadStructures< float >( 2 ).ToArray();

                return ret;
            }
        }

        public struct SEParam
        {
            public eSETypeLayer SEType;
            public byte AutoPlay;
            public byte IsNoFarClip;
            public byte[] Padding00; //[2]
            public int Binary;
            public int BinaryCount;
            public uint PointSelection;

            public byte[] Binaries;

            public static SEParam Read( BinaryReader br )
            {
                SEParam ret = new SEParam();

                long start = br.BaseStream.Position;
                ret.SEType = (eSETypeLayer) br.ReadInt32();
                ret.AutoPlay = br.ReadByte();
                ret.IsNoFarClip = br.ReadByte();
                ret.Padding00 = br.ReadBytes( 2 );
                ret.Binary = br.ReadInt32();
                ret.BinaryCount = br.ReadInt32();
                ret.PointSelection = br.ReadUInt32();
                long end = br.BaseStream.Position;

                br.BaseStream.Position = start + ret.Binary;
                ret.Binaries = br.ReadBytes( ret.BinaryCount );
                br.BaseStream.Position = end;

                return ret;
            }
        }

        public struct SGMemberID
        {
            public byte[] MemberIDs;// [4]

            public static SGMemberID Read( BinaryReader br )
            {
                SGMemberID ret = new SGMemberID();

                ret.MemberIDs = br.ReadBytes( 4 );

                return ret;
            }
        }

        public struct SGOverriddenMember
        {
	        int AssetType;
	        SGMemberID MemberID;

            public static SGOverriddenMember Read( BinaryReader br )
            {
                SGOverriddenMember ret = new SGOverriddenMember();

                ret.AssetType = br.ReadInt32();
                ret.MemberID = SGMemberID.Read( br );

                return ret;
            }
        }

        struct SGOverriddenBG
        {
	        byte RenderShadowEnabled;
	        byte RenderLightShadowEnabled;
            // fixed byte Padding00[2];
	        float RenderModelClipRange;
	        byte IsVisible;
	        byte CollisionExist;
            // fixed byte Padding01[2];
        }

        struct SGOverriddenVFX
        {
	        byte ColorEnable;
	        Color color;
	        byte IsAutoPlay;
	        byte ZCorrectEnable;
            private byte Padding00;
	        float ZCorrect;
        }

        struct SGOverriddenSE
        {
	        byte AutoPlay;
            // fixed byte Padding00[3];
        }

        struct SGOverriddenLight
        {
	        ColorHDRI color;
	        float ShadowClipRange;
	        byte SpecularEnabled;
	        byte BGShadowEnabled;
	        byte CharacterShadowEnabled;
            byte Padding00;
	        ushort MergeGroupID;
	        byte DiffuseColorHDREdited;
	        byte ShadowClipRangeEdited;
	        byte SpecularEnabledEdited;
	        byte BGShadowEnabledEdited;
	        byte CharacterShadowEnabledEdited;
	        byte MergeGroupIDEdited;
        }

        /* Instance object classes */
        public struct BGInstanceObject : IInstanceObject
        {
            public int AssetPath;
            public int CollisionAssetPath;

            public eModelConfigCollisionTypeLayer CollisionType;
            public uint AttributeMask;
            public uint Attribute;
            public int CollisionConfig;   //TODO: read CollisionConfig
            public byte IsVisible;
            public byte RenderShadowEnabled;
            public byte RenderLightShadowEnabled;
            public byte Padding00;
            public float RenderModelClipRange;

            public string strAssetPath;
            public string strCollisionAssetPath;

            public static BGInstanceObject Read( BinaryReader br )
            {
                BGInstanceObject ret = new BGInstanceObject();

                long start = br.BaseStream.Position;
                ret.AssetPath = br.ReadInt32();
                ret.CollisionAssetPath = br.ReadInt32();
                ret.CollisionType = (eModelConfigCollisionTypeLayer) br.ReadInt32();
                ret.AttributeMask = br.ReadUInt32();
                ret.Attribute = br.ReadUInt32();
                ret.CollisionConfig = br.ReadInt32();
                ret.IsVisible = br.ReadByte();
                ret.RenderShadowEnabled = br.ReadByte();
                ret.RenderLightShadowEnabled = br.ReadByte();
                ret.Padding00 = br.ReadByte();
                ret.RenderModelClipRange = br.ReadSingle();

                ret.strAssetPath = br.ReadStringOffset( start + ret.AssetPath - 48 );
                ret.strCollisionAssetPath = br.ReadStringOffset( start + ret.CollisionAssetPath - 48 );

                return ret;
            }
        }

        public struct LightInstanceObject : IInstanceObject
        {
            public eLightTypeLayer LightType;
            public float Attenuation;
            public float RangeRate;
            public ePointLightTypeLayer PointLightType;
            public float AttenuationConeCoefficient;
            public float ConeDegree;
            public int TexturePath;
            public ColorHDRI DiffuseColorHDRI;
            public byte FollowsDirectionalLight;
            public byte Padding00;
            public short Reserved2;
            public byte SpecularEnabled;
            public byte BGShadowEnabled;
            public byte CharacterShadowEnabled;
            public byte Padding01;
            public float ShadowClipRange;
            public float PlaneLightRotationX;
            public float PlaneLightRotationY;
            public ushort MergeGroupID;
            public byte Padding02;

            public string strTexturePath;

            public static LightInstanceObject Read( BinaryReader br )
            {
                LightInstanceObject ret = new LightInstanceObject();

                long start = br.BaseStream.Position;
                ret.LightType = (eLightTypeLayer) br.ReadInt32();
                ret.Attenuation = br.ReadSingle();
                ret.RangeRate = br.ReadSingle();
                ret.PointLightType = (ePointLightTypeLayer) br.ReadInt32();
                ret.AttenuationConeCoefficient = br.ReadSingle();
                ret.ConeDegree = br.ReadSingle();
                ret.TexturePath = br.ReadInt32();
                ret.DiffuseColorHDRI = ColorHDRI.Read( br );
                ret.FollowsDirectionalLight = br.ReadByte();
                ret.Padding00 = br.ReadByte();
                ret.Reserved2 = br.ReadInt16();
                ret.SpecularEnabled = br.ReadByte();
                ret.BGShadowEnabled = br.ReadByte();
                ret.CharacterShadowEnabled = br.ReadByte();
                ret.Padding01 = br.ReadByte();
                ret.ShadowClipRange = br.ReadSingle();
                ret.PlaneLightRotationX = br.ReadSingle();
                ret.PlaneLightRotationY = br.ReadSingle();
                ret.MergeGroupID = br.ReadUInt16();
                ret.Padding02 = br.ReadByte();

                ret.strTexturePath = br.ReadStringOffset( start + ret.TexturePath - 48 );

                return ret;
            }
        }

        public struct VFXInstanceObject : IInstanceObject
        {
            public int AssetPath;
            public float SoftParticleFadeRange;
            public uint Reserved2;
            public Color Color;
            public byte IsAutoPlay;
            public byte IsNoFarClip;
            public byte[] Padding00; //[2]
            public float FadeNearStart;
            public float FadeNearEnd;
            public float FadeFarStart;
            public float FadeFarEnd;
            public float ZCorrect;

            public string strAssetPath;

            public static VFXInstanceObject Read( BinaryReader br )
            {
                VFXInstanceObject ret = new VFXInstanceObject();

                long start = br.BaseStream.Position;
                ret.AssetPath = br.ReadInt32();
                ret.SoftParticleFadeRange = br.ReadSingle();
                ret.Reserved2 = br.ReadUInt32();
                ret.Color = Color.Read( br );
                ret.IsAutoPlay = br.ReadByte();
                ret.IsNoFarClip = br.ReadByte();
                ret.Padding00 = br.ReadBytes( 2 );
                ret.FadeNearStart = br.ReadSingle();
                ret.FadeNearEnd = br.ReadSingle();
                ret.FadeFarStart = br.ReadSingle();
                ret.FadeFarEnd = br.ReadSingle();
                ret.ZCorrect = br.ReadSingle();

                ret.strAssetPath = br.ReadStringOffset( start + ret.AssetPath - 48 );

                return ret;
            }
        }

        public struct PositionMarkerInstanceObject : IInstanceObject
        {
            public ePositionMarkerTypeLayer PositionMarkerType;
            public int CommentJP; //TODO: are these strings?
            public int CommentEN;

            public static PositionMarkerInstanceObject Read( BinaryReader br )
            {
                PositionMarkerInstanceObject ret = new PositionMarkerInstanceObject();

                ret.PositionMarkerType = (ePositionMarkerTypeLayer) br.ReadInt32();
                ret.CommentJP = br.ReadInt32();
                ret.CommentEN = br.ReadInt32();

                return ret;
            }
        }

        public struct SharedGroupInstanceObject : IInstanceObject
        {
            public int AssetPath;
            public eDoorStateLayer InitialDoorState;
            public int OverriddenMembers; // TODO
            public int OverriddenMembersCount;
            public eRotationStateLayer InitialRotationState;
            public byte RandomTimelineAutoPlay;
            public byte RandomTimelineLoopPlayback;
            public byte IsCollisionControllableWithoutEObj;
            public byte Padding00;
            public uint BoundCLientPathInstanceID;
            public int _MovePathSettings;
            public byte NotCreateNavimeshDoor;
            public byte[] Padding01; //[3]
            public eTransformStateLayer InitialTransformState;
            public eColorStateLayer InitialColorState;

            public string strAssetPath;
            public SGOverriddenMember[] SGOverriddenMembers;
            public MovePathSettings MovePathSettings;

            public static SharedGroupInstanceObject Read( BinaryReader br )
            {
                SharedGroupInstanceObject ret = new SharedGroupInstanceObject();

                long start = br.BaseStream.Position;
                ret.AssetPath = br.ReadInt32();
                ret.InitialDoorState = (eDoorStateLayer) br.ReadInt32();
                ret.OverriddenMembers = br.ReadInt32();
                ret.OverriddenMembersCount = br.ReadInt32();
                ret.InitialRotationState = (eRotationStateLayer) br.ReadInt32();
                ret.RandomTimelineAutoPlay = br.ReadByte();
                ret.RandomTimelineLoopPlayback = br.ReadByte();
                ret.IsCollisionControllableWithoutEObj = br.ReadByte();
                ret.Padding00 = br.ReadByte();
                ret.BoundCLientPathInstanceID = br.ReadUInt32();
                ret._MovePathSettings = br.ReadInt32();
                ret.NotCreateNavimeshDoor = br.ReadByte();
                ret.Padding01 = br.ReadBytes( 3 );
                ret.InitialTransformState = (eTransformStateLayer) br.ReadInt32();
                ret.InitialColorState = (eColorStateLayer) br.ReadInt32();
                long end = br.BaseStream.Position;

                ret.strAssetPath = br.ReadStringOffset( start + ret.AssetPath - 48 );

                //TODO unlock the secrets
//                if( ret.OverriddenMembersCount > 0 )
//                {
//                    ret.SGOverriddenMembers = new SGOverriddenMember[ret.OverriddenMembersCount];
//                    for (int i = 0; i < ret.OverriddenMembersCount; i++)
//                        ret.SGOverriddenMembers[i] = SGOverriddenMember.Read(br);
//                }

                br.BaseStream.Position = start + ret._MovePathSettings - 48;
                ret.MovePathSettings = MovePathSettings.Read( br );
                br.BaseStream.Position = end;

                return ret;
            }
        }

        public struct SoundInstanceObject : IInstanceObject
        {
            public int SE_Param;
            public int AssetPath;

            public string strAssetPath;
            public SEParam SEParam;

            public static SoundInstanceObject Read( BinaryReader br )
            {
                SoundInstanceObject ret = new SoundInstanceObject();

                long start = br.BaseStream.Position;
                ret.SE_Param = br.ReadInt32();
                ret.AssetPath = br.ReadInt32();
                long end = br.BaseStream.Position;

                ret.strAssetPath = br.ReadStringOffset( start + ret.AssetPath - 48 );

                br.BaseStream.Position = start + ret.SE_Param - 48;
                ret.SEParam = SEParam.Read( br );
                br.BaseStream.Position = end;
                
                return ret;
            }
        }

        public struct ENPCInstanceObject : IInstanceObject
        {
            public NPCInstanceObject ParentData;

            public uint Behavior;
            public uint Reserved3;
            public uint Reserved4;

            public static ENPCInstanceObject Read( BinaryReader br )
            {
                ENPCInstanceObject ret = new ENPCInstanceObject();
                long start = br.BaseStream.Position;

                ret.ParentData = NPCInstanceObject.Read( br );
                ret.Behavior = br.ReadUInt32();
                ret.Reserved3 = br.ReadUInt32();
                ret.Reserved4 = br.ReadUInt32();

                return ret;
            }
        }

        struct BNPCInstanceObject : IInstanceObject
        {
            public NPCInstanceObject ParentData;

            public uint NameId;
            public uint DropItem;
            public float SenseRangeRate;
            public ushort Level;
            public byte ActiveType;
            public byte PopInterval;
            public byte PopRate;
            public byte PopEvent;
            public byte LinkGroup;
            public byte LinkFamily;
            public byte LinkRange;
            public byte LinkCountLimit;
            public byte NonpopInitZone;
            public byte InvalidRepop;
            public byte LinkParent;
            public byte LinkOverride;
            public byte LinkReply;
            public byte Nonpop;
            public RelativePositions _RelativePositions;
            public float HorizontalPopRange;
            public float VerticalPopRange;
            public int BNpcBaseData;
            public byte RepopId;
            public byte BNPCRankId;
            public ushort TerritoryRange;
            public uint BoundInstanceID;
            public uint FateLayoutLabelId;
            public uint NormalAI;
            public uint ServerPathId;
            public uint EquipmentID;
            public uint CustomizeID;

            public Vector3[] RelativePositions;

            public static BNPCInstanceObject Read( BinaryReader br )
            {
                BNPCInstanceObject ret = new BNPCInstanceObject();
                long start = br.BaseStream.Position;

                ret.ParentData = NPCInstanceObject.Read( br );
                ret.NameId = br.ReadUInt32();
                ret.DropItem = br.ReadUInt32();
                ret.SenseRangeRate = br.ReadSingle();
                ret.Level = br.ReadUInt16();
                ret.ActiveType = br.ReadByte();
                ret.PopInterval = br.ReadByte();
                ret.PopRate = br.ReadByte();
                ret.PopEvent = br.ReadByte();
                ret.LinkGroup = br.ReadByte();
                ret.LinkFamily = br.ReadByte();
                ret.LinkRange = br.ReadByte();
                ret.LinkCountLimit = br.ReadByte();
                ret.NonpopInitZone = br.ReadByte();
                ret.InvalidRepop = br.ReadByte();
                ret.LinkParent = br.ReadByte();
                ret.LinkOverride = br.ReadByte();
                ret.LinkReply = br.ReadByte();
                ret.Nonpop = br.ReadByte();
                ret._RelativePositions = LayerCommon.RelativePositions.Read( br );
                ret.HorizontalPopRange = br.ReadSingle();
                ret.VerticalPopRange = br.ReadSingle();
                ret.BNpcBaseData = br.ReadInt32();
                ret.RepopId = br.ReadByte();
                ret.BNPCRankId = br.ReadByte();
                ret.TerritoryRange = br.ReadUInt16();
                ret.BoundInstanceID = br.ReadUInt32();
                ret.FateLayoutLabelId = br.ReadUInt32();
                ret.NormalAI = br.ReadUInt32();
                ret.ServerPathId = br.ReadUInt32();
                ret.EquipmentID = br.ReadUInt32();
                ret.CustomizeID = br.ReadUInt32();
                long end = br.BaseStream.Position;

                ret.RelativePositions = new Vector3[ret._RelativePositions.PosCount];

                br.BaseStream.Position = start + ret._RelativePositions.Pos;
                for( int i = 0; i < ret._RelativePositions.PosCount; i++)
                    ret.RelativePositions[ i ] = Vector3.Read( br );
                br.BaseStream.Position = end;

                return ret;
            }
        }

        // Need to check if even used/if in files
        public struct CTCharacter : IInstanceObject
        {
            public uint Flags;
            public uint ENpcID;
            public uint BNpcID;
            public uint SEPack;
            public int ModelVisibilities;
            public int ModelVisibilitiesCount;
            public int Weapons;
            public int WeaponCount;
            public byte Visible;
            public byte[] Padding00; //[3]

            public static CTCharacter Read( BinaryReader br )
            {
                CTCharacter ret = new CTCharacter();
                long start = br.BaseStream.Position;

                ret.Flags = br.ReadUInt32();
                ret.ENpcID = br.ReadUInt32();
                ret.BNpcID = br.ReadUInt32();
                ret.SEPack = br.ReadUInt32();
                ret.ModelVisibilities = br.ReadInt32();
                ret.ModelVisibilitiesCount = br.ReadInt32();
                ret.Weapons = br.ReadInt32();
                ret.WeaponCount = br.ReadInt32();
                ret.Visible = br.ReadByte();
                ret.Padding00 = br.ReadBytes( 3 );

                return ret;
            }
        }

        public struct AetheryteInstanceObject : IInstanceObject// : GameInstanceObject
        {
            public GameInstanceObject ParentData;

            public uint BoundInstanceID;
            public uint Reserved1;

            public static AetheryteInstanceObject Read( BinaryReader br )
            {
                AetheryteInstanceObject ret = new AetheryteInstanceObject();
                long start = br.BaseStream.Position;

                ret.ParentData = GameInstanceObject.Read( br );
                ret.BoundInstanceID = br.ReadUInt32();
                ret.Reserved1 = br.ReadUInt32();

                return ret;
            }
        }

        public struct EnvSetInstanceObject : IInstanceObject
        {
            public int AssetPath;
            public uint BoundInstanceID;
            public eEnvSetShapeLayer Shape;
            public byte IsEnvMapShootingPoint;
            public byte Priority;
            public byte[] Padding00; //[2]
            public float EffectiveRange;
            public int InterpolationTime;
            public float Reverb;
            public float Filter;
            public int SoundAssetPath;

            public string strAssetPath;
            public string strSoundAssetPath;

            public static EnvSetInstanceObject Read( BinaryReader br )
            {
                EnvSetInstanceObject ret = new EnvSetInstanceObject();
                long start = br.BaseStream.Position;

                ret.AssetPath = br.ReadInt32();
                ret.BoundInstanceID = br.ReadUInt32();
                ret.Shape = (eEnvSetShapeLayer) br.ReadInt32();
                ret.IsEnvMapShootingPoint = br.ReadByte();
                ret.Priority = br.ReadByte();
                ret.Padding00 = br.ReadBytes( 2 );
                ret.EffectiveRange = br.ReadSingle();
                ret.InterpolationTime = br.ReadInt32();
                ret.Reverb = br.ReadSingle();
                ret.Filter = br.ReadSingle();
                ret.SoundAssetPath = br.ReadInt32();

                ret.strAssetPath = br.ReadStringOffset( start + ret.AssetPath - 48 );
                ret.strSoundAssetPath = br.ReadStringOffset( start + ret.SoundAssetPath - 48 );

                return ret;
            }
        }

        // this extends GameInstanceObject but seems to not actually
        public struct GatheringInstanceObject : IInstanceObject// : GameInstanceObject
        {
            public uint GatheringPointID; // maps to GatheringPoint EXD
            public uint Reserved2;

            public static GatheringInstanceObject Read( BinaryReader br )
            {
                GatheringInstanceObject ret = new GatheringInstanceObject();
                long start = br.BaseStream.Position;

                ret.GatheringPointID = br.ReadUInt32();
                ret.Reserved2 = br.ReadUInt32();

                return ret;
            }
        }

        public struct HelperObjInstanceObject : IInstanceObject
        {
            public eHelperObjectTypeLayer ObjType;
            public eTargetTypeLayer TargetTypeBin;
            public byte Specific;
            public eCharacterSizeLayer CharacterSize;
            public byte UseDefaultMotion;
            public byte PartyMemberIndex;
            public uint TargetInstanceID;
            public uint DirectID;
            public byte UseDirectID;
            public byte KeepHighTexture;
            public WeaponModel Weapon;
            public byte AllianceMemberIndex;
            public byte Padding00;
            public float SkyVisibility;
            public int OtherInstanceObject;
            public byte UseTransform;
            public byte ModelLOD;
            public byte TextureLOD;
            public eDrawHeadPartsLayer DrawHeadParts;
            public Transformation DefaultTransform;

            public static HelperObjInstanceObject Read( BinaryReader br )
            {
                HelperObjInstanceObject ret = new HelperObjInstanceObject();
                long start = br.BaseStream.Position;

                ret.ObjType = (eHelperObjectTypeLayer) br.ReadInt32();
                ret.TargetTypeBin = (eTargetTypeLayer) br.ReadInt32();
                ret.Specific = br.ReadByte();
                ret.CharacterSize = (eCharacterSizeLayer) br.ReadByte();
                ret.UseDefaultMotion = br.ReadByte();
                ret.PartyMemberIndex = br.ReadByte();
                ret.TargetInstanceID = br.ReadUInt32();
                ret.DirectID = br.ReadUInt32();
                ret.UseDirectID = br.ReadByte();
                ret.KeepHighTexture = br.ReadByte();
                ret.Weapon = WeaponModel.Read( br );
                ret.AllianceMemberIndex = br.ReadByte();
                ret.Padding00 = br.ReadByte();
                ret.SkyVisibility = br.ReadSingle();
                ret.OtherInstanceObject = br.ReadInt32();
                ret.UseTransform = br.ReadByte();
                ret.ModelLOD = br.ReadByte();
                ret.TextureLOD = br.ReadByte();
                ret.DrawHeadParts = (eDrawHeadPartsLayer) br.ReadInt32();
                ret.DefaultTransform = Transformation.Read( br );

                return ret;
            }
        }

        public struct TreasureInstanceObject : IInstanceObject// : GameInstanceObject
        {
            public GameInstanceObject ParentData;

            public byte NonpopInitZone;
            public byte[] Padding00; //[3]
            public uint Reserved1;
            public uint Reserved2;

            public static TreasureInstanceObject Read( BinaryReader br )
            {
                TreasureInstanceObject ret = new TreasureInstanceObject();
                long start = br.BaseStream.Position;

                ret.NonpopInitZone = br.ReadByte();
                ret.Padding00 = br.ReadBytes( 3 );
                ret.Reserved1 = br.ReadUInt32();
                ret.Reserved2 = br.ReadUInt32();

                return ret;
            }
        }

        public struct WeaponInstanceObject : IInstanceObject
        {
            public WeaponModel Model;
            public byte IsVisible;
            public byte[] Padding00; //[3]

            public static WeaponInstanceObject Read( BinaryReader br )
            {
                WeaponInstanceObject ret = new WeaponInstanceObject();
                long start = br.BaseStream.Position;

                ret.Model = WeaponModel.Read( br );
                ret.IsVisible = br.ReadByte();
                ret.Padding00 = br.ReadBytes( 3 );

                return ret;
            }
        }

        public struct PopRangeInstanceObject : IInstanceObject
        {
            public ePopTypeLayer PopType;
            public RelativePositions _RelativePositions;
            public float InnerRadiusRatio;
            public byte Index;
            public byte[] Padding00; //[3]
            public uint Reserved1;

            public Vector3[] RelativePositions;

            public static PopRangeInstanceObject Read( BinaryReader br )
            {
                PopRangeInstanceObject ret = new PopRangeInstanceObject();
                long start = br.BaseStream.Position;

                ret.PopType = (ePopTypeLayer) br.ReadInt32();
                ret._RelativePositions = LayerCommon.RelativePositions.Read( br );
                ret.InnerRadiusRatio = br.ReadSingle();
                ret.Index = br.ReadByte();
                ret.Padding00 = br.ReadBytes( 3 );
                ret.Reserved1 = br.ReadUInt32();
                long end = br.BaseStream.Position;

                ret.RelativePositions = new Vector3[ret._RelativePositions.PosCount];

                br.BaseStream.Position = start + ret._RelativePositions.Pos - 48;
                for (int i = 0; i < ret._RelativePositions.PosCount; i++)
                    ret.RelativePositions[i] = Vector3.Read( br );
                br.BaseStream.Position = end;

                return ret;
            }
        }

        public struct ExitRangeInstanceObject : IInstanceObject// : TriggerBoxInstanceObject
        {
            public TriggerBoxInstanceObject ParentData;

            public eExitTypeLayer ExitType;
            public ushort ZoneId;
            public ushort TerritoryType;
            public int Index;
            public uint DestInstanceID;
            public uint ReturnInstanceID;
            public float PlayerRunningDirection;
            public uint Reserved3;

            public static ExitRangeInstanceObject Read( BinaryReader br )
            {
                ExitRangeInstanceObject ret = new ExitRangeInstanceObject();
                long start = br.BaseStream.Position;

                ret.ParentData = TriggerBoxInstanceObject.Read( br );
                ret.ExitType = (eExitTypeLayer) br.ReadInt32();
                ret.ZoneId = br.ReadUInt16();
                ret.TerritoryType = br.ReadUInt16();
                ret.Index = br.ReadInt32();
                ret.DestInstanceID = br.ReadUInt32();
                ret.ReturnInstanceID = br.ReadUInt32();
                ret.PlayerRunningDirection = br.ReadSingle();
                ret.Reserved3 = br.ReadUInt32();

                return ret;
            }
        }

        public struct MapRangeInstanceObject : IInstanceObject// : TriggerBoxInstanceObject
        {
            public TriggerBoxInstanceObject ParentData;

            public uint Map;
	        public uint PlaceNameBlock;
            public uint PlaceNameSpot;
            public uint Weather;
            public uint BGM; // links to BGMSituation EXD
            public uint Reserved2;
            public uint Reserved3;
            public ushort Reserved4;
            public byte HousingBlockID;
            public byte RestBonusEffective;
            public byte DiscoveryId;
            public byte MapEnabled;
            public byte PlaceNameEnabled;
            public byte DiscoveryEnabled;
            public byte BGMEnabled;
            public byte WeatherEnabled;
            public byte RestBonusEnabled;
            public byte BGMPlayZoneInOnly;
            public byte LiftEnabled;
            public byte HousingEnabled;
            public byte[] Padding01; //[2]

            public static MapRangeInstanceObject Read( BinaryReader br )
            {
                MapRangeInstanceObject ret = new MapRangeInstanceObject();
                long start = br.BaseStream.Position;

                ret.ParentData = TriggerBoxInstanceObject.Read( br );
                ret.Map = br.ReadUInt32();
                ret.PlaceNameBlock = br.ReadUInt32();
                ret.PlaceNameSpot = br.ReadUInt32();
                ret.Weather = br.ReadUInt32();
                ret.BGM = br.ReadUInt32();
                ret.Reserved2 = br.ReadUInt32();
                ret.Reserved3 = br.ReadUInt32();
                ret.Reserved4 = br.ReadUInt16();
                ret.HousingBlockID = br.ReadByte();
                ret.RestBonusEffective = br.ReadByte();
                ret.DiscoveryId = br.ReadByte();
                ret.MapEnabled = br.ReadByte();
                ret.PlaceNameEnabled = br.ReadByte();
                ret.DiscoveryEnabled = br.ReadByte();
                ret.BGMEnabled = br.ReadByte();
                ret.WeatherEnabled = br.ReadByte();
                ret.RestBonusEnabled = br.ReadByte();
                ret.BGMPlayZoneInOnly = br.ReadByte();
                ret.LiftEnabled = br.ReadByte();
                ret.HousingEnabled = br.ReadByte();
                ret.Padding01 = br.ReadBytes( 2 );

                return ret;
            }
        }

        //Unknown
        // struct NavimeshRangeInstanceObject
        // {
        //     TriggerBoxInstanceObject ParentData;
        // };

        public struct EventInstanceObject : IInstanceObject
        {
            public GameInstanceObject ParentData;

            public uint BoundInstanceID;
            public uint LinkedInstanceID;
            public uint Reserved1;
            public uint Reserved2;

            public static EventInstanceObject Read( BinaryReader br )
            {
                EventInstanceObject ret = new EventInstanceObject();
                long start = br.BaseStream.Position;

                ret.ParentData = GameInstanceObject.Read( br );
                ret.BoundInstanceID = br.ReadUInt32();
                ret.LinkedInstanceID = br.ReadUInt32();
                ret.Reserved1 = br.ReadUInt32();
                ret.Reserved2 = br.ReadUInt32();

                return ret;
            }
        }

        public struct EnvLocationInstanceObject : IInstanceObject
        {
            public int SHAmbientLightAssetPath;
            public int EnvMapAssetPath;

            public string strSHAmbientLightAssetPath;
            public string strEnvMapAssetPath;

            public static EnvLocationInstanceObject Read( BinaryReader br )
            {
                EnvLocationInstanceObject ret = new EnvLocationInstanceObject();
                long start = br.BaseStream.Position;

                ret.SHAmbientLightAssetPath = br.ReadInt32();
                ret.EnvMapAssetPath = br.ReadInt32();

                ret.strSHAmbientLightAssetPath = br.ReadStringOffset(start + ret.SHAmbientLightAssetPath - 48);
                ret.strEnvMapAssetPath = br.ReadStringOffset(start + ret.EnvMapAssetPath - 48);

                return ret;
            }
        }

        public struct EventRangeInstanceObject : IInstanceObject
        {
            public TriggerBoxInstanceObject ParentData;
            //TODO: 12 more bytes here. Might be flags idk

            public static EventRangeInstanceObject Read( BinaryReader br )
            {
                EventRangeInstanceObject ret = new EventRangeInstanceObject();
                long start = br.BaseStream.Position;

                ret.ParentData = TriggerBoxInstanceObject.Read( br );

                return ret;
            }
        }

        public struct QuestMarkerInstanceObject : IInstanceObject
        {
            public eRangeTypeLayer RangeType;
            public uint Reserved1;
            public uint Reserved2;

            public static QuestMarkerInstanceObject Read( BinaryReader br )
            {
                QuestMarkerInstanceObject ret = new QuestMarkerInstanceObject();
                long start = br.BaseStream.Position;

                ret.RangeType = (eRangeTypeLayer) br.ReadInt32();
                ret.Reserved1 = br.ReadUInt32();
                ret.Reserved2 = br.ReadUInt32();

                return ret;
            }
        }

        public struct CollisionBoxInstanceObject : IInstanceObject
        {
            public TriggerBoxInstanceObject ParentData;

            public uint AttributeMask;
            public uint Attribute;
            public byte PushPlayerOut;
            public byte[] Padding01; //[3]
            public int CollisionAssetPath;
            public uint Reserved2;

            public string strCollisionAssetPath;

            public static CollisionBoxInstanceObject Read( BinaryReader br )
            {
                CollisionBoxInstanceObject ret = new CollisionBoxInstanceObject();
                long start = br.BaseStream.Position;

                ret.ParentData = TriggerBoxInstanceObject.Read( br );
                ret.AttributeMask = br.ReadUInt32();
                ret.Attribute = br.ReadUInt32();
                ret.PushPlayerOut = br.ReadByte();
                ret.Padding01 = br.ReadBytes( 3 );
                ret.CollisionAssetPath = br.ReadInt32();
                ret.Reserved2 = br.ReadUInt32();
                
                return ret;
            }
        }

        // TODO: implement when encountered
        public struct DoorRangeInstanceObject : IInstanceObject// : TriggerBoxInstanceObject
        {
            public uint Reserved2;
            public uint Reserved3;
        }

        public struct LineVFXInstanceObject : IInstanceObject
        {
            public eLineStyleLayer LineStyle;
            public uint Reserved1;
            public uint Reserved2;

            public static LineVFXInstanceObject Read( BinaryReader br )
            {
                LineVFXInstanceObject ret = new LineVFXInstanceObject();
                long start = br.BaseStream.Position;

                ret.LineStyle = (eLineStyleLayer) br.ReadUInt32();
                ret.Reserved1 = br.ReadUInt32();
                ret.Reserved2 = br.ReadUInt32();

                return ret;
            }
        }

        public struct ClientPathInstanceObject : IInstanceObject// : PathInstanceObject
        {
            public PathInstanceObject ParentData;

            public byte Ring;
            public byte[] Padding00; //[3]

            public static ClientPathInstanceObject Read( BinaryReader br )
            {
                ClientPathInstanceObject ret = new ClientPathInstanceObject();
                long start = br.BaseStream.Position;

                ret.ParentData = PathInstanceObject.Read( br );
                ret.Ring = br.ReadByte();
                ret.Padding00 = br.ReadBytes( 3 );

                return ret;
            }
        }

        public struct ServerPathInstanceObject : IInstanceObject
        {
            public PathInstanceObject ParentData;

            public static ServerPathInstanceObject Read( BinaryReader br )
            {
                ServerPathInstanceObject ret = new ServerPathInstanceObject();
                long start = br.BaseStream.Position;

                ret.ParentData = PathInstanceObject.Read( br );

                return ret;
            }
        }

        public struct GimmickRangeInstanceObject : IInstanceObject
        {
            public TriggerBoxInstanceObject ParentData;

            public eGimmickTypeLayer GimmickType;
            public uint GimmickKey;
            public byte RoomUseAttribute;
            public byte GroupId;
            public byte EnabledInDead;
            public byte Padding01;
            public uint Reserved;

            public static GimmickRangeInstanceObject Read( BinaryReader br )
            {
                GimmickRangeInstanceObject ret = new GimmickRangeInstanceObject();
                long start = br.BaseStream.Position;

                ret.ParentData = TriggerBoxInstanceObject.Read( br );
                ret.GimmickType = (eGimmickTypeLayer) br.ReadInt32();
                ret.GimmickKey = br.ReadUInt32();
                ret.RoomUseAttribute = br.ReadByte();
                ret.GroupId = br.ReadByte();
                ret.EnabledInDead = br.ReadByte();
                ret.Padding01 = br.ReadByte();
                ret.Reserved = br.ReadUInt32();
                
                return ret;
            }
        }

        public struct TargetMarkerInstanceObject : IInstanceObject
        {
            public float NamePlateOffsetY;
            public eTargetMarkerTypeLayer TargetMakerType;

            public static TargetMarkerInstanceObject Read( BinaryReader br )
            {
                TargetMarkerInstanceObject ret = new TargetMarkerInstanceObject();
                long start = br.BaseStream.Position;

                ret.NamePlateOffsetY = br.ReadSingle();
                ret.TargetMakerType = (eTargetMarkerTypeLayer) br.ReadInt32();

                return ret;
            }
        }

        public struct ChairMarkerInstanceObject : IInstanceObject
        {
            public byte LeftEnable;
            public byte RightEnable;
            public byte BackEnable;
            public byte Padding00;
            public eObjectTypeLayer ObjectType;

            public static ChairMarkerInstanceObject Read( BinaryReader br )
            {
                ChairMarkerInstanceObject ret = new ChairMarkerInstanceObject();
                long start = br.BaseStream.Position;

                ret.LeftEnable = br.ReadByte();
                ret.RightEnable = br.ReadByte();
                ret.BackEnable = br.ReadByte();
                ret.Padding00 = br.ReadByte();
                ret.ObjectType = (eObjectTypeLayer) br.ReadInt32();

                return ret;
            }
        }

        public struct ClickableRangeInstanceObject : IInstanceObject// : TriggerBoxInstanceObject
        {
            public uint Reserved2;

            public static ClickableRangeInstanceObject Read( BinaryReader br )
            {
                ClickableRangeInstanceObject ret = new ClickableRangeInstanceObject();
                long start = br.BaseStream.Position;

                ret.Reserved2 = br.ReadUInt32();

                return ret;
            }
        }

        public struct PrefetchRangeInstanceObject : IInstanceObject// : TriggerBoxInstanceObject
        {
            public TriggerBoxInstanceObject ParentData;

            public uint BoundInstanceID; // reference to the ExitRange the Prefetch is for
            public uint Reserved2;

            public static PrefetchRangeInstanceObject Read( BinaryReader br )
            {
                PrefetchRangeInstanceObject ret = new PrefetchRangeInstanceObject();
                long start = br.BaseStream.Position;

                ret.ParentData = TriggerBoxInstanceObject.Read( br );
                ret.BoundInstanceID = br.ReadUInt32();
                ret.Reserved2 = br.ReadUInt32();

                return ret;
            }
        }

        public struct FateRangeInstanceObject : IInstanceObject
        {
            public TriggerBoxInstanceObject ParentData;

            public uint FateLayoutLabelId;

            public static FateRangeInstanceObject Read( BinaryReader br )
            {
                FateRangeInstanceObject ret = new FateRangeInstanceObject();
                long start = br.BaseStream.Position;

                ret.ParentData = TriggerBoxInstanceObject.Read( br );
                ret.FateLayoutLabelId = br.ReadUInt32();

                return ret;
            }
        }

        struct KeepRangeInstanceObject
        {
        }

        public struct InstanceObject
        {
            public eAssetTypeLayer AssetType;
            public uint InstanceID;
            public StringOffset Name;
            public Transformation Transform;
            public IInstanceObject Object;

            public static InstanceObject Read( BinaryReader br )
            {
                InstanceObject ret = new InstanceObject();
                long start = br.BaseStream.Position;

                ret.AssetType = (eAssetTypeLayer)br.ReadInt32();
                ret.InstanceID = br.ReadUInt32();
                ret.Name = new StringOffset( br, start );

                ret.Transform = Transformation.Read( br );

                switch ( ret.AssetType )
                {
                    case eAssetTypeLayer.BG: ret.Object = BGInstanceObject.Read( br ); break; //0x1
                    case eAssetTypeLayer.LayLight: ret.Object = LightInstanceObject.Read( br ); break; //0x3
                    case eAssetTypeLayer.VFX: ret.Object = VFXInstanceObject.Read( br ); break; //0x4
                    case eAssetTypeLayer.PositionMarker: ret.Object = PositionMarkerInstanceObject.Read( br ); break; //0x5
                    case eAssetTypeLayer.SharedGroup: ret.Object = SharedGroupInstanceObject.Read( br ); break; //0x6
                    case eAssetTypeLayer.Sound: ret.Object = SoundInstanceObject.Read( br ); break; //0x7
                    case eAssetTypeLayer.EventNPC: ret.Object = ENPCInstanceObject.Read( br ); break; //0x8
                    case eAssetTypeLayer.BattleNPC: ret.Object = BNPCInstanceObject.Read( br ); break; //0x9
                    case eAssetTypeLayer.Aetheryte: ret.Object = AetheryteInstanceObject.Read( br ); break; //0xC
                    case eAssetTypeLayer.EnvSet: ret.Object = EnvSetInstanceObject.Read( br ); break; //0xD
                    case eAssetTypeLayer.Gathering: ret.Object = GatheringInstanceObject.Read( br ); break; //0x#
                    case eAssetTypeLayer.Treasure: ret.Object = TreasureInstanceObject.Read( br ); break; //0x10
                    case eAssetTypeLayer.PopRange: ret.Object = PopRangeInstanceObject.Read( br ); break; //0x28
                    case eAssetTypeLayer.ExitRange: ret.Object = ExitRangeInstanceObject.Read( br ); break; //0x29
                    case eAssetTypeLayer.MapRange: ret.Object = MapRangeInstanceObject.Read( br ); break; //0x2B
                    // case eAssetTypeLayer.NaviMeshRange: ret.Object = NavimeshRangeInstanceObject.Read( br ); break; //0x2C
                    case eAssetTypeLayer.EventObject: ret.Object = EventInstanceObject.Read( br ); break; //0x2D
                    case eAssetTypeLayer.EnvLocation: ret.Object = EnvLocationInstanceObject.Read( br ); break; //0x2F
                    case eAssetTypeLayer.EventRange: ret.Object = EventRangeInstanceObject.Read( br ); break; //0x31
                    case eAssetTypeLayer.QuestMarker: ret.Object = QuestMarkerInstanceObject.Read( br ); break; //0x33
                    case eAssetTypeLayer.CollisionBox: ret.Object = CollisionBoxInstanceObject.Read( br ); break; //0x39
                    case eAssetTypeLayer.LineVFX: ret.Object = LineVFXInstanceObject.Read( br ); break; //0x3B
                    case eAssetTypeLayer.ClientPath: ret.Object = ClientPathInstanceObject.Read( br ); break; //0x41
                    case eAssetTypeLayer.ServerPath: ret.Object = ServerPathInstanceObject.Read( br ); break; //0x42
                    case eAssetTypeLayer.GimmickRange: ret.Object = GimmickRangeInstanceObject.Read( br ); break; //0x43
                    case eAssetTypeLayer.TargetMarker: ret.Object = TargetMarkerInstanceObject.Read( br ); break; //0x44
                    case eAssetTypeLayer.ChairMarker: ret.Object = ChairMarkerInstanceObject.Read( br ); break; //0x45
                    case eAssetTypeLayer.PrefetchRange: ret.Object = PrefetchRangeInstanceObject.Read( br ); break; //0x47
                    case eAssetTypeLayer.FateRange: ret.Object = FateRangeInstanceObject.Read( br ); break; //0x48
                    default:
                        Debug.WriteLine($"Unknown asset {ret.AssetType.ToString()} @ {br.BaseStream.Position}.");
                        break;
                }

//                Debug.WriteLine($"Read {ret.Object.GetType().FullName}");

                return ret;
            }
        }

        public struct LayerSetReferenced
        {
            public uint LayerSetID;

            public static LayerSetReferenced Read( BinaryReader br )
            {
                LayerSetReferenced ret = new LayerSetReferenced();
                long start = br.BaseStream.Position;

                ret.LayerSetID = br.ReadUInt32();

                return ret;
            }
        }

        public struct LayerSetReferencedList
        {
            public LayerSetReferencedType ReferencedType;
            public int LayerSets;
            public int LayerSetCount;

            public static LayerSetReferencedList Read( BinaryReader br )
            {
                LayerSetReferencedList ret = new LayerSetReferencedList();
                long start = br.BaseStream.Position;

                ret.ReferencedType = (LayerSetReferencedType) br.ReadInt32();
                ret.LayerSets = br.ReadInt32();
                ret.LayerSetCount = br.ReadInt32();

                return ret;
            }
        }

        public struct OBSetReferenced
        {
            public eAssetTypeLayer AssetType;
            public uint InstanceID;
            public int OBSetAssetPath;

            public string strOBSetAssetPath;

            public static OBSetReferenced Read( BinaryReader br )
            {
                OBSetReferenced ret = new OBSetReferenced();
                long start = br.BaseStream.Position;

                ret.AssetType = (eAssetTypeLayer) br.ReadInt32();
                ret.InstanceID = br.ReadUInt32();
                ret.OBSetAssetPath = br.ReadInt32();

                ret.strOBSetAssetPath = br.ReadStringOffset( start + ret.OBSetAssetPath );

                return ret;
            }
        }

        public struct OBSetEnableReferenced
        {
            public eAssetTypeLayer AssetType;
            public uint InstanceID;
            public byte OBSetEnable;
            public byte OBSetEmissiveEnable;
            public byte[] Padding00; //[2]

            public static OBSetEnableReferenced Read( BinaryReader br )
            {
                OBSetEnableReferenced ret = new OBSetEnableReferenced();
                long start = br.BaseStream.Position;

                ret.AssetType = (eAssetTypeLayer) br.ReadInt32();
                ret.InstanceID = br.ReadUInt32();
                ret.OBSetEnable = br.ReadByte();
                ret.OBSetEmissiveEnable = br.ReadByte();
                ret.Padding00 = br.ReadBytes( 2 );

                return ret;
            }
        }

        public struct Layer
        {
            public uint LayerID;
            public int Name;
            public int _InstanceObjects;
            public int _InstanceObjectCount;
            public byte ToolModeVisible;
            public byte ToolModeReadOnly;
            public byte IsBushLayer;
            public byte PS3Visible;
            public int _LayerSetReferencedList;
            public ushort FestivalID;
            public ushort FestivalPhaseID;
            public byte IsTemporary;
            public byte IsHousing;
            public ushort VersionMask;
            public uint Reserved;
            public int _OBSetReferencedList;
            public int _OBSetReferencedListCount;
            public int _OBSetEnableReferencedList;
            public int _OBSetEnableReferencedListCount;
            public LayerSetReferencedList LayerSetReferencedList;

            public string strName;

            public InstanceObject[] InstanceObjects;
            public LayerSetReferenced[] LayerSetReferences;
            public OBSetReferenced[] OBSetReferencedList;
            public OBSetEnableReferenced[] OBSetEnableReferencedList;

            public static Layer Read( BinaryReader br )
            {
                Layer ret = new Layer();
                long start = br.BaseStream.Position;

                ret.LayerID = br.ReadUInt32();
                ret.Name = br.ReadInt32();
                ret._InstanceObjects = br.ReadInt32();
                ret._InstanceObjectCount = br.ReadInt32();
                ret.ToolModeVisible = br.ReadByte();
                ret.ToolModeReadOnly = br.ReadByte();
                ret.IsBushLayer = br.ReadByte();
                ret.PS3Visible = br.ReadByte();
                ret._LayerSetReferencedList = br.ReadInt32();
                ret.FestivalID = br.ReadUInt16();
                ret.FestivalPhaseID = br.ReadUInt16();
                ret.IsTemporary = br.ReadByte();
                ret.IsHousing = br.ReadByte();
                ret.VersionMask = br.ReadUInt16();
                ret.Reserved = br.ReadUInt32();
                ret._OBSetReferencedList = br.ReadInt32();
                ret._OBSetReferencedListCount = br.ReadInt32();
                ret._OBSetEnableReferencedList = br.ReadInt32();
                ret._OBSetEnableReferencedListCount = br.ReadInt32();

                ret.strName = br.ReadStringOffset( start + ret.Name );

                br.BaseStream.Position = start + ret._InstanceObjects;
                List<int> instanceOffsets = br.ReadStructures< Int32 >( ret._InstanceObjectCount );

                br.BaseStream.Position = start + ret._LayerSetReferencedList;
                ret.LayerSetReferencedList = LayerSetReferencedList.Read( br );

                ret.InstanceObjects = new InstanceObject[ret._InstanceObjectCount];
                ret.LayerSetReferences = new LayerSetReferenced[ret.LayerSetReferencedList.LayerSetCount];
                ret.OBSetReferencedList = new OBSetReferenced[ret._OBSetReferencedListCount];
                ret.OBSetEnableReferencedList = new OBSetEnableReferenced[ret._OBSetEnableReferencedListCount];
                
                for( int i = 0; i < ret._InstanceObjectCount; i++ )
                {
                    br.BaseStream.Position = start + ret._InstanceObjects + instanceOffsets[i];
                    ret.InstanceObjects[i] = InstanceObject.Read( br );
                }

                br.BaseStream.Position = start + ret.LayerSetReferencedList.LayerSets;
                for (int i = 0; i < ret.LayerSetReferencedList.LayerSetCount; i++)
                    ret.LayerSetReferences[i] = LayerSetReferenced.Read( br );

                br.BaseStream.Position = start + ret._OBSetReferencedList;
                for (int i = 0; i < ret._OBSetReferencedListCount; i++)
                    ret.OBSetReferencedList[i] = OBSetReferenced.Read( br );

                br.BaseStream.Position = start + ret._OBSetEnableReferencedList;
                for (int i = 0; i < ret._OBSetEnableReferencedListCount; i++)
                    ret.OBSetEnableReferencedList[i] = OBSetEnableReferenced.Read( br );

                return ret;
            }
        }
    }
}
