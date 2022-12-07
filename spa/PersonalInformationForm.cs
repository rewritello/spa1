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
    public partial class PersonalInformationForm : Form
    {
        public PersonalInformationForm()
        {
            InitializeComponent();
            if (User.fio != null)
            {
                TextBoxOfInfName.Text = User.fio;
            }
            if (User.pn != null)
            {
                TextBoxOfPhoneNumber.Text = User.pn;
            }
            if (User.adress != null)
            {
                TextBoxOfAdress.Text = User.adress;
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
            MenuForUserForm menuForUserForm = new MenuForUserForm();
            menuForUserForm.Show();
        }

        private void SaveInfoButton_Click(object sender, EventArgs e)
        {
            string loginUser = User.login;
            string passUser = User.password;
            string fio = TextBoxOfInfName.Text;
            User.fio = TextBoxOfInfName.Text;
            string pn = TextBoxOfPhoneNumber.Text;
            User.pn = TextBoxOfPhoneNumber.Text;
            string adress = TextBoxOfAdress.Text;
            User.adress = TextBoxOfAdress.Text;
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("UPDATE `users` SET `phonenumber` = @pn WHERE `users`.`login` = @uL", db.GetConnection());
            MySqlCommand command1 = new MySqlCommand("UPDATE `users` SET `adress` = @adress WHERE `users`.`login` = @uL", db.GetConnection());
            MySqlCommand command2 = new MySqlCommand("UPDATE `users` SET `name` = @fio WHERE `users`.`login` = @uL", db.GetConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@pn", MySqlDbType.VarChar).Value = pn;
            command1.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
            command1.Parameters.Add("@adress", MySqlDbType.VarChar).Value = adress;
            command2.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
            command2.Parameters.Add("@fio", MySqlDbType.VarChar).Value = fio;
            db.openConnection();
            if (command.ExecuteNonQuery() == 1 && command1.ExecuteNonQuery() == 1 && command2.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Изменения сохранены!");
            }
            else
                MessageBox.Show("Изменения не удалось сохранить!");
            db.closeConnection();
        }

        private void ChangePassButton_Click(object sender, EventArgs e)
        {
            this.Close();
            ChangePassForm changePassForm = new ChangePassForm();
            changePassForm.Show();
        }

        private void PersonalInformationForm_Load(object sender, EventArgs e)
        {

        }
    }
}
