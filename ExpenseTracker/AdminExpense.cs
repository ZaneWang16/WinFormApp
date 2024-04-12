using Microsoft.Data.SqlClient;
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
    public partial class AdminExpense : Form
    {
        
        private DatabaseHandler dbHandler = new DatabaseHandler();  // Instantiate the DatabaseHandler

        public AdminExpense()
        {
            InitializeComponent();
            this.FormClosing += AdminExpense_FormClosing;
            ShowExpense();
        }
        public DataTable ConvertToDataTable(List<Expense> expenses)
        {
            var table = new DataTable("Expenses");

            // Assuming all properties of Expense are to be displayed
            table.Columns.Add("ExpenseId", typeof(int));
            table.Columns.Add("ExpenseName", typeof(string));
            table.Columns.Add("ExpenseAccount", typeof(string));
            table.Columns.Add("ExpenseCategory", typeof(string));
            table.Columns.Add("ExpenseDate", typeof(string));
            table.Columns.Add("ExpenseComment", typeof(string));
            table.Columns.Add("ExpenseUser", typeof(string));

            foreach (var expense in expenses)
            {
                table.Rows.Add(expense.ExpenseId, expense.ExpenseName, expense.ExpenseAccount,
                               expense.ExpenseCategory, expense.ExpenseDate, expense.ExpenseComment,
                               expense.ExpenseUser);
            }

            return table;
        }
     

        // Method to display all expenses in the DataGridView.
        private void ShowExpense()
        {
            try
            {
                var dataTable = dbHandler.GetExpenses();  // Call DatabaseHandler to get expenses
                ExpenseDataGridView.DataSource = dataTable;  // Set DataTable as DataSource
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        // Event handler for Back button click.
        private void BackToAdminLogingBtn_Click(object sender, EventArgs e)
        {
            Users users = new Users();
            users.Show();
            this.Hide();
        }

        // Method to filter expenses by category.
        private void FilterByCate()
        {
            try
            {
                var category = ExpenseCategory.SelectedItem.ToString();
                var dataTable = dbHandler.GetExpenses(category);  // Call DatabaseHandler to get filtered expenses
                ExpenseDataGridView.DataSource = dataTable;  // Set DataTable as DataSource
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        // Event handler for Clear Filter button click.
        private void ClearFilterBtn_Click(object sender, EventArgs e)
        {
            ShowExpense();
        }

        // Event handler for ExpenseCategory selection change.
        private void ExpenseCategory_SelectionChangeCommitted(object sender, EventArgs e)
        {
            FilterByCate();
        }

        // Event handler for FormClosing event.
        private void AdminExpense_FormClosing(object? sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
