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
    public partial class SearchIngredients : Form
    {
        private string username;
        public SearchIngredients(string loggedIn)
        {
            InitializeComponent();
            username = loggedIn;
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
                string query = "SELECT * FROM ingredient";

                string filter = guna2ComboBox1.SelectedItem.ToString();

                string orderByClause = "";
                if (filter == "Ascending")
                {
                    orderByClause = " ORDER BY Val(IngredientPrice) ASC";
                }
                else if (filter == "Descending")
                {
                    orderByClause = " ORDER BY Val(IngredientPrice) DESC";
                }

                cmd.CommandText = query;
                cmd.Connection = con;

                da.SelectCommand = cmd;
                ds.Clear();
                da.Fill(ds, "ingredient");
                dgvReport.DataSource = ds.Tables["ingredient"];

                dgvReport.Columns["IngredientName"].HeaderText = "Name of the Ingredient";
                dgvReport.Columns["IngredientAmount"].HeaderText = "Amount";
                dgvReport.Columns["IngredientPrice"].HeaderText = "Price";
                dgvReport.Columns["recipeName"].HeaderText = "Name of the Recipe";
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

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {
            string searchText = guna2TextBox2.Text.Trim();
            if (searchText != "")
            {
                DataView dv = ds.Tables["ingredient"].DefaultView;
                dv.RowFilter = $"username LIKE '%{searchText}%' OR IngredientName LIKE '%{searchText}%' OR IngredientAmount LIKE '%{searchText}%' OR IngredientPrice LIKE '%{searchText}%' OR recipeName LIKE '%{searchText}%'";
                dgvReport.DataSource = dv.ToTable();
            }
            else
            {
                dgvReport.DataSource = ds.Tables["ingredient"];
            }
            LoadUsersData();
        }

        private void btnVisit_Click(object sender, EventArgs e)
        {
            string ownerName = dgvReport.SelectedRows[0].Cells["username"].Value.ToString();
            string recipeName = dgvReport.SelectedRows[0].Cells["recipeName"].Value.ToString();

            ViewRecipes viewRecipesForm = new ViewRecipes(username, ownerName, recipeName);
            viewRecipesForm.Show();
        }
    }
}
