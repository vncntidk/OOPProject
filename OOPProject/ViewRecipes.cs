using AxWMPLib;
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
    public partial class ViewRecipes : Form
    {
        private string username;
        private string recipeName;
        private string ownerName;
        private Form currentMenu;
        private byte[] videoData;
        public ViewRecipes(string loggedInUsername, string owner, string selectedRecipe)
        {
            InitializeComponent();
            username = loggedInUsername;
            recipeName = selectedRecipe;
            ownerName = owner;
            DisplayRecipeImage();
            DisplayRecipeDetails();
            DisplayVideo();
        }
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=RecipeCatalogdb.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        private void DisplayRecipeImage()
        {
            try
            {
                con.Open();

                string selectQuery = "SELECT recipePhoto FROM recipe WHERE username = @username AND recipeName = @recipeName";
                cmd = new OleDbCommand(selectQuery, con);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@recipeName", recipeName);

                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    byte[] imageData = (byte[])result;
                    Image recipeImage = ByteArrayToImage(imageData);

                }
                else
                {
                     
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

         
        private Image ByteArrayToImage(byte[] byteArrayIn)
        {
            using (MemoryStream ms = new MemoryStream(byteArrayIn))
            {
                Image returnImage = Image.FromStream(ms);
                return returnImage;
            }
        }

        private void OpenForm(Form current)
        {
            if (currentMenu != null)
            {
                currentMenu.Close();
            }

            currentMenu = current;
            current.TopLevel = false;
            current.FormBorderStyle = FormBorderStyle.None;
            current.Dock = DockStyle.Fill;
            panelShow.Controls.Add(current);
            panelShow.Tag = current;
            current.BringToFront();
            current.Show();
        }
        private void DisplayRecipeDetails()
        {
            try
            {
                con.Open();

                string selectQuery = "SELECT accessibility, difficulty FROM recipe WHERE username = @username AND recipeName = @recipeName";
                cmd = new OleDbCommand(selectQuery, con);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@recipeName", recipeName);

                using (OleDbDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                         
                        string accessibility = reader["accessibility"].ToString();
                        string difficulty = reader["difficulty"].ToString();
                    }
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

        private void btnBack_Click(object sender, EventArgs e)
        {

        }

        private void ViewRecipes_SizeChanged(object sender, EventArgs e)
        {
            int buttonWidth = panel1.Width / 2;

            btnAbout.Width = buttonWidth;
            btnComment.Width = buttonWidth;
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            OpenForm(new Details(ownerName, recipeName));
        }

        private void btnComment_Click(object sender, EventArgs e)
        {
            OpenForm(new Reviews(username, recipeName));
        }

        private void DisplayVideo()
        {
            try
            {
                con.Open();

                string selectQuery = "SELECT insVid FROM instructions WHERE username = @username AND recipeName = @recipeName";
                cmd = new OleDbCommand(selectQuery, con);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@recipeName", recipeName);


                byte[] videoData = (byte[])cmd.ExecuteScalar();

                if (videoData != null)
                {
                    string tempFilePath = Path.GetTempFileName();
                    File.WriteAllBytes(tempFilePath, videoData);

                    mpInstructions.URL = tempFilePath;
                }
                else
                {
                    MessageBox.Show("No video data found for this recipe.");
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
    }
}
