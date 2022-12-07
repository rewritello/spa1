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
    public partial class ChangePassForm : Form
    {
        public ChangePassForm()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
            PersonalInformationForm personalInformationForm = new PersonalInformationForm();
            personalInformationForm.Show();
        }

        private void SaveNewPassButton_Click(object sender, EventArgs e)
        {
            if (TextBoxOfOldPass.Text == User.password)
            {
                DB db = new DB();
                MySqlCommand command = new MySqlCommand("UPDATE `users` SET `pass` = @uP WHERE `users`.`login` = @uL", db.GetConnection());
                command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = User.login;
                command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = TextBoxOfNewPass.Text;
                db.openConnection();
                if (command.ExecuteNonQuery() == 1)
                {
                    User.password = TextBoxOfNewPass.Text;
                    MessageBox.Show("Изменения успешно сохранены!");
                }
                else
                    MessageBox.Show("Изменения не удалось сохранить!");
                db.closeConnection();
            }
            else MessageBox.Show("Старый пароль введён неверно!");
        }
    }
}
