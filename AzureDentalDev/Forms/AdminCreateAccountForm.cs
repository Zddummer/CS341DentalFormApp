using AzureDentalDev.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AzureDentalDev.Forms
{
    public partial class AdminCreateAccountForm : Form
    {
        public AdminCreateAccountForm()
        {
            InitializeComponent();
            AdminCreateTypeCombobox.Items.Add("P");
            AdminCreateTypeCombobox.Items.Add("D");
            AdminCreateTypeCombobox.Items.Add("H");
            AdminCreateTypeCombobox.Items.Add("A");
        }

        private void AdminCreateAccountFormCloseLabel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AdminCreateUserTextbox_Enter(object sender, EventArgs e)
        {
            if(AdminCreateUserTextbox.Text == "Create a username")
            {
                AdminCreateUserTextbox.Clear();
            }
        }

        private void AdminCreateUserTextbox_Leave(object sender, EventArgs e)
        {
            if(AdminCreateUserTextbox.Text == String.Empty)
            {
                AdminCreateUserTextbox.Text = "Create a username";
            }
        }

        private void AdminCreatePassTextBox_Enter(object sender, EventArgs e)
        {
            if(AdminCreatePassTextBox.Text == "Create a password")
            {
                AdminCreatePassTextBox.Clear();
            }
        }

        private void AdminCreatePassTextBox_Leave(object sender, EventArgs e)
        {
            if(AdminCreatePassTextBox.Text == String.Empty)
            {
                AdminCreatePassTextBox.Text = "Create a password";
            }
        }

        private void AdminCreateFirstTextbox_Enter(object sender, EventArgs e)
        {
            if(AdminCreateFirstTextbox.Text == "Enter the first name")
            {
                AdminCreateFirstTextbox.Clear();
            }
        }

        private void AdminCreateFirstTextbox_Leave(object sender, EventArgs e)
        {
            if(AdminCreateFirstTextbox.Text == String.Empty)
            {
                AdminCreateFirstTextbox.Text = "Enter the first name";
            }
        }

        private void AdminCreateLastTextbox_Enter(object sender, EventArgs e)
        {
            if(AdminCreateLastTextbox.Text == "Enter the last name")
            {
                AdminCreateLastTextbox.Clear();
            }
        }

        private void AdminCreateLastTextbox_Leave(object sender, EventArgs e)
        {
            if(AdminCreateLastTextbox.Text == String.Empty)
            {
                AdminCreateLastTextbox.Text = "Enter the last name";
            }
        }

        private void AdminCreateButton_Click(object sender, EventArgs e)
        {
            if(AdminCreateUserTextbox.Text == String.Empty || AdminCreateUserTextbox.Text == "Create a Username" ||
               AdminCreatePassTextBox.Text == String.Empty || AdminCreatePassTextBox.Text == "Create a password" ||
               AdminCreateFirstTextbox.Text == String.Empty || AdminCreateFirstTextbox.Text == "Enter the first name" ||
               AdminCreateLastTextbox.Text == String.Empty || AdminCreateLastTextbox.Text == "Enter the last name" ||
               AdminCreateTypeCombobox.Text == String.Empty)
            {
                return;
            }

            Boolean blnWasAccountCreated = DataAccessClass.registerNewUser(AdminCreateFirstTextbox.Text,
                                                                           AdminCreateLastTextbox.Text,
                                                                           AdminCreateUserTextbox.Text,
                                                                           AdminCreatePassTextBox.Text,
                                                                           AdminCreateTypeCombobox.Text);

            if (blnWasAccountCreated)
            {
                AdminCreateValidLabel.Visible = true;
                AdminCreateErrorLabel.Visible = false;
            } else
            {
                AdminCreateValidLabel.Visible = false;
                AdminCreateErrorLabel.Visible = true;
            }
        }
    }
}
