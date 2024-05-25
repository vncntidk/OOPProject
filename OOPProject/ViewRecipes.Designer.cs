namespace OOPProject
{
    partial class ViewRecipes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewRecipes));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            splitContainer1 = new SplitContainer();
            mpInstructions = new AxWMPLib.AxWindowsMediaPlayer();
            panelShow = new Guna.UI2.WinForms.Guna2Panel();
            panel1 = new Panel();
            btnComment = new Guna.UI2.WinForms.Guna2Button();
            btnAbout = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)mpInstructions).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(mpInstructions);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(panelShow);
            splitContainer1.Panel2.Controls.Add(panel1);
            splitContainer1.Size = new Size(1214, 936);
            splitContainer1.SplitterDistance = 249;
            splitContainer1.TabIndex = 0;
            // 
            // mpInstructions
            // 
            mpInstructions.Dock = DockStyle.Fill;
            mpInstructions.Enabled = true;
            mpInstructions.Location = new Point(0, 0);
            mpInstructions.Name = "mpInstructions";
            mpInstructions.OcxState = (AxHost.State)resources.GetObject("mpInstructions.OcxState");
            mpInstructions.Size = new Size(1214, 249);
            mpInstructions.TabIndex = 0;
            // 
            // panelShow
            // 
            panelShow.AutoScroll = true;
            panelShow.CustomizableEdges = customizableEdges1;
            panelShow.Dock = DockStyle.Top;
            panelShow.Location = new Point(0, 60);
            panelShow.Name = "panelShow";
            panelShow.ShadowDecoration.CustomizableEdges = customizableEdges2;
            panelShow.Size = new Size(1214, 623);
            panelShow.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnComment);
            panel1.Controls.Add(btnAbout);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1214, 60);
            panel1.TabIndex = 0;
            // 
            // btnComment
            // 
            btnComment.Animated = true;
            btnComment.CustomBorderColor = Color.FromArgb(224, 122, 90);
            btnComment.CustomBorderThickness = new Padding(0, 2, 0, 2);
            btnComment.CustomizableEdges = customizableEdges3;
            btnComment.DisabledState.BorderColor = Color.DarkGray;
            btnComment.DisabledState.CustomBorderColor = Color.DarkGray;
            btnComment.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnComment.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnComment.Dock = DockStyle.Left;
            btnComment.FillColor = Color.FromArgb(255, 245, 237);
            btnComment.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold);
            btnComment.ForeColor = Color.FromArgb(224, 122, 90);
            btnComment.HoverState.BorderColor = Color.FromArgb(224, 122, 90);
            btnComment.HoverState.CustomBorderColor = Color.FromArgb(224, 122, 90);
            btnComment.HoverState.FillColor = Color.FromArgb(224, 122, 90);
            btnComment.HoverState.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold);
            btnComment.HoverState.ForeColor = Color.FromArgb(255, 245, 237);
            btnComment.HoverState.Image = Properties.Resources.chat;
            btnComment.Image = Properties.Resources.chat__1_;
            btnComment.ImageSize = new Size(40, 40);
            btnComment.Location = new Point(606, 0);
            btnComment.Name = "btnComment";
            btnComment.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnComment.Size = new Size(607, 60);
            btnComment.TabIndex = 1;
            btnComment.Text = "Comments";
            btnComment.TextOffset = new Point(5, 0);
            btnComment.Click += btnComment_Click;
            // 
            // btnAbout
            // 
            btnAbout.Animated = true;
            btnAbout.BorderColor = Color.FromArgb(224, 122, 90);
            btnAbout.CustomBorderColor = Color.FromArgb(224, 122, 90);
            btnAbout.CustomBorderThickness = new Padding(0, 2, 0, 2);
            btnAbout.CustomizableEdges = customizableEdges5;
            btnAbout.DisabledState.BorderColor = Color.DarkGray;
            btnAbout.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAbout.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAbout.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAbout.Dock = DockStyle.Left;
            btnAbout.FillColor = Color.FromArgb(255, 245, 237);
            btnAbout.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold);
            btnAbout.ForeColor = Color.FromArgb(224, 122, 90);
            btnAbout.HoverState.BorderColor = Color.FromArgb(224, 122, 90);
            btnAbout.HoverState.CustomBorderColor = Color.FromArgb(224, 122, 90);
            btnAbout.HoverState.FillColor = Color.FromArgb(224, 122, 90);
            btnAbout.HoverState.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold);
            btnAbout.HoverState.ForeColor = Color.FromArgb(255, 245, 237);
            btnAbout.HoverState.Image = Properties.Resources.list__4_;
            btnAbout.Image = Properties.Resources.list__3_;
            btnAbout.ImageSize = new Size(40, 40);
            btnAbout.Location = new Point(0, 0);
            btnAbout.Name = "btnAbout";
            btnAbout.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnAbout.Size = new Size(606, 60);
            btnAbout.TabIndex = 0;
            btnAbout.Text = "Recipe Details";
            btnAbout.TextOffset = new Point(5, 0);
            btnAbout.Click += btnAbout_Click;
            // 
            // ViewRecipes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 245, 237);
            ClientSize = new Size(1214, 936);
            Controls.Add(splitContainer1);
            Name = "ViewRecipes";
            Text = "ViewRecipes";
            SizeChanged += ViewRecipes_SizeChanged;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)mpInstructions).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private AxWMPLib.AxWindowsMediaPlayer mpInstructions;
        private Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnComment;
        private Guna.UI2.WinForms.Guna2Button btnAbout;
        private Guna.UI2.WinForms.Guna2Panel panelShow;
    }
}