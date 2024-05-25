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
    public partial class CuisineMenu : Form
    {
        private string username;
        private bool panelVisible = false;
        private Form currentForm;
        public CuisineMenu(string loggedInUsername)
        {
            InitializeComponent();
            username = loggedInUsername;
            this.Resize += CuisineMenu_Resize;
            panel2.SizeChanged += panel2_SizeChanged;

        }

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=RecipeCatalogdb.mdb");
        OleDbCommand cmd = new OleDbCommand();
        DataSet ds = new DataSet();
        OleDbDataAdapter da = new OleDbDataAdapter();

        private void tbxCuisine_Load(object sender, EventArgs e)
        {

        }

        private void buttons1_Click(object sender, EventArgs e)
        {
            ds = new DataSet();
            con.Open();
            System.Windows.Forms.MessageBox.Show("Connected successfully!");
            con.Close();
        }
        private void ResetButtonColors()
        {
            btnCusines.BackColor = SystemColors.Control;
            btnRecipe.BackColor = SystemColors.Control;
            btnIngredients.BackColor = SystemColors.Control;
            btnInstructions.BackColor = SystemColors.Control;
        }

        private void btnCusines_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            OpenAnotherForm(new AddCuisines(username));
            this.Focus();  
            btnCusines.BackColor = Color.Linen;
        }

        private void btnRecipe_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            OpenAnotherForm(new AddRecipe(username));
            btnRecipe.BackColor = Color.Linen;
        }

        private void btnIngredients_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            OpenAnotherForm(new AddIngredients(username));
            btnIngredients.BackColor = Color.Linen;
        }

        private void btnInstructions_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            OpenAnotherForm(new AddInstructions(username));
            btnInstructions.BackColor = Color.Linen;
        }

        private void OpenAnotherForm(Form form)
        {
             
            currentForm = form;

             
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;


             
            panelControl.Controls.Clear();

             
            panelControl.Controls.Add(form);

             
            this.ClientSize = new Size(this.ClientSize.Width, 1102);  
            panelVisible = true;

             
            form.Show();
        }

        private void CuisineMenu_Resize(object sender, EventArgs e)
        {
             
            int buttonWidth = ButtonPanel.Width / 4;

             
            btnCusines.Width = buttonWidth;
            btnRecipe.Width = buttonWidth;
            btnIngredients.Width = buttonWidth;
            btnInstructions.Width = buttonWidth;

        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnPanelSize_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Panel2 Size: Width = {panel2.Width}, Height = {panel2.Height}");
        }

        private void panel2_SizeChanged(object sender, EventArgs e)
        {
            if (panel2.Width >= 1653 && panel2.Height >= 306)
            {
                 
                iconPictureBox1.BackgroundImage = Image.FromFile("D:\\Downloads\\IDKK.png");
            }
            else
            {
                iconPictureBox1.BackgroundImage = Image.FromFile("D:\\Downloads\\miniz (1).png");
            }
        }

        private void btnPanelSize_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show($"Panel2 Size: Width = {panel2.Width}, Height = {panel2.Height}");
        }
    }
}
