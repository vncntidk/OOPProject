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
    public partial class AllCuisines : Form
    {
        private string loggedInUsername;
        private int panelIndex = 0;  
        private int panelWidth = 200;
        private int panelHeight = 200;
        private int panelMargin = 25;
        public event EventHandler<string> PanelClicked;
        public AllCuisines(string loggedInUsername)
        {
            InitializeComponent();
            this.loggedInUsername = loggedInUsername;
            DisplayCuisines();
            this.Resize += AllCuisines_Resize;
        }

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=RecipeCatalogdb.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        private void AllCuisines_Load(object sender, EventArgs e)
        {

        }
        private void DisplayCuisines()
        {
             
            string query = "SELECT cuisine, cuisinepic FROM cuisine WHERE username = @username";

            using (OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=RecipeCatalogdb.mdb"))
            {
                using (OleDbCommand cmd = new OleDbCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@username", loggedInUsername);
                    con.Open();
                    using (OleDbDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string cuisineName = reader["cuisine"].ToString();

                             
                            byte[] imageData = (byte[])reader["cuisinepic"];
                            Image cuisineImage = ByteArrayToImage(imageData);

                             
                            Panel panel = new Panel();
                            panel.BorderStyle = BorderStyle.FixedSingle;
                            panel.Size = new Size(panelWidth, panelHeight);

                             
                            PictureBox pictureBox = new PictureBox();
                            pictureBox.Image = cuisineImage;
                            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                            pictureBox.Size = new Size(180, 150); 

                             
                            int pictureBoxX = (panel.Width - pictureBox.Width) / 2;  
                            int pictureBoxY = 10;  

                             
                            pictureBox.Location = new Point(pictureBoxX, pictureBoxY);

                             
                            Label label = new Label();
                            label.Text = cuisineName;
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

                             
                            this.Controls.Add(panel);
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

        private void Panel_MouseClick(object sender, MouseEventArgs e)
        {
            Panel clickedPanel = sender as Panel;
            if (clickedPanel != null)
            {
                string cuisineName = (clickedPanel.Controls[1] as Label)?.Text;
                PanelClicked?.Invoke(this, cuisineName);
            }
        }

        private void AllCuisines_Resize(object sender, EventArgs e)
        {
            RedrawPanels();
        }
        private void RedrawPanels()
        {
             
            foreach (Control control in this.Controls)
            {
                control.MouseClick -= Panel_MouseClick;
            }

             
            if (this.Controls.Count == 0)
                return;

            int panelsPerRow = Math.Max((this.ClientSize.Width - 100) / (panelWidth + panelMargin), 1);
            int totalRows = (int)Math.Ceiling((double)this.Controls.Count / panelsPerRow);

            for (int i = 0; i < this.Controls.Count; i++)
            {
                int row = i / panelsPerRow;
                int col = i % panelsPerRow;

                int x = 50 + (panelWidth + panelMargin) * col;
                int y = 50 + (panelHeight + panelMargin) * row;

                this.Controls[i].Location = new Point(x, y);
                this.Controls[i].MouseClick += Panel_MouseClick;  
            }
        }


    }
}
