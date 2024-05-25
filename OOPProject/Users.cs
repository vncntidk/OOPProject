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
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
            LoadUsersData();
        }

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=RecipeCatalogdb.mdb");
        OleDbCommand cmd = new OleDbCommand();
        DataSet ds = new DataSet();
        OleDbDataAdapter da = new OleDbDataAdapter();
        private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LoadUsersData()
        {
            try
            {
                con.Open();
                string query = "SELECT * FROM Users";
                cmd.CommandText = query;
                cmd.Connection = con;

                da.SelectCommand = cmd;
                ds.Clear();
                da.Fill(ds, "Users");
                dgvUsers.DataSource = ds.Tables["Users"];

                dgvUsers.Columns["username"].HeaderText = "Username";
                dgvUsers.Columns["profileName"].HeaderText = "Name";
                dgvUsers.Columns["registeredDate"].HeaderText = "Date of Registration";
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

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count > 0)  
            {
                string username = dgvUsers.SelectedRows[0].Cells["username"].Value.ToString();
                ShowProfile profileForm = new ShowProfile(username);
                profileForm.Show();
            }
            else
            {
                MessageBox.Show("Please select a user from the list.");
            }
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            string searchText = guna2TextBox1.Text.Trim();
            if (searchText != "")
            {
                DataView dv = ds.Tables["Users"].DefaultView;
                dv.RowFilter = $"username LIKE '%{searchText}%' OR profileName LIKE '%{searchText}%' OR Convert(registeredDate, 'System.String') LIKE '%{searchText}%'";
                dgvUsers.DataSource = dv.ToTable();
            }
            else
            {
                dgvUsers.DataSource = ds.Tables["Users"];
            }
        }
    }
}
