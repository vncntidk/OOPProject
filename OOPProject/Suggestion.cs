using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPProject
{
    public partial class Suggestion : Form
    {
        public Suggestion()
        {
            InitializeComponent();
            guna2ComboBox1.SelectedItem = "Pending";
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
                string query = "SELECT * FROM suggestion";

                if (filter == "Pending")
                {
                    query += " WHERE status = 'Pending'";
                }
                else if (filter == "Replied")
                {
                    query += " WHERE status = 'Replied'";
                }

                cmd.CommandText = query;
                cmd.Connection = con;

                da.SelectCommand = cmd;
                ds.Clear();
                da.Fill(ds, "suggestion");
                dgvSuggest.DataSource = ds.Tables["suggestion"];

                dgvSuggest.Columns["username"].HeaderText = "Usernames";
                dgvSuggest.Columns["suggestion"].HeaderText = "Suggestions";
                dgvSuggest.Columns["dateSubmitted"].HeaderText = "Date of Report";
                dgvSuggest.Columns["status"].HeaderText = "Status";
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
            try 
            {
                if (dgvSuggest.SelectedRows.Count > 0)
                {
                     
                    string username = dgvSuggest.SelectedRows[0].Cells["username"].Value.ToString();
                    string suggest = dgvSuggest.SelectedRows[0].Cells["suggestion"].Value.ToString();

                     
                    RepliedSuggest replyForm = new RepliedSuggest(username, suggest);
                    replyForm.Show();
                }
                else
                {
                    MessageBox.Show("Please select a row from the report.");
                }
            }
            catch(Exception ex)
            {

            }
            finally
            {
                LoadUsersData();
            }
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadUsersData();
        }
    }
}
