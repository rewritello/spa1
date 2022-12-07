using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace spa
{
    public partial class CatalogForNonregisteredUserForm : Form
    {
        public static int id;
        public CatalogForNonregisteredUserForm()
        {
            InitializeComponent();
            Catalog.GetMinIdInCatalog();
            id = int.Parse(Catalog.FirstId);
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT name FROM catalog WHERE id = @id", db.GetConnection());
            MySqlCommand command1 = new MySqlCommand("SELECT price FROM catalog WHERE id = @id", db.GetConnection());
            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;
            command1.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;
            adapter.SelectCommand = command;
            adapter.SelectCommand = command1;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                db.openConnection();
                ModelTypeLabel.Text = command.ExecuteScalar().ToString();
                PriceTypeLabel.Text = command1.ExecuteScalar().ToString();
                db.closeConnection();
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
            StartForm startForm = new StartForm();
            startForm.Show();
        }

        private void CatalogForNonregisteredUserForm_Load(object sender, EventArgs e)
        {

        }

        private void PreviousModelButton_Click(object sender, EventArgs e)
        {
            Catalog.GetMinIdInCatalog();
            if (id == int.Parse(Catalog.FirstId))
            {
                MessageBox.Show("Предыдущей модели в каталоге нет!");
            }
            if (id > int.Parse(Catalog.FirstId))
            {
                id--;
                while (Catalog.CheckId(id) == false)
                {
                    id--;
                }
                DB db = new DB();
                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                MySqlCommand command = new MySqlCommand("SELECT name FROM catalog WHERE id = @id", db.GetConnection());
                MySqlCommand command1 = new MySqlCommand("SELECT price FROM catalog WHERE id = @id", db.GetConnection());
                command.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;
                command1.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;
                adapter.SelectCommand = command;
                adapter.SelectCommand = command1;
                adapter.Fill(table);
                if (table.Rows.Count > 0)
                {
                    db.openConnection();
                    ModelTypeLabel.Text = command.ExecuteScalar().ToString();
                    PriceTypeLabel.Text = command1.ExecuteScalar().ToString();
                    db.closeConnection();
                }
                else
                {
                    MessageBox.Show("123");
                }

            }
        }

        private void NextModelButton_Click(object sender, EventArgs e)
        {
            Catalog.GetMaxIdInCatalog();
            if (id != int.Parse(Catalog.LastId))
            {
                id++;
                while (Catalog.CheckId(id) == false)
                {
                    id++;
                }
                DB db = new DB();
                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                MySqlCommand command = new MySqlCommand("SELECT name FROM catalog WHERE id = @id", db.GetConnection());
                MySqlCommand command1 = new MySqlCommand("SELECT price FROM catalog WHERE id = @id", db.GetConnection());
                command.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;
                command1.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;
                adapter.SelectCommand = command;
                adapter.SelectCommand = command1;
                adapter.Fill(table);
                if (table.Rows.Count > 0)
                {
                    db.openConnection();
                    ModelTypeLabel.Text = command.ExecuteScalar().ToString();
                    PriceTypeLabel.Text = command1.ExecuteScalar().ToString();
                    db.closeConnection();
                }
                else
                    MessageBox.Show("Нет соединения с каталогом!");
            }
            else MessageBox.Show("Следующей модели нет!");
        }
    }
}
