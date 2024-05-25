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
            PanelMenu = new Panel();
            btnReport = new Button();
            btnAdmin = new Button();
            btnProf = new Button();
            PanelSubCuisine = new Panel();
            button1 = new Button();
            btnView = new Button();
            btnCuisines = new Button();
            btnHome = new Button();
            panel1 = new Panel();
            buttons1 = new Controls.buttons();
            pictureBox1 = new PictureBox();
            PanelDesktop = new Panel();
            PanelTitle = new Panel();
            tblCurrentTab = new Label();
            btnMin = new Controls.buttons();
            btnClose = new Controls.buttons();
            btnMax = new Controls.buttons();
            pdesktop = new Panel();
            PanelMenu.SuspendLayout();
            PanelSubCuisine.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            PanelTitle.SuspendLayout();
            SuspendLayout();
            // 
            // PanelMenu
            // 
            PanelMenu.BackColor = Color.FromArgb(255, 242, 227);
            PanelMenu.Controls.Add(btnReport);
            PanelMenu.Controls.Add(btnAdmin);
            PanelMenu.Controls.Add(btnProf);
            PanelMenu.Controls.Add(PanelSubCuisine);
            PanelMenu.Controls.Add(btnCuisines);
            PanelMenu.Controls.Add(btnHome);
            PanelMenu.Controls.Add(panel1);
            PanelMenu.Controls.Add(PanelDesktop);
            PanelMenu.Dock = DockStyle.Left;
            PanelMenu.Location = new Point(0, 0);
            PanelMenu.Name = "PanelMenu";
            PanelMenu.Size = new Size(230, 1055);
            PanelMenu.TabIndex = 8;
            // 
            // btnReport
            // 
            btnReport.BackColor = Color.FromArgb(255, 242, 227);
            btnReport.Dock = DockStyle.Top;
            btnReport.FlatAppearance.BorderSize = 0;
            btnReport.FlatStyle = FlatStyle.Flat;
            btnReport.Font = new Font("Palatino Linotype", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReport.ForeColor = Color.FromArgb(192, 41, 66);
            btnReport.Image = (Image)resources.GetObject("btnReport.Image");
            btnReport.ImageAlign = ContentAlignment.MiddleLeft;
            btnReport.Location = new Point(0, 485);
            btnReport.Margin = new Padding(0);
            btnReport.Name = "btnReport";
            btnReport.Padding = new Padding(10, 0, 0, 0);
            btnReport.Size = new Size(230, 68);
            btnReport.TabIndex = 20;
            btnReport.Tag = "Report";
            btnReport.Text = "   Report";
            btnReport.TextAlign = ContentAlignment.MiddleLeft;
            btnReport.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnReport.UseVisualStyleBackColor = false;
            btnReport.Click += button4_Click;
            // 
            // btnAdmin
            // 
            btnAdmin.BackColor = Color.FromArgb(255, 242, 227);
            btnAdmin.Dock = DockStyle.Top;
            btnAdmin.FlatAppearance.BorderSize = 0;
            btnAdmin.FlatStyle = FlatStyle.Flat;
            btnAdmin.Font = new Font("Palatino Linotype", 13.8F, FontStyle.Bold);
            btnAdmin.ForeColor = Color.FromArgb(192, 41, 66);
            btnAdmin.Image = (Image)resources.GetObject("btnAdmin.Image");
            btnAdmin.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdmin.Location = new Point(0, 417);
            btnAdmin.Margin = new Padding(0);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Padding = new Padding(10, 0, 0, 0);
            btnAdmin.Size = new Size(230, 68);
            btnAdmin.TabIndex = 18;
            btnAdmin.Tag = "Admin";
            btnAdmin.Text = "   Admin";
            btnAdmin.TextAlign = ContentAlignment.MiddleLeft;
            btnAdmin.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAdmin.UseVisualStyleBackColor = false;
            btnAdmin.Click += btnAdmin_Click_1;
            // 
            // btnProf
            // 
            btnProf.BackColor = Color.FromArgb(255, 242, 227);
            btnProf.Dock = DockStyle.Top;
            btnProf.FlatAppearance.BorderSize = 0;
            btnProf.FlatStyle = FlatStyle.Flat;
            btnProf.Font = new Font("Palatino Linotype", 13.8F, FontStyle.Bold);
            btnProf.ForeColor = Color.FromArgb(192, 41, 66);
            btnProf.Image = Properties.Resources.user__1_;
            btnProf.ImageAlign = ContentAlignment.MiddleLeft;
            btnProf.Location = new Point(0, 349);
            btnProf.Margin = new Padding(0);
            btnProf.Name = "btnProf";
            btnProf.Padding = new Padding(10, 0, 0, 0);
            btnProf.Size = new Size(230, 68);
            btnProf.TabIndex = 17;
            btnProf.Tag = "Profile";
            btnProf.Text = "   Profile";
            btnProf.TextAlign = ContentAlignment.MiddleLeft;
            btnProf.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnProf.UseVisualStyleBackColor = false;
            btnProf.Click += button3_Click;
            // 
            // PanelSubCuisine
            // 
            PanelSubCuisine.Controls.Add(button1);
            PanelSubCuisine.Controls.Add(btnView);
            PanelSubCuisine.Dock = DockStyle.Top;
            PanelSubCuisine.Location = new Point(0, 261);
            PanelSubCuisine.Name = "PanelSubCuisine";
            PanelSubCuisine.Size = new Size(230, 88);
            PanelSubCuisine.TabIndex = 16;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 242, 227);
            button1.Dock = DockStyle.Top;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(192, 41, 66);
            button1.Image = Properties.Resources.add_file;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(0, 43);
            button1.Name = "button1";
            button1.Size = new Size(230, 43);
            button1.TabIndex = 1;
            button1.Text = "   Manage Cuisines";
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnView
            // 
            btnView.BackColor = Color.FromArgb(255, 242, 227);
            btnView.Dock = DockStyle.Top;
            btnView.FlatAppearance.BorderSize = 0;
            btnView.FlatStyle = FlatStyle.Flat;
            btnView.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnView.ForeColor = Color.FromArgb(192, 41, 66);
            btnView.Image = Properties.Resources.shared_vision__1_;
            btnView.ImageAlign = ContentAlignment.MiddleLeft;
            btnView.Location = new Point(0, 0);
            btnView.Name = "btnView";
            btnView.Size = new Size(230, 43);
            btnView.TabIndex = 0;
            btnView.Text = "   View Cuisines ";
            btnView.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnView.UseVisualStyleBackColor = false;
            btnView.Click += btnView_Click;
            // 
            // btnCuisines
            // 
            btnCuisines.BackColor = Color.FromArgb(255, 242, 227);
            btnCuisines.Dock = DockStyle.Top;
            btnCuisines.FlatAppearance.BorderSize = 0;
            btnCuisines.FlatStyle = FlatStyle.Flat;
            btnCuisines.Font = new Font("Palatino Linotype", 13.8F, FontStyle.Bold);
            btnCuisines.ForeColor = Color.FromArgb(192, 41, 66);
            btnCuisines.Image = Properties.Resources.bake;
            btnCuisines.ImageAlign = ContentAlignment.MiddleLeft;
            btnCuisines.Location = new Point(0, 193);
            btnCuisines.Margin = new Padding(0);
            btnCuisines.Name = "btnCuisines";
            btnCuisines.Padding = new Padding(10, 0, 0, 0);
            btnCuisines.Size = new Size(230, 68);
            btnCuisines.TabIndex = 13;
            btnCuisines.Tag = "Your Cuisines";
            btnCuisines.Text = "  Your Cuisines";
            btnCuisines.TextAlign = ContentAlignment.MiddleLeft;
            btnCuisines.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCuisines.UseVisualStyleBackColor = false;
            btnCuisines.Click += btnCuisines_Click;
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.FromArgb(255, 242, 227);
            btnHome.Dock = DockStyle.Top;
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Palatino Linotype", 13.8F, FontStyle.Bold);
            btnHome.ForeColor = Color.FromArgb(192, 41, 66);
            btnHome.Image = Properties.Resources.home__4_;
            btnHome.ImageAlign = ContentAlignment.MiddleLeft;
            btnHome.Location = new Point(0, 125);
            btnHome.Margin = new Padding(0);
            btnHome.Name = "btnHome";
            btnHome.Padding = new Padding(10, 0, 0, 0);
            btnHome.Size = new Size(230, 68);
            btnHome.TabIndex = 13;
            btnHome.Tag = "Home";
            btnHome.Text = "   Home";
            btnHome.TextAlign = ContentAlignment.MiddleLeft;
            btnHome.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click_1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 242, 227);
            panel1.Controls.Add(buttons1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(230, 125);
            panel1.TabIndex = 12;
            // 
            // buttons1
            // 
            buttons1.BackColor = Color.Transparent;
            buttons1.BackgroundColor = Color.Transparent;
            buttons1.BorderColor = Color.PaleVioletRed;
            buttons1.BorderRadius = 0;
            buttons1.BorderSize = 0;
            buttons1.FlatAppearance.BorderSize = 0;
            buttons1.FlatStyle = FlatStyle.Flat;
            buttons1.ForeColor = Color.Transparent;
            buttons1.Image = (Image)resources.GetObject("buttons1.Image");
            buttons1.Location = new Point(173, 1);
            buttons1.Name = "buttons1";
            buttons1.Size = new Size(55, 53);
            buttons1.TabIndex = 13;
            buttons1.TextColor = Color.Transparent;
            buttons1.UseVisualStyleBackColor = false;
            buttons1.Click += buttons1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.online_education__1_;
            pictureBox1.Location = new Point(30, 29);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 69);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // PanelDesktop
            // 
            PanelDesktop.Location = new Point(291, 106);
            PanelDesktop.Name = "PanelDesktop";
            PanelDesktop.Size = new Size(953, 614);
            PanelDesktop.TabIndex = 11;
            // 
            // PanelTitle
            // 
            PanelTitle.BackColor = Color.FromArgb(255, 242, 227);
            PanelTitle.Controls.Add(tblCurrentTab);
            PanelTitle.Controls.Add(btnMin);
            PanelTitle.Controls.Add(btnClose);
            PanelTitle.Controls.Add(btnMax);
            PanelTitle.Dock = DockStyle.Top;
            PanelTitle.Location = new Point(230, 0);
            PanelTitle.Name = "PanelTitle";
            PanelTitle.Size = new Size(1232, 72);
            PanelTitle.TabIndex = 10;
            PanelTitle.Paint += PanelTitle_Paint;
            PanelTitle.MouseDown += PanelTitle_MouseDown_1;
            // 
            // tblCurrentTab
            // 
            tblCurrentTab.AutoSize = true;
            tblCurrentTab.BackColor = Color.FromArgb(255, 242, 227);
            tblCurrentTab.Font = new Font("Palatino Linotype", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tblCurrentTab.ForeColor = Color.FromArgb(192, 41, 66);
            tblCurrentTab.Location = new Point(17, 12);
            tblCurrentTab.Name = "tblCurrentTab";
            tblCurrentTab.Size = new Size(192, 46);
            tblCurrentTab.TabIndex = 17;
            tblCurrentTab.Text = "Dashboard";
            tblCurrentTab.Click += tblCurrentTab_Click;
            // 
            // btnMin
            // 
            btnMin.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMin.BackColor = Color.Transparent;
            btnMin.BackgroundColor = Color.Transparent;
            btnMin.BorderColor = Color.PaleVioletRed;
            btnMin.BorderRadius = 0;
            btnMin.BorderSize = 0;
            btnMin.FlatAppearance.BorderSize = 0;
            btnMin.FlatStyle = FlatStyle.Flat;
            btnMin.ForeColor = Color.Transparent;
            btnMin.Image = (Image)resources.GetObject("btnMin.Image");
            btnMin.Location = new Point(1066, 1);
            btnMin.Name = "btnMin";
            btnMin.Size = new Size(50, 41);
            btnMin.TabIndex = 16;
            btnMin.TextColor = Color.Transparent;
            btnMin.UseVisualStyleBackColor = false;
            btnMin.Click += btnMin_Click_1;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.BackColor = Color.Transparent;
            btnClose.BackgroundColor = Color.Transparent;
            btnClose.BorderColor = Color.PaleVioletRed;
            btnClose.BorderRadius = 0;
            btnClose.BorderSize = 0;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.ForeColor = Color.Transparent;
            btnClose.Image = Properties.Resources.close__2_;
            btnClose.Location = new Point(1181, 1);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(50, 41);
            btnClose.TabIndex = 15;
            btnClose.TextColor = Color.Transparent;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click_1;
            // 
            // btnMax
            // 
            btnMax.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMax.BackColor = Color.Transparent;
            btnMax.BackgroundColor = Color.Transparent;
            btnMax.BorderColor = Color.PaleVioletRed;
            btnMax.BorderRadius = 0;
            btnMax.BorderSize = 0;
            btnMax.FlatAppearance.BorderSize = 0;
            btnMax.FlatStyle = FlatStyle.Flat;
            btnMax.ForeColor = Color.Transparent;
            btnMax.Image = (Image)resources.GetObject("btnMax.Image");
            btnMax.Location = new Point(1122, 1);
            btnMax.Name = "btnMax";
            btnMax.Size = new Size(50, 41);
            btnMax.TabIndex = 14;
            btnMax.TextColor = Color.Transparent;
            btnMax.UseVisualStyleBackColor = false;
            btnMax.Click += btnMax_Click_1;
            // 
            // pdesktop
            // 
            pdesktop.BackColor = Color.FromArgb(255, 242, 227);
            pdesktop.Dock = DockStyle.Fill;
            pdesktop.Location = new Point(230, 72);
            pdesktop.Name = "pdesktop";
            pdesktop.Size = new Size(1232, 983);
            pdesktop.TabIndex = 12;
            pdesktop.Paint += pdesktop_Paint;
            pdesktop.MouseDown += pdesktop_MouseDown;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(242, 242, 242);
            ClientSize = new Size(1462, 1055);
            Controls.Add(pdesktop);
            Controls.Add(PanelTitle);
            Controls.Add(PanelMenu);
            Name = "FormMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cuisine Catalog";
            WindowState = FormWindowState.Maximized;
            Load += FormMenu_Load_1;
            Resize += FormMenu_Resize;
            PanelMenu.ResumeLayout(false);
            PanelSubCuisine.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            PanelTitle.ResumeLayout(false);
            PanelTitle.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel PanelMenu;
        private Panel PanelDesktop;
        private Panel panel1;
        private Panel PanelTitle;
        private Controls.buttons buttons1;
        private Button btnHome;
        private Panel pdesktop;
        private Button btnProfile;
        private Button btnCuisines;
        private Controls.buttons btnMin;
        private Controls.buttons btnClose;
        private Controls.buttons btnMax;
        private PictureBox pictureBox1;
        private Label tblCurrentTab;
        private Button btnProf;
        private Panel PanelSubCuisine;
        private Button button2;
        private Button btnView;
        private Button button1;
        private Button btnAdmin;
        private Button btnReport;
    }
}