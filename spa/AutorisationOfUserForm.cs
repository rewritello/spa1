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
    public partial class AutorisationOfUserForm : Form
    {
        public string uL;
        public AutorisationOfUserForm()
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
            User.login = TextBoxOfLogin.Text;
            User.password = TextBoxOfPassword.Text;
            string loginUser = TextBoxOfLogin.Text;
            string passUser = TextBoxOfPassword.Text;
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL AND `pass` = @uP", db.GetConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passUser;
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                this.Close();
                MenuForUserForm menuForUserForm = new MenuForUserForm();
                menuForUserForm.Show();
            }
            else
                MessageBox.Show("Пользователя с такими данными не найдено в системе!");
        }

        private void AutorisationOfUserForm_Load(object sender, EventArgs e)
        {

        }
    }
}
