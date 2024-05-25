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
    public partial class SearchCuisine : Form
    {
        public SearchCuisine()
        {
            InitializeComponent();
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
                string query = "SELECT * FROM cuisine";


                cmd.CommandText = query;
                cmd.Connection = con;

                da.SelectCommand = cmd;
                ds.Clear();
                da.Fill(ds, "cuisine");
                dgvReport.DataSource = ds.Tables["cuisine"];

                dgvReport.Columns["username"].HeaderText = "Usernames";
                dgvReport.Columns["cuisine"].HeaderText = "Cuisine Name";
                dgvReport.Columns["recipeCount"].HeaderText = "Number of Recipes";
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
            string username = dgvReport.SelectedRows[0].Cells["username"].Value.ToString();
            string cuisineName = dgvReport.SelectedRows[0].Cells["cuisine"].Value.ToString();
            ViewRecipeHome specRecipesForm = new ViewRecipeHome(username, cuisineName);
            specRecipesForm.Show();
        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {
            string searchText = guna2TextBox2.Text.Trim();
            if (searchText != "")
            {
                DataView dv = ds.Tables["cuisine"].DefaultView;
                dv.RowFilter = $"username LIKE '%{searchText}%' OR cuisine LIKE '%{searchText}%' OR Convert(recipeCount, 'System.String') LIKE '%{searchText}%'";
                dgvReport.DataSource = dv.ToTable();
            }
            else
            {
                dgvReport.DataSource = ds.Tables["cuisine"];
            }
            LoadUsersData();
        }
    }
}
