using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class windowCalc : Form
    {
        public windowCalc()
        {
            InitializeComponent();

            foreach (Control c in Controls)
            {
                if (c.GetType() == typeof(Button))
                {
                    c.MouseEnter += ChangeTextColor;
                    c.MouseLeave += SetTextColorToDefault;
                    c.Click += SetButtonColor;
                }
            }
        }

        private void SetButtonColor(object sender, EventArgs e)
        {
            foreach (Control control in Controls)
            {
                if (control.GetType() == typeof(Button))
                {
                    control.BackColor = SystemColors.Menu;
                }
            }

            (sender as Button).BackColor = Color.PaleTurquoise;
        }

        private void SetTextColorToDefault(object sender, EventArgs e)
        {
            (sender as Button).ForeColor = SystemColors.ControlText;
        }

        private void ChangeTextColor(object sender, EventArgs e)
        {
            (sender as Button).ForeColor = Color.Red;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            Dispose();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblOperator.Text = "";
            lblEquals.Visible = false;
            lblResult.Text = "";
            txtFirstNum.Clear();
            txtSecondNum.Clear();
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            if (Calculator.Validate(txtFirstNum.Text, txtSecondNum.Text))
            {
                lblResult.Text = Calculator.Add(Convert.ToDouble(txtFirstNum.Text), Convert.ToDouble(txtSecondNum.Text)).ToString();
                lblEquals.Visible = true;
                lblOperator.Text = "+";

                ChangeColor();
            }
        }

        private void btnSubs_Click(object sender, EventArgs e)
        {
            if (Calculator.Validate(txtFirstNum.Text, txtSecondNum.Text))
            {
                lblEquals.Visible = true;
                lblOperator.Text = "-";
                lblResult.Text = Calculator.Subs(Convert.ToDouble(txtFirstNum.Text), Convert.ToDouble(txtSecondNum.Text)).ToString();

                ChangeColor();
            }
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            if (Calculator.Validate(txtFirstNum.Text, txtSecondNum.Text))
            {
                lblOperator.Text = "/";
                try
                {
                    lblResult.Text = string.Format("{0:0.00}", Calculator.Div(Convert.ToDouble(txtFirstNum.Text), Convert.ToDouble(txtSecondNum.Text)));
                    lblEquals.Visible = true;
                    ChangeColor();
                }
                catch (DivideByZeroException)
                {
                    lblResult.Text = "Error";
                    lblResult.BackColor = Color.Red;
                }
            }
        }

        private void btnMultip_Click(object sender, EventArgs e)
        {
            if (Calculator.Validate(txtFirstNum.Text, txtSecondNum.Text))
            {
                lblEquals.Visible = true;
                lblOperator.Text = "*";
                lblResult.Text = Calculator.Multip(Convert.ToDouble(txtFirstNum.Text), Convert.ToDouble(txtSecondNum.Text)).ToString();

                ChangeColor();
            }
        }

        private void ChangeColor()
        {
            if (Convert.ToDouble(lblResult.Text) > 0)
            {
                lblResult.BackColor = Color.LightGreen;
            }
            else lblResult.BackColor = Color.Red;
        }

        private void txtFirstNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ',') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '-') && ((sender as TextBox).Text.IndexOf('-') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtSecondNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ',') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '-') && ((sender as TextBox).Text.IndexOf('-') > -1))
            {
                e.Handled = true;
            }
        }

        Point lastPoint;
        private void windowCalc_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Left += e.X - lastPoint.X;
                Top += e.Y - lastPoint.Y;
            }
        }

        private void windowCalc_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Hide();
            windowApplicationSelection frm = new windowApplicationSelection();
            frm.ShowDialog();
            Dispose();
        }
    }
}
