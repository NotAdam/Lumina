using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using Lumina.Data.Structs.Excel;
using Lumina.Excel;
using Lumina.Text;
using Newtonsoft.Json;

namespace Lumina.SpaghettiUpdater
{
    public class SpaghettiUpdater
    {
        private const float COL_SIM_PERCENTAGE = 0.98f;
        private const float COL_DIST_PERCENTAGE = 1f - COL_SIM_PERCENTAGE;
        private const float NEW_INDEX_THRESHOLD = 0.65f;
        private const float SAME_COL_THRESHOLD = 0.65f;
        private const uint INVALID_INDEX = uint.MaxValue;
        private const int DISTANCE_THRESHOLD = 50;
        
        public GameData OldGameData;
        public GameData GameData;
        public HashSet< string > QuestionableSheets;

        public SpaghettiUpdater(string oldPath, string path)
        {
            OldGameData = new GameData( oldPath );
            GameData = new GameData( path );
            QuestionableSheets = new HashSet< string >();
        }

        public static bool DefinitionExists( string name )
        {
            return File.Exists( $"./Definitions/{name}.json" );
        }
        
        public static Type ExcelTypeToManaged( ExcelColumnDataType type )
        {
            switch( type )
            {
                case ExcelColumnDataType.String:
                    return typeof( SeString );
                case ExcelColumnDataType.Bool:
                    return typeof( bool );
                case ExcelColumnDataType.Int8:
                    return typeof( sbyte );
                case ExcelColumnDataType.UInt8:
                    return typeof( byte );
                case ExcelColumnDataType.Int16:
                    return typeof( short );
                case ExcelColumnDataType.UInt16:
                    return typeof( ushort );
                case ExcelColumnDataType.Int32:
                    return typeof( int );
                case ExcelColumnDataType.UInt32:
                    return typeof( uint );
                case ExcelColumnDataType.Float32:
                    return typeof( float );
                case ExcelColumnDataType.Int64:
                    return typeof( long );
                case ExcelColumnDataType.UInt64:
                    return typeof( ulong );
                case ExcelColumnDataType.PackedBool0:
                case ExcelColumnDataType.PackedBool1:
                case ExcelColumnDataType.PackedBool2:
                case ExcelColumnDataType.PackedBool3:
                case ExcelColumnDataType.PackedBool4:
                case ExcelColumnDataType.PackedBool5:
                case ExcelColumnDataType.PackedBool6:
                case ExcelColumnDataType.PackedBool7:
                    return typeof( bool );
                default:
                    throw new ArgumentOutOfRangeException( nameof( type ), type, null );
            }
        }

        private static BigInteger ToBi( object o ) => o switch
        {
            sbyte x => new BigInteger( x ),
            byte x => new BigInteger( x ),
            ushort x => new BigInteger( x ),
            short x => new BigInteger( x ),
            uint x => new BigInteger( x ),
            int x => new BigInteger( x ),
            ulong x => new BigInteger( x ),
            long x => new BigInteger( x ),
            // We don't actually care about the value of the floats so we
            // can transform them, as long as we *always* transform them...
            float x => new BigInteger( x * 100 ),
            double x => new BigInteger( x * 100 ),
            _ => throw new NotImplementedException()
        };

        private bool IsNumeric(Type t)
        {
            return 
                t == typeof( sbyte ) ||
                t == typeof( byte ) ||
                t == typeof( short ) ||
                t == typeof( ushort ) ||
                t == typeof( int ) ||
                t == typeof( uint ) ||
                t == typeof( long ) ||
                t == typeof( ulong ) ||
                t == typeof( float ) ||
                t == typeof( double );
        }
        
        private bool IsPossiblySameColumn(ExcelSheetImpl oldSheet, uint oldColumnIdx, ExcelSheetImpl newSheet, uint newColumnIdx)
        {
            var oldType = oldSheet.Columns[ oldColumnIdx ].Type;
            var newType = newSheet.Columns[ newColumnIdx ].Type;

            var oldMgd = ExcelTypeToManaged( oldType );
            var newMgd = ExcelTypeToManaged( newType );
            
            if( IsNumeric( oldMgd ) != IsNumeric( newMgd ) )
                return false;

            if( (oldMgd == typeof( bool ) || newMgd == typeof (bool)) && oldMgd != newMgd )
                return false;
            
            if( (oldMgd == typeof( SeString ) || newMgd == typeof (SeString)) && oldMgd != newMgd )
                return false;
            return true;
        }

