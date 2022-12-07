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
    public partial class AutorisationForm : Form
    {
        public AutorisationForm()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
            StartForm startForm = new StartForm();
            startForm.Show();
        }

        private void ChooseAdminButton_Click(object sender, EventArgs e)
        {
            this.Close();
            AutorisationOfAdminForm autorisationOfAdminForm = new AutorisationOfAdminForm();
            autorisationOfAdminForm.Show();
        }

        private void ChooseUserButton_Click(object sender, EventArgs e)
        {
            this.Close();
            AutorisationOfUserForm autorisationOfUserForm = new AutorisationOfUserForm();
            autorisationOfUserForm.Show();
        }

        private void AutorisationForm_Load(object sender, EventArgs e)
        {

        }
    }
}
