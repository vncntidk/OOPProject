using FontAwesome.Sharp;
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
    public partial class theReply : Form
    {
        private string username;
        public theReply(string loggedUser)
        {
            InitializeComponent();
            username = loggedUser;
        }
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=RecipeCatalogdb.mdb");
        OleDbCommand cmd = new OleDbCommand();
        private void theReply_Load(object sender, EventArgs e)
        {
            LoadReplies();
        }

        private void LoadReplies()
        {
            try
            {
                OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=RecipeCatalogdb.mdb");
                con.Open();

                 
                string replyQuery = "SELECT reply FROM reply WHERE username = @username";
                OleDbCommand cmd = new OleDbCommand(replyQuery, con);
                cmd.Parameters.AddWithValue("@username", username);
                object replyResult = cmd.ExecuteScalar();

                if (replyResult != null)
                {
                    lblReply.Text = replyResult.ToString();
                }

                 
                string replySuggQuery = "SELECT reply FROM replysug WHERE username = @username";
                cmd = new OleDbCommand(replySuggQuery, con);
                cmd.Parameters.AddWithValue("@username", username);
                replyResult = cmd.ExecuteScalar();

                if (replyResult != null)
                {
                    lblReply.Text = replyResult.ToString();
                }
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                 
                string deleteReplyQuery = "DELETE FROM reply WHERE username = @username";
                cmd = new OleDbCommand(deleteReplyQuery, con);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.ExecuteNonQuery();

                 
                string deleteReplySuggQuery = "DELETE FROM replysug WHERE username = @username";
                cmd = new OleDbCommand(deleteReplySuggQuery, con);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.ExecuteNonQuery();

                 
                MessageBox.Show("Replies deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                 
                lblReply.Text = "";
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
    }
}
