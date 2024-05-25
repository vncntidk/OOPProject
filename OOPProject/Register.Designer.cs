namespace OOPProject
{
    partial class FormRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegister));
            label4 = new Label();
            label3 = new Label();
            checkBox2 = new CheckBox();
            txtPass = new TextBox();
            txtUser = new TextBox();
            btnLog = new Button();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            label2 = new Label();
            panel1 = new Panel();
            label1 = new Label();
            txtConPass = new TextBox();
            pictureBox3 = new PictureBox();
            panel3 = new Panel();
            label5 = new Label();
            label6 = new Label();
            pcMax = new PictureBox();
            pcmin = new PictureBox();
            lblClose = new Label();
            pictureBox4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcMax).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcmin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Cursor = Cursors.Hand;
            label4.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(61, 59, 64);
            label4.Location = new Point(215, 670);
            label4.Name = "label4";
            label4.Size = new Size(64, 28);
            label4.TabIndex = 26;
            label4.Text = "Login";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Nirmala UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(61, 59, 64);
            label3.Location = new Point(144, 642);
            label3.Name = "label3";
            label3.Size = new Size(206, 23);
            label3.TabIndex = 25;
            label3.Text = "Already have an account?";
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.BackColor = Color.Transparent;
            checkBox2.Cursor = Cursors.Hand;
            checkBox2.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox2.ForeColor = Color.FromArgb(61, 59, 64);
            checkBox2.Location = new Point(284, 456);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(170, 32);
            checkBox2.TabIndex = 23;
            checkBox2.Text = "Show password";
            checkBox2.UseVisualStyleBackColor = false;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // txtPass
            // 
            txtPass.BackColor = Color.White;
            txtPass.BorderStyle = BorderStyle.None;
            txtPass.Font = new Font("Nirmala UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPass.ForeColor = Color.FromArgb(61, 59, 64);
            txtPass.Location = new Point(48, 312);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '•';
            txtPass.Size = new Size(408, 24);
            txtPass.TabIndex = 22;
            // 
            // txtUser
            // 
            txtUser.BackColor = Color.White;
            txtUser.BorderStyle = BorderStyle.None;
            txtUser.Font = new Font("Nirmala UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtUser.ForeColor = Color.FromArgb(61, 59, 64);
            txtUser.Location = new Point(47, 212);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(408, 24);
            txtUser.TabIndex = 21;
            // 
            // btnLog
            // 
            btnLog.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnLog.BackColor = Color.White;
            btnLog.FlatAppearance.BorderColor = Color.FromArgb(61, 59, 64);
            btnLog.FlatAppearance.BorderSize = 2;
            btnLog.FlatStyle = FlatStyle.Flat;
            btnLog.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLog.ForeColor = Color.FromArgb(61, 59, 64);
            btnLog.Location = new Point(41, 532);
            btnLog.Name = "btnLog";
            btnLog.Size = new Size(415, 52);
            btnLog.TabIndex = 20;
            btnLog.Text = "REGISTER";
            btnLog.UseVisualStyleBackColor = false;
            btnLog.Click += btnLog_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(41, 265);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(52, 37);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 19;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.profile_user;
            pictureBox1.Location = new Point(41, 163);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(52, 37);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(61, 59, 64);
            panel2.Location = new Point(41, 340);
            panel2.Name = "panel2";
            panel2.Size = new Size(413, 2);
            panel2.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(61, 59, 64);
            label2.Location = new Point(89, 270);
            label2.Name = "label2";
            label2.Size = new Size(100, 28);
            label2.TabIndex = 16;
            label2.Text = "Password";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(61, 59, 64);
            panel1.Location = new Point(41, 241);
            panel1.Name = "panel1";
            panel1.Size = new Size(413, 2);
            panel1.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(61, 59, 64);
            label1.Location = new Point(89, 168);
            label1.Name = "label1";
            label1.Size = new Size(106, 28);
            label1.TabIndex = 14;
            label1.Text = "Username";
            // 
            // txtConPass
            // 
            txtConPass.BackColor = Color.White;
            txtConPass.BorderStyle = BorderStyle.None;
            txtConPass.Font = new Font("Nirmala UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtConPass.ForeColor = Color.FromArgb(61, 59, 64);
            txtConPass.Location = new Point(48, 412);
            txtConPass.Name = "txtConPass";
            txtConPass.PasswordChar = '•';
            txtConPass.Size = new Size(408, 24);
            txtConPass.TabIndex = 30;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(41, 364);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(52, 37);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 29;
            pictureBox3.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(61, 59, 64);
            panel3.Location = new Point(41, 441);
            panel3.Name = "panel3";
            panel3.Size = new Size(413, 2);
            panel3.TabIndex = 28;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(61, 59, 64);
            label5.Location = new Point(89, 369);
            label5.Name = "label5";
            label5.Size = new Size(232, 28);
            label5.TabIndex = 27;
            label5.Text = "Confirmation password";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Nirmala UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(61, 59, 64);
            label6.Location = new Point(139, 76);
            label6.Name = "label6";
            label6.Size = new Size(225, 60);
            label6.TabIndex = 31;
            label6.Text = "REGISTER";
            // 
            // pcMax
            // 
            pcMax.BackColor = Color.Transparent;
            pcMax.Cursor = Cursors.Hand;
            pcMax.Image = (Image)resources.GetObject("pcMax.Image");
            pcMax.Location = new Point(406, 14);
            pcMax.Name = "pcMax";
            pcMax.Size = new Size(40, 20);
            pcMax.SizeMode = PictureBoxSizeMode.Zoom;
            pcMax.TabIndex = 34;
            pcMax.TabStop = false;
            // 
            // pcmin
            // 
            pcmin.BackColor = Color.Transparent;
            pcmin.Cursor = Cursors.Hand;
            pcmin.Image = (Image)resources.GetObject("pcmin.Image");
            pcmin.Location = new Point(361, 14);
            pcmin.Name = "pcmin";
            pcmin.Size = new Size(40, 20);
            pcmin.SizeMode = PictureBoxSizeMode.Zoom;
            pcmin.TabIndex = 33;
            pcmin.TabStop = false;
            pcmin.Click += pcmin_Click;
            // 
            // lblClose
            // 
            lblClose.AutoSize = true;
            lblClose.Cursor = Cursors.Hand;
            lblClose.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblClose.ForeColor = Color.RoyalBlue;
            lblClose.Location = new Point(451, 14);
            lblClose.Name = "lblClose";
            lblClose.Size = new Size(0, 20);
            lblClose.TabIndex = 32;
            lblClose.Click += lblClose_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.Cursor = Cursors.Hand;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(446, 14);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(40, 20);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 35;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // FormRegister
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(24, 30, 54);
            BackgroundImage = Properties.Resources.Untitled_design__2_;
            ClientSize = new Size(498, 722);
            Controls.Add(pictureBox4);
            Controls.Add(pcMax);
            Controls.Add(pcmin);
            Controls.Add(lblClose);
            Controls.Add(label6);
            Controls.Add(txtConPass);
            Controls.Add(pictureBox3);
            Controls.Add(panel3);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(checkBox2);
            Controls.Add(txtPass);
            Controls.Add(txtUser);
            Controls.Add(btnLog);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(panel2);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormRegister";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            Load += Register_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcMax).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcmin).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Label label3;
        private CheckBox checkBox2;
        private TextBox txtPass;
        private TextBox txtUser;
        private Button btnLog;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Label label2;
        private Panel panel1;
        private Label label1;
        private TextBox txtConPass;
        private PictureBox pictureBox3;
        private Panel panel3;
        private Label label5;
        private Label label6;
        private PictureBox pcMax;
        private PictureBox pcmin;
        private Label lblClose;
        private PictureBox pictureBox4;
    }
}