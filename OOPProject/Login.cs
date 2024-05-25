using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace OOPProject
{
    public partial class FormLog : Form
    {
        private Point initialMousePosition;
        private bool dragging;
        public FormLog()
        {
            InitializeComponent();
            dragging = false;

            this.MouseDown += BorderlessForm_MouseDown;
            this.MouseMove += BorderlessForm_MouseMove;
            this.MouseUp += BorderlessForm_MouseUp;
        }

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=RecipeCatalogdb.mdb");
        OleDbCommand cmd = new OleDbCommand();

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

        private void pcmin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void FormLog_Load(object sender, EventArgs e)
        {
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            con.Open();
            string login = "SELECT * FROM [user] WHERE username='" + txtUser.Text + "' and password= '" + txtPass.Text + "'";
            cmd = new OleDbCommand(login, con);
            OleDbDataReader dr = cmd.ExecuteReader();

            if (dr.Read() == true)
            {
                string username = GetLoggedInUsername();
                MessageBox.Show($"Welcome {username}!", "Login Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                new CuisineMenu(username);
                new FormMenu(username).Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtPass.Text = "";
                txtUser.Text = "";
                txtUser.Focus();
            }
            con.Close();
        }

        private string GetLoggedInUsername()
        {
            return txtUser.Text;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                txtPass.PasswordChar = '\0';
            }
            else
            {
                txtPass.PasswordChar = '•';
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            new FormRegister().Show();
            this.Hide();
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.TransparencyKey = Color.FromKnownColor(KnownColor.Control);
            this.Update();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
