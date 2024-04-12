using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpenseTracker
{
    public partial class Expenses : Form
    {// The Expenses class is a Form that handles the functionality related to expenses.
        private DatabaseHandler dbHandler = new DatabaseHandler();  // Instantiate the DatabaseHandler
        public Expenses()// Initialize the components of the form and attach an event handler to the FormClosing event.
        {
            InitializeComponent();
            this.FormClosing += Expenses_FormClosing;
        }

        private void Clear() // This method clears all the input fields in the form.
        {
            ExpenseName.Text = "";
            ExpenseAmount.Text = "";
            ExpenseDescription.Text = "";
            ExpenseCategory.SelectedIndex = 0;
        }

        private void ExpBackToMainBtn_Click(object sender, EventArgs e)//called when the ExpBackToMainBtn button is clicked.
        {
            this.Hide();
        }

        private void AddExpBtn_Click_1(object sender, EventArgs e)//This method is called when the AddExpBtn button is clicked.
        {
            // If any of the input fields are empty or no category is selected, show a message box asking for all information.
            if (ExpenseName.Text == "" || ExpenseAmount.Text == "" ||
                ExpenseCategory.SelectedIndex == -1 || ExpenseDescription.Text == "")
            {
                MessageBox.Show("Please fill out All Information");
            }
            else
            {// If all input fields are filled and a category is selected, try to add the expense to the database.
                bool isAdded = dbHandler.AddExpense(
                    ExpenseName.Text,
                    ExpenseAmount.Text,
                    ExpenseCategory.SelectedItem.ToString(),
                    ExpenseDate.Value.Date,
                    ExpenseDescription.Text,
                    Login.User
                );

                if (isAdded)// If the expense was added successfully, show a success message and clear all input fields.
                {
                    MessageBox.Show("Expense Added");
                    Clear();
                }
                else
                {
                    MessageBox.Show("An error occurred while adding the expense.");
                }
            }
        }

        private void Expenses_FormClosing(object? sender, FormClosingEventArgs e)
        { // Exit the application when this form closes.
            Application.Exit();
        }
    }
}
