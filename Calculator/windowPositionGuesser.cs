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
    public partial class windowPositionGuesser : Form
    {
        PositionGuesser _positionGuesser = new PositionGuesser();

        public windowPositionGuesser()
        {
            InitializeComponent();
            lblResult.Text = _positionGuesser.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        Point lastPoint;
        private void windowPositionGuesser_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void windowPositionGuesser_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Left += e.X - lastPoint.X;
                Top += e.Y - lastPoint.Y;
            }
        }

        private void btnNorth_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("North",btnNorth);
        }

        private void btnReset_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Reset", btnReset);
        }

        private void btnNorth_Click(object sender, EventArgs e)
        {
            _positionGuesser.North();
            lblResult.Text = _positionGuesser.ToString();
        }

        private void btnSouth_Click(object sender, EventArgs e)
        {
            _positionGuesser.South();
            lblResult.Text = _positionGuesser.ToString();
        }

        private void btnEast_Click(object sender, EventArgs e)
        {
            _positionGuesser.East();
            lblResult.Text = _positionGuesser.ToString();
        }

        private void btnWest_Click(object sender, EventArgs e)
        {
            _positionGuesser.West();
            lblResult.Text = _positionGuesser.ToString();
        }

        private void btnSouthEast_Click(object sender, EventArgs e)
        {
            _positionGuesser.South();
            _positionGuesser.East();
            lblResult.Text = _positionGuesser.ToString();
        }

        private void btnNorthEast_Click(object sender, EventArgs e)
        {
            _positionGuesser.North();
            _positionGuesser.East();
            lblResult.Text = _positionGuesser.ToString();
        }

        private void btnSouthWest_Click(object sender, EventArgs e)
        {
            _positionGuesser.South();
            _positionGuesser.West();
            lblResult.Text = _positionGuesser.ToString();
        }

        private void btnNorthWest_Click(object sender, EventArgs e)
        {
            _positionGuesser.North();
            _positionGuesser.West();
            lblResult.Text = _positionGuesser.ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            _positionGuesser.ResetGuess();
            lblResult.Text = _positionGuesser.ToString();
        }
    }
}
