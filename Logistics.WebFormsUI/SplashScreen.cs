using System;
using System.Windows.Forms;

namespace Logistics.WebFormsUI
{
    public partial class SplashScreen : Form
    {
        private int ticks = 0;

        public SplashScreen()
        {
            InitializeComponent();
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            progressBar.BringToFront();
            progressBar.Value = 1;
            progressBar.Step = 1; 
            progressBar.Maximum = 100;

            timer.Start();
        }        

        private void timer_Tick(object sender, EventArgs e)
        {
            ticks++;
            progressBar.Value = ticks;
            lblPercentage.Text = "% " + progressBar.Value.ToString();
            
            if (progressBar.Value == 100)
            {
                timer.Stop();

                LoginForm loginForm = new LoginForm();
                loginForm.Show();
                this.Hide();

            }
        }
    }
}
