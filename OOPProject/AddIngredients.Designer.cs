namespace OOPProject
{
    partial class AddIngredients
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddIngredients));
            cbxRecipes = new Controls.cmbx();
            label2 = new Label();
            cbxCuisines = new Controls.cmbx();
            btnDelete = new Controls.buttons();
            btnUpdate = new Controls.buttons();
            tbxAdd = new TextBox();
            btnIngredient = new Controls.buttons();
            label1 = new Label();
            lblname = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            label4 = new Label();
            textBox2 = new TextBox();
            label5 = new Label();
            tbxPrice = new TextBox();
            label6 = new Label();
            tbxAmount = new TextBox();
            label7 = new Label();
            tbxName = new TextBox();
            cbxIngredient = new Controls.cmbx();
            label8 = new Label();
            ingredientsPanel = new Panel();
            panel1 = new Panel();
            panelAdd = new Panel();
            label9 = new Label();
            panelEdit = new Panel();
            label10 = new Label();
            rbtnEdit = new RadioButton();
            rbtnAdd = new RadioButton();
            label11 = new Label();
            labelRecipe = new Label();
            panel3 = new Panel();
            pictureBox2 = new PictureBox();
            panelHide1 = new Panel();
            pictureBox1 = new PictureBox();
            panelAdd.SuspendLayout();
            panelEdit.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panelHide1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // cbxRecipes
            // 
            cbxRecipes.BackColor = Color.FromArgb(255, 245, 237);
            cbxRecipes.BorderColor = Color.FromArgb(192, 41, 66);
            cbxRecipes.BorderSize = 1;
            cbxRecipes.DropDownStyle = ComboBoxStyle.DropDown;
            cbxRecipes.Font = new Font("Segoe UI", 10F);
            cbxRecipes.ForeColor = Color.FromArgb(192, 41, 66);
            cbxRecipes.IconColor = Color.FromArgb(224, 122, 90);
            cbxRecipes.ListBackColor = Color.FromArgb(236, 236, 234);
            cbxRecipes.ListTextColor = Color.FromArgb(192, 41, 66);
            cbxRecipes.Location = new Point(133, 104);
            cbxRecipes.MinimumSize = new Size(200, 30);
            cbxRecipes.Name = "cbxRecipes";
            cbxRecipes.Padding = new Padding(1);
            cbxRecipes.Size = new Size(200, 38);
            cbxRecipes.TabIndex = 100;
            cbxRecipes.Texts = "";
            cbxRecipes.OnSelectedIndexChanged += cbxRecipes_OnSelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(192, 41, 66);
            label2.Location = new Point(36, 107);
            label2.Name = "label2";
            label2.Size = new Size(78, 27);
            label2.TabIndex = 99;
            label2.Text = "Recipe:";
            // 
            // cbxCuisines
            // 
            cbxCuisines.BackColor = Color.FromArgb(255, 245, 237);
            cbxCuisines.BorderColor = Color.FromArgb(192, 41, 66);
            cbxCuisines.BorderSize = 1;
            cbxCuisines.DropDownStyle = ComboBoxStyle.DropDown;
            cbxCuisines.Font = new Font("Segoe UI", 10F);
            cbxCuisines.ForeColor = Color.FromArgb(192, 41, 66);
            cbxCuisines.IconColor = Color.FromArgb(224, 122, 90);
            cbxCuisines.ListBackColor = Color.FromArgb(236, 236, 234);
            cbxCuisines.ListTextColor = Color.FromArgb(192, 41, 66);
            cbxCuisines.Location = new Point(133, 29);
            cbxCuisines.MinimumSize = new Size(200, 30);
            cbxCuisines.Name = "cbxCuisines";
            cbxCuisines.Padding = new Padding(1);
            cbxCuisines.Size = new Size(200, 38);
            cbxCuisines.TabIndex = 98;
            cbxCuisines.Texts = "";
            cbxCuisines.OnSelectedIndexChanged += cbxCuisines_OnSelectedIndexChanged;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.None;
            btnDelete.BackColor = Color.FromArgb(255, 245, 237);
            btnDelete.BackgroundColor = Color.FromArgb(255, 245, 237);
            btnDelete.BorderColor = Color.FromArgb(192, 41, 66);
            btnDelete.BorderRadius = 10;
            btnDelete.BorderSize = 2;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Palatino Linotype", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.FromArgb(192, 41, 66);
            btnDelete.Location = new Point(369, 478);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(243, 40);
            btnDelete.TabIndex = 96;
            btnDelete.Text = "Delete recipe";
            btnDelete.TextColor = Color.FromArgb(192, 41, 66);
            btnDelete.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = AnchorStyles.None;
            btnUpdate.BackColor = Color.FromArgb(255, 245, 237);
            btnUpdate.BackgroundColor = Color.FromArgb(255, 245, 237);
            btnUpdate.BorderColor = Color.FromArgb(192, 41, 66);
            btnUpdate.BorderRadius = 10;
            btnUpdate.BorderSize = 2;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Palatino Linotype", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = Color.FromArgb(192, 41, 66);
            btnUpdate.Location = new Point(53, 478);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(243, 40);
            btnUpdate.TabIndex = 91;
            btnUpdate.Text = "Update recipe";
            btnUpdate.TextColor = Color.FromArgb(192, 41, 66);
            btnUpdate.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // tbxAdd
            // 
            tbxAdd.Anchor = AnchorStyles.None;
            tbxAdd.BorderStyle = BorderStyle.None;
            tbxAdd.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbxAdd.ForeColor = Color.FromArgb(192, 41, 66);
            tbxAdd.Location = new Point(76, 142);
            tbxAdd.Name = "tbxAdd";
            tbxAdd.Size = new Size(289, 23);
            tbxAdd.TabIndex = 88;
            // 
            // btnIngredient
            // 
            btnIngredient.Anchor = AnchorStyles.None;
            btnIngredient.BackColor = Color.FromArgb(255, 245, 237);
            btnIngredient.BackgroundColor = Color.FromArgb(255, 245, 237);
            btnIngredient.BorderColor = Color.FromArgb(192, 41, 66);
            btnIngredient.BorderRadius = 10;
            btnIngredient.BorderSize = 2;
            btnIngredient.FlatAppearance.BorderSize = 0;
            btnIngredient.FlatStyle = FlatStyle.Flat;
            btnIngredient.Font = new Font("Palatino Linotype", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnIngredient.ForeColor = Color.FromArgb(192, 41, 66);
            btnIngredient.Location = new Point(99, 427);
            btnIngredient.Name = "btnIngredient";
            btnIngredient.Size = new Size(243, 40);
            btnIngredient.TabIndex = 87;
            btnIngredient.Text = "Add Ingredient";
            btnIngredient.TextColor = Color.FromArgb(192, 41, 66);
            btnIngredient.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnIngredient.UseVisualStyleBackColor = false;
            btnIngredient.Click += btnIngredient_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(192, 41, 66);
            label1.Location = new Point(36, 33);
            label1.Name = "label1";
            label1.Size = new Size(86, 27);
            label1.TabIndex = 85;
            label1.Text = "Cuisine:";
            // 
            // lblname
            // 
            lblname.Anchor = AnchorStyles.None;
            lblname.AutoSize = true;
            lblname.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblname.ForeColor = Color.FromArgb(192, 41, 66);
            lblname.Location = new Point(133, 98);
            lblname.Name = "lblname";
            lblname.Size = new Size(168, 27);
            lblname.TabIndex = 101;
            lblname.Text = "Ingredient Name";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(192, 41, 66);
            label3.Location = new Point(122, 202);
            label3.Name = "label3";
            label3.Size = new Size(188, 27);
            label3.TabIndex = 103;
            label3.Text = "Ingredient Amount";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.FromArgb(192, 41, 66);
            textBox1.Location = new Point(76, 245);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(289, 23);
            textBox1.TabIndex = 102;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(192, 41, 66);
            label4.Location = new Point(133, 298);
            label4.Name = "label4";
            label4.Size = new Size(158, 27);
            label4.TabIndex = 105;
            label4.Text = "Ingredient Price";
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.None;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox2.ForeColor = Color.FromArgb(192, 41, 66);
            textBox2.Location = new Point(76, 345);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(289, 23);
            textBox2.TabIndex = 104;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(192, 41, 66);
            label5.Location = new Point(268, 349);
            label5.Name = "label5";
            label5.Size = new Size(158, 27);
            label5.TabIndex = 111;
            label5.Text = "Ingredient Price";
            // 
            // tbxPrice
            // 
            tbxPrice.Anchor = AnchorStyles.None;
            tbxPrice.BorderStyle = BorderStyle.None;
            tbxPrice.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbxPrice.ForeColor = Color.FromArgb(192, 41, 66);
            tbxPrice.Location = new Point(231, 396);
            tbxPrice.Name = "tbxPrice";
            tbxPrice.Size = new Size(242, 23);
            tbxPrice.TabIndex = 110;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(192, 41, 66);
            label6.Location = new Point(263, 253);
            label6.Name = "label6";
            label6.Size = new Size(188, 27);
            label6.TabIndex = 109;
            label6.Text = "Ingredient Amount";
            // 
            // tbxAmount
            // 
            tbxAmount.Anchor = AnchorStyles.None;
            tbxAmount.BorderStyle = BorderStyle.None;
            tbxAmount.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbxAmount.ForeColor = Color.FromArgb(192, 41, 66);
            tbxAmount.Location = new Point(231, 296);
            tbxAmount.Name = "tbxAmount";
            tbxAmount.Size = new Size(242, 23);
            tbxAmount.TabIndex = 108;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(192, 41, 66);
            label7.Location = new Point(274, 149);
            label7.Name = "label7";
            label7.Size = new Size(168, 27);
            label7.TabIndex = 107;
            label7.Text = "Ingredient Name";
            // 
            // tbxName
            // 
            tbxName.Anchor = AnchorStyles.None;
            tbxName.BorderStyle = BorderStyle.None;
            tbxName.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbxName.ForeColor = Color.FromArgb(192, 41, 66);
            tbxName.Location = new Point(184, 193);
            tbxName.Name = "tbxName";
            tbxName.Size = new Size(340, 23);
            tbxName.TabIndex = 106;
            // 
            // cbxIngredient
            // 
            cbxIngredient.Anchor = AnchorStyles.None;
            cbxIngredient.BackColor = Color.FromArgb(255, 245, 237);
            cbxIngredient.BorderColor = Color.FromArgb(192, 41, 66);
            cbxIngredient.BorderSize = 1;
            cbxIngredient.DropDownStyle = ComboBoxStyle.DropDown;
            cbxIngredient.Font = new Font("Segoe UI", 10F);
            cbxIngredient.ForeColor = Color.FromArgb(192, 41, 66);
            cbxIngredient.IconColor = Color.FromArgb(224, 122, 90);
            cbxIngredient.ListBackColor = Color.FromArgb(236, 236, 234);
            cbxIngredient.ListTextColor = Color.FromArgb(192, 41, 66);
            cbxIngredient.Location = new Point(248, 32);
            cbxIngredient.MinimumSize = new Size(200, 30);
            cbxIngredient.Name = "cbxIngredient";
            cbxIngredient.Padding = new Padding(1);
            cbxIngredient.Size = new Size(270, 38);
            cbxIngredient.TabIndex = 113;
            cbxIngredient.Texts = "";
            cbxIngredient.OnSelectedIndexChanged += cbxIngredient_OnSelectedIndexChanged;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(192, 41, 66);
            label8.Location = new Point(38, 36);
            label8.Name = "label8";
            label8.Size = new Size(197, 27);
            label8.TabIndex = 112;
            label8.Text = "Select an ingredient:";
            // 
            // ingredientsPanel
            // 
            ingredientsPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ingredientsPanel.AutoScroll = true;
            ingredientsPanel.BorderStyle = BorderStyle.Fixed3D;
            ingredientsPanel.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold);
            ingredientsPanel.ForeColor = Color.FromArgb(192, 41, 66);
            ingredientsPanel.Location = new Point(539, 59);
            ingredientsPanel.Name = "ingredientsPanel";
            ingredientsPanel.Size = new Size(501, 205);
            ingredientsPanel.TabIndex = 117;
            ingredientsPanel.Paint += ingredientsPanel_Paint;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.BackColor = Color.FromArgb(192, 41, 66);
            panel1.ForeColor = SystemColors.ControlLight;
            panel1.Location = new Point(461, 299);
            panel1.Name = "panel1";
            panel1.Size = new Size(3, 615);
            panel1.TabIndex = 118;
            // 
            // panelAdd
            // 
            panelAdd.Controls.Add(label9);
            panelAdd.Controls.Add(label4);
            panelAdd.Controls.Add(btnIngredient);
            panelAdd.Controls.Add(textBox1);
            panelAdd.Controls.Add(tbxAdd);
            panelAdd.Controls.Add(lblname);
            panelAdd.Controls.Add(label3);
            panelAdd.Controls.Add(textBox2);
            panelAdd.Location = new Point(8, 344);
            panelAdd.Name = "panelAdd";
            panelAdd.Size = new Size(443, 488);
            panelAdd.TabIndex = 119;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.Font = new Font("Palatino Linotype", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.FromArgb(192, 41, 66);
            label9.Location = new Point(108, 18);
            label9.Name = "label9";
            label9.Size = new Size(219, 38);
            label9.TabIndex = 113;
            label9.Text = "New Ingredient";
            // 
            // panelEdit
            // 
            panelEdit.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelEdit.Controls.Add(btnDelete);
            panelEdit.Controls.Add(btnUpdate);
            panelEdit.Controls.Add(cbxIngredient);
            panelEdit.Controls.Add(tbxName);
            panelEdit.Controls.Add(label8);
            panelEdit.Controls.Add(label7);
            panelEdit.Controls.Add(label5);
            panelEdit.Controls.Add(tbxAmount);
            panelEdit.Controls.Add(tbxPrice);
            panelEdit.Controls.Add(label6);
            panelEdit.Location = new Point(498, 314);
            panelEdit.Name = "panelEdit";
            panelEdit.Size = new Size(677, 590);
            panelEdit.TabIndex = 120;
            panelEdit.Visible = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.FromArgb(192, 41, 66);
            label10.Location = new Point(34, 189);
            label10.Name = "label10";
            label10.Size = new Size(70, 27);
            label10.TabIndex = 123;
            label10.Text = "Mode:";
            // 
            // rbtnEdit
            // 
            rbtnEdit.AutoSize = true;
            rbtnEdit.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbtnEdit.ForeColor = Color.FromArgb(192, 41, 66);
            rbtnEdit.Location = new Point(133, 226);
            rbtnEdit.Name = "rbtnEdit";
            rbtnEdit.Size = new Size(62, 27);
            rbtnEdit.TabIndex = 122;
            rbtnEdit.TabStop = true;
            rbtnEdit.Text = "Edit";
            rbtnEdit.UseVisualStyleBackColor = true;
            // 
            // rbtnAdd
            // 
            rbtnAdd.AutoSize = true;
            rbtnAdd.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbtnAdd.ForeColor = Color.FromArgb(192, 41, 66);
            rbtnAdd.Location = new Point(133, 189);
            rbtnAdd.Name = "rbtnAdd";
            rbtnAdd.Size = new Size(64, 27);
            rbtnAdd.TabIndex = 121;
            rbtnAdd.TabStop = true;
            rbtnAdd.Text = "Add";
            rbtnAdd.UseVisualStyleBackColor = true;
            rbtnAdd.CheckedChanged += rbtnAdd_CheckedChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold);
            label11.ForeColor = Color.FromArgb(192, 41, 66);
            label11.Location = new Point(540, 18);
            label11.Name = "label11";
            label11.Size = new Size(140, 27);
            label11.TabIndex = 124;
            label11.Text = "Ingredients in";
            // 
            // labelRecipe
            // 
            labelRecipe.AutoSize = true;
            labelRecipe.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold);
            labelRecipe.ForeColor = Color.FromArgb(192, 41, 66);
            labelRecipe.Location = new Point(682, 19);
            labelRecipe.Name = "labelRecipe";
            labelRecipe.Size = new Size(0, 27);
            labelRecipe.TabIndex = 125;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.Controls.Add(pictureBox2);
            panel3.Location = new Point(515, 299);
            panel3.Name = "panel3";
            panel3.Size = new Size(679, 638);
            panel3.TabIndex = 126;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 15);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(679, 638);
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // panelHide1
            // 
            panelHide1.Controls.Add(pictureBox1);
            panelHide1.Location = new Point(24, 314);
            panelHide1.Name = "panelHide1";
            panelHide1.Size = new Size(402, 605);
            panelHide1.TabIndex = 127;
            panelHide1.Visible = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.Hidden;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(402, 605);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // AddIngredients
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(255, 245, 237);
            ClientSize = new Size(1232, 964);
            Controls.Add(panelAdd);
            Controls.Add(panelHide1);
            Controls.Add(panelEdit);
            Controls.Add(labelRecipe);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(rbtnEdit);
            Controls.Add(rbtnAdd);
            Controls.Add(panel1);
            Controls.Add(ingredientsPanel);
            Controls.Add(cbxRecipes);
            Controls.Add(label2);
            Controls.Add(cbxCuisines);
            Controls.Add(label1);
            Controls.Add(panel3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddIngredients";
            Text = "AddIngredients";
            panelAdd.ResumeLayout(false);
            panelAdd.PerformLayout();
            panelEdit.ResumeLayout(false);
            panelEdit.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panelHide1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Controls.cmbx cbxRecipes;
        private Label label2;
        private Controls.cmbx cbxCuisines;
        private Controls.buttons btnDelete;
        private Controls.buttons btnUpdate;
        private TextBox tbxAdd;
        private Controls.buttons btnIngredient;
        private Label label1;
        private Label lblname;
        private Label label3;
        private TextBox textBox1;
        private Label label4;
        private TextBox textBox2;
        private Label label5;
        private TextBox tbxPrice;
        private Label label6;
        private TextBox tbxAmount;
        private Label label7;
        private TextBox tbxName;
        private Controls.cmbx cbxIngredient;
        private Label label8;
        private Panel ingredientsPanel;
        private Panel panel1;
        private Panel panelAdd;
        private Panel panelEdit;
        private Label label9;
        private Label label10;
        private RadioButton rbtnEdit;
        private RadioButton rbtnAdd;
        private Label label11;
        private Label labelRecipe;
        private Panel panel3;
        private PictureBox pictureBox2;
        private Panel panelHide1;
        private PictureBox pictureBox1;
    }
}