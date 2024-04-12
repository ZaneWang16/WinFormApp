using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace ExpenseTracker
{
    public partial class Users : Form
    { // The Users class is a Form that handles the functionality related to user management.
        private DatabaseHandler dbHandler = new DatabaseHandler();  // Instantiate the DatabaseHandler
        public Users()
        {
            InitializeComponent();
            this.FormClosing += Users_FormClosing;
            ShowUser();// Call the method to display users in the data grid view.
        }

        // This method retrieves users from the database and displays them in a data grid view.
        private void ShowUser()
        {
            try
            {
                var dataTable = dbHandler.GetUsers();  // Get users from the database.
                UsersDataGridView.DataSource = dataTable;  // Set DataTable as DataSource
            }
            catch (Exception ex)// Show an error message if an exception occurs.
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void Clear() // This method clears all input fields in the form.
        {
            UserNameTb.Text = "";
            UserPasswordTb.Text = "";
            UserPhoneTb.Text = "";
            UserAddressTb.Text = "";
        }

        // Event handler for AddUserBtn button click event. It adds a user to the database when clicked.
        private void AddUserBtn_Click(object sender, EventArgs e)
        {
            if (UserNameTb.Text == "" || UserPhoneTb.Text == "" ||
        UserPasswordTb.Text == "" || UserAddressTb.Text == "")
            {
                MessageBox.Show("Please fill out All Information");// Show a message box if any input field is empty.           
            }
            else
            {
                bool userAdded = dbHandler.AddUser(UserNameTb.Text, UserDOB.Value, UserPhoneTb.Text, UserPasswordTb.Text, UserAddressTb.Text);
                if (userAdded)
                {
                    MessageBox.Show("User Added");// Show a success message if the user was added successfully.
                    ShowUser();
                    Clear();
                }
                else
                {// Show an error message if there was an error while adding the user.
                    MessageBox.Show("An error occurred while adding the user.");
                }
            }
        }

        // Event handler for ViewExpenseBtn button click event. It opens the AdminExpense form when clicked.
        private void ViewExpenseBtn_Click(object sender, EventArgs e)
        {
            AdminExpense adminExpense = new AdminExpense();
            adminExpense.Show();
            this.Hide();
        }

        // Event handler for BackToAdminLoginBtn button click event. It opens the AdminLogin form when clicked.
        private void BackToAdminLoginBtn_Click(object sender, EventArgs e)
        {
            AdminLogin adminLogin = new AdminLogin();
            adminLogin.Show();
            this.Hide();
        }

        // Event handler for FormClosing event. It exits the application when this form closes.
        private void Users_FormClosing(object? sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
