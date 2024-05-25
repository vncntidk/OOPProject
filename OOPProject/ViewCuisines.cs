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
    public partial class ViewCuisines : Form
    {
        private Form currentMenu;
        private string ownerName;
        private string username;
        public ViewCuisines(string loggedInUsername)
        {
            InitializeComponent();
            username = loggedInUsername;
        }

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=RecipeCatalogdb.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

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
            panelView.Controls.Add(current);
            panelView.Tag = current;
            current.BringToFront();
            current.Show();
        }
        private void ViewCuisines_Load(object sender, EventArgs e)
        {
            AllCuisines allCuisines = new AllCuisines(username);
            allCuisines.PanelClicked += (s, cuisineName) => OpenSpecRecipes(cuisineName);
            OpenForm(allCuisines);
        }

        private void OpenViewRecipes(string recipeName)
        {
             
            ViewRecipes viewRecipesForm = new ViewRecipes(username, ownerName, recipeName);
            viewRecipesForm.TopLevel = false;
            viewRecipesForm.FormBorderStyle = FormBorderStyle.None;
            viewRecipesForm.Dock = DockStyle.Fill;
            panelView.Controls.Clear();
            panelView.Controls.Add(viewRecipesForm);
            viewRecipesForm.Show();
        }
        private void OpenSpecRecipes(string cuisineName)
        {
             
            SpecRecipes specRecipesForm = new SpecRecipes(username, cuisineName);
            specRecipesForm.PanelClicked += (s, recipeName) => OpenViewRecipes(recipeName);
            specRecipesForm.TopLevel = false;
            specRecipesForm.FormBorderStyle = FormBorderStyle.None;
            specRecipesForm.Dock = DockStyle.Fill;
            panelView.Controls.Clear();
            panelView.Controls.Add(specRecipesForm);
            specRecipesForm.Show();
        }
    }
}
