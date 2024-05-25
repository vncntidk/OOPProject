namespace OOPProject
{
    partial class SubProfile
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubProfile));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            btnSave = new Guna.UI2.WinForms.Guna2Button();
            pbxProfile = new Guna.UI2.WinForms.Guna2PictureBox();
            lblProfile = new Guna.UI2.WinForms.Guna2HtmlLabel();
            tbxName = new Guna.UI2.WinForms.Guna2TextBox();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)pbxProfile).BeginInit();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnSave.BorderColor = Color.FromArgb(192, 41, 66);
            btnSave.BorderRadius = 25;
            btnSave.BorderThickness = 2;
            btnSave.CustomizableEdges = customizableEdges1;
            btnSave.DisabledState.BorderColor = Color.DarkGray;
            btnSave.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSave.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSave.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSave.FillColor = Color.White;
            btnSave.Font = new Font("Palatino Linotype", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.FromArgb(192, 41, 66);
            btnSave.Location = new Point(182, 512);
            btnSave.Name = "btnSave";
            btnSave.PressedDepth = 25;
            btnSave.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnSave.Size = new Size(229, 52);
            btnSave.TabIndex = 6;
            btnSave.Text = "Save";
            btnSave.Click += btnSave_Click;
            // 
            // pbxProfile
            // 
            pbxProfile.AutoRoundedCorners = true;
            pbxProfile.BorderRadius = 100;
            pbxProfile.Cursor = Cursors.Hand;
            pbxProfile.CustomizableEdges = customizableEdges3;
            pbxProfile.ImageRotate = 0F;
            pbxProfile.InitialImage = (Image)resources.GetObject("pbxProfile.InitialImage");
            pbxProfile.Location = new Point(194, 33);
            pbxProfile.Name = "pbxProfile";
            pbxProfile.ShadowDecoration.CustomizableEdges = customizableEdges4;
            pbxProfile.Size = new Size(208, 203);
            pbxProfile.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxProfile.TabIndex = 7;
            pbxProfile.TabStop = false;
            pbxProfile.Click += pbxProfile_Click;
            // 
            // lblProfile
            // 
            lblProfile.BackColor = Color.Transparent;
            lblProfile.Font = new Font("Palatino Linotype", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProfile.ForeColor = Color.FromArgb(192, 41, 66);
            lblProfile.Location = new Point(228, 253);
            lblProfile.Name = "lblProfile";
            lblProfile.Size = new Size(154, 33);
            lblProfile.TabIndex = 8;
            lblProfile.Text = "Profile Picture";
            // 
            // tbxName
            // 
            tbxName.BorderColor = Color.FromArgb(192, 41, 66);
            tbxName.BorderRadius = 25;
            tbxName.CustomizableEdges = customizableEdges5;
            tbxName.DefaultText = "";
            tbxName.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            tbxName.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            tbxName.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            tbxName.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            tbxName.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            tbxName.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxName.ForeColor = Color.FromArgb(192, 41, 66);
            tbxName.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            tbxName.Location = new Point(111, 331);
            tbxName.Margin = new Padding(3, 5, 3, 5);
            tbxName.Name = "tbxName";
            tbxName.PasswordChar = '\0';
            tbxName.PlaceholderText = "";
            tbxName.SelectedText = "";
            tbxName.ShadowDecoration.CustomizableEdges = customizableEdges6;
            tbxName.Size = new Size(383, 49);
            tbxName.TabIndex = 9;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Palatino Linotype", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel1.ForeColor = Color.FromArgb(192, 41, 66);
            guna2HtmlLabel1.Location = new Point(263, 397);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(67, 33);
            guna2HtmlLabel1.TabIndex = 10;
            guna2HtmlLabel1.Text = "Name";
            // 
            // SubProfile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(252, 232, 219);
            ClientSize = new Size(606, 598);
            Controls.Add(guna2HtmlLabel1);
            Controls.Add(tbxName);
            Controls.Add(lblProfile);
            Controls.Add(pbxProfile);
            Controls.Add(btnSave);
            Name = "SubProfile";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SubProfile";
            ((System.ComponentModel.ISupportInitialize)pbxProfile).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2PictureBox pbxProfile;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblProfile;
        private Guna.UI2.WinForms.Guna2TextBox tbxName;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
    }
}