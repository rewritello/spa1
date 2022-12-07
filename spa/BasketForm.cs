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
    public partial class BasketForm : Form
    {
        public static int IdOfProduct = 0;
        public static int FlagLastItem = 0;
        public static int FlagFirstItem = 0;
        public static List<int> ListOfProductId = new List<int>();
        public BasketForm()
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
                MySqlCommand command = new MySqlCommand("SELECT name FROM catalog WHERE id = @id", db.GetConnection());
                MySqlCommand command1 = new MySqlCommand("SELECT price FROM catalog WHERE id = @id", db.GetConnection());
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
            }
        }

        private void OrdersLabel_Click(object sender, EventArgs e)
        {

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
            MenuForUserForm menuForUserForm = new MenuForUserForm();
            menuForUserForm.Show();
        }

        private void AddElementToOrderButton_Click(object sender, EventArgs e)
        {
            OrdersForm.IdOfProduct = IdOfProduct;
            OrdersForm.FlagLastItem++;
            if (OrdersForm.ListOfProductId.Count == 0)
            {
                OrdersForm.FlagFirstItem = IdOfProduct;
            }
            OrdersForm.ListOfProductId.Add(IdOfProduct);
            MessageBox.Show("Заказ успешно оформлен, для получения товара обратитесь в наш салон!");
            DB db = new DB();
            DataTable table = new DataTable();
            DataTable table1 = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("INSERT INTO `orders` (`name`, `price`, `id`) VALUES (@name, @price, @id)", db.GetConnection());
            MySqlCommand command1 = new MySqlCommand("DELETE FROM `catalog` WHERE name = @name AND price = @price", db.GetConnection());
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = ModelTypeLabel.Text;
            command.Parameters.Add("@price", MySqlDbType.VarChar).Value = PriceTypeLabel.Text;
            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = IdOfProduct;
            command1.Parameters.Add("@name", MySqlDbType.VarChar).Value = ModelTypeLabel.Text;
            command1.Parameters.Add("@price", MySqlDbType.VarChar).Value = PriceTypeLabel.Text;
            adapter.SelectCommand = command;
            adapter.Fill(table);
            adapter.SelectCommand = command1;
            adapter.Fill(table1);
            
        }

        private void PreviousElementBasketButton_Click(object sender, EventArgs e)
        {
            if (ListOfProductId.Count == 0)
            {
                MessageBox.Show("Предыдущего элемента в корзине нет!");
            }
            else
            {
                if (IdOfProduct == FlagFirstItem)
                {
                    MessageBox.Show("Это первый элемент корзины!");
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
                MySqlCommand command = new MySqlCommand("SELECT name FROM catalog WHERE id = @id", db.GetConnection());
                MySqlCommand command1 = new MySqlCommand("SELECT price FROM catalog WHERE id = @id", db.GetConnection());
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

        private void NextElementBasketButton_Click(object sender, EventArgs e)
        {
            if (ListOfProductId.Count == 0)
            {
                MessageBox.Show("Следующего элемента в корзине нет!");
            }
            else
            {
                if (IdOfProduct == ListOfProductId[FlagLastItem-1])
                {
                    MessageBox.Show("Это последний элемент корзины!");
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
                MySqlCommand command = new MySqlCommand("SELECT name FROM catalog WHERE id = @id", db.GetConnection());
                MySqlCommand command1 = new MySqlCommand("SELECT price FROM catalog WHERE id = @id", db.GetConnection());
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
