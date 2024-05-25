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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace OOPProject
{
    public partial class AddIngredients : Form
    {
        private string username;
        public AddIngredients(string loggedInUsername)
        {
            InitializeComponent();
            username = loggedInUsername;
            LoadCuisines();
            rbtnAdd.Checked = true;
        }

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=RecipeCatalogdb.mdb");
        OleDbCommand cmd = new OleDbCommand();
        DataSet ds = new DataSet();
        OleDbDataAdapter da = new OleDbDataAdapter();
        private void btnIngredient_Click(object sender, EventArgs e)
        {
            string selectedRecipe = cbxRecipes.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(selectedRecipe))
            {
                string ingredientName = tbxAdd.Text;
                string ingredientAmount = textBox1.Text;
                string ingredientPrice = textBox2.Text;

                if (!string.IsNullOrEmpty(ingredientName) && !string.IsNullOrEmpty(ingredientAmount) && !string.IsNullOrEmpty(ingredientPrice))
                {
                    try
                    {
                        con.Open();

                        string insertQuery = "INSERT INTO ingredient (IngredientName, IngredientAmount, IngredientPrice, recipeName) VALUES (?, ?, ?, ?)";
                        cmd = new OleDbCommand(insertQuery, con);
                        cmd.Parameters.AddWithValue("@ingredientName", ingredientName);
                        cmd.Parameters.AddWithValue("@ingredientAmount", ingredientAmount);
                        cmd.Parameters.AddWithValue("@ingredientPrice", ingredientPrice);
                        cmd.Parameters.AddWithValue("@recipeName", selectedRecipe);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Ingredient added successfully to " + selectedRecipe + ".");
                            tbxAdd.Text = "";
                            textBox1.Text = "";
                            textBox2.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("Failed to add ingredient.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                    finally
                    {
                        con.Close();
                        PopulateIngredientsPanel();
                        cbxRecipes_OnSelectedIndexChanged(sender, e);
                    }
                }
                else
                {
                    MessageBox.Show("Please fill in all fields.");
                }
            }
            else
            {
                MessageBox.Show("Please select a recipe first.");
            }
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
        private void PopulateIngredientsPanel()
        {
            ingredientsPanel.Controls.Clear();

            string selectedRecipe = cbxRecipes.SelectedItem?.ToString();

            if (selectedRecipe != null)
            {
                con.Open();

                string queryIngredients = "SELECT ingredientName, IngredientAmount, IngredientPrice FROM Summary WHERE username =? AND recipeName =?";
                cmd = new OleDbCommand(queryIngredients, con);
                cmd.Parameters.Add("@username", OleDbType.VarChar).Value = username;
                cmd.Parameters.Add("@recipeName", OleDbType.VarChar).Value = selectedRecipe;

                OleDbDataReader readerIngredients = cmd.ExecuteReader();

                TableLayoutPanel tableLayoutPanel = new TableLayoutPanel();
                tableLayoutPanel.ColumnCount = 3;
                tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40));  
                tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30));
                tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30));
                tableLayoutPanel.Dock = DockStyle.Fill;  
                tableLayoutPanel.Padding = new Padding(5);  
                tableLayoutPanel.Font = new Font("Palatino Linotype", 12, FontStyle.Regular);

                 
                Label nameLabelHeader = new Label() { Text = "Name", AutoSize = true, Anchor = AnchorStyles.Left, Dock = DockStyle.Top };
                Label amountLabelHeader = new Label() { Text = "Amount", AutoSize = true, Anchor = AnchorStyles.Left, Dock = DockStyle.Top };
                Label priceLabelHeader = new Label() { Text = "Price", AutoSize = true, Anchor = AnchorStyles.Left, Dock = DockStyle.Top };

                tableLayoutPanel.Controls.Add(nameLabelHeader, 0, 0);
                tableLayoutPanel.Controls.Add(amountLabelHeader, 1, 0);
                tableLayoutPanel.Controls.Add(priceLabelHeader, 2, 0);

                int row = 1;
                while (readerIngredients.Read())
                {
                     
                    Label nameLabel = new Label() { Text = readerIngredients["IngredientName"].ToString(), AutoSize = true, Anchor = AnchorStyles.Left, Dock = DockStyle.Top };
                    Label amountLabel = new Label() { Text = readerIngredients["IngredientAmount"].ToString(), AutoSize = true, Anchor = AnchorStyles.Left, Dock = DockStyle.Top };
                    Label priceLabel = new Label() { Text = readerIngredients["IngredientPrice"].ToString(), AutoSize = true, Anchor = AnchorStyles.Left, Dock = DockStyle.Top };

                    tableLayoutPanel.Controls.Add(nameLabel, 0, row);
                    tableLayoutPanel.Controls.Add(amountLabel, 1, row);
                    tableLayoutPanel.Controls.Add(priceLabel, 2, row);

                     
                    row++;
                }
                readerIngredients.Close();

                con.Close();


                ingredientsPanel.Controls.Add(tableLayoutPanel);
            }
        }


        private void cbxRecipes_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateIngredientsPanel();
            labelRecipe.Text = cbxRecipes.SelectedItem.ToString();
            string selectedCuisine = cbxRecipes.SelectedItem.ToString();

            if (!string.IsNullOrEmpty(selectedCuisine))
            {

                cbxIngredient.Items.Clear();

                try
                {
                    con.Open();

                    string selectQuery = "SELECT IngredientName, IngredientAmount, IngredientPrice FROM Summary WHERE recipeName = @recipe AND username = @username";
                    cmd = new OleDbCommand(selectQuery, con);
                    cmd.Parameters.AddWithValue("@cuisine", selectedCuisine);
                    cmd.Parameters.AddWithValue("@username", username);

                    OleDbDataReader readerIngredients = cmd.ExecuteReader();
                    while (readerIngredients.Read())
                    {
                        cbxIngredient.Items.Add(readerIngredients["IngredientName"].ToString());
                    }
                    readerIngredients.Close();
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

        private void cbxCuisines_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCuisine = cbxCuisines.SelectedItem.ToString();
            if (!string.IsNullOrEmpty(selectedCuisine))
            {

                cbxRecipes.Items.Clear();

                try
                {
                    con.Open();

                    string selectQuery = "SELECT recipeName FROM SummaryRecipe WHERE cuisine = @cuisine AND username = @username";
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
        }

        private void cbxIngredient_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedIngredient = cbxIngredient.SelectedItem?.ToString();
            

            if (!string.IsNullOrEmpty(selectedIngredient))
            {
                try
                {
                    con.Open();

                    string selectQuery = "SELECT IngredientName, IngredientAmount, IngredientPrice FROM Summary WHERE IngredientName = @ingredient AND username = @username";
                    cmd = new OleDbCommand(selectQuery, con);
                    cmd.Parameters.AddWithValue("@ingredient", selectedIngredient);
                    cmd.Parameters.AddWithValue("@username", username);

                    OleDbDataReader readerIngredient = cmd.ExecuteReader();
                    if (readerIngredient.Read())
                    {
                         
                        tbxName.Text = readerIngredient["IngredientName"].ToString();
                        tbxAmount.Text = readerIngredient["IngredientAmount"].ToString();
                        tbxPrice.Text = readerIngredient["IngredientPrice"].ToString();
                    }
                    else
                    {
                         
                        MessageBox.Show("Ingredient details not found.");
                    }
                    readerIngredient.Close();
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

        private void ingredientsPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rbtnAdd_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnAdd.Checked)
            {
                panelEdit.Visible = false;
                panelAdd.Visible = true;
                panel3.Visible = true;
                panelHide1.Visible = false;
            }
            else
            {
                panelEdit.Visible = true;
                panelAdd.Visible = false;
                panel3.Visible = false;
                panelHide1.Visible = true;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string selectedIngredient = cbxIngredient.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(selectedIngredient))
            {
                try
                {
                    con.Open();

                    string updateQuery = "UPDATE Summary SET IngredientName = ?, IngredientAmount = ?, IngredientPrice = ? WHERE IngredientName = ? AND username = ?";
                    cmd = new OleDbCommand(updateQuery, con);
                    cmd.Parameters.AddWithValue("@newIngredientName", tbxName.Text);
                    cmd.Parameters.AddWithValue("@newIngredientAmount", tbxAmount.Text);
                    cmd.Parameters.AddWithValue("@newIngredientPrice", tbxPrice.Text);
                    cmd.Parameters.AddWithValue("@oldIngredientName", selectedIngredient);
                    cmd.Parameters.AddWithValue("@username", username);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Ingredient updated successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Failed to update ingredient.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    con.Close();
                    PopulateIngredientsPanel();
                    cbxRecipes_OnSelectedIndexChanged(sender, e);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string selectedIngredient = cbxIngredient.SelectedItem?.ToString();
            string selectedRecipe = cbxRecipes.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(selectedIngredient))
            {
                try
                {
                    con.Open();

                    string deleteQuery = "DELETE FROM ingredient WHERE IngredientName = ? AND recipeName = ?";
                    cmd = new OleDbCommand(deleteQuery, con);
                    cmd.Parameters.AddWithValue("@ingredientName", selectedIngredient);
                    cmd.Parameters.AddWithValue("@recipeName", selectedRecipe);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Ingredient deleted successfully.");
                        PopulateIngredientsPanel();  
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete ingredient.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    con.Close();
                    cbxRecipes_OnSelectedIndexChanged(sender, e);
                }
            }
        }
    }
}
