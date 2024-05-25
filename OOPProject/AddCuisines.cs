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

namespace OOPProject
{
    public partial class AddCuisines : Form
    {
        private string username;
        public AddCuisines(string loggedInUsername)
        {
            InitializeComponent();
            username = loggedInUsername;
            LoadCuisines();
            populatePanel();
            rbtnAdd.Checked = true;
        }

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=RecipeCatalogdb.mdb");
        OleDbCommand cmd = new OleDbCommand();
        private void AddCuisines_Load(object sender, EventArgs e)
        {

        }
        private void btnCusines_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbxAdd.Text) && pbxCuisine.Image != null)
            {
               
                string cuisineName = tbxAdd.Text.Trim();

                byte[] imageData = ImageToByteArray(pbxCuisine.Image);

                try
                {
                    con.Open();

                    string insertQuery = "INSERT INTO cuisine (cuisine, cuisinepic, username) VALUES (?, ?, ?)";
                    cmd = new OleDbCommand(insertQuery, con);
                    cmd.Parameters.AddWithValue("@cuisine", cuisineName);
                    cmd.Parameters.AddWithValue("@cuisinepic", imageData);
                    cmd.Parameters.AddWithValue("@username", username);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Cuisine information and image uploaded successfully and saved to the database.");
                        tbxAdd.Text = "";
                        pbxCuisine.Image = null;
                    }
                    else
                    {
                        MessageBox.Show("Failed to save cuisine information and image.");
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
                cbxCuisines.Items.Clear();
                LoadCuisines();
                populatePanel();
            }
            else
            {
                MessageBox.Show("Please enter a cuisine name and select an image.");
            }
        }


        private void pbxCuisine_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.png; *.jpg; *.jpeg; *.gif; *.bmp)|*.png; *.jpg; *.jpeg; *.gif; *.bmp|All files (*.*)|*.*";
            openFileDialog.Title = "Select an Image File";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if (pbxCuisine.Image != null)
                    {
                        pbxCuisine.Image.Dispose();
                    }
                    pbxCuisine.Image = Image.FromFile(openFileDialog.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading image: " + ex.Message);
                }
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

        private void SaveImageDataToDatabase(byte[] imageData)
        {
            try
            {
                con.Open();

                string insertQuery = "INSERT INTO cuisine (cuisinepic, cuisine, username) VALUES (?, ?, ?)";
                cmd = new OleDbCommand(insertQuery, con);
                cmd.Parameters.AddWithValue("@cuisinepic", imageData);
                cmd.Parameters.AddWithValue("@cuisine", tbxAdd.Text); 
                cmd.Parameters.AddWithValue("@username", username);

                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Image uploaded successfully and saved to the database.");
                }
                else
                {
                    MessageBox.Show("Failed to upload image.");
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

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.png; *.jpg; *.jpeg; *.gif; *.bmp)|*.png; *.jpg; *.jpeg; *.gif; *.bmp|All files (*.*)|*.*";
            openFileDialog.Title = "Select an Image File";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if (pbxCuisine.Image != null)
                    {
                        pbxCuisine.Image.Dispose();
                    }
                    pbxCuisine.Image = Image.FromFile(openFileDialog.FileName);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading image: " + ex.Message);
                }
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (cbxCuisines.SelectedItem != null)
            {
                string selectedCuisine = cbxCuisines.SelectedItem.ToString();

                try
                {
                    con.Open();

                    string deleteQuery = "DELETE FROM cuisine WHERE cuisine = ? AND username = ?";
                    cmd = new OleDbCommand(deleteQuery, con);
                    cmd.Parameters.AddWithValue("@cuisine", selectedCuisine);
                    cmd.Parameters.AddWithValue("@username", username);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Cuisine and its image deleted successfully.");
                        cbxCuisines.Items.Remove(selectedCuisine);
                        pbxUpdate.Image = null;
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete cuisine and image.");
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
                MessageBox.Show("Please select a cuisine to delete.");
            }
            populatePanel();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (cbxCuisines.SelectedItem != null && !string.IsNullOrEmpty(tbxUpdate.Text))
            {
                string selectedCuisine = cbxCuisines.SelectedItem.ToString();
                string updatedCuisine = tbxUpdate.Text.Trim();

                try
                {
                    con.Open();

                    string updateQuery = "UPDATE cuisine SET cuisine = ? WHERE cuisine = ? AND username = ?";
                    cmd = new OleDbCommand(updateQuery, con);
                    cmd.Parameters.AddWithValue("@newCuisine", updatedCuisine);
                    cmd.Parameters.AddWithValue("@oldCuisine", selectedCuisine);
                    cmd.Parameters.AddWithValue("@username", username);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Cuisine name updated successfully.");
                        cbxCuisines.Items[cbxCuisines.SelectedIndex] = updatedCuisine;
                    }
                    else
                    {
                        MessageBox.Show("Failed to update cuisine name.");
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
            else
            {
                MessageBox.Show("Please select a cuisine and enter an updated cuisine name.");
            }
            populatePanel();
        }

        private void buttons1_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            con.Open();
            System.Windows.Forms.MessageBox.Show("Connected successfully!");
            con.Close();
        }

        private void panelCuisines_Paint(object sender, PaintEventArgs e)
        {

        }

        private void populatePanel()
        {
            panelCuisines.Controls.Clear();

            if (cbxCuisines.Items.Count > 0)
            {
                int labelY = 10;

                foreach (object item in cbxCuisines.Items)
                {
                    Label label = new Label();
                    label.Text = item.ToString();
                    label.Font = new Font("Palatino Linotype", 10, FontStyle.Regular);
                    label.ForeColor = Color.FromArgb(192, 41, 66);
                    label.AutoSize = true;
                    label.Location = new Point(10, labelY);
                    labelY += label.Height + 5;

                    panelCuisines.Controls.Add(label);
                }
            }
            else
            {
                Label noCuisineLabel = new Label();
                noCuisineLabel.Text = "No cuisines available.";
                noCuisineLabel.AutoSize = true;
                noCuisineLabel.Location = new Point(10, 15);
                panelCuisines.Controls.Add(noCuisineLabel);
            }

            panelCuisines.AutoScroll = true;
            panelCuisines.VerticalScroll.Value = 0;
            panelCuisines.VerticalScroll.Maximum = 0;
        }

        private void rbtnEdit_CheckedChanged(object sender, EventArgs e)
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

        private void cbxCuisines_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbxCuisines.SelectedItem != null)
                {
                    string selectedCuisine = cbxCuisines.SelectedItem.ToString();
                    tbxUpdate.Text = selectedCuisine;
                    con.Open();

                    string queryCuisine = "SELECT cuisinepic FROM cuisine WHERE cuisine = ? AND username = ?";
                    cmd = new OleDbCommand(queryCuisine, con);
                    cmd.Parameters.AddWithValue("@cuisine", selectedCuisine);
                    cmd.Parameters.AddWithValue("@username", username);

                    byte[] imageData = (byte[])cmd.ExecuteScalar();

                    if (imageData != null)
                    {
                        using (MemoryStream ms = new MemoryStream(imageData))
                        {
                            pbxUpdate.Image = Image.FromStream(ms);
                        }
                    }
                    else
                    {
                        pbxUpdate.Image = null;
                    }

                    con.Close();
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}
