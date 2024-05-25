using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace OOPProject
{
    public partial class AddRecipe : Form
    {
        private string username;
        public AddRecipe(string loggedInUsername)
        {
            InitializeComponent();
            username = loggedInUsername;
            cbxCuisines.OnSelectedIndexChanged += cbxCuisines_OnSelectedIndexChanged;
            LoadCuisines();
            rbtnAdd.Checked = true;
        }

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=RecipeCatalogdb.mdb");
        OleDbCommand cmd = new OleDbCommand();
        DataSet ds = new DataSet();
        OleDbDataAdapter da = new OleDbDataAdapter();

        private void tbxAdd_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoadCuisines()
        {
             
            cbxCuisines.Items.Clear();

            if (username != null && username != string.Empty)
            {
                con.Open();

                 
                string queryCuisines = "SELECT DISTINCT cuisine FROM cuisine WHERE username = @username";
                cmd = new OleDbCommand(queryCuisines, con);
                cmd.Parameters.Add("@username", OleDbType.VarChar).Value = username;

                 
                OleDbDataReader readerCuisines = cmd.ExecuteReader();
                while (readerCuisines.Read())
                {
                    cbxCuisines.Items.Add(readerCuisines["cuisine"].ToString());
                }
                readerCuisines.Close();

                con.Close();
            }
            else
            {
                MessageBox.Show("Please enter a username.");
            }
        }
        private byte[] ImageToByteArray(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                 
                image.Save(ms, ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }


        private void btnRecipes_Click(object sender, EventArgs e)
        {
            string selectedCuisine = cbxCuisines.SelectedItem.ToString();

            string accessibility = rbtnPublic.Checked ? "Public" : "Private";

            string difficulty = "";
            if (rbtnBeg.Checked)
                difficulty = "Beginner";
            else if (rbtnInter.Checked)
                difficulty = "Intermediate";
            else if (rbtnExpert.Checked)
                difficulty = "Expert";

            if (!string.IsNullOrEmpty(selectedCuisine) && !string.IsNullOrEmpty(tbxAdd.Text))
            {
                try
                {
                    con.Open();

                     
                    byte[] imageData = (pbxRecipe.Image != null) ? ImageToByteArray(pbxRecipe.Image) : null;

                     
                    DateTime currentDate = DateTime.Now;

                     
                    string insertQuery = "INSERT INTO recipe (recipeName, accessibility, difficulty, cuisine, username, recipePhoto, publishDate, updateDate) " +
                                         "VALUES (?, ?, ?, ?, ?, ?, ?, ?)";
                    cmd = new OleDbCommand(insertQuery, con);
                    cmd.Parameters.AddWithValue("@recipeName", tbxAdd.Text.Trim());
                    cmd.Parameters.AddWithValue("@accessibility", accessibility);
                    cmd.Parameters.AddWithValue("@difficulty", difficulty);
                    cmd.Parameters.AddWithValue("@cuisine", selectedCuisine);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@recipePhoto", (imageData != null) ? (object)imageData : DBNull.Value);
                    cmd.Parameters.AddWithValue("@publishDate", currentDate.ToShortDateString());  
                    cmd.Parameters.AddWithValue("@updateDate", currentDate.ToShortDateString());  

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Recipe information saved successfully.");
                        tbxAdd.Text = "";
                         
                        pbxRecipe.Image = null;

                        if (accessibility == "Public")
                        {
                            string updateQuery = "UPDATE cuisine SET recipeCount = recipeCount + 1 WHERE cuisine = ?";
                            cmd = new OleDbCommand(updateQuery, con);
                            cmd.Parameters.AddWithValue("@cuisine", selectedCuisine);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Failed to save recipe information.");
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
            else
            {
                MessageBox.Show("Please enter both cuisine and recipe name.");
            }
            cbxRecipes.Items.Clear();
            cbxCuisines_OnSelectedIndexChanged(sender, e);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cbxCuisines.SelectedItem?.ToString()) && !string.IsNullOrEmpty(cbxRecipes.SelectedItem?.ToString()) && !string.IsNullOrEmpty(tbxUpdate.Text))
            {
                string selectedRecipe = cbxRecipes.SelectedItem.ToString();
                string updatedRecipe = tbxUpdate.Text.Trim();

                try
                {
                    con.Open();

                     
                    byte[] imageData = (pbxUpdate.Image != null) ? ImageToByteArray(pbxUpdate.Image) : null;

                     
                    DateTime currentDate = DateTime.Now;

                     
                    string updateQuery = "UPDATE recipe SET recipeName = ?, accessibility = ?, difficulty = ?, recipePhoto = ?, updateDate = ? WHERE recipeName = ? AND username = ?";
                    cmd = new OleDbCommand(updateQuery, con);
                    cmd.Parameters.AddWithValue("@newRecipeName", updatedRecipe);
                     
                    cmd.Parameters.AddWithValue("@accessibility", (rbtnPub.Checked) ? "Public" : "Private");
                    if (rbtnB.Checked)
                        cmd.Parameters.AddWithValue("@difficulty", "Beginner");
                    else if (rbtnI.Checked)
                        cmd.Parameters.AddWithValue("@difficulty", "Intermediate");
                    else if (rbtnE.Checked)
                        cmd.Parameters.AddWithValue("@difficulty", "Expert");
                    else
                        cmd.Parameters.AddWithValue("@difficulty", DBNull.Value);

                     
                    cmd.Parameters.AddWithValue("@recipePhoto", (imageData != null) ? (object)imageData : DBNull.Value);

                     
                    cmd.Parameters.AddWithValue("@updateDate", currentDate.ToShortDateString());  

                    cmd.Parameters.AddWithValue("@oldRecipeName", selectedRecipe);
                    cmd.Parameters.AddWithValue("@username", username);

                     
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Recipe updated successfully.");
                        tbxUpdate.Text = "";
                        rbtnB.Checked = false;
                        rbtnE.Checked = false;
                        rbtnI.Checked = false;
                        rbtnPriv.Checked = false;
                        rbtnPub.Checked = false;
                         
                        pbxUpdate.Image = null;
                    }
                    else
                    {
                        MessageBox.Show("Failed to update recipe.");
                    }
                }
                catch (Exception ex)
                {
                }
                finally
                {
                    con.Close();
                    PopulatePanel();
                }
            }
            else
            {
                MessageBox.Show("Please select a cuisine, a recipe, and enter a new recipe name.");
            }
            cbxRecipes.Items.Clear();
            cbxRecipes.SelectedItem = "";
            cbxCuisines_OnSelectedIndexChanged(sender, e);
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cbxCuisines.SelectedItem?.ToString()) && !string.IsNullOrEmpty(cbxRecipes.SelectedItem?.ToString()))
            {
                string selectedRecipe = cbxRecipes.SelectedItem.ToString();

                DialogResult result = MessageBox.Show("Are you sure you want to delete this recipe?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        con.Open();

                         
                        string deleteQuery = "DELETE FROM recipe WHERE recipeName = ? AND username = ?";
                        cmd = new OleDbCommand(deleteQuery, con);
                        cmd.Parameters.AddWithValue("@recipeName", selectedRecipe);
                        cmd.Parameters.AddWithValue("@username", username);

                         
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Recipe and image deleted successfully.");
                             
                            pbxUpdate.Image = null;

                             
                            string updateCuisineQuery = "UPDATE cuisine SET recipeCount = recipeCount - 1 WHERE cuisine = ?";
                            cmd = new OleDbCommand(updateCuisineQuery, con);
                            cmd.Parameters.AddWithValue("@cuisine", cbxCuisines.SelectedItem.ToString());
                            cmd.ExecuteNonQuery();
                        }
                        else
                        {
                            MessageBox.Show("Failed to delete recipe and image.");
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
            }
            else
            {
                MessageBox.Show("Please select a cuisine and a recipe to delete.");
            }
            PopulatePanel();
            cbxRecipes.Items.Clear();
            cbxCuisines_OnSelectedIndexChanged(sender, e);
        }


        private void cbxCuisines_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCuisine = cbxCuisines.SelectedItem.ToString();
            labelCuisines.Text = selectedCuisine;
            if (!string.IsNullOrEmpty(selectedCuisine))
            {
                cbxRecipes.Items.Clear();

                try
                {
                    con.Open();

                    string selectQuery = "SELECT recipeName FROM recipe WHERE cuisine = @cuisine AND username = @username";
                    cmd = new OleDbCommand(selectQuery, con);
                    cmd.Parameters.AddWithValue("@cuisine", selectedCuisine);
                    cmd.Parameters.AddWithValue("@username", username);

                    OleDbDataReader readerRecipes = cmd.ExecuteReader();
                    while (readerRecipes.Read())
                    {
                        cbxRecipes.Items.Add(readerRecipes["recipeName"].ToString());
                    }
                    readerRecipes.Close();
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
            PopulatePanel();
        }

        private void cbxRecipes_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string selectedRecipe = cbxRecipes.SelectedItem.ToString();

                con.Open();

                 
                string selectQuery = "SELECT * FROM recipe WHERE recipeName = ? AND username = ?";
                cmd = new OleDbCommand(selectQuery, con);
                cmd.Parameters.AddWithValue("@recipeName", selectedRecipe);
                cmd.Parameters.AddWithValue("@username", username);
                OleDbDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                     
                    string cuisine = reader["cuisine"].ToString();
                    string accessibility = reader["accessibility"].ToString();
                    string difficulty = reader["difficulty"].ToString();

                     
                    cbxCuisines.SelectedItem = cuisine;
                    tbxUpdate.Text = selectedRecipe;

                     
                    if (accessibility == "Public")
                        rbtnPub.Checked = true;
                    else if (accessibility == "Private")
                        rbtnPriv.Checked = true;

                     
                    if (difficulty == "Beginner")
                        rbtnB.Checked = true;
                    else if (difficulty == "Intermediate")
                        rbtnI.Checked = true;
                    else if (difficulty == "Expert")
                        rbtnE.Checked = true;

                     
                    if (reader["recipePhoto"] != DBNull.Value)
                    {
                        byte[] imageData = (byte[])reader["recipePhoto"];
                        if (imageData != null && imageData.Length > 0)
                        {
                             
                            using (MemoryStream ms = new MemoryStream(imageData))
                            {
                                pbxUpdate.Image = Image.FromStream(ms);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Recipe not found.");
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

        private void AddRecipe_Load(object sender, EventArgs e)
        {

        }

        private void rbtnAdd_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnAdd.Checked)
            {
                panelEdit.Visible = false;
                panelAdd.Visible = true;
                panel2.Visible = true;
                panelHide1.Visible = false;
            }
            else
            {
                panelEdit.Visible = true;
                panelAdd.Visible = false;
                panel2.Visible = false;
                panelHide1.Visible = true;
            }
        }

        private void rbtnEdit_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnEdit.Checked)
            {
                panelAdd.Visible = false;
                panelEdit.Visible = true;
            }
            else
            {
                panelAdd.Visible = true;
                panelEdit.Visible = false;
            }
        }

        private void rbtnPub_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RecipePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PopulatePanel()
        {
            RecipePanel.Controls.Clear();

            string selectedCuisine = cbxCuisines.SelectedItem.ToString();
            try
            {
                con.Open();

                 
                string selectQuery = "SELECT recipeName FROM recipe WHERE cuisine = ? AND username = ?";
                cmd = new OleDbCommand(selectQuery, con);
                cmd.Parameters.AddWithValue("@cuisine", selectedCuisine);
                cmd.Parameters.AddWithValue("@username", username);
                OleDbDataReader reader = cmd.ExecuteReader();

                int labelY = 10;  
                bool recipesFound = false;  

                 
                while (reader.Read())
                {
                    string recipeName = reader["recipeName"].ToString();
                    recipesFound = true;  

                     
                    Label label = new Label();
                    label.Text = recipeName;
                    label.Font = new Font("Palatino Linotype", 10, FontStyle.Regular);
                    label.ForeColor = Color.FromArgb(192, 41, 66);
                    label.AutoSize = true;
                    label.Location = new Point(10, labelY);
                    labelY += label.Height + 5;

                     
                    RecipePanel.Controls.Add(label);
                }

                 
                if (!recipesFound)
                {
                    Label noRecipeLabel = new Label();
                    noRecipeLabel.Text = "No recipes available for this cuisine.";
                    noRecipeLabel.AutoSize = true;
                    noRecipeLabel.Location = new Point(10, labelY);  
                    RecipePanel.Controls.Add(noRecipeLabel);
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

        private void pbxRecipe_Click(object sender, EventArgs e)
        {
             
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.png; *.jpg; *.jpeg; *.gif; *.bmp)|*.png; *.jpg; *.jpeg; *.gif; *.bmp|All files (*.*)|*.*";
            openFileDialog.Title = "Select an Image File";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                     
                    pbxRecipe.Image = Image.FromFile(openFileDialog.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading image: " + ex.Message);
                }
            }
        }

        private void pbxUpdate_Click(object sender, EventArgs e)
        {
             
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.png; *.jpg; *.jpeg; *.gif; *.bmp)|*.png; *.jpg; *.jpeg; *.gif; *.bmp|All files (*.*)|*.*";
            openFileDialog.Title = "Select an Image File";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                     
                    pbxUpdate.Image = Image.FromFile(openFileDialog.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading image: " + ex.Message);
                }
            }
        }
    }
}
