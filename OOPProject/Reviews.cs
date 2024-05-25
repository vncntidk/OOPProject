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
using System.Xml.Linq;

namespace OOPProject
{
    public partial class Reviews : Form
    {
        private string username;
        private string recipeName;
        private Form currentMenu;
        private Form currMenu;
        private string sortingDirection = "Ascending";
        public Reviews(string loggedInUsername, string selectedRecipe)
        {
            InitializeComponent();
            username = loggedInUsername;
            recipeName = selectedRecipe;
            ratingStar.Enabled = false;
            LoadProfilePicture(username, pbxProfile);
            OpenForm(new Comments(username, recipeName));
            Toggle.Checked = true;
        }

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=RecipeCatalogdb.mdb");
        OleDbCommand cmd = new OleDbCommand();

        private void Reviews_Load(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd.Connection = con;

                LoadRatings();
                CheckFeedback(username, recipeName);

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading ratings and feedback: " + ex.Message);
            }
        }

        private void OpenForm(Form current)
        {
            if (currMenu != null)
            {
                currMenu.Close();
            }

            currMenu = current;
            current.TopLevel = false;
            current.FormBorderStyle = FormBorderStyle.None;
            current.Dock = DockStyle.Fill;
            panelRecent.Controls.Add(current);
            panelRecent.Tag = current;
            current.BringToFront();
            current.Show();
        }

        private void OpenSortedComm(Form currents)
        {
            if (currentMenu != null)
            {
                currentMenu.Close();
            }

            currentMenu = currents;
            currents.TopLevel = false;
            currents.FormBorderStyle = FormBorderStyle.None;
            currents.Dock = DockStyle.Fill;
            panelDisplay.Controls.Add(currents);
            panelDisplay.Tag = currents;
            currents.BringToFront();
            currents.Show();
        }

        private void ratingStar_ValueChanged(object sender, EventArgs e)
        {

        }

