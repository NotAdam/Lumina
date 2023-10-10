using System;
using System.Collections.Generic;
using System.Linq;
using Lumina.Data;

namespace Lumina.Excel;

public class LinkUnion
{
    internal enum LinkUnionHandlerType
    {
        Match,
        Switch,
    }
    
    public class LinkUnionHandler
    {
        private LinkUnionHandlerType _type;
        private LinkUnion _union;

        private HashSet<(uint, Type)> _caseTypesConsidered;
        private HashSet<(uint, Type)> _caseTypesPermitted;
        
        private HashSet< Type > _typesConsidered;
        private HashSet< Type > _typesPermitted;

        internal LinkUnionHandler( LinkUnionHandlerType type, LinkUnion union )
        {
            _type = type;
            _union = union;
            _typesConsidered = new HashSet< Type >();
            _typesPermitted = _union.Cases.Select( h => h.Type ).ToHashSet();
            _caseTypesConsidered = new HashSet< (uint, Type) >();
            _caseTypesPermitted = _union.Cases.Select( h => (h.SwitchValue, h.Type) ).ToHashSet();
        }

        public LinkUnionHandler Case< T >( Action< LazyRow< T > > func ) where T : ExcelRow
        {
            var workingType = typeof( T );
            TypeCheck( workingType );
            
            foreach( var handler in _union.Cases.Where( h => h.Type == workingType ) )
            {
                if( handler.LazyRow is not LazyRow< T > lazyRow ) continue;
                func( lazyRow );
            }
            
            _typesConsidered.Add( typeof( T ) );
            return this;
        }
        
        public LinkUnionHandler Case< T >( uint switchValue, Action< LazyRow< T > > func ) where T : ExcelRow
        {
            var workingType = typeof( T );
            CaseCheck( switchValue, workingType );
            
            foreach( var handler in _union.Cases.Where( h => h.SwitchValue == switchValue && h.Type == workingType ) )
            {
                if( handler.LazyRow is not LazyRow< T > lazyRow ) continue;
                func( lazyRow );
            }

            _caseTypesConsidered.Add( (switchValue, workingType) );
            return this;
        }

        private void TypeCheck( Type type )
        {
            if( _typesConsidered.Contains( type ) )
            {
                throw new ArgumentException( $"Duplicate case for type {type.Name}" );
            }

            if( !_typesPermitted.Contains( type ) )
            {
                throw new ArgumentException( $"Type {type.Name} is not permitted here" );
            }
        }

        private void CaseCheck( uint value, Type type )
        {
            if( _caseTypesConsidered.Contains( ( value, type ) ) )
            {
                throw new ArgumentException( $"Duplicate case for value {value} {type}" );
            }
            
            if( !_caseTypesPermitted.Contains( (value, type) ) )
            {
                throw new ArgumentException( $"Case {value}, {type} is not permitted here" );
            }
        }

        public LinkUnionHandler Ignore< T >() where T : ExcelRow
        {
            _typesConsidered.Add( typeof( T ) );
            return this;
        }
        
        public LinkUnionHandler Default( Action< ILazyRow > func )
        {
            _typesConsidered.UnionWith( _typesPermitted );
            _caseTypesConsidered.UnionWith( _caseTypesPermitted );
            return this;
        }

        public void Exhaust()
        {
            //TODO more on this
            var unusedTypes = _typesPermitted.Except( _typesConsidered );
            var unusedCases = _caseTypesPermitted.Except( _caseTypesConsidered );
            
            if( unusedTypes.Any() )
            {
                throw new ArgumentException( $"Unmatched types: {string.Join( ", ", unusedTypes.Select( t => t.Name ) )}" );
            }
        }
    }

    public abstract class ILinkUnionCase
    {
        public uint SwitchValue { get; internal set; }
        public uint SwitchColumnValue { get; internal set; }
        public uint FieldRowId { get; internal set; }
        public Type Type { get; internal set; }
        public ILazyRow? LazyRow { get; internal set; }
    }

    public class LinkUnionCase<T> : ILinkUnionCase where T : ExcelRow
    { 
        public LinkUnionCase( uint switchValue, uint switchColumnValue, uint fieldRowId, GameData gameData, Language language )
        {
            SwitchValue = switchValue;
            SwitchColumnValue = switchColumnValue;
            FieldRowId = fieldRowId;
            Type = typeof( T );

            var rowExists = gameData.GetExcelSheet< T >().HasRow( fieldRowId );
            
            if (SwitchValue == SwitchColumnValue && rowExists)
                LazyRow = new LazyRow< T >( gameData, FieldRowId, language );
        }
        
        // public static ILinkUnionCase Create( uint switchValue, uint switchColumnValue, uint fieldRowId, GameData gameData, Language language, List<Type> possibleTypes )
        // {
        //     if( switchValue == switchColumnValue )
        //     {
        //         Type firstFoundType = null;
        //         foreach( var possibleType in possibleTypes )
        //         {
        //             var rawSheet = gameData.Excel.GetSheetRaw( possibleType.Name );
        //             if( rawSheet.GetRow( fieldRowId ) != null )
        //             {
        //                 firstFoundType = possibleType;
        //             }
        //         }
        //         
        //         if( firstFoundType == null )
        //         {
        //             throw new ArgumentException( $"Could not find any matching types for row {fieldRowId}" );
        //         }
        //         
        //         var openCase = typeof(LinkUnionCase<>);
        //         var genericCase = openCase.MakeGenericType(firstFoundType);
        //         var instance = (ILinkUnionCase) Activator.CreateInstance(genericCase);
        //         
        //         var openLazyRow = typeof(LazyRow<>);
        //         var genericLazyRow = openLazyRow.MakeGenericType(firstFoundType);
        //         var lazyRowInstance = (ILazyRow) Activator.CreateInstance(genericLazyRow, gameData, fieldRowId, language);
        //         
        //         instance.Type = firstFoundType;
        //         instance.SwitchValue = switchValue;
        //         instance.SwitchColumnValue = switchColumnValue;
        //         instance.FieldRowId = fieldRowId;
        //         instance.LazyRow = lazyRowInstance;
        //     }
        //     
        //     // _switchValue = switchValue;
        //     // _switchColumnValue = switchColumnValue;
        //     // _fieldRowId = fieldRowId;
        //     // _type = typeof( T );
        //     //
        //     // if( _switchValue == _switchColumnValue )
        //     // {
        //     //     foreach( var possibleType in possibleTypes )
        //     //     {
        //     //         
        //     //     }
        //     //     _lazyRow = new LazyRow< T >( gameData, _fieldRowId, language );
        //     // }
        // }
    }
    
    public uint RowId;
    public List<ILinkUnionCase> Cases = new();

    public LinkUnionHandler Match()
    {
        return new LinkUnionHandler(LinkUnionHandlerType.Match, this);
    }

    public LinkUnionHandler Switch()
    {
        return new LinkUnionHandler(LinkUnionHandlerType.Switch, this);
    }

    public LinkUnionHandler OneOf()
    {
        return new LinkUnionHandler(LinkUnionHandlerType.Switch, this);
    }
}