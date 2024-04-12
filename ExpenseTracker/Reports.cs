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
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;
#nullable disable

namespace ExpenseTracker
{

    public partial class Reports : Form
    {// The Reports class is a Form that handles the functionality related to expense reports.
        private readonly DatabaseHandler dbHandler = new DatabaseHandler(); // Instantiate the DatabaseHandler to interact with the database.

        public Reports()
        {
            InitializeComponent();// Initialize the components of the form and attach an event handler to the FormClosing event.
            this.FormClosing += Reports_FormClosing;
            // Call methods to get and display various expense statistics.
            GetMaxExp();
            GetMinExp();
            GetAvgExp();
            GetTotExp();
            GetHighestByCate();
            GetLowestByCate();
        }

        // This method gets and displays the maximum expense for the logged-in user.
        private void GetMaxExp()
        {
            decimal maxExpense = dbHandler.GetMaxExpense(Login.User);
            MaxLabel.Text = "$" + maxExpense.ToString();
        }

        private void GetMinExp()// This method gets and displays the minimum expense for the logged-in user.
        {
            decimal minExpense = dbHandler.GetMinExpense(Login.User);
            MinLabel.Text = "$" + minExpense.ToString();
        }

        private void GetAvgExp()// This method gets and displays the average expense for the logged-in user.
        {
            var result = dbHandler.GetSumAndCount(Login.User);
            double sum = result.sum;
            int count = result.count;

            if (count != 0)  // Check to prevent division by zero
            {
                double Avg = sum / count;
                CountLabel.Text = "You have Recorded " + count.ToString() + " Expenses";
                AvgLabel.Text = "$" + Avg;
            }
            else
            {
                CountLabel.Text = "You have Recorded 0 Expenses";
                AvgLabel.Text = "$0";
            }
        }

        private void GetTotExp()// This method gets and displays the total expense for the logged-in user.
        {
            decimal totalExpense = dbHandler.GetTotExpense(Login.User);
            TotalLabel.Text = "$" + totalExpense.ToString();
        }


        private void GetHighestByCate()// This method gets and displays the category with the highest expense for the logged-in user.
        {
            string highestCategory = dbHandler.GetHighestExpenseCategory(Login.User);
            HighestCate.Text = highestCategory;
        }

        private void GetLowestByCate()// This method gets and displays the category with the lowest expense for the logged-in user.
        {
            string lowestCategory = dbHandler.GetLowestExpenseCategory(Login.User);
            LowestCate.Text = lowestCategory;
        }

        private void GetTotalExpByCate()// This method gets and displays the total expense for a selected category for the logged-in user.
        {
            decimal totalByCategory = dbHandler.GetTotalExpenseByCategory(Login.User, ExpenseCate2.SelectedItem.ToString());
            TotalByCate.Text = "$" + totalByCategory.ToString();
            TotalByCate.Visible = true;
        }

        // Event handler for when a selection is made in ExpenseCate2.
        // It calls GetTotalExpByCate() to update the total expense display for that category.
        private void ExpenseCate2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetTotalExpByCate();
        }

        // Event handler for BackToMainBtn button click event. It hides this form when clicked.
        private void BackToMainBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        // Event handler for FormClosing event. It exits the application when this form closes.
        private void Reports_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
