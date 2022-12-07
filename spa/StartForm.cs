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
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void AutorisationButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AutorisationForm autorisationForm = new AutorisationForm();
            autorisationForm.Show();
        }

        private void RegistrationButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.Show();
        }

        private void CheckCatalogButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            CatalogForNonregisteredUserForm catalogForNonregisteredUser = new CatalogForNonregisteredUserForm();
            catalogForNonregisteredUser.Show();
        }
    }
}
