namespace OOPProject
{
    partial class Search
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            lblFilter = new Guna.UI2.WinForms.Guna2HtmlLabel();
            cbxCategory = new Guna.UI2.WinForms.Guna2ComboBox();
            panel1 = new Panel();
            guna2Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // guna2Panel1
            // 
            guna2Panel1.Controls.Add(lblFilter);
            guna2Panel1.Controls.Add(cbxCategory);
            guna2Panel1.CustomizableEdges = customizableEdges3;
            guna2Panel1.Dock = DockStyle.Top;
            guna2Panel1.Location = new Point(0, 0);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2Panel1.Size = new Size(1233, 77);
            guna2Panel1.TabIndex = 0;
            // 
            // lblFilter
            // 
            lblFilter.BackColor = Color.Transparent;
            lblFilter.Font = new Font("Palatino Linotype", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFilter.ForeColor = Color.FromArgb(224, 122, 90);
            lblFilter.Location = new Point(31, 26);
            lblFilter.Name = "lblFilter";
            lblFilter.Size = new Size(102, 33);
            lblFilter.TabIndex = 11;
            lblFilter.Text = "Category:";
            // 
            // cbxCategory
            // 
            cbxCategory.BackColor = Color.Transparent;
            cbxCategory.BorderColor = Color.FromArgb(224, 122, 90);
            cbxCategory.BorderRadius = 10;
            cbxCategory.BorderThickness = 2;
            cbxCategory.CustomizableEdges = customizableEdges1;
            cbxCategory.DrawMode = DrawMode.OwnerDrawFixed;
            cbxCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxCategory.FocusedColor = Color.FromArgb(94, 148, 255);
            cbxCategory.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cbxCategory.Font = new Font("Segoe UI", 10F);
            cbxCategory.ForeColor = Color.FromArgb(68, 88, 112);
            cbxCategory.ItemHeight = 30;
            cbxCategory.Items.AddRange(new object[] { "Cuisine", "Recipe", "Ingredient" });
            cbxCategory.Location = new Point(139, 26);
            cbxCategory.Name = "cbxCategory";
            cbxCategory.ShadowDecoration.CustomizableEdges = customizableEdges2;
            cbxCategory.Size = new Size(167, 36);
            cbxCategory.TabIndex = 10;
            cbxCategory.SelectedIndexChanged += cbxCategory_SelectedIndexChanged;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 77);
            panel1.Name = "panel1";
            panel1.Size = new Size(1233, 1025);
            panel1.TabIndex = 1;
            // 
            // Search
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 245, 237);
            ClientSize = new Size(1233, 1102);
            Controls.Add(panel1);
            Controls.Add(guna2Panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Search";
            Text = "Search";
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblFilter;
        private Guna.UI2.WinForms.Guna2ComboBox cbxCategory;
        private Panel panel1;
    }
}