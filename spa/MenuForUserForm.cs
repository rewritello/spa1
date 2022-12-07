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
    public partial class MenuForUserForm : Form
    {
        public static bool LeaveButtonPressed = false;
        public MenuForUserForm()
        {
            InitializeComponent();
        }

        private void LeaveFromAccountButton_Click(object sender, EventArgs e)
        {

            LeaveButtonPressed = true ;
            this.Close();
            StartForm startForm = new StartForm();
            startForm.Show();
        }

        private void MenuForUserForm_Load(object sender, EventArgs e)
        {

        }

        private void OrderButton_Click(object sender, EventArgs e)
        {
            this.Close();
            OrdersForm ordersForm = new OrdersForm();
            ordersForm.Show();
        }

        private void BacketButton_Click(object sender, EventArgs e)
        {
            this.Close();
            BasketForm basketForm = new BasketForm();
            basketForm.Show();
        }

        private void PersonalInfoButton_Click(object sender, EventArgs e)
        {
            this.Close();
            PersonalInformationForm personalInformationForm = new PersonalInformationForm();
            personalInformationForm.Show();
        }

        private void CatalogButton_Click(object sender, EventArgs e)
        {
            LeaveButtonPressed = false;
            this.Close();
            CatalogForRegisteredUserForm catalogForRegisteredUserForm = new CatalogForRegisteredUserForm();
            catalogForRegisteredUserForm.Show();
        }
    }
}
