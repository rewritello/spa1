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
    public partial class AutorisationOfAdminForm : Form
    {
        public AutorisationOfAdminForm()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
            AutorisationForm autorisationForm = new AutorisationForm();
            autorisationForm.Show();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string loginAdmin = TextBoxOfLogin.Text;
            string passAdmin = TextBoxOfPassword.Text;
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `admins` WHERE `login` = @uL AND `pass` = @uP", db.GetConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginAdmin;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passAdmin;
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                this.Close();
                MenuForAdminForm menuForAdminForm = new MenuForAdminForm();
                menuForAdminForm.Show();
            }
            else
                MessageBox.Show("Администратора с такими данными не найдено в системе!");
        }

        private void AutorisationOfAdminForm_Load(object sender, EventArgs e)
        {

        }
    }
}
