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
    public partial class MainMenu : Form
    { // The MainMenu class is a Form that serves as the mainmenu after user logged the application.
        public MainMenu()
        {
            InitializeComponent();
            this.FormClosing += MainMenu_FormClosing;
            // Display the current day and month on the main menu.
            DayLabel.Text = DateTime.Today.Day.ToString();
            MonthLabel.Text = DateTime.Today.ToString("MMMM");
            // Display a welcome message with the username of the logged-in user.
            UserNameLabel.Text = "Welcome " + Login.User;
        }

        // Event handler for the AddExpenseBtn button click event. called when the AddExpenseBtn button is clicked.
        private void AddExpenseBtn_Click(object sender, EventArgs e)
        {
            Expenses cost = new Expenses();
            cost.Show();
        }

        // Event handler for the VeiwExpBtn button click event. called when the VeiwExpBtn button is clicked.
        private void VeiwExpBtn_Click(object sender, EventArgs e)
        {
            ViewExpense view = new ViewExpense();
            view.Show();
        }

        // Event handler for the ViewRepBtn button click event. called when the ViewRepBtn button is clicked.
        private void ViewRepBtn_Click(object sender, EventArgs e)
        {
            Reports report = new Reports();
            report.Show();
        }

        // Event handler for the LogoutBtn button click event. called when the LogoutBtn button is clicked.
        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            Login logout = new Login();
            logout.Show();
            this.Hide();
        }

        // Event handler for the FormClosing event. called when the form is closing.
        private void MainMenu_FormClosing(object? sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
