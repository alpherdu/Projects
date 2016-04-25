using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Common;

namespace FactoryMethod
{
    public class AppContext
    {
        public static DatabaseType DatabaseType
        {
            get;
            set;
        }

        public static DbProviderFactory DbProviderFactory
        {
            get;
            set;
        }
    }

    /// <summary>
    /// Database Type enumeration
    /// </summary>
    public enum DatabaseType
    {
        SqlServer,
        Access
    }
}
