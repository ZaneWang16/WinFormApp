using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpenseTracker
{
    public partial class ViewExpense : Form
    {// The ViewExpense class is a Form that handles displaying expenses for a user
        private DatabaseHandler dbHandler = new DatabaseHandler();  // Instantiate the DatabaseHandler
        public ViewExpense()
        {
            InitializeComponent();
            this.FormClosing += ViewExpense_FormClosing;
            // Call the method to display expenses in the data grid view.
            ShowExpense();
        }

        // This method retrieves expenses for the logged-in user from the database and displays them in a data grid view.
        private void ShowExpense()
        {
            try
            {
                var dataTable = dbHandler.GetExpensesForUser(Login.User);  // Call DatabaseHandler to get expenses
                VeiwDataGridView.DataSource = dataTable;  // Set DataTable as DataSource
            }
            catch (Exception ex) // Show an error message if an exception occurs.
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        // This method retrieves expenses
        // for a selected category for the logged-in user from the database and displays them in a data grid view.
        private void FilterByCate()
        {
            try
            {
                var category = ExpenseCategory.SelectedItem.ToString();
                var dataTable = dbHandler.GetExpensesForUserByCategory(Login.User, category);  // Call DatabaseHandler to get filtered expenses
                VeiwDataGridView.DataSource = dataTable;  // Set DataTable as DataSource
            }
            catch (Exception ex)// Show an error message if an exception occurs.
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        // Event handler for ClearFilterBtn button click event. It calls ShowExpense() to display all expenses when clicked.
        private void ClearFilterBtn_Click(object sender, EventArgs e)
        {
            ShowExpense();
        }

        private void ExpenseCategory_SelectionChangeCommitted(object sender, EventArgs e)
        {
            FilterByCate();
        }

        // Event handler for BackToUsersBtn button click event. It hides this form when clicked.
        private void BackToUsersBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        // Event handler for FormClosing event. It exits the application when this form closes.
        private void ViewExpense_FormClosing(object? sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
