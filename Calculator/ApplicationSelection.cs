using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class windowApplicationSelection : Form
    {
        public windowApplicationSelection()
        {
            InitializeComponent();
        }

        private void btnCalculator_Click(object sender, EventArgs e)
        {
            Hide();
            windowCalc frm = new windowCalc();
            frm.ShowDialog();
            Dispose();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        Point lastPoint;
        private void windowApplicationSelection_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Left += e.X - lastPoint.X;
                Top += e.Y - lastPoint.Y;
            }
        }

        private void windowApplicationSelection_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void btnEncryption_Click(object sender, EventArgs e)
        {
            Hide();
            windowEncryption frm = new windowEncryption(new Encryption());
            frm.ShowDialog();
            Dispose();
        }

        private void btnGuesser_Click(object sender, EventArgs e)
        {
            Hide();
            windowPositionGuesser frm = new windowPositionGuesser();
            frm.ShowDialog();
            Dispose();
        }
    }
}
