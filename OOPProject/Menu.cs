using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPProject
{
    public partial class FormMenu : Form
    {
        private Point initialMousePosition;
        private bool dragging;
        public FormMenu()
        {
            InitializeComponent();

            this.MouseDown += BorderlessForm_MouseDown;
            this.MouseMove += BorderlessForm_MouseMove;
            this.MouseUp += BorderlessForm_MouseUp;
        }

        private void BorderlessForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                initialMousePosition = e.Location;
                dragging = true;
            }
        }

        private void BorderlessForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point delta = new Point(e.X - initialMousePosition.X, e.Y - initialMousePosition.Y);
                this.Location = new Point(this.Location.X + delta.X, this.Location.Y + delta.Y);
            }
        }

        private void BorderlessForm_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                dragging = false;
            }
        }

        private void plSideMenu_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
