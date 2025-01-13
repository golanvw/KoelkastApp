using SQLite;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoelkastApp
{
    public static class Constants
    {
        private const string DBFileName = "KoelkastDB.db3";

        public const SQLiteOpenFlags flags =
            SQLiteOpenFlags.ReadWrite |
            SQLiteOpenFlags.Create |
            SQLiteOpenFlags.SharedCache;

        public static string DatabasePath
        {
            get
            {
                return Path.Combine(FileSystem.AppDataDirectory, DBFileName);
            }
        }

        //api constants
        public const string BEER_BY_BRAND = "https://kratjes.net/api/?brand={0}";
        public const string BEER_BY_STORE = "https://kratjes.net/api/?supermarket={0}";

    }
}
