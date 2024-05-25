using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheArtOfDevHtmlRenderer.Adapters;

namespace OOPProject
{
    public partial class Admin : Form
    {
        private string username;
        private Form currentMenu;
        public Admin(string loggedInUsername)
        {
            InitializeComponent();
            username = loggedInUsername;

        }

        private void OpenForm(Form current)
        {
            if (currentMenu != null)
            {
                currentMenu.Close();
            }

            currentMenu = current;
            current.TopLevel = false;
            current.FormBorderStyle = FormBorderStyle.None;
            current.Dock = DockStyle.Fill;
            paneldisplay.Controls.Add(current);
            paneldisplay.Tag = current;
            current.BringToFront();
            current.Show();
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            OpenForm(new Users());
        }

        private void btnRep_Click(object sender, EventArgs e)
        {
            OpenForm(new ReportAdmin());
        }

        private void btnSuggest_Click(object sender, EventArgs e)
        {
            OpenForm(new Suggestion());
        }

        private void Admin_SizeChanged(object sender, EventArgs e)
        {
            int buttonWidth = guna2Panel2.Width / 3;

            btnRep.Width = buttonWidth;
            btnSuggest.Width = buttonWidth;
            guna2Button1.Width = buttonWidth;
        }
    }
}
