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
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
            StartForm startForm = new StartForm();
            startForm.Show();
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {

        }

        private void RegistrationButton_Click(object sender, EventArgs e)
        {
            User.login = TextBoxOfLogin.Text;
            User.password = TextBoxOfPassword.Text;
            if (TextBoxOfLogin.Text == "" || TextBoxOfPassword.Text == "")
            {
                MessageBox.Show("Введите корректные данные!");
                return;
            }
            if (UserIsExsists()) return;
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`login`, `pass`,`phonenumber`,`adress`,`name`) VALUES (@uL, @uP, @pn, @adress,@name)", db.GetConnection());
            command.Parameters.Add("@uL",MySqlDbType.VarChar).Value=TextBoxOfLogin.Text;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = TextBoxOfPassword.Text;
            command.Parameters.Add("@pn", MySqlDbType.VarChar).Value = "";
            command.Parameters.Add("@adress", MySqlDbType.VarChar).Value = "";
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = "";
            db.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                this.Close();
                MenuForUserForm menuForUserForm = new MenuForUserForm();
                menuForUserForm.Show();
            }
            else
                MessageBox.Show("Аккаунт не был создан!");
            db.closeConnection();
        }
        public Boolean UserIsExsists()
        {
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL", db.GetConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = TextBoxOfLogin.Text;
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Пользователь с таким логином уже зарегистрирован в системе!");
                return true;
            }
            else return false;                
        }
    }
}
