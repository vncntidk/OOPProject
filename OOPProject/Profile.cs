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
    public partial class Profile : Form
    {
        private string username;
        public Profile(string loggedInUsername)
        {
            InitializeComponent();
            username = loggedInUsername;
            lblUsername.Text = "@" + username;
            UpdateRecipeCountLabel();
            LoadProfileData();
        }




        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=RecipeCatalogdb.mdb");
        OleDbCommand cmd = new OleDbCommand();
        DataSet ds = new DataSet();
        OleDbDataAdapter da = new OleDbDataAdapter();


        private void Profile_SizeChanged(object sender, EventArgs e)
        {
        }

        private void btnRecipes_Click(object sender, EventArgs e)
        {

        }

        private void btnAbout_Click(object sender, EventArgs e)
        {

        }

        private void UpdateRecipeCountLabel()
        {
            try
            {
                con.Open();
                 
                string query = "SELECT COUNT(*) FROM recipe WHERE username = ?";
                cmd = new OleDbCommand(query, con);
                cmd.Parameters.AddWithValue("@p1", username);  

                int recipeCount = (int)cmd.ExecuteScalar();

                lblRecipes.Text = $"{recipeCount} recipes posted";
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SubProfile subProfileForm = new SubProfile(username);
            subProfileForm.FormClosed += SubProfileForm_FormClosed;  
            subProfileForm.ShowDialog();
        }
        private void LoadProfileData()
        {
            try
            {
                con.Open();
                string query = "SELECT profileName, profilePic FROM profile WHERE username = ?";
                cmd = new OleDbCommand(query, con);
                cmd.Parameters.AddWithValue("@p1", username);
                OleDbDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                     
                    string profileName = reader["profileName"].ToString();
                    lblName.Text = profileName;

                    lblUsername.Text = "@" + username;
                     
                    byte[] profilePicBytes = (byte[])reader["profilePic"];
                    pbxProfile.Image = Image.FromStream(new MemoryStream(profilePicBytes));
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
        private void SubProfileForm_FormClosed(object sender, FormClosedEventArgs e)
        {
             
            LoadProfileData();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                 
                string deleteQuery = "DELETE FROM hobbies WHERE username = ?";
                cmd = new OleDbCommand(deleteQuery, con);
                cmd.Parameters.AddWithValue("@p1", username);
                cmd.ExecuteNonQuery();

                 
                foreach (Control innerControl in guna2Panel5.Controls)
                {
                    if (innerControl is Guna2CheckBox checkBox)
                    {
                        if (checkBox.Name.StartsWith("chkHobby") && checkBox.Checked)
                        {
                            string hobby = checkBox.Text;
                            string insertQuery = "INSERT INTO hobbies (hobby, username) VALUES (?, ?)";
                            cmd = new OleDbCommand(insertQuery, con);
                            cmd.Parameters.AddWithValue("@p1", hobby);
                            cmd.Parameters.AddWithValue("@p2", username);
                            cmd.ExecuteNonQuery();
                        }
                    }
                }
                MessageBox.Show("Hobbies saved successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
                LoadHobbies();
            }
        }
        private void LoadHobbies()
        {
            try
            {
                con.Open();

                 
                string selectQuery = "SELECT hobby FROM hobbies WHERE username = ?";
                cmd = new OleDbCommand(selectQuery, con);
                cmd.Parameters.AddWithValue("@p1", username);

                using (OleDbDataReader reader = cmd.ExecuteReader())
                {
                     
                    while (reader.Read())
                    {
                        string hobby = reader["hobby"].ToString();

                         
                        foreach (Control innerControl in guna2Panel5.Controls)
                        {
                            if (innerControl is Guna2CheckBox checkBox &&
                                checkBox.Name.StartsWith("chkHobby") &&
                                checkBox.Text == hobby)
                            {
                                checkBox.Checked = true;
                                break;  
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

        private void Profile_Load(object sender, EventArgs e)
        {
            LoadHobbies();
        }
    }
}
