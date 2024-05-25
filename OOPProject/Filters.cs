using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPProject
{
    public partial class Filters : Form
    {
        public string SelectedCategory { get; set; }
        public string SelectedDifficulty { get; set; }
        public Filters()
        {
            InitializeComponent();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            SelectedCategory = GetSelectedCategory();
            SelectedDifficulty = GetSelectedDifficulty();
            this.Close();
        }

        private string GetSelectedDifficulty()
        {
            List<string> selectedDifficulties = new List<string>();

            if (chkBeg.Checked)
            {
                selectedDifficulties.Add("Beginner");
            }

            if (chkInt.Checked)
            {
                selectedDifficulties.Add("Intermediate");
            }

            if (chkEx.Checked)
            {
                selectedDifficulties.Add("Expert");
            }

             
            if (selectedDifficulties.Count == 0)
            {
                return "";
            }
            else
            {
                 
                return string.Join(", ", selectedDifficulties);
            }
        }

        private string GetSelectedCategory()
        {
            if (rbtnCuis.Checked)
            {
                return "Cuisine";
            }
            else if (rbtnRecipe.Checked)
            {
                return "Recipe";
            }
            else if (rbtnIng.Checked)
            {
                return "Ingredient";
            }
            else
            {
                 
                return "";
            }
        }

    }
}
