using Microsoft.Data.SqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;

namespace ExpenseTracker
{


    public partial class Login : Form
    {
        private DatabaseHandler dbHandler = new DatabaseHandler();  // Instantiate the DatabaseHandler

        // Constructor to initialize components, set event handlers, and set the AcceptButton property
        public Login()
        {
            InitializeComponent();
            this.FormClosing += Login_FormClosing;  // Event handler for FormClosing event
            this.AcceptButton = LoginBtn;  // Sets the LoginBtn to be "clicked" when Enter key is pressed
        }

        // Static string to hold the username of the logged-in user
        public static string? User;

        // Event handler for Login button click
        private void LoginBtn_Click(object sender, EventArgs e)
        {
            string username = UserNameTable.Text;
            string password = UserPasswordTable.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }


            User? user = dbHandler.GetUser(username, password);

            if (user != null)
            {
                User = user.UserName;
                MainMenu exp = new MainMenu();
                exp.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong UserName or Password");
            }
        }

        // Event handler for Admin Login button click
        private void AdminLoginBtn_Click(object sender, EventArgs e)
        {
            // Create and show the AdminLogin form, and hide the Login form
            AdminLogin adminLogin = new AdminLogin();
            adminLogin.Show();
            this.Hide();
        }

        // Event handler for FormClosing event
        private void Login_FormClosing(object? sender, FormClosingEventArgs e)
        {
            // Exit the application when the Login form is closed
            Application.Exit();
        }
    }
}
