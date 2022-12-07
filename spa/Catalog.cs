using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spa
{
    internal static class Catalog
    {
        public static string LastId;
        public static string FirstId;
        public static void GetMaxIdInCatalog()
        {
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT id FROM catalog ORDER BY id DESC LIMIT 1", db.GetConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                db.openConnection();
                LastId = command.ExecuteScalar().ToString();
                db.closeConnection();
            }
            else return;
        }
        public static void GetMinIdInCatalog()
        {
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT id FROM catalog ORDER BY id ASC LIMIT 1", db.GetConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                db.openConnection();
                FirstId = command.ExecuteScalar().ToString();
                db.closeConnection();
            }
            else return;
        }
        public static bool CheckId(int id)
        {
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT id FROM catalog WHERE id = @id", db.GetConnection());
            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
