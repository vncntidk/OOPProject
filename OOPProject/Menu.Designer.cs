namespace OOPProject
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            plSideMenu = new Panel();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel2 = new Panel();
            pcMax = new PictureBox();
            pcmin = new PictureBox();
            lblClose = new Label();
            plSideMenu.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcMax).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcmin).BeginInit();
            SuspendLayout();
            // 
            // plSideMenu
            // 
            plSideMenu.BackColor = Color.FromArgb(24, 30, 54);
            plSideMenu.Controls.Add(button3);
            plSideMenu.Controls.Add(button2);
            plSideMenu.Controls.Add(button1);
            plSideMenu.Controls.Add(panel1);
            plSideMenu.Location = new Point(0, 36);
            plSideMenu.Name = "plSideMenu";
            plSideMenu.Size = new Size(324, 398);
            plSideMenu.TabIndex = 3;
            plSideMenu.Paint += plSideMenu_Paint;
            // 
            // button3
            // 
            button3.BackgroundImageLayout = ImageLayout.Zoom;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Nirmala UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Image = Properties.Resources.profile_user__4_;
            button3.ImageAlign = ContentAlignment.MiddleRight;
            button3.Location = new Point(3, 316);
            button3.Name = "button3";
            button3.Size = new Size(318, 77);
            button3.TabIndex = 5;
            button3.Text = "     P R O F I L E";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Nirmala UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Image = Properties.Resources.profile_user__4_;
            button2.ImageAlign = ContentAlignment.MiddleRight;
            button2.Location = new Point(1, 233);
            button2.Name = "button2";
            button2.Size = new Size(321, 77);
            button2.TabIndex = 5;
            button2.Text = "     R E C I P E";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Nirmala UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Image = Properties.Resources.profile_user__4_;
            button1.ImageAlign = ContentAlignment.MiddleRight;
            button1.Location = new Point(1, 141);
            button1.Name = "button1";
            button1.Size = new Size(321, 77);
            button1.TabIndex = 5;
            button1.Text = "     P R O F I L E";
            button1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(324, 132);
            panel1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(90, 81);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(104, 21);
            label1.Name = "label1";
            label1.Size = new Size(208, 74);
            label1.TabIndex = 2;
            label1.Text = "R E C I P E \r\nC A T A L O G";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(24, 30, 54);
            panel2.Controls.Add(pcMax);
            panel2.Controls.Add(pcmin);
            panel2.Controls.Add(lblClose);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(916, 37);
            panel2.TabIndex = 4;
            // 
            // pcMax
            // 
            pcMax.Cursor = Cursors.Hand;
            pcMax.Image = (Image)resources.GetObject("pcMax.Image");
            pcMax.Location = new Point(832, 8);
            pcMax.Name = "pcMax";
            pcMax.Size = new Size(40, 20);
            pcMax.SizeMode = PictureBoxSizeMode.Zoom;
            pcMax.TabIndex = 23;
            pcMax.TabStop = false;
            // 
            // pcmin
            // 
            pcmin.Cursor = Cursors.Hand;
            pcmin.Image = (Image)resources.GetObject("pcmin.Image");
            pcmin.Location = new Point(787, 8);
            pcmin.Name = "pcmin";
            pcmin.Size = new Size(40, 20);
            pcmin.SizeMode = PictureBoxSizeMode.Zoom;
            pcmin.TabIndex = 22;
            pcmin.TabStop = false;
            // 
            // lblClose
            // 
            lblClose.AutoSize = true;
            lblClose.Cursor = Cursors.Hand;
            lblClose.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblClose.ForeColor = Color.RoyalBlue;
            lblClose.Location = new Point(877, 8);
            lblClose.Name = "lblClose";
            lblClose.Size = new Size(31, 20);
            lblClose.TabIndex = 21;
            lblClose.Text = "✖";
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(916, 433);
            Controls.Add(panel2);
            Controls.Add(plSideMenu);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            plSideMenu.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pcMax).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcmin).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel plSideMenu;
        private Panel panel2;
        private PictureBox pcMax;
        private PictureBox pcmin;
        private Label lblClose;
        private Button button1;
        private Button button3;
        private Button button2;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
    }
}