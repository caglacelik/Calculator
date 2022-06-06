using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsApp8
{
    public partial class windowLogin : Form
    {
        private System.Windows.Forms.Timer _formClosingTimer;

        public windowLogin()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            UserManager userManager = UserManager.CreateAsSingleton();

            if (userManager.Login(txtUsername.Text, txtPassword.Text))
            {
                lblState.Text = "Success!";
                lblState.ForeColor = Color.Green;
                SetFormTimer();
                AnimateProgBar(1500);
            }
            else
            {
                lblState.Text = "Fail!";
                lblState.ForeColor = Color.Red;
            }
        }

        private void SetFormTimer()
        {
            _formClosingTimer = new System.Windows.Forms.Timer();  // Creating a new timer 
            _formClosingTimer.Tick += new EventHandler(CloseForm); // Defining tick event to invoke after a time period
            _formClosingTimer.Interval = 3000; // Time Interval in miliseconds
            _formClosingTimer.Start(); // Starting a timer
        }

        private void CloseForm(object sender, EventArgs e)
        {
            _formClosingTimer.Stop(); // Stoping timer. If we dont stop, function will be triggered in regular intervals
            _formClosingTimer.Enabled = false;
            Hide(); // Closing the current form
            windowApplicationSelection frm = new windowApplicationSelection();
            frm.ShowDialog();
            Dispose();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            btnLogin.Enabled = true;

            if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                btnLogin.Enabled = false;
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            btnLogin.Enabled = true;

            if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                btnLogin.Enabled = false;
            }
        }

        private void lblSignUp_Click(object sender, EventArgs e)
        {
            Hide();
            windowSignup frm = new windowSignup();
            frm.ShowDialog();
            Close();
        }

        Point lastPoint;
        private void windowLogin_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Left += e.X - lastPoint.X;
                Top += e.Y - lastPoint.Y;
            }
        }

        private void windowLogin_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void progressTimer_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
            {
                progressBar1.Value += 1;
                progressBar1.Refresh();
            }
            else
            {
                progressTimer.Enabled = false;
            }
        }

        public void AnimateProgBar(int milliSeconds)
        {
            if (!progressTimer.Enabled)
            {
                progressBar1.Value = 0;
                progressTimer.Interval = milliSeconds / 100;
                progressTimer.Enabled = true;
            }
        }
    }
}
