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
    public partial class OrdersForm : Form
    {
        public static int IdOfProduct = 0;
        public static int FlagLastItem = 0;
        public static int FlagFirstItem = 0;
        public static List<int> ListOfProductId = new List<int>();
        public OrdersForm()
        {
            InitializeComponent();
            if (MenuForUserForm.LeaveButtonPressed == true)
            {
                ListOfProductId.Clear();
            }
            if (ListOfProductId.Count == 0)
            {
                ModelTypeLabel.Text = "";
                PriceTypeLabel.Text = "";
            }
            else
            {
                DB db = new DB();
                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                MySqlCommand command = new MySqlCommand("SELECT name FROM orders WHERE id = @id", db.GetConnection());
                MySqlCommand command1 = new MySqlCommand("SELECT price FROM orders WHERE id = @id", db.GetConnection());
                command.Parameters.Add("@id", MySqlDbType.VarChar).Value = IdOfProduct;
                command1.Parameters.Add("@id", MySqlDbType.VarChar).Value = IdOfProduct;
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
                    MessageBox.Show("Не удалось соединиться с каталогом!");
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
            MenuForUserForm menuForUserForm = new MenuForUserForm();
            menuForUserForm.Show();
        }

        private void OrdersForm_Load(object sender, EventArgs e)
        {

        }

        private void PreviousElementOrdersButton_Click(object sender, EventArgs e)
        {
            if (ListOfProductId.Count == 0)
            {
                MessageBox.Show("Предыдущего заказа нет!");
            }
            else
            {
                if (IdOfProduct == FlagFirstItem)
                {
                    MessageBox.Show("Это первый заказ!");
                    return;
                }
                IdOfProduct--;
                if (ListOfProductId.Contains(IdOfProduct) == false)
                {
                    while (ListOfProductId.Contains(IdOfProduct) == false)
                    {
                        IdOfProduct--;
                    }
                }

                DB db = new DB();
                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                MySqlCommand command = new MySqlCommand("SELECT name FROM orders WHERE id = @id", db.GetConnection());
                MySqlCommand command1 = new MySqlCommand("SELECT price FROM orders WHERE id = @id", db.GetConnection());
                command.Parameters.Add("@id", MySqlDbType.VarChar).Value = IdOfProduct;
                command1.Parameters.Add("@id", MySqlDbType.VarChar).Value = IdOfProduct;
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
                    MessageBox.Show("Не удалось соединиться с каталогом!");

            }
        }

        private void NextElementOrdersButton_Click(object sender, EventArgs e)
        {
            if (ListOfProductId.Count == 0)
            {
                MessageBox.Show("Следующего заказа нет!");
            }
            else
            {
                if (IdOfProduct == ListOfProductId[FlagLastItem - 1])
                {
                    MessageBox.Show("Это последний заказ!");
                    return;
                }
                IdOfProduct++;
                if (ListOfProductId.Contains(IdOfProduct) == false)
                {
                    while (ListOfProductId.Contains(IdOfProduct) == false)
                    {
                        IdOfProduct++;
                    }
                }
                DB db = new DB();
                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                MySqlCommand command = new MySqlCommand("SELECT name FROM orders WHERE id = @id", db.GetConnection());
                MySqlCommand command1 = new MySqlCommand("SELECT price FROM orders WHERE id = @id", db.GetConnection());
                command.Parameters.Add("@id", MySqlDbType.VarChar).Value = IdOfProduct;
                command1.Parameters.Add("@id", MySqlDbType.VarChar).Value = IdOfProduct;
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
                    MessageBox.Show("Не удалось соединиться с каталогом!");
            }
        }
    }
}
