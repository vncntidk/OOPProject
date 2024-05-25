namespace OOPProject
{
    partial class CuisineMenu
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
            btnCusines = new Controls.buttons();
            cbxCuisines = new ComboBox();
            lblCuisines = new Label();
            lblRecipe = new Label();
            cbxRecipes = new ComboBox();
            ingredientsPanel = new Panel();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            panel2 = new Panel();
            ButtonPanel = new Panel();
            btnInstructions = new Controls.buttons();
            btnIngredients = new Controls.buttons();
            btnRecipe = new Controls.buttons();
            panelControl = new Panel();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            panel2.SuspendLayout();
            ButtonPanel.SuspendLayout();
            SuspendLayout();
            // 
            // btnCusines
            // 
            btnCusines.BackColor = Color.FromArgb(255, 245, 237);
            btnCusines.BackgroundColor = Color.FromArgb(255, 245, 237);
            btnCusines.BorderColor = Color.FromArgb(192, 41, 66);
            btnCusines.BorderRadius = 0;
            btnCusines.BorderSize = 0;
            btnCusines.Dock = DockStyle.Left;
            btnCusines.FlatAppearance.BorderSize = 0;
            btnCusines.FlatStyle = FlatStyle.Flat;
            btnCusines.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCusines.ForeColor = Color.FromArgb(192, 41, 66);
            btnCusines.Location = new Point(0, 0);
            btnCusines.Name = "btnCusines";
            btnCusines.Size = new Size(308, 59);
            btnCusines.TabIndex = 49;
            btnCusines.Text = "Cuisines";
            btnCusines.TextColor = Color.FromArgb(192, 41, 66);
            btnCusines.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCusines.UseVisualStyleBackColor = false;
            btnCusines.Click += btnCusines_Click;
            // 
            // cbxCuisines
            // 
            cbxCuisines.FormattingEnabled = true;
            cbxCuisines.Location = new Point(63, 185);
            cbxCuisines.Name = "cbxCuisines";
            cbxCuisines.Size = new Size(151, 28);
            cbxCuisines.TabIndex = 52;
            // 
            // lblCuisines
            // 
            lblCuisines.AutoSize = true;
            lblCuisines.Location = new Point(63, 149);
            lblCuisines.Name = "lblCuisines";
            lblCuisines.Size = new Size(62, 20);
            lblCuisines.TabIndex = 53;
            lblCuisines.Text = "Cuisines";
            // 
            // lblRecipe
            // 
            lblRecipe.AutoSize = true;
            lblRecipe.Location = new Point(277, 149);
            lblRecipe.Name = "lblRecipe";
            lblRecipe.Size = new Size(60, 20);
            lblRecipe.TabIndex = 55;
            lblRecipe.Text = "Recipes";
            // 
            // cbxRecipes
            // 
            cbxRecipes.FormattingEnabled = true;
            cbxRecipes.Location = new Point(277, 185);
            cbxRecipes.Name = "cbxRecipes";
            cbxRecipes.Size = new Size(151, 28);
            cbxRecipes.TabIndex = 54;
            // 
            // ingredientsPanel
            // 
            ingredientsPanel.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ingredientsPanel.ForeColor = Color.FromArgb(192, 41, 66);
            ingredientsPanel.Location = new Point(479, 149);
            ingredientsPanel.Name = "ingredientsPanel";
            ingredientsPanel.Size = new Size(323, 81);
            ingredientsPanel.TabIndex = 56;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.FromArgb(236, 236, 234);
            iconPictureBox1.BackgroundImage = Properties.Resources.Untitled_design__9_;
            iconPictureBox1.Dock = DockStyle.Fill;
            iconPictureBox1.ForeColor = SystemColors.ControlText;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconPictureBox1.IconColor = SystemColors.ControlText;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 306;
            iconPictureBox1.Location = new Point(0, 0);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(1211, 306);
            iconPictureBox1.TabIndex = 58;
            iconPictureBox1.TabStop = false;
            iconPictureBox1.Click += iconPictureBox1_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(iconPictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1211, 306);
            panel2.TabIndex = 62;
            panel2.SizeChanged += panel2_SizeChanged;
            // 
            // ButtonPanel
            // 
            ButtonPanel.Controls.Add(btnInstructions);
            ButtonPanel.Controls.Add(btnIngredients);
            ButtonPanel.Controls.Add(btnRecipe);
            ButtonPanel.Controls.Add(btnCusines);
            ButtonPanel.Dock = DockStyle.Top;
            ButtonPanel.Location = new Point(0, 306);
            ButtonPanel.Name = "ButtonPanel";
            ButtonPanel.Size = new Size(1211, 59);
            ButtonPanel.TabIndex = 76;
            // 
            // btnInstructions
            // 
            btnInstructions.BackColor = Color.FromArgb(255, 245, 237);
            btnInstructions.BackgroundColor = Color.FromArgb(255, 245, 237);
            btnInstructions.BorderColor = Color.FromArgb(192, 41, 66);
            btnInstructions.BorderRadius = 0;
            btnInstructions.BorderSize = 0;
            btnInstructions.Dock = DockStyle.Left;
            btnInstructions.FlatAppearance.BorderSize = 0;
            btnInstructions.FlatStyle = FlatStyle.Flat;
            btnInstructions.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnInstructions.ForeColor = Color.FromArgb(192, 41, 66);
            btnInstructions.Location = new Point(924, 0);
            btnInstructions.Name = "btnInstructions";
            btnInstructions.Size = new Size(287, 59);
            btnInstructions.TabIndex = 52;
            btnInstructions.Text = "Instructions";
            btnInstructions.TextColor = Color.FromArgb(192, 41, 66);
            btnInstructions.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnInstructions.UseVisualStyleBackColor = false;
            btnInstructions.Click += btnInstructions_Click;
            // 
            // btnIngredients
            // 
            btnIngredients.BackColor = Color.FromArgb(255, 245, 237);
            btnIngredients.BackgroundColor = Color.FromArgb(255, 245, 237);
            btnIngredients.BorderColor = Color.FromArgb(192, 41, 66);
            btnIngredients.BorderRadius = 0;
            btnIngredients.BorderSize = 0;
            btnIngredients.Dock = DockStyle.Left;
            btnIngredients.FlatAppearance.BorderSize = 0;
            btnIngredients.FlatStyle = FlatStyle.Flat;
            btnIngredients.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnIngredients.ForeColor = Color.FromArgb(192, 41, 66);
            btnIngredients.Location = new Point(616, 0);
            btnIngredients.Name = "btnIngredients";
            btnIngredients.Size = new Size(308, 59);
            btnIngredients.TabIndex = 51;
            btnIngredients.Text = "Ingredients";
            btnIngredients.TextColor = Color.FromArgb(192, 41, 66);
            btnIngredients.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnIngredients.UseVisualStyleBackColor = false;
            btnIngredients.Click += btnIngredients_Click;
            // 
            // btnRecipe
            // 
            btnRecipe.BackColor = Color.FromArgb(255, 245, 237);
            btnRecipe.BackgroundColor = Color.FromArgb(255, 245, 237);
            btnRecipe.BorderColor = Color.FromArgb(192, 41, 66);
            btnRecipe.BorderRadius = 0;
            btnRecipe.BorderSize = 0;
            btnRecipe.Dock = DockStyle.Left;
            btnRecipe.FlatAppearance.BorderSize = 0;
            btnRecipe.FlatStyle = FlatStyle.Flat;
            btnRecipe.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRecipe.ForeColor = Color.FromArgb(192, 41, 66);
            btnRecipe.Location = new Point(308, 0);
            btnRecipe.Name = "btnRecipe";
            btnRecipe.Size = new Size(308, 59);
            btnRecipe.TabIndex = 50;
            btnRecipe.Text = "Recipes";
            btnRecipe.TextColor = Color.FromArgb(192, 41, 66);
            btnRecipe.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRecipe.UseVisualStyleBackColor = false;
            btnRecipe.Click += btnRecipe_Click;
            // 
            // panelControl
            // 
            panelControl.AutoScroll = true;
            panelControl.BackColor = Color.FromArgb(255, 245, 237);
            panelControl.Dock = DockStyle.Top;
            panelControl.Location = new Point(0, 365);
            panelControl.Name = "panelControl";
            panelControl.Size = new Size(1211, 1153);
            panelControl.TabIndex = 77;
            // 
            // CuisineMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(236, 236, 234);
            ClientSize = new Size(1232, 1102);
            Controls.Add(panelControl);
            Controls.Add(ButtonPanel);
            Controls.Add(panel2);
            Controls.Add(ingredientsPanel);
            Controls.Add(lblRecipe);
            Controls.Add(cbxRecipes);
            Controls.Add(lblCuisines);
            Controls.Add(cbxCuisines);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CuisineMenu";
            Text = "Cuisines";
            Resize += CuisineMenu_Resize;
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ButtonPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Controls.Textbox tbxRecipe;
        private Label label5;
        private Controls.buttons btnCusines;
        private ComboBox cbxCuisines;
        private Label lblCuisines;
        private Label lblRecipe;
        private ComboBox cbxRecipes;
        private Panel ingredientsPanel;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Panel panel2;
        private Panel ButtonPanel;
        private Controls.buttons btnInstructions;
        private Controls.buttons btnIngredients;
        private Controls.buttons btnRecipe;
        private Panel panelControl;
    }
}