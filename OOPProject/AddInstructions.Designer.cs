namespace OOPProject
{
    partial class AddInstructions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddInstructions));
            Controls.buttons UploadVid;
            Controls.buttons btnUpdateVid;
            panelHide1 = new Panel();
            pictureBox1 = new PictureBox();
            label10 = new Label();
            rbtnEdit = new RadioButton();
            rbtnAdd = new RadioButton();
            cbxRecipes = new Controls.cmbx();
            label2 = new Label();
            cbxCuisines = new Controls.cmbx();
            label1 = new Label();
            panel1 = new Panel();
            panel3 = new Panel();
            pictureBox2 = new PictureBox();
            panelAdd = new Panel();
            tbxStep = new TextBox();
            tbxInstructions = new Controls.Textbox();
            label9 = new Label();
            btnInstruction = new Controls.buttons();
            lblname = new Label();
            label3 = new Label();
            panelEdit = new Panel();
            tbxSteep = new Controls.Textbox();
            label5 = new Label();
            tbxIns = new Controls.Textbox();
            label4 = new Label();
            btnDelete = new Controls.buttons();
            btnUpdate = new Controls.buttons();
            cbxsteps = new Controls.cmbx();
            label8 = new Label();
            instructionsPanel = new Panel();
            mpInstruction = new AxWMPLib.AxWindowsMediaPlayer();
            mpUpdate = new AxWMPLib.AxWindowsMediaPlayer();
            UploadVid = new Controls.buttons();
            btnUpdateVid = new Controls.buttons();
            panelHide1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panelAdd.SuspendLayout();
            panelEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)mpInstruction).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mpUpdate).BeginInit();
            SuspendLayout();
            // 
            // panelHide1
            // 
            panelHide1.Controls.Add(pictureBox1);
            panelHide1.Location = new Point(53, 309);
            panelHide1.Name = "panelHide1";
            panelHide1.Size = new Size(402, 606);
            panelHide1.TabIndex = 135;
            panelHide1.Visible = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Hidden;
            pictureBox1.Location = new Point(0, 10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(402, 595);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.FromArgb(192, 41, 66);
            label10.Location = new Point(39, 186);
            label10.Name = "label10";
            label10.Size = new Size(70, 27);
            label10.TabIndex = 134;
            label10.Text = "Mode:";
            // 
            // rbtnEdit
            // 
            rbtnEdit.AutoSize = true;
            rbtnEdit.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbtnEdit.ForeColor = Color.FromArgb(192, 41, 66);
            rbtnEdit.Location = new Point(138, 223);
            rbtnEdit.Name = "rbtnEdit";
            rbtnEdit.Size = new Size(62, 27);
            rbtnEdit.TabIndex = 133;
            rbtnEdit.TabStop = true;
            rbtnEdit.Text = "Edit";
            rbtnEdit.UseVisualStyleBackColor = true;
            // 
            // rbtnAdd
            // 
            rbtnAdd.AutoSize = true;
            rbtnAdd.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbtnAdd.ForeColor = Color.FromArgb(192, 41, 66);
            rbtnAdd.Location = new Point(138, 186);
            rbtnAdd.Name = "rbtnAdd";
            rbtnAdd.Size = new Size(64, 27);
            rbtnAdd.TabIndex = 132;
            rbtnAdd.TabStop = true;
            rbtnAdd.Text = "Add";
            rbtnAdd.UseVisualStyleBackColor = true;
            rbtnAdd.CheckedChanged += rbtnAdd_CheckedChanged;
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
            cbxRecipes.Location = new Point(138, 101);
            cbxRecipes.MinimumSize = new Size(200, 30);
            cbxRecipes.Name = "cbxRecipes";
            cbxRecipes.Padding = new Padding(1);
            cbxRecipes.Size = new Size(200, 38);
            cbxRecipes.TabIndex = 131;
            cbxRecipes.Texts = "";
            cbxRecipes.OnSelectedIndexChanged += cbxRecipes_OnSelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(192, 41, 66);
            label2.Location = new Point(41, 104);
            label2.Name = "label2";
            label2.Size = new Size(78, 27);
            label2.TabIndex = 130;
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
            cbxCuisines.Location = new Point(138, 26);
            cbxCuisines.MinimumSize = new Size(200, 30);
            cbxCuisines.Name = "cbxCuisines";
            cbxCuisines.Padding = new Padding(1);
            cbxCuisines.Size = new Size(200, 38);
            cbxCuisines.TabIndex = 129;
            cbxCuisines.Texts = "";
            cbxCuisines.OnSelectedIndexChanged += cbxCuisines_OnSelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(192, 41, 66);
            label1.Location = new Point(41, 30);
            label1.Name = "label1";
            label1.Size = new Size(86, 27);
            label1.TabIndex = 128;
            label1.Text = "Cuisine:";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.BackColor = Color.FromArgb(192, 41, 66);
            panel1.ForeColor = SystemColors.ControlLight;
            panel1.Location = new Point(520, 339);
            panel1.Name = "panel1";
            panel1.Size = new Size(3, 615);
            panel1.TabIndex = 136;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.Controls.Add(pictureBox2);
            panel3.Location = new Point(551, 333);
            panel3.Name = "panel3";
            panel3.Size = new Size(624, 638);
            panel3.TabIndex = 137;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-38, 7);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(679, 638);
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // panelAdd
            // 
            panelAdd.Controls.Add(UploadVid);
            panelAdd.Controls.Add(mpInstruction);
            panelAdd.Controls.Add(tbxStep);
            panelAdd.Controls.Add(tbxInstructions);
            panelAdd.Controls.Add(label9);
            panelAdd.Controls.Add(btnInstruction);
            panelAdd.Controls.Add(lblname);
            panelAdd.Controls.Add(label3);
            panelAdd.Location = new Point(30, 319);
            panelAdd.Name = "panelAdd";
            panelAdd.Size = new Size(461, 641);
            panelAdd.TabIndex = 138;
            // 
            // tbxStep
            // 
            tbxStep.Anchor = AnchorStyles.None;
            tbxStep.BorderStyle = BorderStyle.None;
            tbxStep.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbxStep.ForeColor = Color.FromArgb(192, 41, 66);
            tbxStep.Location = new Point(215, 129);
            tbxStep.Name = "tbxStep";
            tbxStep.Size = new Size(121, 23);
            tbxStep.TabIndex = 141;
            // 
            // tbxInstructions
            // 
            tbxInstructions.BackColor = Color.FromArgb(255, 245, 237);
            tbxInstructions.BorderColor = Color.FromArgb(192, 41, 66);
            tbxInstructions.BorderFocusColor = Color.FromArgb(192, 41, 66);
            tbxInstructions.BorderRadius = 20;
            tbxInstructions.BorderSize = 2;
            tbxInstructions.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold);
            tbxInstructions.ForeColor = Color.FromArgb(64, 64, 64);
            tbxInstructions.Location = new Point(37, 221);
            tbxInstructions.Margin = new Padding(4);
            tbxInstructions.Multiline = true;
            tbxInstructions.Name = "tbxInstructions";
            tbxInstructions.Padding = new Padding(10, 7, 10, 7);
            tbxInstructions.PasswordChar = false;
            tbxInstructions.PlaceholderColor = Color.DarkGray;
            tbxInstructions.PlaceholderText = "";
            tbxInstructions.Size = new Size(388, 126);
            tbxInstructions.TabIndex = 115;
            tbxInstructions.TextAlign = ContentAlignment.TopLeft;
            tbxInstructions.Texts = "";
            tbxInstructions.UnderlinedStyle = false;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.Font = new Font("Palatino Linotype", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.FromArgb(192, 41, 66);
            label9.Location = new Point(120, 33);
            label9.Name = "label9";
            label9.Size = new Size(232, 38);
            label9.TabIndex = 113;
            label9.Text = "Add Instructions";
            // 
            // btnInstruction
            // 
            btnInstruction.Anchor = AnchorStyles.None;
            btnInstruction.BackColor = Color.FromArgb(255, 245, 237);
            btnInstruction.BackgroundColor = Color.FromArgb(255, 245, 237);
            btnInstruction.BorderColor = Color.FromArgb(192, 41, 66);
            btnInstruction.BorderRadius = 10;
            btnInstruction.BorderSize = 2;
            btnInstruction.FlatAppearance.BorderSize = 0;
            btnInstruction.FlatStyle = FlatStyle.Flat;
            btnInstruction.Font = new Font("Palatino Linotype", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnInstruction.ForeColor = Color.FromArgb(192, 41, 66);
            btnInstruction.Location = new Point(143, 574);
            btnInstruction.Name = "btnInstruction";
            btnInstruction.Size = new Size(243, 40);
            btnInstruction.TabIndex = 87;
            btnInstruction.Text = "Add Instruction";
            btnInstruction.TextColor = Color.FromArgb(192, 41, 66);
            btnInstruction.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnInstruction.UseVisualStyleBackColor = false;
            btnInstruction.Click += btnInstruction_Click;
            // 
            // lblname
            // 
            lblname.Anchor = AnchorStyles.None;
            lblname.AutoSize = true;
            lblname.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblname.ForeColor = Color.FromArgb(192, 41, 66);
            lblname.Location = new Point(156, 125);
            lblname.Name = "lblname";
            lblname.Size = new Size(53, 27);
            lblname.TabIndex = 101;
            lblname.Text = "Step";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(192, 41, 66);
            label3.Location = new Point(165, 190);
            label3.Name = "label3";
            label3.Size = new Size(113, 27);
            label3.TabIndex = 103;
            label3.Text = "Instruction";
            // 
            // panelEdit
            // 
            panelEdit.Controls.Add(btnUpdateVid);
            panelEdit.Controls.Add(mpUpdate);
            panelEdit.Controls.Add(tbxSteep);
            panelEdit.Controls.Add(label5);
            panelEdit.Controls.Add(tbxIns);
            panelEdit.Controls.Add(label4);
            panelEdit.Controls.Add(btnDelete);
            panelEdit.Controls.Add(btnUpdate);
            panelEdit.Controls.Add(cbxsteps);
            panelEdit.Controls.Add(label8);
            panelEdit.Location = new Point(561, 319);
            panelEdit.Name = "panelEdit";
            panelEdit.Size = new Size(614, 645);
            panelEdit.TabIndex = 139;
            panelEdit.Visible = false;
            // 
            // tbxSteep
            // 
            tbxSteep.Anchor = AnchorStyles.None;
            tbxSteep.BackColor = Color.FromArgb(236, 236, 234);
            tbxSteep.BorderColor = Color.FromArgb(192, 41, 66);
            tbxSteep.BorderFocusColor = Color.FromArgb(192, 41, 66);
            tbxSteep.BorderRadius = 20;
            tbxSteep.BorderSize = 2;
            tbxSteep.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold);
            tbxSteep.ForeColor = Color.FromArgb(64, 64, 64);
            tbxSteep.Location = new Point(293, 103);
            tbxSteep.Margin = new Padding(4);
            tbxSteep.Multiline = false;
            tbxSteep.Name = "tbxSteep";
            tbxSteep.Padding = new Padding(10, 7, 10, 7);
            tbxSteep.PasswordChar = false;
            tbxSteep.PlaceholderColor = Color.DarkGray;
            tbxSteep.PlaceholderText = "";
            tbxSteep.Size = new Size(62, 42);
            tbxSteep.TabIndex = 121;
            tbxSteep.TextAlign = ContentAlignment.MiddleCenter;
            tbxSteep.Texts = "";
            tbxSteep.UnderlinedStyle = false;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(192, 41, 66);
            label5.Location = new Point(234, 109);
            label5.Name = "label5";
            label5.Size = new Size(53, 27);
            label5.TabIndex = 120;
            label5.Text = "Step";
            // 
            // tbxIns
            // 
            tbxIns.BackColor = Color.FromArgb(255, 245, 237);
            tbxIns.BorderColor = Color.FromArgb(192, 41, 66);
            tbxIns.BorderFocusColor = Color.FromArgb(192, 41, 66);
            tbxIns.BorderRadius = 20;
            tbxIns.BorderSize = 2;
            tbxIns.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold);
            tbxIns.ForeColor = Color.FromArgb(64, 64, 64);
            tbxIns.Location = new Point(80, 205);
            tbxIns.Margin = new Padding(4);
            tbxIns.Multiline = true;
            tbxIns.Name = "tbxIns";
            tbxIns.Padding = new Padding(10, 7, 10, 7);
            tbxIns.PasswordChar = false;
            tbxIns.PlaceholderColor = Color.DarkGray;
            tbxIns.PlaceholderText = "";
            tbxIns.Size = new Size(437, 142);
            tbxIns.TabIndex = 119;
            tbxIns.TextAlign = ContentAlignment.TopLeft;
            tbxIns.Texts = "";
            tbxIns.UnderlinedStyle = false;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(192, 41, 66);
            label4.Location = new Point(243, 174);
            label4.Name = "label4";
            label4.Size = new Size(113, 27);
            label4.TabIndex = 118;
            label4.Text = "Instruction";
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
            btnDelete.Location = new Point(355, 582);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(243, 40);
            btnDelete.TabIndex = 96;
            btnDelete.Text = "Delete Instruction";
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
            btnUpdate.Location = new Point(22, 581);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(243, 40);
            btnUpdate.TabIndex = 91;
            btnUpdate.Text = "Update Instruction";
            btnUpdate.TextColor = Color.FromArgb(192, 41, 66);
            btnUpdate.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // cbxsteps
            // 
            cbxsteps.Anchor = AnchorStyles.None;
            cbxsteps.BackColor = Color.FromArgb(255, 245, 237);
            cbxsteps.BorderColor = Color.FromArgb(192, 41, 66);
            cbxsteps.BorderSize = 1;
            cbxsteps.DropDownStyle = ComboBoxStyle.DropDown;
            cbxsteps.Font = new Font("Segoe UI", 10F);
            cbxsteps.ForeColor = Color.FromArgb(192, 41, 66);
            cbxsteps.IconColor = Color.FromArgb(224, 122, 90);
            cbxsteps.ListBackColor = Color.FromArgb(236, 236, 234);
            cbxsteps.ListTextColor = Color.FromArgb(192, 41, 66);
            cbxsteps.Location = new Point(157, 30);
            cbxsteps.MinimumSize = new Size(200, 30);
            cbxsteps.Name = "cbxsteps";
            cbxsteps.Padding = new Padding(1);
            cbxsteps.Size = new Size(270, 38);
            cbxsteps.TabIndex = 113;
            cbxsteps.Texts = "";
            cbxsteps.OnSelectedIndexChanged += cbxsteps_OnSelectedIndexChanged;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(192, 41, 66);
            label8.Location = new Point(22, 33);
            label8.Name = "label8";
            label8.Size = new Size(129, 27);
            label8.TabIndex = 112;
            label8.Text = "Select a step:";
            // 
            // instructionsPanel
            // 
            instructionsPanel.AutoScroll = true;
            instructionsPanel.BorderStyle = BorderStyle.Fixed3D;
            instructionsPanel.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold);
            instructionsPanel.ForeColor = Color.FromArgb(192, 41, 66);
            instructionsPanel.Location = new Point(548, 30);
            instructionsPanel.Name = "instructionsPanel";
            instructionsPanel.Size = new Size(627, 234);
            instructionsPanel.TabIndex = 140;
            // 
            // mpInstruction
            // 
            mpInstruction.Enabled = true;
            mpInstruction.Location = new Point(37, 377);
            mpInstruction.Name = "mpInstruction";
            mpInstruction.OcxState = (AxHost.State)resources.GetObject("mpInstruction.OcxState");
            mpInstruction.Size = new Size(388, 170);
            mpInstruction.TabIndex = 142;
            mpInstruction.Enter += mpInstruction_Enter;
            // 
            // mpUpdate
            // 
            mpUpdate.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            mpUpdate.Enabled = true;
            mpUpdate.Location = new Point(80, 377);
            mpUpdate.Name = "mpUpdate";
            mpUpdate.OcxState = (AxHost.State)resources.GetObject("mpUpdate.OcxState");
            mpUpdate.Size = new Size(450, 170);
            mpUpdate.TabIndex = 143;
            // 
            // UploadVid
            // 
            UploadVid.BackColor = Color.Transparent;
            UploadVid.BackgroundColor = Color.Transparent;
            UploadVid.BorderColor = Color.FromArgb(192, 41, 66);
            UploadVid.BorderRadius = 25;
            UploadVid.BorderSize = 3;
            UploadVid.FlatAppearance.BorderSize = 0;
            UploadVid.FlatStyle = FlatStyle.Flat;
            UploadVid.ForeColor = Color.FromArgb(192, 41, 66);
            UploadVid.Image = Properties.Resources.upload__2_;
            UploadVid.Location = new Point(45, 569);
            UploadVid.Name = "UploadVid";
            UploadVid.Size = new Size(52, 50);
            UploadVid.TabIndex = 143;
            UploadVid.TextColor = Color.FromArgb(192, 41, 66);
            UploadVid.UseVisualStyleBackColor = false;
            UploadVid.Click += UploadVid_Click;
            // 
            // btnUpdateVid
            // 
            btnUpdateVid.BackColor = Color.Transparent;
            btnUpdateVid.BackgroundColor = Color.Transparent;
            btnUpdateVid.BorderColor = Color.FromArgb(192, 41, 66);
            btnUpdateVid.BorderRadius = 25;
            btnUpdateVid.BorderSize = 3;
            btnUpdateVid.FlatAppearance.BorderSize = 0;
            btnUpdateVid.FlatStyle = FlatStyle.Flat;
            btnUpdateVid.ForeColor = Color.FromArgb(192, 41, 66);
            btnUpdateVid.Image = Properties.Resources.upload__2_;
            btnUpdateVid.Location = new Point(285, 576);
            btnUpdateVid.Name = "btnUpdateVid";
            btnUpdateVid.Size = new Size(52, 50);
            btnUpdateVid.TabIndex = 144;
            btnUpdateVid.TextColor = Color.FromArgb(192, 41, 66);
            btnUpdateVid.UseVisualStyleBackColor = false;
            // 
            // AddInstructions
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 245, 237);
            ClientSize = new Size(1232, 983);
            Controls.Add(instructionsPanel);
            Controls.Add(panelEdit);
            Controls.Add(panelAdd);
            Controls.Add(panel1);
            Controls.Add(panelHide1);
            Controls.Add(panel3);
            Controls.Add(label10);
            Controls.Add(rbtnEdit);
            Controls.Add(rbtnAdd);
            Controls.Add(cbxRecipes);
            Controls.Add(label2);
            Controls.Add(cbxCuisines);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddInstructions";
            Text = "AddInstructions";
            panelHide1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panelAdd.ResumeLayout(false);
            panelAdd.PerformLayout();
            panelEdit.ResumeLayout(false);
            panelEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)mpInstruction).EndInit();
            ((System.ComponentModel.ISupportInitialize)mpUpdate).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelHide1;
        private PictureBox pictureBox1;
        private Label label10;
        private RadioButton rbtnEdit;
        private RadioButton rbtnAdd;
        private Controls.cmbx cbxRecipes;
        private Label label2;
        private Controls.cmbx cbxCuisines;
        private Label label1;
        private Panel panel1;
        private Panel panel3;
        private PictureBox pictureBox2;
        private Panel panelAdd;
        private Label label9;
        private Controls.buttons btnInstruction;
        private Label lblname;
        private Label label3;
        private Controls.Textbox tbxInstructions;
        private Panel panelEdit;
        private Controls.Textbox tbxIns;
        private Label label4;
        private Controls.buttons btnDelete;
        private Controls.buttons btnUpdate;
        private Controls.cmbx cbxsteps;
        private Label label8;
        private Controls.Textbox tbxSteep;
        private Label label5;
        private Panel instructionsPanel;
        private TextBox tbxStep;
        private AxWMPLib.AxWindowsMediaPlayer mpInstruction;
        private AxWMPLib.AxWindowsMediaPlayer mpUpdate;
    }
}