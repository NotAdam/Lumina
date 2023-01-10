// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Quest", columnHash: 0xc4157593 )]
    public partial class Quest : ExcelRow
    {
        
        public SeString Name { get; set; }
        public SeString Id { get; set; }
        public LazyRow< ExVersion > Expansion { get; set; }
        public LazyRow< ClassJobCategory > ClassJobCategory0 { get; set; }
        public ushort ClassJobLevel0 { get; set; }
        public byte QuestLevelOffset { get; set; }
        public LazyRow< ClassJobCategory > ClassJobCategory1 { get; set; }
        public ushort ClassJobLevel1 { get; set; }
        public byte PreviousQuestJoin { get; set; }
        public LazyRow< Quest >[] PreviousQuest { get; set; }
        public uint Unknown12 { get; set; }
        public byte QuestLockJoin { get; set; }
        public LazyRow< Quest >[] QuestLock { get; set; }
        public ushort Header { get; set; }
        public byte Unknown17 { get; set; }
        public byte Unknown18 { get; set; }
        public LazyRow< ClassJob > ClassJobUnlock { get; set; }
        public LazyRow< GrandCompany > GrandCompany { get; set; }
        public LazyRow< GrandCompanyRank > GrandCompanyRank { get; set; }
        public byte InstanceContentJoin { get; set; }
        public LazyRow< InstanceContent >[] InstanceContent { get; set; }
        public LazyRow< Festival > Festival { get; set; }
        public byte FestivalBegin { get; set; }
        public byte FestivalEnd { get; set; }
        public ushort BellStart { get; set; }
        public ushort BellEnd { get; set; }
        public LazyRow< BeastTribe > BeastTribe { get; set; }
        public LazyRow< BeastReputationRank > BeastReputationRank { get; set; }
        public ushort BeastReputationValue { get; set; }
        public LazyRow< SatisfactionNpc > SatisfactionNpc { get; set; }
        public byte SatisfactionLevel { get; set; }
        public LazyRow< Mount > MountRequired { get; set; }
        public bool IsHouseRequired { get; set; }
        public LazyRow< DeliveryQuest > DeliveryQuest { get; set; }
        public uint IssuerStart { get; set; }
        public LazyRow< Level > IssuerLocation { get; set; }
        public LazyRow< Behavior > ClientBehavior { get; set; }
        public uint TargetEnd { get; set; }
        public bool IsRepeatable { get; set; }
        public byte RepeatIntervalType { get; set; }
        public LazyRow< QuestRepeatFlag > QuestRepeatFlag { get; set; }
        public bool CanCancel { get; set; }
        public byte Type { get; set; }
        public LazyRow< QuestClassJobSupply > QuestClassJobSupply { get; set; }
        public SeString[] ScriptInstruction { get; set; }
        public uint[] ScriptArg { get; set; }
        public byte[] ActorSpawnSeq { get; set; }
        public byte[] ActorDespawnSeq { get; set; }
        public uint[] Listener { get; set; }
        public byte[] QuestUInt8A { get; set; }
        public byte[] QuestUInt8B { get; set; }
        public byte[] ConditionType { get; set; }
        public uint[] ConditionValue { get; set; }
        public byte[] ConditionOperator { get; set; }
        public ushort[] Behavior { get; set; }
        public bool[] VisibleBool { get; set; }
        public bool[] ConditionBool { get; set; }
        public bool[] ItemBool { get; set; }
        public bool[] AnnounceBool { get; set; }
        public bool[] BehaviorBool { get; set; }
        public bool[] AcceptBool { get; set; }
        public bool[] QualifiedBool { get; set; }
        public bool[] CanTargetBool { get; set; }
        public byte[] ToDoCompleteSeq { get; set; }
        public byte[] ToDoQty { get; set; }
        public uint[] Unknown1221 { get; set; }
        public uint Unknown1229 { get; set; }
        public uint Unknown1230 { get; set; }
        public uint Unknown1231 { get; set; }
        public uint Unknown1232 { get; set; }
        public uint Unknown1233 { get; set; }
        public uint Unknown1234 { get; set; }
        public uint Unknown1235 { get; set; }
        public uint Unknown1236 { get; set; }
        public uint Unknown1237 { get; set; }
        public uint Unknown1238 { get; set; }
        public uint Unknown1239 { get; set; }
        public uint Unknown1240 { get; set; }
        public uint Unknown1241 { get; set; }
        public uint Unknown1242 { get; set; }
        public uint Unknown1243 { get; set; }
        public uint Unknown1244 { get; set; }
        public uint Unknown1245 { get; set; }
        public uint Unknown1246 { get; set; }
        public uint Unknown1247 { get; set; }
        public uint Unknown1248 { get; set; }
        public uint Unknown1249 { get; set; }
        public uint Unknown1250 { get; set; }
        public uint Unknown1251 { get; set; }
        public uint Unknown1252 { get; set; }
        public uint Unknown1253 { get; set; }
        public uint Unknown1254 { get; set; }
        public uint Unknown1255 { get; set; }
        public uint Unknown1256 { get; set; }
        public uint Unknown1257 { get; set; }
        public uint Unknown1258 { get; set; }
        public uint Unknown1259 { get; set; }
        public uint Unknown1260 { get; set; }
        public uint Unknown1261 { get; set; }
        public uint Unknown1262 { get; set; }
        public uint Unknown1263 { get; set; }
        public uint Unknown1264 { get; set; }
        public uint Unknown1265 { get; set; }
        public uint Unknown1266 { get; set; }
        public uint Unknown1267 { get; set; }
        public uint Unknown1268 { get; set; }
        public uint Unknown1269 { get; set; }
        public uint Unknown1270 { get; set; }
        public uint Unknown1271 { get; set; }
        public uint Unknown1272 { get; set; }
        public uint Unknown1273 { get; set; }
        public uint Unknown1274 { get; set; }
        public uint Unknown1275 { get; set; }
        public uint Unknown1276 { get; set; }
        public uint Unknown1277 { get; set; }
        public uint Unknown1278 { get; set; }
        public uint Unknown1279 { get; set; }
        public uint Unknown1280 { get; set; }
        public uint Unknown1281 { get; set; }
        public uint Unknown1282 { get; set; }
        public uint Unknown1283 { get; set; }
        public uint Unknown1284 { get; set; }
        public uint Unknown1285 { get; set; }
        public uint Unknown1286 { get; set; }
        public uint Unknown1287 { get; set; }
        public uint Unknown1288 { get; set; }
        public uint Unknown1289 { get; set; }
        public uint Unknown1290 { get; set; }
        public uint Unknown1291 { get; set; }
        public uint Unknown1292 { get; set; }
        public uint Unknown1293 { get; set; }
        public uint Unknown1294 { get; set; }
        public uint Unknown1295 { get; set; }
        public uint Unknown1296 { get; set; }
        public uint Unknown1297 { get; set; }
        public uint Unknown1298 { get; set; }
        public uint Unknown1299 { get; set; }
        public uint Unknown1300 { get; set; }
        public uint Unknown1301 { get; set; }
        public uint Unknown1302 { get; set; }
        public uint Unknown1303 { get; set; }
        public uint Unknown1304 { get; set; }
        public uint Unknown1305 { get; set; }
        public uint Unknown1306 { get; set; }
        public uint Unknown1307 { get; set; }
        public uint Unknown1308 { get; set; }
        public uint Unknown1309 { get; set; }
        public uint Unknown1310 { get; set; }
        public uint Unknown1311 { get; set; }
        public uint Unknown1312 { get; set; }
        public uint Unknown1313 { get; set; }
        public uint Unknown1314 { get; set; }
        public uint Unknown1315 { get; set; }
        public uint Unknown1316 { get; set; }
        public uint Unknown1317 { get; set; }
        public uint Unknown1318 { get; set; }
        public uint Unknown1319 { get; set; }
        public uint Unknown1320 { get; set; }
        public uint Unknown1321 { get; set; }
        public uint Unknown1322 { get; set; }
        public uint Unknown1323 { get; set; }
        public uint Unknown1324 { get; set; }
        public uint Unknown1325 { get; set; }
        public uint Unknown1326 { get; set; }
        public uint Unknown1327 { get; set; }
        public uint Unknown1328 { get; set; }
        public uint Unknown1329 { get; set; }
        public uint Unknown1330 { get; set; }
        public uint Unknown1331 { get; set; }
        public uint Unknown1332 { get; set; }
        public uint Unknown1333 { get; set; }
        public uint Unknown1334 { get; set; }
        public uint Unknown1335 { get; set; }
        public uint Unknown1336 { get; set; }
        public uint Unknown1337 { get; set; }
        public uint Unknown1338 { get; set; }
        public uint Unknown1339 { get; set; }
        public uint Unknown1340 { get; set; }
        public uint Unknown1341 { get; set; }
        public uint Unknown1342 { get; set; }
        public uint Unknown1343 { get; set; }
        public uint Unknown1344 { get; set; }
        public uint Unknown1345 { get; set; }
        public uint Unknown1346 { get; set; }
        public uint Unknown1347 { get; set; }
        public uint Unknown1348 { get; set; }
        public uint Unknown1349 { get; set; }
        public uint Unknown1350 { get; set; }
        public uint Unknown1351 { get; set; }
        public uint Unknown1352 { get; set; }
        public uint Unknown1353 { get; set; }
        public uint Unknown1354 { get; set; }
        public uint Unknown1355 { get; set; }
        public uint Unknown1356 { get; set; }
        public uint Unknown1357 { get; set; }
        public uint Unknown1358 { get; set; }
        public uint Unknown1359 { get; set; }
        public uint Unknown1360 { get; set; }
        public uint Unknown1361 { get; set; }
        public uint Unknown1362 { get; set; }
        public uint Unknown1363 { get; set; }
        public uint Unknown1364 { get; set; }
        public uint Unknown1365 { get; set; }
        public uint Unknown1366 { get; set; }
        public uint Unknown1367 { get; set; }
        public uint Unknown1368 { get; set; }
        public uint Unknown1369 { get; set; }
        public uint Unknown1370 { get; set; }
        public uint Unknown1371 { get; set; }
        public uint Unknown1372 { get; set; }
        public uint Unknown1373 { get; set; }
        public uint Unknown1374 { get; set; }
        public uint Unknown1375 { get; set; }
        public uint Unknown1376 { get; set; }
        public uint Unknown1377 { get; set; }
        public uint Unknown1378 { get; set; }
        public uint Unknown1379 { get; set; }
        public uint Unknown1380 { get; set; }
        public uint Unknown1381 { get; set; }
        public uint Unknown1382 { get; set; }
        public uint Unknown1383 { get; set; }
        public uint Unknown1384 { get; set; }
        public uint Unknown1385 { get; set; }
        public uint Unknown1386 { get; set; }
        public uint Unknown1387 { get; set; }
        public uint Unknown1388 { get; set; }
        public uint Unknown1389 { get; set; }
        public uint Unknown1390 { get; set; }
        public uint Unknown1391 { get; set; }
        public uint Unknown1392 { get; set; }
        public uint Unknown1393 { get; set; }
        public uint Unknown1394 { get; set; }
        public uint Unknown1395 { get; set; }
        public uint Unknown1396 { get; set; }
        public uint Unknown1397 { get; set; }
        public uint Unknown1398 { get; set; }
        public uint Unknown1399 { get; set; }
        public uint Unknown1400 { get; set; }
        public uint Unknown1401 { get; set; }
        public uint Unknown1402 { get; set; }
        public uint Unknown1403 { get; set; }
        public uint Unknown1404 { get; set; }
        public uint Unknown1405 { get; set; }
        public uint Unknown1406 { get; set; }
        public uint Unknown1407 { get; set; }
        public uint Unknown1408 { get; set; }
        public uint Unknown1409 { get; set; }
        public uint Unknown1410 { get; set; }
        public uint Unknown1411 { get; set; }
        public uint Unknown1412 { get; set; }
        public byte[] CountableNum { get; set; }
        public byte LevelMax { get; set; }
        public LazyRow< ClassJob > ClassJobRequired { get; set; }
        public LazyRow< QuestRewardOther > QuestRewardOtherDisplay { get; set; }
        public ushort ExpFactor { get; set; }
        public uint GilReward { get; set; }
        public LazyRow< Item > CurrencyReward { get; set; }
        public uint CurrencyRewardCount { get; set; }
        public LazyRow< Item >[] ItemCatalyst { get; set; }
        public byte[] ItemCountCatalyst { get; set; }
        public byte ItemRewardType { get; set; }
        public uint[] ItemReward { get; set; }
        public byte[] ItemCountReward { get; set; }
        public bool Unknown1465 { get; set; }
        public bool Unknown1466 { get; set; }
        public bool Unknown1467 { get; set; }
        public bool Unknown1468 { get; set; }
        public bool Unknown1469 { get; set; }
        public bool Unknown1470 { get; set; }
        public bool Unknown1471 { get; set; }
        public LazyRow< Stain >[] StainReward { get; set; }
        public LazyRow< Item >[] OptionalItemReward { get; set; }
        public byte[] OptionalItemCountReward { get; set; }
        public bool[] OptionalItemIsHQReward { get; set; }
        public LazyRow< Stain >[] OptionalItemStainReward { get; set; }
        public LazyRow< Emote > EmoteReward { get; set; }
        public LazyRow< Action > ActionReward { get; set; }
        public LazyRow< GeneralAction >[] GeneralActionReward { get; set; }
        public ushort SystemReward0 { get; set; }
        public LazyRow< QuestRewardOther > OtherReward { get; set; }
        public ushort SystemReward1 { get; set; }
        public ushort GCTypeReward { get; set; }
        public LazyRow< InstanceContent > InstanceContentUnlock { get; set; }
        public byte Tomestone { get; set; }
        public byte TomestoneReward { get; set; }
        public byte TomestoneCountReward { get; set; }
        public byte ReputationReward { get; set; }
        public LazyRow< PlaceName > PlaceName { get; set; }
        public LazyRow< JournalGenre > JournalGenre { get; set; }
        public byte Unknown1514 { get; set; }
        public uint Icon { get; set; }
        public uint IconSpecial { get; set; }
        public bool Introduction { get; set; }
        public bool HideOfferIcon { get; set; }
        public LazyRow< EventIconType > EventIconType { get; set; }
        public byte Unknown1520 { get; set; }
        public ushort SortKey { get; set; }
        public bool Unknown1522 { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Name = parser.ReadColumn< SeString >( 0 );
            Id = parser.ReadColumn< SeString >( 1 );
            Expansion = new LazyRow< ExVersion >( gameData, parser.ReadColumn< byte >( 2 ), language );
            ClassJobCategory0 = new LazyRow< ClassJobCategory >( gameData, parser.ReadColumn< byte >( 3 ), language );
            ClassJobLevel0 = parser.ReadColumn< ushort >( 4 );
            QuestLevelOffset = parser.ReadColumn< byte >( 5 );
            ClassJobCategory1 = new LazyRow< ClassJobCategory >( gameData, parser.ReadColumn< byte >( 6 ), language );
            ClassJobLevel1 = parser.ReadColumn< ushort >( 7 );
            PreviousQuestJoin = parser.ReadColumn< byte >( 8 );
            PreviousQuest = new LazyRow< Quest >[ 3 ];
            for( var i = 0; i < 3; i++ )
                PreviousQuest[ i ] = new LazyRow< Quest >( gameData, parser.ReadColumn< uint >( 9 + i ), language );
            Unknown12 = parser.ReadColumn< uint >( 12 );
            QuestLockJoin = parser.ReadColumn< byte >( 13 );
            QuestLock = new LazyRow< Quest >[ 2 ];
            for( var i = 0; i < 2; i++ )
                QuestLock[ i ] = new LazyRow< Quest >( gameData, parser.ReadColumn< uint >( 14 + i ), language );
            Header = parser.ReadColumn< ushort >( 16 );
            Unknown17 = parser.ReadColumn< byte >( 17 );
            Unknown18 = parser.ReadColumn< byte >( 18 );
            ClassJobUnlock = new LazyRow< ClassJob >( gameData, parser.ReadColumn< byte >( 19 ), language );
            GrandCompany = new LazyRow< GrandCompany >( gameData, parser.ReadColumn< byte >( 20 ), language );
            GrandCompanyRank = new LazyRow< GrandCompanyRank >( gameData, parser.ReadColumn< byte >( 21 ), language );
            InstanceContentJoin = parser.ReadColumn< byte >( 22 );
            InstanceContent = new LazyRow< InstanceContent >[ 3 ];
            for( var i = 0; i < 3; i++ )
                InstanceContent[ i ] = new LazyRow< InstanceContent >( gameData, parser.ReadColumn< uint >( 23 + i ), language );
            Festival = new LazyRow< Festival >( gameData, parser.ReadColumn< byte >( 26 ), language );
            FestivalBegin = parser.ReadColumn< byte >( 27 );
            FestivalEnd = parser.ReadColumn< byte >( 28 );
            BellStart = parser.ReadColumn< ushort >( 29 );
            BellEnd = parser.ReadColumn< ushort >( 30 );
            BeastTribe = new LazyRow< BeastTribe >( gameData, parser.ReadColumn< byte >( 31 ), language );
            BeastReputationRank = new LazyRow< BeastReputationRank >( gameData, parser.ReadColumn< byte >( 32 ), language );
            BeastReputationValue = parser.ReadColumn< ushort >( 33 );
            SatisfactionNpc = new LazyRow< SatisfactionNpc >( gameData, parser.ReadColumn< byte >( 34 ), language );
            SatisfactionLevel = parser.ReadColumn< byte >( 35 );
            MountRequired = new LazyRow< Mount >( gameData, parser.ReadColumn< int >( 36 ), language );
            IsHouseRequired = parser.ReadColumn< bool >( 37 );
            DeliveryQuest = new LazyRow< DeliveryQuest >( gameData, parser.ReadColumn< byte >( 38 ), language );
            IssuerStart = parser.ReadColumn< uint >( 39 );
            IssuerLocation = new LazyRow< Level >( gameData, parser.ReadColumn< uint >( 40 ), language );
            ClientBehavior = new LazyRow< Behavior >( gameData, parser.ReadColumn< ushort >( 41 ), language );
            TargetEnd = parser.ReadColumn< uint >( 42 );
            IsRepeatable = parser.ReadColumn< bool >( 43 );
            RepeatIntervalType = parser.ReadColumn< byte >( 44 );
            QuestRepeatFlag = new LazyRow< QuestRepeatFlag >( gameData, parser.ReadColumn< byte >( 45 ), language );
            CanCancel = parser.ReadColumn< bool >( 46 );
            Type = parser.ReadColumn< byte >( 47 );
            QuestClassJobSupply = new LazyRow< QuestClassJobSupply >( gameData, parser.ReadColumn< ushort >( 48 ), language );
            ScriptInstruction = new SeString[ 50 ];
            for( var i = 0; i < 50; i++ )
                ScriptInstruction[ i ] = parser.ReadColumn< SeString >( 49 + i );
            ScriptArg = new uint[ 50 ];
            for( var i = 0; i < 50; i++ )
                ScriptArg[ i ] = parser.ReadColumn< uint >( 99 + i );
            ActorSpawnSeq = new byte[ 64 ];
            for( var i = 0; i < 64; i++ )
                ActorSpawnSeq[ i ] = parser.ReadColumn< byte >( 149 + i );
            ActorDespawnSeq = new byte[ 64 ];
            for( var i = 0; i < 64; i++ )
                ActorDespawnSeq[ i ] = parser.ReadColumn< byte >( 213 + i );
            Listener = new uint[ 64 ];
            for( var i = 0; i < 64; i++ )
                Listener[ i ] = parser.ReadColumn< uint >( 277 + i );
            QuestUInt8A = new byte[ 32 ];
            for( var i = 0; i < 32; i++ )
                QuestUInt8A[ i ] = parser.ReadColumn< byte >( 341 + i );
            QuestUInt8B = new byte[ 32 ];
            for( var i = 0; i < 32; i++ )
                QuestUInt8B[ i ] = parser.ReadColumn< byte >( 373 + i );
            ConditionType = new byte[ 64 ];
            for( var i = 0; i < 64; i++ )
                ConditionType[ i ] = parser.ReadColumn< byte >( 405 + i );
            ConditionValue = new uint[ 64 ];
            for( var i = 0; i < 64; i++ )
                ConditionValue[ i ] = parser.ReadColumn< uint >( 469 + i );
            ConditionOperator = new byte[ 64 ];
            for( var i = 0; i < 64; i++ )
                ConditionOperator[ i ] = parser.ReadColumn< byte >( 533 + i );
            Behavior = new ushort[ 64 ];
            for( var i = 0; i < 64; i++ )
                Behavior[ i ] = parser.ReadColumn< ushort >( 597 + i );
            VisibleBool = new bool[ 64 ];
            for( var i = 0; i < 64; i++ )
                VisibleBool[ i ] = parser.ReadColumn< bool >( 661 + i );
            ConditionBool = new bool[ 64 ];
            for( var i = 0; i < 64; i++ )
                ConditionBool[ i ] = parser.ReadColumn< bool >( 725 + i );
            ItemBool = new bool[ 64 ];
            for( var i = 0; i < 64; i++ )
                ItemBool[ i ] = parser.ReadColumn< bool >( 789 + i );
            AnnounceBool = new bool[ 64 ];
            for( var i = 0; i < 64; i++ )
                AnnounceBool[ i ] = parser.ReadColumn< bool >( 853 + i );
            BehaviorBool = new bool[ 64 ];
            for( var i = 0; i < 64; i++ )
                BehaviorBool[ i ] = parser.ReadColumn< bool >( 917 + i );
            AcceptBool = new bool[ 64 ];
            for( var i = 0; i < 64; i++ )
                AcceptBool[ i ] = parser.ReadColumn< bool >( 981 + i );
            QualifiedBool = new bool[ 64 ];
            for( var i = 0; i < 64; i++ )
                QualifiedBool[ i ] = parser.ReadColumn< bool >( 1045 + i );
            CanTargetBool = new bool[ 64 ];
            for( var i = 0; i < 64; i++ )
                CanTargetBool[ i ] = parser.ReadColumn< bool >( 1109 + i );
            ToDoCompleteSeq = new byte[ 24 ];
            for( var i = 0; i < 24; i++ )
                ToDoCompleteSeq[ i ] = parser.ReadColumn< byte >( 1173 + i );
            ToDoQty = new byte[ 24 ];
            for( var i = 0; i < 24; i++ )
                ToDoQty[ i ] = parser.ReadColumn< byte >( 1197 + i );
            Unknown1221 = new uint[ 8 ];
            for( var i = 0; i < 8; i++ )
                Unknown1221[ i ] = parser.ReadColumn< uint >( 1221 + i );
            Unknown1229 = parser.ReadColumn< uint >( 1229 );
            Unknown1230 = parser.ReadColumn< uint >( 1230 );
            Unknown1231 = parser.ReadColumn< uint >( 1231 );
            Unknown1232 = parser.ReadColumn< uint >( 1232 );
            Unknown1233 = parser.ReadColumn< uint >( 1233 );
            Unknown1234 = parser.ReadColumn< uint >( 1234 );
            Unknown1235 = parser.ReadColumn< uint >( 1235 );
            Unknown1236 = parser.ReadColumn< uint >( 1236 );
            Unknown1237 = parser.ReadColumn< uint >( 1237 );
            Unknown1238 = parser.ReadColumn< uint >( 1238 );
            Unknown1239 = parser.ReadColumn< uint >( 1239 );
            Unknown1240 = parser.ReadColumn< uint >( 1240 );
            Unknown1241 = parser.ReadColumn< uint >( 1241 );
            Unknown1242 = parser.ReadColumn< uint >( 1242 );
            Unknown1243 = parser.ReadColumn< uint >( 1243 );
            Unknown1244 = parser.ReadColumn< uint >( 1244 );
            Unknown1245 = parser.ReadColumn< uint >( 1245 );
            Unknown1246 = parser.ReadColumn< uint >( 1246 );
            Unknown1247 = parser.ReadColumn< uint >( 1247 );
            Unknown1248 = parser.ReadColumn< uint >( 1248 );
            Unknown1249 = parser.ReadColumn< uint >( 1249 );
            Unknown1250 = parser.ReadColumn< uint >( 1250 );
            Unknown1251 = parser.ReadColumn< uint >( 1251 );
            Unknown1252 = parser.ReadColumn< uint >( 1252 );
            Unknown1253 = parser.ReadColumn< uint >( 1253 );
            Unknown1254 = parser.ReadColumn< uint >( 1254 );
            Unknown1255 = parser.ReadColumn< uint >( 1255 );
            Unknown1256 = parser.ReadColumn< uint >( 1256 );
            Unknown1257 = parser.ReadColumn< uint >( 1257 );
            Unknown1258 = parser.ReadColumn< uint >( 1258 );
            Unknown1259 = parser.ReadColumn< uint >( 1259 );
            Unknown1260 = parser.ReadColumn< uint >( 1260 );
            Unknown1261 = parser.ReadColumn< uint >( 1261 );
            Unknown1262 = parser.ReadColumn< uint >( 1262 );
            Unknown1263 = parser.ReadColumn< uint >( 1263 );
            Unknown1264 = parser.ReadColumn< uint >( 1264 );
            Unknown1265 = parser.ReadColumn< uint >( 1265 );
            Unknown1266 = parser.ReadColumn< uint >( 1266 );
            Unknown1267 = parser.ReadColumn< uint >( 1267 );
            Unknown1268 = parser.ReadColumn< uint >( 1268 );
            Unknown1269 = parser.ReadColumn< uint >( 1269 );
            Unknown1270 = parser.ReadColumn< uint >( 1270 );
            Unknown1271 = parser.ReadColumn< uint >( 1271 );
            Unknown1272 = parser.ReadColumn< uint >( 1272 );
            Unknown1273 = parser.ReadColumn< uint >( 1273 );
            Unknown1274 = parser.ReadColumn< uint >( 1274 );
            Unknown1275 = parser.ReadColumn< uint >( 1275 );
            Unknown1276 = parser.ReadColumn< uint >( 1276 );
            Unknown1277 = parser.ReadColumn< uint >( 1277 );
            Unknown1278 = parser.ReadColumn< uint >( 1278 );
            Unknown1279 = parser.ReadColumn< uint >( 1279 );
            Unknown1280 = parser.ReadColumn< uint >( 1280 );
            Unknown1281 = parser.ReadColumn< uint >( 1281 );
            Unknown1282 = parser.ReadColumn< uint >( 1282 );
            Unknown1283 = parser.ReadColumn< uint >( 1283 );
            Unknown1284 = parser.ReadColumn< uint >( 1284 );
            Unknown1285 = parser.ReadColumn< uint >( 1285 );
            Unknown1286 = parser.ReadColumn< uint >( 1286 );
            Unknown1287 = parser.ReadColumn< uint >( 1287 );
            Unknown1288 = parser.ReadColumn< uint >( 1288 );
            Unknown1289 = parser.ReadColumn< uint >( 1289 );
            Unknown1290 = parser.ReadColumn< uint >( 1290 );
            Unknown1291 = parser.ReadColumn< uint >( 1291 );
            Unknown1292 = parser.ReadColumn< uint >( 1292 );
            Unknown1293 = parser.ReadColumn< uint >( 1293 );
            Unknown1294 = parser.ReadColumn< uint >( 1294 );
            Unknown1295 = parser.ReadColumn< uint >( 1295 );
            Unknown1296 = parser.ReadColumn< uint >( 1296 );
            Unknown1297 = parser.ReadColumn< uint >( 1297 );
            Unknown1298 = parser.ReadColumn< uint >( 1298 );
            Unknown1299 = parser.ReadColumn< uint >( 1299 );
            Unknown1300 = parser.ReadColumn< uint >( 1300 );
            Unknown1301 = parser.ReadColumn< uint >( 1301 );
            Unknown1302 = parser.ReadColumn< uint >( 1302 );
            Unknown1303 = parser.ReadColumn< uint >( 1303 );
            Unknown1304 = parser.ReadColumn< uint >( 1304 );
            Unknown1305 = parser.ReadColumn< uint >( 1305 );
            Unknown1306 = parser.ReadColumn< uint >( 1306 );
            Unknown1307 = parser.ReadColumn< uint >( 1307 );
            Unknown1308 = parser.ReadColumn< uint >( 1308 );
            Unknown1309 = parser.ReadColumn< uint >( 1309 );
            Unknown1310 = parser.ReadColumn< uint >( 1310 );
            Unknown1311 = parser.ReadColumn< uint >( 1311 );
            Unknown1312 = parser.ReadColumn< uint >( 1312 );
            Unknown1313 = parser.ReadColumn< uint >( 1313 );
            Unknown1314 = parser.ReadColumn< uint >( 1314 );
            Unknown1315 = parser.ReadColumn< uint >( 1315 );
            Unknown1316 = parser.ReadColumn< uint >( 1316 );
            Unknown1317 = parser.ReadColumn< uint >( 1317 );
            Unknown1318 = parser.ReadColumn< uint >( 1318 );
            Unknown1319 = parser.ReadColumn< uint >( 1319 );
            Unknown1320 = parser.ReadColumn< uint >( 1320 );
            Unknown1321 = parser.ReadColumn< uint >( 1321 );
            Unknown1322 = parser.ReadColumn< uint >( 1322 );
            Unknown1323 = parser.ReadColumn< uint >( 1323 );
            Unknown1324 = parser.ReadColumn< uint >( 1324 );
            Unknown1325 = parser.ReadColumn< uint >( 1325 );
            Unknown1326 = parser.ReadColumn< uint >( 1326 );
            Unknown1327 = parser.ReadColumn< uint >( 1327 );
            Unknown1328 = parser.ReadColumn< uint >( 1328 );
            Unknown1329 = parser.ReadColumn< uint >( 1329 );
            Unknown1330 = parser.ReadColumn< uint >( 1330 );
            Unknown1331 = parser.ReadColumn< uint >( 1331 );
            Unknown1332 = parser.ReadColumn< uint >( 1332 );
            Unknown1333 = parser.ReadColumn< uint >( 1333 );
            Unknown1334 = parser.ReadColumn< uint >( 1334 );
            Unknown1335 = parser.ReadColumn< uint >( 1335 );
            Unknown1336 = parser.ReadColumn< uint >( 1336 );
            Unknown1337 = parser.ReadColumn< uint >( 1337 );
            Unknown1338 = parser.ReadColumn< uint >( 1338 );
            Unknown1339 = parser.ReadColumn< uint >( 1339 );
            Unknown1340 = parser.ReadColumn< uint >( 1340 );
            Unknown1341 = parser.ReadColumn< uint >( 1341 );
            Unknown1342 = parser.ReadColumn< uint >( 1342 );
            Unknown1343 = parser.ReadColumn< uint >( 1343 );
            Unknown1344 = parser.ReadColumn< uint >( 1344 );
            Unknown1345 = parser.ReadColumn< uint >( 1345 );
            Unknown1346 = parser.ReadColumn< uint >( 1346 );
            Unknown1347 = parser.ReadColumn< uint >( 1347 );
            Unknown1348 = parser.ReadColumn< uint >( 1348 );
            Unknown1349 = parser.ReadColumn< uint >( 1349 );
            Unknown1350 = parser.ReadColumn< uint >( 1350 );
            Unknown1351 = parser.ReadColumn< uint >( 1351 );
            Unknown1352 = parser.ReadColumn< uint >( 1352 );
            Unknown1353 = parser.ReadColumn< uint >( 1353 );
            Unknown1354 = parser.ReadColumn< uint >( 1354 );
            Unknown1355 = parser.ReadColumn< uint >( 1355 );
            Unknown1356 = parser.ReadColumn< uint >( 1356 );
            Unknown1357 = parser.ReadColumn< uint >( 1357 );
            Unknown1358 = parser.ReadColumn< uint >( 1358 );
            Unknown1359 = parser.ReadColumn< uint >( 1359 );
            Unknown1360 = parser.ReadColumn< uint >( 1360 );
            Unknown1361 = parser.ReadColumn< uint >( 1361 );
            Unknown1362 = parser.ReadColumn< uint >( 1362 );
            Unknown1363 = parser.ReadColumn< uint >( 1363 );
            Unknown1364 = parser.ReadColumn< uint >( 1364 );
            Unknown1365 = parser.ReadColumn< uint >( 1365 );
            Unknown1366 = parser.ReadColumn< uint >( 1366 );
            Unknown1367 = parser.ReadColumn< uint >( 1367 );
            Unknown1368 = parser.ReadColumn< uint >( 1368 );
            Unknown1369 = parser.ReadColumn< uint >( 1369 );
            Unknown1370 = parser.ReadColumn< uint >( 1370 );
            Unknown1371 = parser.ReadColumn< uint >( 1371 );
            Unknown1372 = parser.ReadColumn< uint >( 1372 );
            Unknown1373 = parser.ReadColumn< uint >( 1373 );
            Unknown1374 = parser.ReadColumn< uint >( 1374 );
            Unknown1375 = parser.ReadColumn< uint >( 1375 );
            Unknown1376 = parser.ReadColumn< uint >( 1376 );
            Unknown1377 = parser.ReadColumn< uint >( 1377 );
            Unknown1378 = parser.ReadColumn< uint >( 1378 );
            Unknown1379 = parser.ReadColumn< uint >( 1379 );
            Unknown1380 = parser.ReadColumn< uint >( 1380 );
            Unknown1381 = parser.ReadColumn< uint >( 1381 );
            Unknown1382 = parser.ReadColumn< uint >( 1382 );
            Unknown1383 = parser.ReadColumn< uint >( 1383 );
            Unknown1384 = parser.ReadColumn< uint >( 1384 );
            Unknown1385 = parser.ReadColumn< uint >( 1385 );
            Unknown1386 = parser.ReadColumn< uint >( 1386 );
            Unknown1387 = parser.ReadColumn< uint >( 1387 );
            Unknown1388 = parser.ReadColumn< uint >( 1388 );
            Unknown1389 = parser.ReadColumn< uint >( 1389 );
            Unknown1390 = parser.ReadColumn< uint >( 1390 );
            Unknown1391 = parser.ReadColumn< uint >( 1391 );
            Unknown1392 = parser.ReadColumn< uint >( 1392 );
            Unknown1393 = parser.ReadColumn< uint >( 1393 );
            Unknown1394 = parser.ReadColumn< uint >( 1394 );
            Unknown1395 = parser.ReadColumn< uint >( 1395 );
            Unknown1396 = parser.ReadColumn< uint >( 1396 );
            Unknown1397 = parser.ReadColumn< uint >( 1397 );
            Unknown1398 = parser.ReadColumn< uint >( 1398 );
            Unknown1399 = parser.ReadColumn< uint >( 1399 );
            Unknown1400 = parser.ReadColumn< uint >( 1400 );
            Unknown1401 = parser.ReadColumn< uint >( 1401 );
            Unknown1402 = parser.ReadColumn< uint >( 1402 );
            Unknown1403 = parser.ReadColumn< uint >( 1403 );
            Unknown1404 = parser.ReadColumn< uint >( 1404 );
            Unknown1405 = parser.ReadColumn< uint >( 1405 );
            Unknown1406 = parser.ReadColumn< uint >( 1406 );
            Unknown1407 = parser.ReadColumn< uint >( 1407 );
            Unknown1408 = parser.ReadColumn< uint >( 1408 );
            Unknown1409 = parser.ReadColumn< uint >( 1409 );
            Unknown1410 = parser.ReadColumn< uint >( 1410 );
            Unknown1411 = parser.ReadColumn< uint >( 1411 );
            Unknown1412 = parser.ReadColumn< uint >( 1412 );
            CountableNum = new byte[ 24 ];
            for( var i = 0; i < 24; i++ )
                CountableNum[ i ] = parser.ReadColumn< byte >( 1413 + i );
            LevelMax = parser.ReadColumn< byte >( 1437 );
            ClassJobRequired = new LazyRow< ClassJob >( gameData, parser.ReadColumn< byte >( 1438 ), language );
            QuestRewardOtherDisplay = new LazyRow< QuestRewardOther >( gameData, parser.ReadColumn< byte >( 1439 ), language );
            ExpFactor = parser.ReadColumn< ushort >( 1440 );
            GilReward = parser.ReadColumn< uint >( 1441 );
            CurrencyReward = new LazyRow< Item >( gameData, parser.ReadColumn< uint >( 1442 ), language );
            CurrencyRewardCount = parser.ReadColumn< uint >( 1443 );
            ItemCatalyst = new LazyRow< Item >[ 3 ];
            for( var i = 0; i < 3; i++ )
                ItemCatalyst[ i ] = new LazyRow< Item >( gameData, parser.ReadColumn< byte >( 1444 + i ), language );
            ItemCountCatalyst = new byte[ 3 ];
            for( var i = 0; i < 3; i++ )
                ItemCountCatalyst[ i ] = parser.ReadColumn< byte >( 1447 + i );
            ItemRewardType = parser.ReadColumn< byte >( 1450 );
            ItemReward = new uint[ 7 ];
            for( var i = 0; i < 7; i++ )
                ItemReward[ i ] = parser.ReadColumn< uint >( 1451 + i );
            ItemCountReward = new byte[ 7 ];
            for( var i = 0; i < 7; i++ )
                ItemCountReward[ i ] = parser.ReadColumn< byte >( 1458 + i );
            Unknown1465 = parser.ReadColumn< bool >( 1465 );
            Unknown1466 = parser.ReadColumn< bool >( 1466 );
            Unknown1467 = parser.ReadColumn< bool >( 1467 );
            Unknown1468 = parser.ReadColumn< bool >( 1468 );
            Unknown1469 = parser.ReadColumn< bool >( 1469 );
            Unknown1470 = parser.ReadColumn< bool >( 1470 );
            Unknown1471 = parser.ReadColumn< bool >( 1471 );
            StainReward = new LazyRow< Stain >[ 7 ];
            for( var i = 0; i < 7; i++ )
                StainReward[ i ] = new LazyRow< Stain >( gameData, parser.ReadColumn< byte >( 1472 + i ), language );
            OptionalItemReward = new LazyRow< Item >[ 5 ];
            for( var i = 0; i < 5; i++ )
                OptionalItemReward[ i ] = new LazyRow< Item >( gameData, parser.ReadColumn< uint >( 1479 + i ), language );
            OptionalItemCountReward = new byte[ 5 ];
            for( var i = 0; i < 5; i++ )
                OptionalItemCountReward[ i ] = parser.ReadColumn< byte >( 1484 + i );
            OptionalItemIsHQReward = new bool[ 5 ];
            for( var i = 0; i < 5; i++ )
                OptionalItemIsHQReward[ i ] = parser.ReadColumn< bool >( 1489 + i );
            OptionalItemStainReward = new LazyRow< Stain >[ 5 ];
            for( var i = 0; i < 5; i++ )
                OptionalItemStainReward[ i ] = new LazyRow< Stain >( gameData, parser.ReadColumn< byte >( 1494 + i ), language );
            EmoteReward = new LazyRow< Emote >( gameData, parser.ReadColumn< byte >( 1499 ), language );
            ActionReward = new LazyRow< Action >( gameData, parser.ReadColumn< ushort >( 1500 ), language );
            GeneralActionReward = new LazyRow< GeneralAction >[ 2 ];
            for( var i = 0; i < 2; i++ )
                GeneralActionReward[ i ] = new LazyRow< GeneralAction >( gameData, parser.ReadColumn< byte >( 1501 + i ), language );
            SystemReward0 = parser.ReadColumn< ushort >( 1503 );
            OtherReward = new LazyRow< QuestRewardOther >( gameData, parser.ReadColumn< byte >( 1504 ), language );
            SystemReward1 = parser.ReadColumn< ushort >( 1505 );
            GCTypeReward = parser.ReadColumn< ushort >( 1506 );
            InstanceContentUnlock = new LazyRow< InstanceContent >( gameData, parser.ReadColumn< uint >( 1507 ), language );
            Tomestone = parser.ReadColumn< byte >( 1508 );
            TomestoneReward = parser.ReadColumn< byte >( 1509 );
            TomestoneCountReward = parser.ReadColumn< byte >( 1510 );
            ReputationReward = parser.ReadColumn< byte >( 1511 );
            PlaceName = new LazyRow< PlaceName >( gameData, parser.ReadColumn< ushort >( 1512 ), language );
            JournalGenre = new LazyRow< JournalGenre >( gameData, parser.ReadColumn< uint >( 1513 ), language );
            Unknown1514 = parser.ReadColumn< byte >( 1514 );
            Icon = parser.ReadColumn< uint >( 1515 );
            IconSpecial = parser.ReadColumn< uint >( 1516 );
            Introduction = parser.ReadColumn< bool >( 1517 );
            HideOfferIcon = parser.ReadColumn< bool >( 1518 );
            EventIconType = new LazyRow< EventIconType >( gameData, parser.ReadColumn< byte >( 1519 ), language );
            Unknown1520 = parser.ReadColumn< byte >( 1520 );
            SortKey = parser.ReadColumn< ushort >( 1521 );
            Unknown1522 = parser.ReadColumn< bool >( 1522 );
        }
    }
}