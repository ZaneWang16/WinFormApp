using Microsoft.Extensions.Logging;

namespace ExpenseTracker
{
    public partial class Starting : Form
    {// The Starting class is a Form that handles the loading screen of the application.
        public Starting()
        {
            InitializeComponent();
        }

        int startTime = 0;// Variable to keep track of the loading progress.

        // Event handler for the Loadingtimer Tick event. This method is called every time the Loadingtimer ticks (every interval).
        private void Loadingtimer_Tick(object sender, EventArgs e)
        {
            startTime += 4;// Increase the loading progress
            LoadingProgress.Value = startTime;

            if (LoadingProgress.Value == 100) // If the loading progress has reached 100, stop the timer,
                                              // create a new instance of the Login form, hide the current form,
                                              // and show the Login form.
            {
                LoadingProgress.Value = 0;
                Loadingtimer.Stop();
                Login login = new Login();
                this.Hide();
                login.Show();
            }
        }

        // Event handler for the Load event of the Starting form. called when the Starting form is loaded.
        private void Starting_Load(object sender, EventArgs e)
        {
            Loadingtimer.Start();
        }


    }
}