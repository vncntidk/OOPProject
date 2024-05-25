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
    public partial class AddInstructions : Form
    {
        private string username;
        private byte[] videoData;
        public AddInstructions(string loggedInUsername)
        {
            InitializeComponent();
            rbtnAdd.Checked = true;
            username = loggedInUsername;
            LoadCuisines();
        }

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=RecipeCatalogdb.mdb");
        OleDbCommand cmd = new OleDbCommand();
        DataSet ds = new DataSet();
        OleDbDataAdapter da = new OleDbDataAdapter();

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

        private void cbxCuisines_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCuisine = cbxCuisines.SelectedItem.ToString();
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
        }

        private void cbxRecipes_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            instructionsPanel.Controls.Clear();
            string selectedRecipe = cbxRecipes.SelectedItem?.ToString();
            if (selectedRecipe != null)
            {
                try
                {
                    con.Open();

                    string queryInstructions = "SELECT steps, instructions, insVid FROM SummaryInstructions WHERE username = ? AND recipeName = ?";
                    cmd = new OleDbCommand(queryInstructions, con);
                    cmd.Parameters.Add("@username", OleDbType.VarChar).Value = username;
                    cmd.Parameters.Add("@recipeName", OleDbType.VarChar).Value = selectedRecipe;

                    using (OleDbDataReader readerInstructions = cmd.ExecuteReader())
                    {
                        TableLayoutPanel tableLayoutPanel = new TableLayoutPanel();
                        tableLayoutPanel.ColumnCount = 3;  
                        tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
                        tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20));  
                        tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
                        tableLayoutPanel.Location = new Point(10, 10);
                        tableLayoutPanel.AutoSize = true;
                        tableLayoutPanel.Font = new Font("Palatino Linotype", 12, FontStyle.Bold);

                         
                        if (readerInstructions.HasRows)
                        {
                             
                            while (readerInstructions.Read())
                            {
                                tableLayoutPanel.Font = new Font("Palatino Linotype", 10, FontStyle.Regular);

                                 
                                Label stepLabel = new Label() { Text = "Step " + readerInstructions["steps"].ToString() + ":", AutoSize = true, TextAlign = ContentAlignment.MiddleLeft };
                                Label instructionLabel = new Label() { Text = readerInstructions["instructions"].ToString(), AutoSize = true, MaximumSize = new Size(500, 0) };  

                                 
                                tableLayoutPanel.Controls.Add(stepLabel);
                                tableLayoutPanel.SetColumnSpan(stepLabel, 1);  
                                tableLayoutPanel.Controls.Add(new Label() { Text = "", AutoSize = true });  
                                tableLayoutPanel.Controls.Add(instructionLabel);

                                 
                                if (mpInstruction.URL == string.Empty)
                                {
                                    byte[] videoData = (byte[])readerInstructions["insVid"];
                                    DisplayVideo(videoData);
                                }

                                 
                                if (mpUpdate.URL == string.Empty)
                                {
                                    byte[] videoData = (byte[])readerInstructions["insVid"];
                                    DisplayVideoUpdate(videoData);
                                }

                            }
                        }
                        else
                        {

                        }

                        instructionsPanel.Controls.Add(tableLayoutPanel);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    if (con.State == ConnectionState.Open)
                    {
                        con.Close();
                        PopulateStepsComboBox(selectedRecipe);
                    }
                }
            }
        }

        private void DisplayVideoUpdate(byte[] videoData)
        {
            try
            {
                 
                string tempFilePath = Path.GetTempFileName();
                File.WriteAllBytes(tempFilePath, videoData);

                 
                mpUpdate.URL = tempFilePath;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void DisplayVideo(byte[] videoData)
        {
            try
            {
                 
                string tempFilePath = Path.GetTempFileName();
                File.WriteAllBytes(tempFilePath, videoData);

                 
                mpInstruction.URL = tempFilePath;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void btnInstruction_Click(object sender, EventArgs e)
        {
            string selectedRecipe = cbxRecipes.SelectedItem?.ToString();
            string step = tbxStep.Text;
            string instructions = tbxInstructions.Texts;

            if (selectedRecipe != null && !string.IsNullOrEmpty(step) && !string.IsNullOrEmpty(instructions))
            {
                try
                {
                    con.Open();

                     
                    string insertQuery = "INSERT INTO instructions (recipeName, steps, instructions, insVid) VALUES (@recipeName, @steps, @instructions, @insVid)";
                    cmd = new OleDbCommand(insertQuery, con);
                    cmd.Parameters.AddWithValue("@recipeName", selectedRecipe);
                    cmd.Parameters.AddWithValue("@steps", step);
                    cmd.Parameters.AddWithValue("@instructions", instructions);
                    cmd.Parameters.AddWithValue("@insVid", videoData);  

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Instructions added successfully.");
                        tbxStep.Clear();
                        tbxInstructions.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Failed to add instructions.");
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
            else
            {
                MessageBox.Show("Please fill in all the fields.");
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string selectedRecipe = cbxRecipes.SelectedItem?.ToString();
            string step = cbxsteps.SelectedItem?.ToString();

            if (selectedRecipe != null && !string.IsNullOrEmpty(step))
            {
                try
                {
                    con.Open();

                    string deleteQuery = "DELETE FROM instructions WHERE recipeName = @recipeName AND steps = @steps";
                    cmd = new OleDbCommand(deleteQuery, con);
                    cmd.Parameters.AddWithValue("@recipeName", selectedRecipe);
                    cmd.Parameters.AddWithValue("@steps", step);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Instructions deleted successfully.");
                        tbxStep.Clear();
                        tbxInstructions.Texts = "";
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete instructions.");
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
            else
            {
                MessageBox.Show("Please select a recipe and enter a step to delete.");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string selectedRecipe = cbxRecipes.SelectedItem?.ToString();
            string step = tbxSteep.Texts;
            string instructions = tbxIns.Texts;

            if (selectedRecipe != null && !string.IsNullOrEmpty(step) && !string.IsNullOrEmpty(instructions))
            {
                try
                {
                    con.Open();

                    string updateQuery = "UPDATE instructions SET instructions = @instructions WHERE recipeName = @recipeName AND steps = @steps";
                    cmd = new OleDbCommand(updateQuery, con);
                    cmd.Parameters.AddWithValue("@instructions", instructions);
                    cmd.Parameters.AddWithValue("@recipeName", selectedRecipe);
                    cmd.Parameters.AddWithValue("@steps", step);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Instructions updated successfully.");
                        tbxStep.Clear();
                        tbxInstructions.Texts = "";
                    }
                    else
                    {
                        MessageBox.Show("Failed to update instructions.");
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
            else
            {
                MessageBox.Show("Please select a recipe, enter a step, and fill in instructions to update.");
            }
        }

        private void cbxsteps_OnSelectedIndexChanged(object sender, EventArgs e)
        {
             
            if (cbxsteps.SelectedItem != null)
            {
                 
                string selectedStep = cbxsteps.SelectedItem.ToString();

                 
                try
                {
                    con.Open();

                    string selectQuery = "SELECT steps, instructions FROM instructions WHERE steps = @step";  
                    cmd = new OleDbCommand(selectQuery, con);
                    cmd.Parameters.AddWithValue("@step", selectedStep);

                    OleDbDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                         
                        tbxSteep.Texts = reader["steps"].ToString();
                        tbxIns.Texts = reader["instructions"].ToString();
                    }
                    else
                    {
                         
                        tbxSteep.Text = "";
                        tbxIns.Text = "";
                    }
                    reader.Close();
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

        private void mpInstruction_Enter(object sender, EventArgs e)
        {

        }

        private void UploadVid_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Video Files|*.mp4;*.avi;*.mov|All Files|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog.FileName;

                try
                {
                     
                    videoData = File.ReadAllBytes(selectedFilePath);

                     
                    mpInstruction.URL = selectedFilePath;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void PopulateStepsComboBox(string selectedRecipe)
        {
             
            cbxsteps.Items.Clear();

            try
            {
                con.Open();

                string selectQuery = "SELECT DISTINCT steps FROM instructions WHERE recipeName = @recipeName";  
                cmd = new OleDbCommand(selectQuery, con);
                cmd.Parameters.AddWithValue("@recipeName", selectedRecipe);

                OleDbDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                     
                    cbxsteps.Items.Add(reader["steps"].ToString());
                }
                reader.Close();
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
