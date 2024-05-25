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
    public partial class SubProfile : Form
    {
        private string username;
        private bool profileExists;
        public SubProfile(string loggedInUsername)
        {
            InitializeComponent();
            username = loggedInUsername;
            LoadProfileData();
        }

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=RecipeCatalogdb.mdb");
        OleDbCommand cmd = new OleDbCommand();
        DataSet ds = new DataSet();
        OleDbDataAdapter da = new OleDbDataAdapter();

        private void LoadProfileData()
        {
            try
            {
                con.Open();

                 
                string checkExistQuery = "SELECT COUNT(*) FROM profile WHERE username = ?";
                cmd = new OleDbCommand(checkExistQuery, con);
                cmd.Parameters.AddWithValue("@p1", username);
                int count = (int)cmd.ExecuteScalar();

                if (count > 0)
                {
                     
                    profileExists = true;

                    string selectQuery = "SELECT profileName, profilePic FROM profile WHERE username = ?";
                    cmd = new OleDbCommand(selectQuery, con);
                    cmd.Parameters.AddWithValue("@p1", username);
                    OleDbDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                         
                        string profileName = reader["profileName"].ToString();
                        tbxName.Text = profileName;

                         
                        byte[] profilePicBytes = (byte[])reader["profilePic"];
                        pbxProfile.Image = Image.FromStream(new MemoryStream(profilePicBytes));
                    }
                    reader.Close();
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
        private void pbxProfile_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Image Files (*.jpg, *.png, *.jpeg, *.gif, *.bmp)|*.jpg; *.png; *.jpeg; *.gif; *.bmp";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                     
                    string imagePath = openFileDialog.FileName;
                    pbxProfile.Image = Image.FromFile(imagePath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void UpdateOrInsertProfileData(byte[] imageBytes)
        {
            try
            {
                con.Open();

                if (profileExists)
                {
                     
                    string updateQuery = "UPDATE profile SET profileName = ?, profilePic = ? WHERE username = ?";
                    cmd = new OleDbCommand(updateQuery, con);
                }
                else
                {
                     
                    string insertQuery = "INSERT INTO profile (profileName, profilePic, username) VALUES (?, ?, ?)";
                    cmd = new OleDbCommand(insertQuery, con);
                }

                 
                cmd.Parameters.AddWithValue("@p1", tbxName.Text);  
                cmd.Parameters.AddWithValue("@p2", imageBytes);
                cmd.Parameters.AddWithValue("@p3", username);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Profile data saved successfully!");
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                 
                if (string.IsNullOrWhiteSpace(tbxName.Text))
                {
                    MessageBox.Show("Please enter a name before saving.");
                    return;  
                }

                 
                if (pbxProfile.Image == null)
                {
                    MessageBox.Show("Please select a profile picture before saving.");
                    return;
                }

                byte[] imageBytes = ImageToByteArray(pbxProfile.Image);

                 
                UpdateOrInsertProfileData(imageBytes);

                 
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errorsne: " + ex.Message);
            }
        }

         
        private byte[] ImageToByteArray(Image image)
        {
            using (var ms = new MemoryStream())
            {
                image.Save(ms, image.RawFormat);
                return ms.ToArray();
            }
        }
    }
}
