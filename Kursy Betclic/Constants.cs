using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursy_Betclic
{
    public static class Constants
    {
        public const string DataBaseFileName = "Odds.db3";

        public const SQLite.SQLiteOpenFlags Flags =
            SQLite.SQLiteOpenFlags.ReadWrite |
            SQLite.SQLiteOpenFlags.Create |
            SQLite.SQLiteOpenFlags.SharedCache;

        public static string DataBasePath =>
            Path.Combine(System.AppContext.BaseDirectory, DataBaseFileName);
    }

    
}
