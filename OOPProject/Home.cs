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

namespace OOPProject
{
    public partial class Home : Form
    {
        private string username;
        private Form currentMenu;

        public Home(string loggedInUsername)
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
            splitContainer1.Panel2.Controls.Add(current);
            splitContainer1.Panel2.Tag = current;
            current.BringToFront();
            current.Show();
        }
        public void ReplaceForm(Form newForm)
        {
            if (currentMenu != null)
            {
                currentMenu.Close();
            }

            currentMenu = newForm;
            newForm.TopLevel = false;
            newForm.FormBorderStyle = FormBorderStyle.None;
            newForm.Dock = DockStyle.Fill;
            splitContainer1.Panel2.Controls.Add(newForm);
            splitContainer1.Panel2.Tag = newForm;
            newForm.BringToFront();
            newForm.Show();
        }
        private void Home_Load(object sender, EventArgs e)
        {
            OpenForm(new ViewPopular(username));
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            OpenForm(new Search(username));
        }
    }
}
