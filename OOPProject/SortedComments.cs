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

    public partial class SortedComments : Form
    {
        private string username;
        private string recipeName;
        private string sort;
        public SortedComments(string loggedInUsername, string selectedRecipe, string sortOrder)
        {
            InitializeComponent();
            username = loggedInUsername;
            recipeName = selectedRecipe;
            sort = sortOrder;
            DisplayComments();
        }

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=RecipeCatalogdb.mdb");
        OleDbCommand cmd = new OleDbCommand();

        public class Comment
        {
            public string Author { get; set; }
            public DateTime PostDate { get; set; }
            public int Stars { get; set; }
            public string Feedback { get; set; }
            public Image ProfilePicture { get; set; }  
        }

        private void DisplayComments()
        {
            List<Comment> comments = GetCommentsFromDatabase();
            DisplayComments(comments);
        }
        private void DisplayComments(List<Comment> comments)
        {


             
            panelling.Controls.Clear();

             
            for (int i = comments.Count - 1; i >= 0; i--)
            {
                var comment = comments[i];

                 
                Guna.UI2.WinForms.Guna2Panel commentPanel = new Guna.UI2.WinForms.Guna2Panel();
                commentPanel.Size = new Size(618, 206);
                commentPanel.Dock = DockStyle.Top;
                commentPanel.FillColor = Color.FromArgb(255, 245, 237);


                 
                Guna.UI2.WinForms.Guna2CirclePictureBox pbxProfile = new Guna.UI2.WinForms.Guna2CirclePictureBox();
                pbxProfile.Size = new Size(68, 64);
                pbxProfile.Location = new Point(23, 32);
                pbxProfile.BackColor = Color.Transparent;
                pbxProfile.Image = comment.ProfilePicture;  
                pbxProfile.SizeMode = PictureBoxSizeMode.StretchImage;  
                commentPanel.Controls.Add(pbxProfile);

                 
                LinkLabel lnkAuthor = new LinkLabel();
                lnkAuthor.Size = new Size(96, 29);
                lnkAuthor.Font = new Font("Palatino Linotype", 12f, FontStyle.Bold);
                lnkAuthor.LinkColor = Color.DarkSeaGreen;
                lnkAuthor.Location = new Point(117, 28);
                lnkAuthor.BackColor = Color.Transparent;
                lnkAuthor.Text = comment.Author;  
                lnkAuthor.Tag = comment.Author;  
                lnkAuthor.LinkClicked += lnkAuthor_LinkClicked;  
                commentPanel.Controls.Add(lnkAuthor);

                Label lblDate = new Label();
                lblDate.Font = new Font("Palatino Linotype", 10.2f, FontStyle.Italic);
                lblDate.ForeColor = Color.OliveDrab;
                lblDate.Location = new Point(225, 32);
                lblDate.BackColor = Color.Transparent;
                lblDate.Size = new Size(75, 27);
                lblDate.Text = GetRelativeTime(comment.PostDate);
                commentPanel.Controls.Add(lblDate);

                Guna.UI2.WinForms.Guna2RatingStar stars = new Guna.UI2.WinForms.Guna2RatingStar();
                stars.BackColor = Color.FromArgb(255, 245, 237);
                stars.BorderColor = Color.OliveDrab;
                stars.BorderThickness = 2;
                stars.Location = new Point(117, 65);
                stars.BackColor = Color.Transparent;
                stars.Size = new Size(168, 25);
                stars.RatingColor = Color.OliveDrab;
                stars.Value = comment.Stars;
                commentPanel.Controls.Add(stars);

                Label lblFeedback = new Label();
                lblFeedback.BackColor = Color.Transparent;
                lblFeedback.Font = new Font("Palatino Linotype", 10.8f);
                lblFeedback.ForeColor = Color.OliveDrab;
                lblFeedback.Location = new Point(141, 109);
                lblFeedback.Size = new Size(445, 71);
                lblFeedback.Text = comment.Feedback;
                commentPanel.Controls.Add(lblFeedback);

                 
                panelling.Controls.Add(commentPanel);
            }
        }


        private void lnkAuthor_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string clickedUsername = ((LinkLabel)sender).Tag.ToString();

             
            ShowProfile profileForm = new ShowProfile(clickedUsername);
            profileForm.Show();
        }
        private List<Comment> GetCommentsFromDatabase()
        {
            List<Comment> comments = new List<Comment>();

            try
            {
                using (OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=RecipeCatalogdb.mdb"))
                {
                    con.Open();

                     
                    string sortDirection = sort == "Ascending" ? "ASC" : "DESC";
                    string commentsQuery = $"SELECT * FROM Feedbacks WHERE recipeName = @recipeName ORDER BY rating {sortDirection}";

                    using (OleDbCommand commentsCmd = new OleDbCommand(commentsQuery, con))
                    {
                        commentsCmd.Parameters.AddWithValue("@recipeName", recipeName);

                        using (OleDbDataReader reader = commentsCmd.ExecuteReader())
                        {
                             
                            while (reader.Read())
                            {
                                Comment comment = new Comment();
                                comment.Author = reader["username"].ToString();
                                comment.PostDate = Convert.ToDateTime(reader["dateSubmitted"]);
                                comment.Stars = Convert.ToInt32(reader["rating"]);
                                comment.Feedback = reader["feedback"].ToString();

                                comment.ProfilePicture = GetProfilePicture(reader["username"].ToString());

                                 
                                comments.Add(comment);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading comments: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return comments;
        }

        private Image GetProfilePicture(string username)
        {
            Image profilePicture = null;  

            using (OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=RecipeCatalogdb.mdb"))
            {
                con.Open();
                using (OleDbCommand cmd = new OleDbCommand("SELECT profilePic FROM profile WHERE username = @username", con))
                {
                    cmd.Parameters.AddWithValue("@username", username);

                    object result = cmd.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        byte[] imageData = (byte[])result;
                        using (MemoryStream ms = new MemoryStream(imageData))
                        {
                            profilePicture = Image.FromStream(ms);
                        }
                    }
                }
            }

            return profilePicture;
        }

         
        private string GetRelativeTime(DateTime postDate)
        {
            TimeSpan timeDifference = DateTime.Now - postDate;

            if (timeDifference.TotalMinutes < 1)
            {
                return "Just now";
            }
            else if (timeDifference.TotalMinutes < 60)
            {
                return $"{(int)timeDifference.TotalMinutes} minute{(timeDifference.TotalMinutes >= 2 ? "s" : "")} ago";
            }
            else if (timeDifference.TotalHours < 24)
            {
                 
                int hours = (int)timeDifference.TotalHours;
                return $"{hours} {(hours > 1 ? "hours" : "hour")} ago";
            }
            else if (timeDifference.TotalDays < 30)
            {
                return $"{(int)timeDifference.TotalDays} day{(timeDifference.TotalDays >= 2 ? "s" : "")} ago";
            }
            else
            {
                 
                return postDate.ToString("MMMM dd, yyyy");
            }
        }
    }
}
