using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpenseTracker
{
    public partial class AdminLogin : Form
    {// The AdminLogin class is a Form that handles the login functionality for an admin user.
        public AdminLogin()// The constructor for the AdminLogin class.
        {
            InitializeComponent();
            this.AcceptButton = AdminLoginBtn; // Set the AcceptButton property to the AdminLoginBtn, so that clicking Enter triggers this button.
            this.FormClosing += AdminLogin_FormClosing;
        }

        // Event handler for the BackToLogin button click event. called when the BackToLogin button is clicked.
        private void BackToLogin_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();// Hide the current (AdminLogin) form.
        }

        // Event handler for the AdminLoginBtn button click event. called when the AdminLoginBtn button is clicked.
        private void AdminLoginBtn_Click(object sender, EventArgs e)
        {
            if (UserPasswordTable.Text == "")// If the password field is empty, show a message box asking for the admin password.
            {
                MessageBox.Show("Please Enter Admin Password");
            }
            else if (UserPasswordTable.Text == "adminpass")// If the password field matches "adminpass",
                                                           // create a new instance of the Users form and show it,
                                                           // then hide the current form.
            {
                Users users = new Users();
                users.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong Password, Please try again");
            }
        }

        private void AdminLogin_FormClosing(object? sender, FormClosingEventArgs e)
        {//called when the form is closing.
            Application.Exit();
        }
    }
}
