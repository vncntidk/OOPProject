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

namespace OOPProject
{
    public partial class ShowProfile : Form
    {
        private string username;
        public ShowProfile(string chosenUsername)
        {
            InitializeComponent();
            username = chosenUsername;
            LoadProfileData();
            LoadHobbies();
        }

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=RecipeCatalogdb.mdb");
        OleDbCommand cmd = new OleDbCommand();
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
    }
}
