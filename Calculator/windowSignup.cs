using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class windowSignup : Form
    {
        public windowSignup()
        {
            InitializeComponent();

            foreach (Control control in Controls)
            {
                if (control.GetType() == typeof(TextBox))
                {
                    control.TextChanged += CheckIfTextBoxEmpty;
                }
            }
        }

        private void CheckIfTextBoxEmpty(object sender, EventArgs e)
        {
            btnSignup.Enabled = true;

            if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text) || string.IsNullOrWhiteSpace(txtConfirmPassword.Text))
            {
                btnSignup.Enabled = false;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            Dispose();
        }

        Point lastPoint;
        private void windowSignup_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Left += e.X - lastPoint.X;
                Top += e.Y - lastPoint.Y;
            }
        }

        private void windowSignup_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                lblInfo.Text = "Passwords doesn't match!";
                lblInfo.ForeColor = Color.Red;
                return;
            }

            UserManager userManager = UserManager.CreateAsSingleton();

            if (!userManager.SignUp(txtUsername.Text, txtPassword.Text))
            {
                lblInfo.Text = "Username already exists!";
                lblInfo.ForeColor = Color.Red;
                return;
            }

            lblInfo.Text = "Success";
            lblInfo.ForeColor = Color.Green;

            Hide();
            windowLogin frm = new windowLogin();
            frm.ShowDialog();
            Dispose();
        }
    }
}