        private int SeStringSim( SeString one, SeString two )
        {
            return DamerauLevenshteinDistance( one.RawData.ToArray(), two.RawData.ToArray(), DISTANCE_THRESHOLD);
        }
        
        private float Compare( object o1, object o2 )
        {
            // Console.WriteLine($"values {o1} and {o2}...");
            
            if( IsNumeric( o1.GetType() ) && IsNumeric( o2.GetType() ) )
            {
                try
                {
                    var l1 = ToBi( o1 );
                    var l2 = ToBi( o2 );

                    var equals = l1.Equals( l2 );
                    var zero = l1.Equals( 0 );

                    if( equals && !zero )
                        return 1f;
                    // if( equals )
                        // return 0.33f;
                } catch( NotImplementedException ) {}
            }

            if( o1.Equals( o2 ) )
            {
                return 1f;
            }

            if( o1 is SeString oldStr && o2 is SeString newStr )
            {
                return ( 1f / DISTANCE_THRESHOLD ) * ( DISTANCE_THRESHOLD - SeStringSim( oldStr, newStr ) );
            }
            
            // Console.WriteLine($"values {o1} and {o2} do not match...");
            return 0f;
        }

        private float SimilarityCalc( ExcelSheetImpl oldSheet, uint oldColumnIdx, ExcelSheetImpl newSheet, uint newColumnIdx )
        {
            // Fail faster if these can't even possibly be the same column
            if( !IsPossiblySameColumn( oldSheet, oldColumnIdx, newSheet, newColumnIdx ) )
                return 0f;
            
            float sim = 0f;

            uint startIdx = oldSheet.DataPages[ 0 ].StartId;
            uint rowsProcessed = 0;

            for( uint rowIdx = startIdx; rowsProcessed < oldSheet.RowCount; rowIdx++ )
            {
                var oldParser = oldSheet.GetRowParser(rowIdx);
                var newParser = newSheet.GetRowParser(rowIdx);
                
                // Some sheets with subrows actually skip row numbers...
                if( oldParser == null || newParser == null )
                {
                    // If the old parser had a row, we should count this row 
                    if (oldParser == null) 
                        rowsProcessed++;
                    continue;
                }
                
                if( oldParser.RowCount == 1 )
                {
                    var oldValue = oldParser.ReadColumnRaw( (int) oldColumnIdx );
                    var newValue = newParser.ReadColumnRaw( (int) newColumnIdx );
                    sim += Compare( oldValue, newValue );
                    rowsProcessed++;
                }
                else
                {
                    uint subRowIdx = 0;
                    for( ; subRowIdx < oldParser.RowCount && subRowIdx < newParser.RowCount; subRowIdx++ )
                    {
                        oldParser.SeekToRow(rowIdx, subRowIdx);
                        newParser.SeekToRow(rowIdx, subRowIdx);
                        var oldValue = oldParser.ReadColumnRaw( (int) oldColumnIdx );
                        var newValue = newParser.ReadColumnRaw( (int) newColumnIdx );
                        sim += Compare( oldValue, newValue );
                        rowsProcessed++;
                    }

                    // Only add if we skipped counts that existed in the old parser
                    // and do not exist in the new one, because the old parser is the
                    // basis for the max similarity count
                    if( subRowIdx < oldParser.RowCount )
                        rowsProcessed += oldParser.RowCount - subRowIdx;
                    // if( subRowIdx < newParser.RowCount )
                        // rowsProcessed += oldParser.RowCount - subRowIdx;
                }
            }

            return sim;
        }

        private float GetSimilarity( ExcelSheetImpl oldSheet, uint oldColumnIdx, ExcelSheetImpl newSheet, uint newColumnIdx )
        {
            float maxSim = SimilarityCalc( oldSheet, oldColumnIdx, oldSheet, oldColumnIdx );
            float sim = SimilarityCalc( oldSheet, oldColumnIdx, newSheet, newColumnIdx );
            
            
            return sim / maxSim;
        }

