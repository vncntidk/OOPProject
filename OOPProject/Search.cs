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
    public partial class Search : Form
    {
        private string selectedCategory = "";
        private string selectedDifficulty = "";
        private Form currentMenu;
        private string username;
        public Search(string loggedUser)
        {
            InitializeComponent();
            username = loggedUser;
            cbxCategory.SelectedItem = "Cuisine";
            OpenForm(new SearchCuisine());
        }

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=RecipeCatalogdb.mdb");
        OleDbCommand cmd = new OleDbCommand();
        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {

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
            panel1.Controls.Add(current);
            panel1.Tag = current;
            current.BringToFront();
            current.Show();
        }
        private void btnSort_Click(object sender, EventArgs e)
        {

        }
        private void cbxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCategory = cbxCategory.SelectedItem.ToString();

            if (selectedCategory == "Cuisine")
            {
                OpenForm(new SearchCuisine());
            }
            else if (selectedCategory == "Recipe")
            {
                OpenForm(new SearchRecipe(username));
            }
            else if (selectedCategory == "Ingredient")
            {
                OpenForm(new SearchIngredients(username));
            }
        }

        private void cbxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
