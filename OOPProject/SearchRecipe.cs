using Guna.UI2.WinForms;
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
    public partial class SearchRecipe : Form
    {
        private string username;
        public SearchRecipe(string usern)
        {
            InitializeComponent();
            username = usern;
            guna2ComboBox1.SelectedItem = "Descending";
            LoadUsersData();
        }

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=RecipeCatalogdb.mdb");
        OleDbCommand cmd = new OleDbCommand();
        DataSet ds = new DataSet();
        OleDbDataAdapter da = new OleDbDataAdapter();

        private void LoadUsersData()
        {
            try
            {
                con.Open();
                string filter = guna2ComboBox1.SelectedItem.ToString();
                string query = "SELECT * FROM recipe";

                if (filter == "Descending")
                {
                    query += " WHERE recipeAve BETWEEN 1 AND 5 ORDER BY recipeAve DESC";  
                }
                else if (filter == "Ascending")
                {
                    query += " WHERE recipeAve BETWEEN 1 AND 5 ORDER BY recipeAve ASC";  
                }

                cmd.CommandText = query;
                cmd.Connection = con;

                da.SelectCommand = cmd;
                ds.Clear();
                da.Fill(ds, "recipe");
                dgvReport.DataSource = ds.Tables["recipe"];

                dgvReport.Columns["username"].HeaderText = "Usernames";
                dgvReport.Columns["recipeName"].HeaderText = "Name of the Recipe";
                dgvReport.Columns["publishDate"].HeaderText = "Publish Date";
                dgvReport.Columns["recipeAve"].HeaderText = "Ratings";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnVisit_Click(object sender, EventArgs e)
        {
            string ownerName = dgvReport.SelectedRows[0].Cells["username"].Value.ToString();
            string recipeName = dgvReport.SelectedRows[0].Cells["recipeName"].Value.ToString();

            ViewRecipes viewRecipesForm = new ViewRecipes(username, ownerName, recipeName);
            viewRecipesForm.Show();
        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {
            string searchText = guna2TextBox2.Text.Trim();
            if (searchText != "")
            {
                DataView dv = ds.Tables["recipe"].DefaultView;
                dv.RowFilter = $"username LIKE '%{searchText}%' OR recipeName LIKE '%{searchText}%' OR Convert(publishDate, 'System.String') LIKE '%{searchText}%' OR Convert(recipeAve, 'System.String') LIKE '%{searchText}%'";
                dgvReport.DataSource = dv.ToTable();
            }
            else
            {
                dgvReport.DataSource = ds.Tables["recipe"];
            }
            LoadUsersData();
        }
    }
}