        private uint FindNewIndex( ExcelSheetImpl oldSheet, uint oldColumnIdx, ExcelSheetImpl newSheet, Dictionary<uint, uint>.ValueCollection mappedSheets)
        {
            float bestCalc = 0f;
            uint bestIdx = INVALID_INDEX;
            uint retIdx = INVALID_INDEX;

            for( uint i = 0; i < newSheet.ColumnCount; i++ )
            {
                if( mappedSheets.Contains( i ) ) continue;
                var simCalc = GetSimilarity( oldSheet, oldColumnIdx, newSheet, i );
                var distCalc = i == oldColumnIdx ? 1f : 1f - Math.Abs( (int) oldColumnIdx - (int) i ) / (float) newSheet.ColumnCount;
                var tmpCalc = (simCalc * COL_SIM_PERCENTAGE) + (distCalc * COL_DIST_PERCENTAGE);

                if( tmpCalc > bestCalc )
                {
                    bestCalc = tmpCalc;
                    bestIdx = i;
                }
                
                Console.WriteLine($"\t\t\tcolumn {i} has sim {simCalc:F} dist {distCalc:F} calc {tmpCalc:F}, best is {bestCalc:F} @ {bestIdx}");
            }

            if( bestCalc > NEW_INDEX_THRESHOLD )
                retIdx = bestIdx;
                
            if (retIdx == INVALID_INDEX)
                Console.WriteLine($"\t\t\t\t[WARNING] failed on {oldSheet.Name} col {oldColumnIdx}, highest match was {bestCalc:F} @ {bestIdx}");
            return retIdx;
        }

        public string ProcessDefinition( string name )
        {
            if( !DefinitionExists( name ) )
            {
                // Console.WriteLine( $" - sheet {name} has no definition, skipping");
                return null;
            }
            
            var path = $"./Definitions/{name}.json";
            var def = File.ReadAllText( path );

            var oldSheet = OldGameData.Excel.GetSheetRaw( name );
            if( oldSheet == null )
            {
                Console.WriteLine( $"--- sheet {name} has no file in the old gamever! ---" );
                return null;
            }
            var newSheet = GameData.Excel.GetSheetRaw( name );
            if( newSheet == null )
            {
                Console.WriteLine( $"--- sheet {name} no longer exists! ---" );
                return null;
            }

            var oldHash = oldSheet.HeaderFile.GetColumnsHash();
            var newHash = newSheet.HeaderFile.GetColumnsHash();

            if( oldHash == newHash )
            {
                Console.WriteLine($"--- sheet {name} is unchanged! ---");
                return def;
            }

            var newColumnIndices = new Dictionary< uint, uint >();
            var oldSchema = JsonConvert.DeserializeObject< SheetDefinition.Sheet >( def );
            var newSchema = oldSchema.Clone();
            newSchema.Definitions.Clear();
            
            // By maintaining a shift value based on remapped columns, we can more accurately predict
            // the new column index that should match the current column's contents
            int currentShift = 0;
            
            Console.WriteLine($"sheet {oldSheet.Name}");
            
            foreach(var schemaDef in oldSchema.Definitions)
            {
                uint columnIdx = schemaDef.Index; 
                var newSchemaDef = schemaDef.Clone();
                
                // We know the previous column's shift - let's try to start looking there, then
                uint firstCheckIdx = columnIdx;
                uint possibleFirstCheckIdx = (uint)( (int)columnIdx + currentShift );
                if( possibleFirstCheckIdx < newSheet.ColumnCount)
                    firstCheckIdx = possibleFirstCheckIdx;
                
                Console.WriteLine($"\tfirst check column is {firstCheckIdx} as shift is {currentShift}!");

                float similarity = 0f;

                if( newSheet.ColumnCount > firstCheckIdx )
                    similarity = GetSimilarity( oldSheet, columnIdx, newSheet, firstCheckIdx );
                
                Console.WriteLine($"\tcol {columnIdx} ({schemaDef.DefName}) match with col {firstCheckIdx} pct {similarity:F}");

                if( similarity < SAME_COL_THRESHOLD || (similarity > SAME_COL_THRESHOLD && newColumnIndices.ContainsValue(firstCheckIdx)))
                {
                    if (newColumnIndices.ContainsValue(firstCheckIdx))
                        Console.WriteLine( $"\t\tsimilarity past threshold but the column was already assigned, finding new index for column {columnIdx} from old sheet..." );
                    else
                        Console.WriteLine($"\t\tsimilarity was below threshold {SAME_COL_THRESHOLD}, finding new index for column {columnIdx} from old sheet..." );
                    
                    var newIdx = FindNewIndex( oldSheet, columnIdx, newSheet, newColumnIndices.Values );
                    newColumnIndices[ columnIdx ] = newIdx;
                    if( newIdx == INVALID_INDEX )
                    {
                        QuestionableSheets.Add( oldSheet.Name );
                        Console.WriteLine( $"\t\t\t[WARNING] failed to find named column {columnIdx} ({schemaDef.DefName})! maybe it was removed or a new column was added in its place? you may have to adjust links manually!" );
                    }
                    else
                    {
                        Console.WriteLine($"\t\tnew index for {columnIdx} is {newIdx}");
                        
                        // Only set current shift if we found a candidate index
                        currentShift = (int) newIdx - (int) columnIdx;
                    }

                    if( schemaDef.Type == "repeat" && newSheet.ColumnCount - ( newIdx + schemaDef.Count ) < 0 )
                    {
                        QuestionableSheets.Add( oldSheet.Name );
                        Console.Out.WriteLine( $"looks like old column {columnIdx} ({schemaDef.Name}) is type \"repeat\", but the new index is not possible with its repeat count. please check it!" );
                    }
                }
                else
                {
                    newColumnIndices[ columnIdx ] = firstCheckIdx;
                }
                
                newSchemaDef.Index = newColumnIndices[columnIdx];
                if( newSchemaDef.Index != INVALID_INDEX )
                {
                    newSchema.Definitions.Add( newSchemaDef );
                    Console.WriteLine($"\t\tnew column is saved as {newColumnIndices[columnIdx]}");
                }
                else
                {
                    Console.WriteLine("\t\tcolumn has no match so it wasn't added");
                }
            }

            Console.WriteLine("new indices:");
            foreach( var key in newColumnIndices.Keys )
                Console.Write($"({key}: {newColumnIndices[key]}) ");
            Console.WriteLine();
            newSchema.Definitions.Sort( ( s1, s2) => s1.Index.CompareTo(s2.Index));
            return JsonConvert.SerializeObject(newSchema, Formatting.Indented, new JsonSerializerSettings() {DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore});
        }

