using FontAwesome.Sharp;
using Guna.UI2.WinForms;
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
    public partial class Details : Form
    {
        private string username;
        private string recipeName;
        public Details(string loggedInUsername, string selectedRecipe)
        {
            InitializeComponent();
            username = loggedInUsername;
            recipeName = selectedRecipe;
            LoadIngredients();
            LoadInstructions();
            LoadInfo();
        }

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=RecipeCatalogdb.mdb");
        OleDbCommand cmd = new OleDbCommand();

        private void LoadInfo()
        {
            try
            {
                con.Open();

                string queryRecipeInfo = "SELECT difficulty, accessibility, publishDate, updateDate, recipePhoto FROM recipe WHERE username = ? AND recipeName = ?";
                cmd = new OleDbCommand(queryRecipeInfo, con);
                cmd.Parameters.Add("@username", OleDbType.VarChar).Value = username;
                cmd.Parameters.Add("@recipeName", OleDbType.VarChar).Value = recipeName;

                using (OleDbDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string difficulty = reader["difficulty"].ToString();
                        string accessibility = reader["accessibility"].ToString();
                        DateTime publishDate = (DateTime)reader["publishDate"];
                        DateTime updateDate = (DateTime)reader["updateDate"];
                        byte[] recipePhoto = reader["recipePhoto"] as byte[];

                        lblRecipe.Text = recipeName;
                        lblDiff.Text = difficulty;
                        lblAccess.Text = accessibility;
                        lblAuth.Text = username;
                        lblPublished.Text = publishDate.ToString("MM/dd//yyyy");
                        lblUpdated.Text = updateDate.ToString("MM/dd//yyyy"); 

                        if (recipePhoto != null && recipePhoto.Length > 0)
                        {
                            using (MemoryStream ms = new MemoryStream(recipePhoto))
                            {
                                pbxRecipe.Image = Image.FromStream(ms);
                            }
                        }
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

        private void LoadIngredients()
        {
            panelIngr.Controls.Clear();

            con.Open();

            string queryIngredients = "SELECT ingredientName, IngredientAmount, IngredientPrice FROM Summary WHERE username =? AND recipeName =?";
            cmd = new OleDbCommand(queryIngredients, con);
            cmd.Parameters.Add("@username", OleDbType.VarChar).Value = username;
            cmd.Parameters.Add("@recipeName", OleDbType.VarChar).Value = recipeName;

            OleDbDataReader readerIngredients = cmd.ExecuteReader();
            TableLayoutPanel tableLayoutPanel = new TableLayoutPanel();
            tableLayoutPanel.ColumnCount = 3;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40));  
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30));
            tableLayoutPanel.Dock = DockStyle.Fill;  
            tableLayoutPanel.Padding = new Padding(5);  
            tableLayoutPanel.Font = new Font("Palatino Linotype", 12, FontStyle.Regular);

            int row = 2;
            while (readerIngredients.Read())
            {
                 
                Label nameLabel = new Label() { Text = readerIngredients["IngredientName"].ToString(), TextAlign = ContentAlignment.TopCenter, AutoSize = true, Anchor = AnchorStyles.Left, Dock = DockStyle.Top };
                Label amountLabel = new Label() { Text = readerIngredients["IngredientAmount"].ToString(), TextAlign = ContentAlignment.TopCenter, AutoSize = true, Anchor = AnchorStyles.Left, Dock = DockStyle.Top };
                Label priceLabel = new Label() { Text = readerIngredients["IngredientPrice"].ToString(), TextAlign = ContentAlignment.TopCenter, AutoSize = true, Anchor = AnchorStyles.Left, Dock = DockStyle.Top };

                tableLayoutPanel.Controls.Add(nameLabel, 0, row);
                tableLayoutPanel.Controls.Add(amountLabel, 1, row);
                tableLayoutPanel.Controls.Add(priceLabel, 2, row);

                 
                row++;
            }
            readerIngredients.Close();

            con.Close();

            panelIngr.Controls.Add(tableLayoutPanel);
        }

        private void LoadInstructions()
        {
            try
            {
                con.Open();

                string queryInstructions = "SELECT steps, instructions, insVid FROM SummaryInstructions WHERE username = ? AND recipeName = ?";
                cmd = new OleDbCommand(queryInstructions, con);
                cmd.Parameters.Add("@username", OleDbType.VarChar).Value = username;
                cmd.Parameters.Add("@recipeName", OleDbType.VarChar).Value = recipeName;

                using (OleDbDataReader readerInstructions = cmd.ExecuteReader())
                {
                    TableLayoutPanel tableLayoutPanel = new TableLayoutPanel();
                    tableLayoutPanel.ColumnCount = 3;  
                    tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
                    tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20));  
                    tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
                    tableLayoutPanel.Location = new Point(10, 10);
                    tableLayoutPanel.Dock = DockStyle.Fill;
                    tableLayoutPanel.AutoSize = true;
                    tableLayoutPanel.Font = new Font("Palatino Linotype", 15, FontStyle.Bold);

                     
                    if (readerInstructions.HasRows)
                    {
                         
                        while (readerInstructions.Read())
                        {
                            tableLayoutPanel.Font = new Font("Palatino Linotype", 10, FontStyle.Regular);

                             
                            Label stepLabel = new Label() { Text = "Step " + readerInstructions["steps"].ToString() + ":", AutoSize = true, TextAlign = ContentAlignment.MiddleLeft };
                            Label instructionLabel = new Label() { Text = readerInstructions["instructions"].ToString(), AutoSize = true, MaximumSize = new Size(1000, 0) };  

                             
                            tableLayoutPanel.Controls.Add(stepLabel);
                            tableLayoutPanel.SetColumnSpan(stepLabel, 1);  
                            tableLayoutPanel.Controls.Add(new Label() { Text = "", AutoSize = true });  
                            tableLayoutPanel.Controls.Add(instructionLabel);


                        }
                    }
                    else
                    {

                    }

                    panelInst.Controls.Add(tableLayoutPanel);
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

        private void panelInst_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
