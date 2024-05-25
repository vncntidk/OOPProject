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

namespace OOPProject
{
    public partial class ViewPopular : Form
    {
        private string usernames;
        private string recipeName;
        private string ownerName;
        private int currentPage;
        private int itemsPerPage;
        private int currentPager;
        private int itemsPerPager;

        private float miniPanelWidth;
        private int miniPanelHeight;
        private int totalCuisines;
        private int totalRecipes;
        public ViewPopular(string loggedInUsername)
        {
            InitializeComponent();
            miniPanelHeight = panelCuisine.Height;
            miniPanelWidth = panelCuisine.Width / (float)4;
            usernames = loggedInUsername;
            currentPage = 1;
            itemsPerPage = 4;
            currentPager = 1;
            itemsPerPager = 4;
        }

        private async void ViewPopular_Load(object sender, EventArgs e)
        {
            await LoadPageDataAsync();
            await LoadRecipeAsync();
        }

        private async Task LoadPageDataAsync()
        {
            try
            {
                using (OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=RecipeCatalogdb.mdb"))
                {
                    await con.OpenAsync();

                     
                    string countQuery = "SELECT COUNT(*) FROM cuisine";
                    using (OleDbCommand countCmd = new OleDbCommand(countQuery, con))
                    {
                        totalCuisines = (int)await countCmd.ExecuteScalarAsync();
                    }

                     
                    string query = "SELECT cuisine.*, (SELECT COUNT(*) FROM recipe WHERE cuisine = cuisine.cuisine) AS RecipeCount " +
                                   "FROM cuisine ORDER BY RecipeCount DESC";
                    using (OleDbCommand cmd = new OleDbCommand(query, con))
                    {

                        using (var reader = await cmd.ExecuteReaderAsync())
                        {
                            int rowIndex = 0;
                            int columnIndex = 0;
                            int startIndex = (currentPage - 1) * itemsPerPage;
                            int endIndex = Math.Min(startIndex + itemsPerPage - 1, totalCuisines - 1);

                            int currentCuisineIndex = 0;

                            while (await reader.ReadAsync() && currentCuisineIndex <= endIndex)
                            {
                                if (currentCuisineIndex >= startIndex && currentCuisineIndex <= endIndex)
                                {
                                    string cuisineName = reader["cuisine"].ToString();
                                    byte[] cuisinePicData = (byte[])reader["cuisinepic"];

                                     
                                    int availableWidth = panelCuisine.Width - (itemsPerPage + 1) * 8;  

                                    Guna2Panel miniPanel = new Guna2Panel();
                                    miniPanel.BackColor = Color.Transparent;
                                    miniPanel.BorderRadius = 30;
                                    miniPanel.BorderThickness = 3;
                                    miniPanel.BorderColor = Color.FromArgb(255, 128, 0);

                                     
                                    int miniPanelWidth = availableWidth / itemsPerPage;

                                     
                                    miniPanel.Size = new Size(miniPanelWidth, panelCuisine.Height - 20);  
                                    miniPanel.Margin = new Padding(5);  

                                    Guna2PictureBox minipbxCuisine = new Guna2PictureBox();
                                    minipbxCuisine.SizeMode = PictureBoxSizeMode.StretchImage;
                                    minipbxCuisine.BorderRadius = 30;
                                    minipbxCuisine.BackColor = Color.Transparent;
                                    minipbxCuisine.Image = ByteArrayToImage(cuisinePicData);
                                    minipbxCuisine.Size = new Size(miniPanelWidth - 20, 200);
                                    minipbxCuisine.Location = new Point(10, 10);
                                    miniPanel.Controls.Add(minipbxCuisine);


                                    Label label = new Label();
                                    label.Text = cuisineName;
                                    label.AutoSize = true;
                                    label.Location = new Point(((miniPanelWidth - label.Width) / 2) + 15, miniPanelHeight - 110);
                                    label.Font = new Font("Palatino Linotype", 10.800001f, FontStyle.Bold);
                                    label.ForeColor = Color.FromArgb(224, 122, 90);
                                    miniPanel.Controls.Add(label);

                                    miniPanel.Click += (sender, e) =>
                                    {
                                        string cuisineName = label.Text;
                                        ViewRecipeHome specRecipesForm = new ViewRecipeHome(usernames, cuisineName);
                                        Form parentForm = this.ParentForm;
                                        if (parentForm != null && parentForm is Home)
                                        {
                                            Home homeForm = (Home)parentForm;
                                            homeForm.ReplaceForm(specRecipesForm);
                                        }
                                    };

                                    Label lblRecipe = new Label();
                                    lblRecipe.AutoSize = true;
                                    lblRecipe.Location = new Point(50, miniPanelHeight - 80);
                                    lblRecipe.Font = new Font("Palatino Linotype", 8.800001f, FontStyle.Regular);
                                    lblRecipe.ForeColor = Color.FromArgb(224, 122, 90);

                                    int recipeCount = await GetRecipeCountAsync(cuisineName);
                                    lblRecipe.Text = $"Recipes: {recipeCount}";

                                    miniPanel.Controls.Add(lblRecipe);

                                    panelCuisine.Controls.Add(miniPanel);

                                    columnIndex++;
                                    if (columnIndex == 4)  
                                    {
                                        columnIndex = 0;
                                        rowIndex++;
                                    }
                                }

                                currentCuisineIndex++;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errorss: " + ex.Message);
            }
        }

        private async Task<int> GetRecipeCountAsync(string cuisineName)
        {
            int recipeCount = 0;
            try
            {
                using (OleDbConnection connection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=RecipeCatalogdb.mdb"))
                {
                    await connection.OpenAsync();

                    using (OleDbCommand cmd = new OleDbCommand("SELECT COUNT(*) FROM recipe WHERE cuisine = @cuisine", connection))
                    {
                        cmd.Parameters.AddWithValue("@cuisine", cuisineName);
                        recipeCount = (int)await cmd.ExecuteScalarAsync();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            return recipeCount;
        }

        private async Task LoadRecipeAsync()
        {
            try
            {
                using (OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=RecipeCatalogdb.mdb"))
                {
                    await con.OpenAsync();

                     
                    string countQuery = "SELECT COUNT(*) FROM recipe WHERE accessibility = 'Public'";
                    using (OleDbCommand countCmd = new OleDbCommand(countQuery, con))
                    {
                        totalRecipes = (int)await countCmd.ExecuteScalarAsync();
                    }

                    string query = "SELECT recipeName, recipePhoto, username FROM recipe WHERE accessibility = 'Public' ORDER BY recipeAve DESC";
                    using (OleDbCommand cmd = new OleDbCommand(query, con))
                    {
                        using (var reader = await cmd.ExecuteReaderAsync())
                        {
                            int rowIndex = 0;
                            int columnIndex = 0;
                            int startIndex = (currentPager - 1) * itemsPerPager;
                            int endIndex = Math.Min(startIndex + itemsPerPager - 1, totalRecipes - 1);

                            int currentRecipeIndex = 0;

                            while (await reader.ReadAsync() && currentRecipeIndex <= endIndex)
                            {
                                if (currentRecipeIndex >= startIndex && currentRecipeIndex <= endIndex)
                                {
                                    recipeName = reader["recipeName"].ToString();
                                    ownerName = reader["username"].ToString();
                                    byte[] recipePicData = (byte[])reader["recipePhoto"];

                                     
                                    int availableWidth = panelRecipes.Width - (itemsPerPager + 1) * 8;  

                                    Guna2Panel miniPanel = new Guna2Panel();
                                    miniPanel.BackColor = Color.Transparent;
                                    miniPanel.BorderRadius = 30;
                                    miniPanel.BorderThickness = 3;
                                    miniPanel.BorderColor = Color.FromArgb(255, 128, 0);

                                     
                                    int miniPanelWidth = availableWidth / itemsPerPager;

                                     
                                    miniPanel.Size = new Size(miniPanelWidth, panelRecipes.Height - 20);  
                                    miniPanel.Margin = new Padding(5);  

                                    Guna2PictureBox minipbxRecipe = new Guna2PictureBox();
                                    minipbxRecipe.SizeMode = PictureBoxSizeMode.StretchImage;
                                    minipbxRecipe.BorderRadius = 30;
                                    minipbxRecipe.BackColor = Color.Transparent;
                                    minipbxRecipe.Image = ByteArrayToImage(recipePicData);
                                    minipbxRecipe.Size = new Size(miniPanelWidth - 20, 200);
                                    minipbxRecipe.Location = new Point(10, 10);
                                    miniPanel.Controls.Add(minipbxRecipe);

                                    Label label = new Label();
                                    label.Text = recipeName;
                                    label.AutoSize = true;
                                    label.Location = new Point(((miniPanelWidth - label.Width) / 2) + (label.Width / 2), miniPanelHeight - 110);
                                    label.Font = new Font("Palatino Linotype", 10.800001f, FontStyle.Bold);
                                    label.ForeColor = Color.FromArgb(224, 122, 90);
                                    miniPanel.Controls.Add(label);

                                    Label labels = new Label();
                                    labels.Text = ownerName;
                                    labels.Visible = false;
                                    miniPanel.Controls.Add(labels);

                                    miniPanel.Click += (sender, e) =>
                                    {
                                        string recipeName = label.Text;
                                        string ownerName = labels.Text;
                                        ViewRecipes viewRecipesForm = new ViewRecipes(usernames, ownerName, recipeName);
                                        Form parentForm = this.ParentForm;
                                        if (parentForm != null && parentForm is Home)
                                        {
                                            Home homeForm = (Home)parentForm;
                                            homeForm.ReplaceForm(viewRecipesForm);
                                        }
                                    };

                                    Label lblAvgRating = new Label();
                                    lblAvgRating.AutoSize = true;
                                    lblAvgRating.Location = new Point(50, miniPanelHeight - 80);
                                    lblAvgRating.Font = new Font("Palatino Linotype", 8.800001f, FontStyle.Regular);
                                    lblAvgRating.ForeColor = Color.FromArgb(224, 122, 90);

                                    double avgRating = await GetAverageRatingAsync(recipeName);
                                    lblAvgRating.Text = $"Ratings: {avgRating.ToString("0.##")}";

                                    miniPanel.Controls.Add(lblAvgRating);

                                    panelRecipes.Controls.Add(miniPanel);

                                    columnIndex++;
                                    if (columnIndex == 4)  
                                    {
                                        columnIndex = 0;
                                        rowIndex++;
                                    }
                                }
                                currentRecipeIndex++;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errorss: " + ex.Message);
            }
        }

        private async Task<double> GetAverageRatingAsync(string recipeName)
        {
            double avgRating = 0.0;
            try
            {
                using (OleDbConnection connection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=RecipeCatalogdb.mdb"))
                {
                    await connection.OpenAsync();

                    using (OleDbCommand cmd = new OleDbCommand("SELECT AVG(rating) FROM feedback WHERE recipeName = @recipeName", connection))
                    {
                        cmd.Parameters.AddWithValue("@recipeName", recipeName);
                        object result = await cmd.ExecuteScalarAsync();
                        if (result != DBNull.Value)
                        {
                            avgRating = Convert.ToDouble(result);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            return avgRating;
        }

        private Image ByteArrayToImage(byte[] byteArray)
        {
            using (MemoryStream ms = new MemoryStream(byteArray))
            {
                Image image = Image.FromStream(ms);
                return image;
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                panelCuisine.Controls.Clear();
                LoadPageDataAsync();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentPage < totalCuisines / itemsPerPage)
            {
                currentPage++;
                panelCuisine.Controls.Clear();
                LoadPageDataAsync();
            }
        }

        private void panel1_SizeChanged(object sender, EventArgs e)
        {
            miniPanelWidth = panelCuisine.Width / 4;
            panelCuisine.Controls.Clear();
            panelRecipes.Controls.Clear();
            LoadPageDataAsync();
            LoadRecipeAsync();
        }

        private async void btnPrevi_Click(object sender, EventArgs e)
        {
            if (currentPager > 1)
            {
                currentPager--;
                panelRecipes.Controls.Clear();
                await LoadRecipeAsync();
            }
        }

        private async void btnNexts_Click(object sender, EventArgs e)
        {
            int totalPages = (int)Math.Ceiling((double)totalRecipes / itemsPerPager);
            if (currentPager < totalPages)
            {
                currentPager++;
                panelRecipes.Controls.Clear();
                await LoadRecipeAsync();
            }
        }
    }
}
