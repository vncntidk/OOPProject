namespace OOPProject
{
    partial class FormLog
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLog));
            label1 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            btnLog = new Button();
            txtUser = new TextBox();
            txtPass = new TextBox();
            checkBox2 = new CheckBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            pcmin = new PictureBox();
            pcMax = new PictureBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcmin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcMax).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Nirmala UI", 12F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(61, 59, 64);
            label1.Location = new Point(89, 168);
            label1.Name = "label1";
            label1.Size = new Size(106, 28);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(61, 59, 64);
            panel1.ForeColor = Color.FromArgb(61, 59, 64);
            panel1.Location = new Point(41, 242);
            panel1.Name = "panel1";
            panel1.Size = new Size(413, 2);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(61, 59, 64);
            panel2.Location = new Point(41, 340);
            panel2.Name = "panel2";
            panel2.Size = new Size(413, 2);
            panel2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Nirmala UI", 12F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(61, 59, 64);
            label2.Location = new Point(89, 270);
            label2.Name = "label2";
            label2.Size = new Size(100, 28);
            label2.TabIndex = 2;
            label2.Text = "Password";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(41, 163);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(52, 37);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(41, 265);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(52, 37);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // btnLog
            // 
            btnLog.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnLog.BackColor = Color.White;
            btnLog.FlatAppearance.BorderSize = 2;
            btnLog.FlatStyle = FlatStyle.Flat;
            btnLog.Font = new Font("Nirmala UI", 12F, FontStyle.Bold);
            btnLog.ForeColor = Color.FromArgb(61, 59, 64);
            btnLog.Location = new Point(41, 440);
            btnLog.Name = "btnLog";
            btnLog.Size = new Size(415, 52);
            btnLog.TabIndex = 7;
            btnLog.Text = "LOGIN";
            btnLog.UseVisualStyleBackColor = false;
            btnLog.Click += btnLog_Click;
            // 
            // txtUser
            // 
            txtUser.BackColor = Color.White;
            txtUser.BorderStyle = BorderStyle.None;
            txtUser.Font = new Font("Nirmala UI", 10.8F, FontStyle.Bold);
            txtUser.ForeColor = Color.FromArgb(61, 59, 64);
            txtUser.Location = new Point(46, 213);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(408, 24);
            txtUser.TabIndex = 8;
            txtUser.TextChanged += txtUser_TextChanged;
            // 
            // txtPass
            // 
            txtPass.BackColor = Color.White;
            txtPass.BorderStyle = BorderStyle.None;
            txtPass.Font = new Font("Nirmala UI", 10.8F, FontStyle.Bold);
            txtPass.ForeColor = Color.FromArgb(61, 59, 64);
            txtPass.Location = new Point(46, 312);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '•';
            txtPass.Size = new Size(408, 24);
            txtPass.TabIndex = 9;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.BackColor = Color.Transparent;
            checkBox2.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBox2.ForeColor = Color.FromArgb(61, 59, 64);
            checkBox2.Location = new Point(284, 363);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(180, 32);
            checkBox2.TabIndex = 10;
            checkBox2.Text = "Show password";
            checkBox2.UseVisualStyleBackColor = false;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Nirmala UI", 10.2F);
            label3.ForeColor = Color.FromArgb(61, 59, 64);
            label3.Location = new Point(157, 529);
            label3.Name = "label3";
            label3.Size = new Size(190, 23);
            label3.TabIndex = 12;
            label3.Text = "Don't have an account?";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Cursor = Cursors.Hand;
            label4.Font = new Font("Nirmala UI", 12F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(61, 59, 64);
            label4.Location = new Point(213, 556);
            label4.Name = "label4";
            label4.Size = new Size(77, 28);
            label4.TabIndex = 13;
            label4.Text = "Signup";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Nirmala UI", 25.8000011F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(61, 59, 64);
            label5.Location = new Point(170, 76);
            label5.Name = "label5";
            label5.Size = new Size(159, 60);
            label5.TabIndex = 14;
            label5.Text = "LOGIN";
            // 
            // pcmin
            // 
            pcmin.BackColor = Color.Transparent;
            pcmin.Cursor = Cursors.Hand;
            pcmin.Image = (Image)resources.GetObject("pcmin.Image");
            pcmin.Location = new Point(364, 14);
            pcmin.Name = "pcmin";
            pcmin.Size = new Size(37, 20);
            pcmin.SizeMode = PictureBoxSizeMode.Zoom;
            pcmin.TabIndex = 19;
            pcmin.TabStop = false;
            pcmin.Click += pcmin_Click;
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
            pcMax.TabIndex = 20;
            pcMax.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Cursor = Cursors.Hand;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(446, 14);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(40, 20);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 21;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // FormLog
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(24, 30, 54);
            BackgroundImage = Properties.Resources.Untitled_design__2_;
            ClientSize = new Size(498, 606);
            Controls.Add(pictureBox3);
            Controls.Add(pcMax);
            Controls.Add(pcmin);
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
            Name = "FormLog";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login Authentication";
            Load += FormLog_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcmin).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcMax).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private Label label2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button btnLog;
        private TextBox txtUser;
        private TextBox txtPass;
        private CheckBox checkBox2;
        private Label label3;
        private Label label4;
        private Label label5;
        private PictureBox pcmin;
        private PictureBox pcMax;
        private PictureBox pictureBox3;
    }
}
