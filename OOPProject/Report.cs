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
    public partial class Report : Form
    {
        private string username;
        public Report(string loggedInUsername)
        {
            InitializeComponent();
            username = loggedInUsername;
        }
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=RecipeCatalogdb.mdb");
        OleDbCommand cmd = new OleDbCommand();
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                string reason = cbxReason.SelectedItem.ToString();
                string reportField = reason == "Bug Report" ? "bugReport" : "suggestion";
                string tableName = reason == "Bug Report" ? "report" : "suggestion";

                DateTime currentDate = DateTime.Now;

                string status = "Pending";

                string query = $"INSERT INTO {tableName} (username, {reportField}, dateSubmitted, status) VALUES (?, ?, ?, ?)";

                cmd = new OleDbCommand(query, con);
                cmd.Parameters.AddWithValue("@p1", username);
                cmd.Parameters.AddWithValue("@p2", tbxReport.Text); 
                cmd.Parameters.AddWithValue("@p3", currentDate.ToShortDateString());
                cmd.Parameters.AddWithValue("@p4", status);

                cmd.ExecuteNonQuery();

                MessageBox.Show($"{reason} submitted successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();

                cbxReason.SelectedItem = "";
                tbxReport.Text = "";
            }
        }
    }
}