        private void LoadRatings()
        {
            try
            {
                 
                cmd.CommandText = "SELECT AVG(rating), COUNT(*) FROM feedback WHERE recipeName = @recipe";
                cmd.Parameters.AddWithValue("@recipe", recipeName);
                OleDbDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                     
                    double averageRating = reader.IsDBNull(0) ? 0 : Convert.ToDouble(reader[0]);
                    lblRatings.Text = averageRating.ToString("0.0");

                     
                    int totalReviews = Convert.ToInt32(reader[1]);
                    lblReviews.Text = totalReviews.ToString();

                     
                    ratingStar.Value = (float)averageRating;
                }
                else
                {
                    lblRatings.Text = "N/A";
                    ratingStar.Value = 0;
                    lblReviews.Text = "0";
                }
                reader.Close();

                 
                cmd.CommandText = "SELECT COUNT(*) FROM feedback WHERE recipeName = @recipe";
                int totalRatings = Convert.ToInt32(cmd.ExecuteScalar());

                 
                for (int i = 1; i <= 5; i++)
                {
                     
                    cmd.CommandText = "SELECT COUNT(*) FROM feedback WHERE recipeName = @recipe AND rating = @rating";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@recipe", recipeName);
                    cmd.Parameters.AddWithValue("@rating", i);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                     
                    double percentage = (totalRatings > 0) ? (count / (double)totalRatings) * 100 : 0;

                     
                    Guna.UI2.WinForms.Guna2ProgressBar progressBar = (Guna.UI2.WinForms.Guna2ProgressBar)this.Controls.Find("pb" + i.ToString(), true).FirstOrDefault();
                    if (progressBar != null)
                    {
                        progressBar.Value = (int)percentage;
                    }
                }
            }
            catch (Exception ex)
            {
            }
            finally
            {
                con.Close();
            }
        }

        private void CheckFeedback(string username, string recipeName)
        {
            try
            {
                con.Open();
                OleDbCommand cmd = new OleDbCommand("SELECT feedback, rating FROM Feedback WHERE username = @username AND recipeName = @recipeName", con);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@recipeName", recipeName);

                OleDbDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                     
                    tbxFeedback.Text = reader["feedback"].ToString();
                    starRatings.Value = Convert.ToInt32(reader["rating"]);
                    btnSubmit.Hide();
                    starRatings.Enabled = false;
                    tbxFeedback.Enabled = false;
                }
                else
                {
                     
                    tbxFeedback.Text = "";
                    starRatings.Value = 0;
                    btnSubmit.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error checking feedback: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }


        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbxFeedback.Text))
            {
                MessageBox.Show("Please provide feedback.", "Missing Feedback", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=RecipeCatalogdb.mdb"))
            {
                try
                {
                    DateTime currentDate = DateTime.Now;

                    con.Open();
                    using (OleDbCommand cmd = new OleDbCommand())
                    {
                        cmd.Connection = con;
                        cmd.CommandText = "INSERT INTO feedback (feedback, rating, dateSubmitted, recipeName, username) VALUES (@feedback, @rating, @dateSubmitted, @recipeName, @username)";
                        cmd.Parameters.AddWithValue("@feedback", tbxFeedback.Text);
                        cmd.Parameters.AddWithValue("@rating", starRatings.Value);
                        cmd.Parameters.AddWithValue("@dateSubmitted", currentDate.ToShortDateString());
                        cmd.Parameters.AddWithValue("@recipeName", recipeName);
                        cmd.Parameters.AddWithValue("@username", username);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Your review has been submitted successfully.", "Review Submitted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            starRatings.Value = 0;
                            tbxFeedback.Text = string.Empty;

                            LoadRatings();

                            string updateQuery = "UPDATE views SET comments = comments + 1 WHERE recipeName = ?";
                            cmd.CommandText = updateQuery;
                            cmd.Parameters.Clear();
                            cmd.Parameters.AddWithValue("@recipeName", recipeName);
                            cmd.ExecuteNonQuery();

                            double averageRating = CalculateAverageRating(con, recipeName);

                            UpdateRecipeAverageRating(con, recipeName, averageRating);
                        }
                        else
                        {
                            MessageBox.Show("Failed to submit your review. Please try again.", "Review Submission Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error submitting review: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private double CalculateAverageRating(OleDbConnection con, string recipeName)
        {
            double averageRating = 0.0;
            using (OleDbCommand cmd = new OleDbCommand("SELECT AVG(rating) FROM feedback WHERE recipeName = @recipeName", con))
            {
                cmd.Parameters.AddWithValue("@recipeName", recipeName);
                object result = cmd.ExecuteScalar();
                if (result != DBNull.Value)
                {
                    averageRating = Convert.ToDouble(result);
                }
            }
            return averageRating;
        }

        private void UpdateRecipeAverageRating(OleDbConnection con, string recipeName, double averageRating)
        {
            using (OleDbCommand cmd = new OleDbCommand("UPDATE recipe SET recipeAve = @averageRating WHERE recipeName = @recipeName", con))
            {
                cmd.Parameters.AddWithValue("@averageRating", averageRating);
                cmd.Parameters.AddWithValue("@recipeName", recipeName);
                cmd.ExecuteNonQuery();
            }
        }

        private void LoadProfilePicture(string username, PictureBox pictureBox)
        {
            using (OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=RecipeCatalogdb.mdb"))
            {
                try
                {
                    con.Open();
                    using (OleDbCommand cmd = new OleDbCommand())
                    {
                        cmd.Connection = con;
                        cmd.CommandText = "SELECT profilePic FROM profile WHERE Username = @username";
                        cmd.Parameters.AddWithValue("@username", username);

                         
                        object result = cmd.ExecuteScalar();

                         
                        if (result != null && result != DBNull.Value)
                        {
                            byte[] imageData = (byte[])result;
                            using (MemoryStream ms = new MemoryStream(imageData))
                            {
                                pictureBox.Image = Image.FromStream(ms);
                            }
                        }
                        else
                        {
                             
                             
                             
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading profile picture: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Toggle_CheckedChanged(object sender, EventArgs e)
        {
             
            sortingDirection = Toggle.Checked ? "Ascending" : "Descending";

            OpenSortedComm(new SortedComments(username, recipeName, sortingDirection));

            lblSortOrder.Text = "Sort Order: " + (Toggle.Checked ? "Ascending" : "Descending");
        }
    }
}