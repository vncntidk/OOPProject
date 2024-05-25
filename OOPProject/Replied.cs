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
    public partial class Replied : Form
    {
        private string username;
        private string reports;
        private string statusColumnValue = "Replied";
        public Replied(string Username, string bugrep)
        {
            InitializeComponent();
            username = Username;
            reports = bugrep;
        }

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=RecipeCatalogdb.mdb");
        OleDbCommand cmd = new OleDbCommand();

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string reply = tbxReply.Text.Trim();
            if (reply != "")
            {
                try
                {
                    DateTime currentDate = DateTime.Now;

                    con.Open();
                    string query = "INSERT INTO reply (username, bugReport, reply, dateReplied) VALUES (@username, @report, @reply, @replyDate)";
                    OleDbCommand cmd = new OleDbCommand(query, con);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@report", reports);
                    cmd.Parameters.AddWithValue("@reply", reply);
                    cmd.Parameters.AddWithValue("@replyDate", currentDate.ToShortDateString());

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Reply saved successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    con.Close();
                    UpdateStatusToReplied();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Please enter a reply.");
            }
        }

        private void UpdateStatusToReplied()
        {
            try
            {
                con.Open();
                string updateQuery = "UPDATE report SET status = @status WHERE username = @username AND bugReport = @bugReport";
                OleDbCommand updateCmd = new OleDbCommand(updateQuery, con);
                updateCmd.Parameters.AddWithValue("@status", statusColumnValue);
                updateCmd.Parameters.AddWithValue("@username", username);
                updateCmd.Parameters.AddWithValue("@bugReport", reports);
                updateCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating status: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