        #region stackoverflow
        // https://stackoverflow.com/a/9454016
        public static int DamerauLevenshteinDistance(byte[] source, byte[] target, int threshold) {

            int length1 = source.Length;
            int length2 = target.Length;

            if( length1 == 0 )
                return threshold;
            if( length2 == 0 )
                return threshold;

            // Return trivial case - difference in string lengths exceeds threshhold
            if (Math.Abs(length1 - length2) > threshold) { return threshold; }

            // Ensure arrays [i] / length1 use shorter length 
            if (length1 > length2)
            {
                ( target, source ) = ( source, target );
                ( length1, length2 ) = ( length2, length1 );
            }

            int maxi = length1;
            int maxj = length2;

            int[] dCurrent = new int[maxi + 1];
            int[] dMinus1 = new int[maxi + 1];
            int[] dMinus2 = new int[maxi + 1];
            int[] dSwap;

            for (int i = 0; i <= maxi; i++) { dCurrent[i] = i; }

            int jm1 = 0, im1 = 0, im2 = -1;

            for (int j = 1; j <= maxj; j++) {

                // Rotate
                dSwap = dMinus2;
                dMinus2 = dMinus1;
                dMinus1 = dCurrent;
                dCurrent = dSwap;

                // Initialize
                int minDistance = int.MaxValue;
                dCurrent[0] = j;
                im1 = 0;
                im2 = -1;

                for (int i = 1; i <= maxi; i++) {

                    int cost = source[im1] == target[jm1] ? 0 : 1;

                    int del = dCurrent[im1] + 1;
                    int ins = dMinus1[i] + 1;
                    int sub = dMinus1[im1] + cost;

                    //Fastest execution for min value of 3 integers
                    int min = (del > ins) ? (ins > sub ? sub : ins) : (del > sub ? sub : del);

                    if (i > 1 && j > 1 && source[im2] == target[jm1] && source[im1] == target[j - 2])
                        min = Math.Min(min, dMinus2[im2] + cost);

                    dCurrent[i] = min;
                    if (min < minDistance) { minDistance = min; }
                    im1++;
                    im2++;
                }
                jm1++;
                if (minDistance > threshold) { return threshold; }
            }

            int result = dCurrent[maxi];
            return (result > threshold) ? threshold : result;
        }
        #endregion
    }
}