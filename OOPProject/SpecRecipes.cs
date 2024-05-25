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
    public partial class SpecRecipes : Form
    {
        private string username;
        private string cuisineName;
        private int panelIndex = 0;  
        private int panelWidth = 200;
        private int panelHeight = 200;
        private int panelMargin = 25;
        public event EventHandler<string> PanelClicked;

        public SpecRecipes(string loggedInUsername, string selectedCuisine)
        {
            InitializeComponent();
            username = loggedInUsername;
            cuisineName = selectedCuisine;
            DisplayRecipes();
            this.Resize += SpecRecipes_Resize;
            lblRecipe.Text = selectedCuisine + " cuisine:";

        }

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=RecipeCatalogdb.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        private void Panel_MouseClick(object sender, MouseEventArgs e)
        {
            Panel clickedPanel = sender as Panel;
            if (clickedPanel != null)
            {
                string recipeName = (clickedPanel.Controls[1] as Label)?.Text;
                PanelClicked?.Invoke(this, recipeName);
            }
        }
        private void flowLayoutPanel1_SizeChanged(object sender, EventArgs e)
        {

        }

        private void DisplayRecipes()
        {
             
            string query = "SELECT recipeName, recipePhoto FROM recipe WHERE username = @username AND cuisine = @cuisine";

            using (OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=RecipeCatalogdb.mdb"))
            {
                using (OleDbCommand cmd = new OleDbCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@cuisine", cuisineName);  
                    con.Open();
                    using (OleDbDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                string recipeName = reader["recipeName"].ToString();

                                 
                                byte[] imageData = (byte[])reader["recipePhoto"];
                                Image recipeImage = ByteArrayToImage(imageData);

                                 
                                Panel panel = new Panel();
                                panel.BorderStyle = BorderStyle.FixedSingle;
                                panel.Size = new Size(panelWidth, panelHeight);

                                 
                                PictureBox pictureBox = new PictureBox();
                                pictureBox.Image = recipeImage;
                                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                                pictureBox.Size = new Size(180, 150);

                                 
                                int pictureBoxX = (panel.Width - pictureBox.Width) / 2;  
                                int pictureBoxY = 10;  

                                 
                                pictureBox.Location = new Point(pictureBoxX, pictureBoxY);

                                 
                                Label label = new Label();
                                label.Text = recipeName;
                                label.TextAlign = ContentAlignment.TopCenter;
                                label.Dock = DockStyle.Bottom;
                                label.Font = new Font("Palatino Linotype", 12, FontStyle.Regular);
                                label.ForeColor = Color.FromArgb(192, 41, 66);

                                 
                                panel.Controls.Add(pictureBox);
                                panel.Controls.Add(label);

                                 
                                panel.MouseClick += Panel_MouseClick;

                                 
                                int row = panelIndex / 3;
                                int col = panelIndex % 3;
                                int x = 50 + (panelWidth + panelMargin) * col;
                                int y = 50 + (panelHeight + panelMargin) * row;
                                panel.Location = new Point(x, y);
                                panelIndex++;

                                 
                                flowLayoutPanel1.Controls.Add(panel);
                            }
                        }
                        else
                        {
                             
                            Label noRecipesLabel = new Label();
                            noRecipesLabel.Text = "No recipes added yet";
                            noRecipesLabel.Font = new Font("Palatino Linotype", 12, FontStyle.Regular);
                            noRecipesLabel.ForeColor = Color.FromArgb(192, 41, 66);
                            noRecipesLabel.AutoSize = true;

                             
                            int labelX = (flowLayoutPanel1.ClientSize.Width - noRecipesLabel.Width) / 2;
                            int labelY = (flowLayoutPanel1.ClientSize.Height - noRecipesLabel.Height) / 2;
                            noRecipesLabel.Location = new Point(labelX, labelY);

                            flowLayoutPanel1.Controls.Add(noRecipesLabel);
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



        private void SpecRecipes_Resize(object sender, EventArgs e)
        {
            RedrawPanels();
        }

        private void RedrawPanels()
        {
             
            flowLayoutPanel1.SuspendLayout();

            int panelsPerRow = Math.Max((flowLayoutPanel1.ClientSize.Width - 100) / (panelWidth + panelMargin), 1);
            int totalRows = (int)Math.Ceiling((double)flowLayoutPanel1.Controls.Count / panelsPerRow);

            for (int i = 0; i < flowLayoutPanel1.Controls.Count; i++)
            {
                int row = i / panelsPerRow;
                int col = i % panelsPerRow;

                int x = 50 + (panelWidth + panelMargin) * col;
                int y = 50 + (panelHeight + panelMargin) * row;

                flowLayoutPanel1.Controls[i].Location = new Point(x, y);
            }

            flowLayoutPanel1.ResumeLayout();
        }
    }
}
