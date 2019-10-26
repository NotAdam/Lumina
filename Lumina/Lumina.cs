using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.IO;
using System.Linq;
using Lumina.Data;

namespace Lumina
{
    public class Lumina
    {
        public DirectoryInfo DataPath { get; private set; }

        public List< DatCategory > Categories { get; private set; }
        
        public static LuminaOptions Options { get; private set; }

        /// <summary>
        /// Constructs a new Lumina object allowing access to game data.
        /// </summary>
        /// <param name="dataPath">Path to the sqpack directory</param>
        /// <param name="options">Options object to provide additional configuration</param>
        /// <exception cref="DirectoryNotFoundException">Thrown when the sqpack directory supplied is missing.</exception>
        public Lumina( string dataPath, LuminaOptions options = null )
        {
            Contract.Requires( dataPath != null );
            Contract.Ensures( Options != null );
            Contract.Ensures( Categories != null );
            
            Options = options ?? new LuminaOptions();
            
            DataPath = new DirectoryInfo( dataPath );

            if( !DataPath.Exists )
            {
                throw new DirectoryNotFoundException( "DataPath provided is missing." );
            }

            Categories = DataPath.GetDirectories().Select( d => new DatCategory( d ) ).ToList();
        }
    }
}