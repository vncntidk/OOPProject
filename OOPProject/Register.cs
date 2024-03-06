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
    public partial class FormRegister : Form
    {
        private Point initialMousePosition;
        private bool dragging;
        public FormRegister()
        {
            InitializeComponent();
            dragging = false;

            this.MouseDown += BorderlessForm_MouseDown;
            this.MouseMove += BorderlessForm_MouseMove;
            this.MouseUp += BorderlessForm_MouseUp;
        }

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db_users.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

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
        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pcmin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "" && txtPass.Text == "" && txtConPass.Text == "")
            {
                MessageBox.Show("Please fill in all fields.", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtPass.Text == txtConPass.Text)
            {
                con.Open();
                string register = "INSERT INTO tbl_users VALUES('" + txtUser.Text + "','" + txtPass.Text + "')";
                cmd = new OleDbCommand(register, con);
                cmd.ExecuteNonQuery();
                con.Close();

                txtUser.Text = "";
                txtPass.Text = "";
                txtConPass.Text = "";

                MessageBox.Show("Your account has been successfully created", "Registration Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Password does not match", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtConPass.Text = "";
                txtPass.Text = "";
                txtPass.Focus();
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                txtPass.PasswordChar = '\0';
                txtConPass.PasswordChar = '\0';
            }
            else
            {
                txtPass.PasswordChar = '•';
                txtConPass.PasswordChar = '•';
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            new FormLog().Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
