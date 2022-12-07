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
    public partial class AddProductInCatalogForm : Form
    {
        public AddProductInCatalogForm()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
            CatalogForAdminForm catalogForAdminForm = new CatalogForAdminForm();
            catalogForAdminForm.Show();
        }

        private void AddProductInCatalogButton_Click(object sender, EventArgs e)
        {
            if (TextBoxOfModelProduct.Text == "" || TextBoxOfPriceProduct.Text == "")
            {
                MessageBox.Show("Введите корректные данные!");
                return;
            }
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `catalog` (`name`, `price`) VALUES (@n, @p)", db.GetConnection());
            command.Parameters.Add("@n", MySqlDbType.VarChar).Value = TextBoxOfModelProduct.Text;
            command.Parameters.Add("@p", MySqlDbType.VarChar).Value = TextBoxOfPriceProduct.Text;
            db.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Товар добавлен в каталог!");
            }
            else
                MessageBox.Show("Товар не удалось добавить в каталог!");
            db.closeConnection();
        }
    }
}
