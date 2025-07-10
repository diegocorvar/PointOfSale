using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;

namespace PuntoDeVenta.Helpers
{
    public static class ConexionDB
    {
        private static string ruteDB = Path.Combine(Application.StartupPath, @"DataBase\PointOfSale_db.db");

        public static SQLiteConnection GetConnection()
        {
            return new SQLiteConnection($"Data Source={ruteDB};Version=3;");
        }
    }
}
