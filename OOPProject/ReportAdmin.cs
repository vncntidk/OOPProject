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
    public partial class ReportAdmin : Form
    {
        public ReportAdmin()
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
                string query = "SELECT * FROM report";

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
                da.Fill(ds, "report");
                dgvReport.DataSource = ds.Tables["report"];

                dgvReport.Columns["username"].HeaderText = "Usernames";
                dgvReport.Columns["bugReport"].HeaderText = "Bug Reports";
                dgvReport.Columns["dateSubmitted"].HeaderText = "Date of Report";
                dgvReport.Columns["status"].HeaderText = "Status";
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
        private void dgvReport_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (dgvReport.SelectedRows.Count > 0)
            {
                 
                string username = dgvReport.SelectedRows[0].Cells["username"].Value.ToString();
                string bugReport = dgvReport.SelectedRows[0].Cells["bugReport"].Value.ToString();

                 
                Replied replyForm = new Replied(username, bugReport);
                replyForm.Show();
            }
            else
            {
                MessageBox.Show("Please select a row from the report.");
            }
            LoadUsersData();
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadUsersData();
        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
