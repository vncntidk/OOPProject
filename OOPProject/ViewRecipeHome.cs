using Guna.UI2.WinForms;
using Guna.UI2.WinForms.Enums;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace OOPProject
{

    public partial class ViewRecipeHome : Form
    {
        private string username;
        private string cuisineName;
        private int panelIndex = 0;  
        private int panelWidth;
        private int panelHeight = 250;
        private int panelMargin = 25;
        public event EventHandler<string> PanelClicked;

        public ViewRecipeHome(string loggedInUsername, string selectedCuisine)
        {
            InitializeComponent();
            cuisineName = selectedCuisine;
            username = loggedInUsername;
            panelWidth = (panelFlow.Width) / 4;
            DisplayRecipes();
        }

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=RecipeCatalogdb.mdb");
        OleDbCommand cmd = new OleDbCommand();
        private void Panel_MouseClick(object sender, MouseEventArgs e)
        {
        }
        private void DisplayRecipes()
        {
             
            string query = "SELECT recipeName, recipePhoto, username FROM recipe WHERE cuisine = @cuisine and accessibility = 'Public'";

            using (OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=RecipeCatalogdb.mdb"))
            {
                using (OleDbCommand cmd = new OleDbCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@cuisine", cuisineName);  
                    con.Open();
                    using (OleDbDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                string recipeName = reader["recipeName"].ToString();
                                string ownerName = reader["username"].ToString();

                                 
                                byte[] imageData = (byte[])reader["recipePhoto"];
                                Image recipeImage = ByteArrayToImage(imageData);

                                Guna2Panel miniPanel = new Guna2Panel();
                                miniPanel.BackColor = Color.Transparent;
                                miniPanel.BorderRadius = 30;
                                miniPanel.BorderThickness = 3;
                                miniPanel.BorderColor = Color.FromArgb(255, 128, 0);
                                miniPanel.Size = new Size(panelWidth, panelHeight);  
                                miniPanel.Margin = new Padding(5);  

                                Guna2PictureBox minipbxCuisine = new Guna2PictureBox();
                                minipbxCuisine.SizeMode = PictureBoxSizeMode.StretchImage;
                                minipbxCuisine.BorderRadius = 30;
                                minipbxCuisine.BackColor = Color.Transparent;
                                minipbxCuisine.Image = recipeImage;
                                minipbxCuisine.Size = new Size(panelWidth - 20, 170);
                                minipbxCuisine.Location = new Point(10, 10);
                                miniPanel.Controls.Add(minipbxCuisine);

                                 
                                Label label = new Label();
                                label.Text = recipeName;
                                label.TextAlign = ContentAlignment.TopCenter;
                                label.Font = new Font("Palatino Linotype", 12, FontStyle.Regular);
                                label.ForeColor = Color.FromArgb(192, 41, 66);
                                label.Location = new Point(100, panelHeight - 40);

                                Label user = new Label();
                                user.Text = ownerName;
                                user.Visible = false;

                                 
                                miniPanel.Controls.Add(minipbxCuisine);
                                miniPanel.Controls.Add(label);
                                miniPanel.Controls.Add(user);

                                 
                                miniPanel.Click += (sender, e) =>
                                {
                                    string recipeName = label.Text;
                                    string Ownerusername = user.Text;
                                    ViewRecipes viewRecipesForm = new ViewRecipes(username, Ownerusername, recipeName);
                                    Form parentForm = this.ParentForm;
                                    if (parentForm != null && parentForm is Home)
                                    {
                                        Home homeForm = (Home)parentForm;
                                        homeForm.ReplaceForm(viewRecipesForm);
                                    }
                                };

                                 
                                int row = panelIndex / 5;
                                int col = panelIndex % 5;
                                int x = 50 + (panelWidth + panelMargin) * col;
                                int y = 50 + (panelHeight + panelMargin) * row;
                                miniPanel.Location = new Point(x, y);
                                panelIndex++;

                                 
                                panelFlow.Controls.Add(miniPanel);
                            }
                        }
                        else
                        {
                             
                            Label noRecipesLabel = new Label();
                            noRecipesLabel.Text = "No recipes added yet";
                            noRecipesLabel.Font = new Font("Palatino Linotype", 12, FontStyle.Regular);
                            noRecipesLabel.ForeColor = Color.FromArgb(192, 41, 66);
                            noRecipesLabel.AutoSize = true;

                             
                            int labelX = (panelFlow.ClientSize.Width - noRecipesLabel.Width) / 2;
                            int labelY = (panelFlow.ClientSize.Height - noRecipesLabel.Height) / 2;
                            noRecipesLabel.Location = new Point(labelX, labelY);

                            panelFlow.Controls.Add(noRecipesLabel);
                        }
                    }
                }
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

        private void RedrawPanels()
        {
             
            panelFlow.SuspendLayout();

            int panelsPerRow = Math.Max((panelFlow.ClientSize.Width - 100) / (panelWidth + panelMargin), 1);
            int totalRows = (int)Math.Ceiling((double)panelFlow.Controls.Count / panelsPerRow);

            for (int i = 0; i < panelFlow.Controls.Count; i++)
            {
                int row = i / panelsPerRow;
                int col = i % panelsPerRow;

                int x = 50 + (panelWidth + panelMargin) * col;
                int y = 50 + (panelHeight + panelMargin) * row;

                panelFlow.Controls[i].Location = new Point(x, y);
            }

            panelFlow.ResumeLayout();
        }

        private void ViewRecipeHome_SizeChanged(object sender, EventArgs e)
        {
            RedrawPanels();
        }
    }
}
