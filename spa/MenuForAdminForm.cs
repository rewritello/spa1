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
    public partial class MenuForAdminForm : Form
    {
        public MenuForAdminForm()
        {
            InitializeComponent();
        }

        private void LeaveFromAccountButton_Click(object sender, EventArgs e)
        {
            this.Close();
            StartForm startForm = new StartForm();
            startForm.Show();
        }

        private void MenuForAdminForm_Load(object sender, EventArgs e)
        {

        }

        private void OrderListOfUsersButton_Click(object sender, EventArgs e)
        {
            this.Close();
            ListOfUsersOrdersForm listOfUsersOrdersForm = new ListOfUsersOrdersForm();
            listOfUsersOrdersForm.Show();
        }

        private void ListOfUsersButton_Click(object sender, EventArgs e)
        {
            this.Close();
            ListOfUsersForm listOfUsersForm = new ListOfUsersForm();
            listOfUsersForm.Show();
        }

        private void ChooseCatalogButton_Click(object sender, EventArgs e)
        {
            this.Close();
            CatalogForAdminForm catalogForAdminForm = new CatalogForAdminForm();
            catalogForAdminForm.Show();
        }
    }
}
