namespace OOPProject
{
    partial class RepliedSuggest
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            tbxReply = new Guna.UI2.WinForms.Guna2TextBox();
            btnSubmit = new Guna.UI2.WinForms.Guna2Button();
            guna2ShadowPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // guna2ShadowPanel1
            // 
            guna2ShadowPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            guna2ShadowPanel1.BackColor = Color.Transparent;
            guna2ShadowPanel1.Controls.Add(tbxReply);
            guna2ShadowPanel1.Controls.Add(btnSubmit);
            guna2ShadowPanel1.FillColor = Color.AntiqueWhite;
            guna2ShadowPanel1.Location = new Point(74, 38);
            guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            guna2ShadowPanel1.ShadowColor = Color.Black;
            guna2ShadowPanel1.Size = new Size(836, 627);
            guna2ShadowPanel1.TabIndex = 23;
            // 
            // tbxReply
            // 
            tbxReply.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbxReply.BorderRadius = 20;
            tbxReply.CustomizableEdges = customizableEdges1;
            tbxReply.DefaultText = "";
            tbxReply.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            tbxReply.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            tbxReply.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            tbxReply.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            tbxReply.FillColor = Color.FromArgb(255, 245, 237);
            tbxReply.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            tbxReply.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxReply.ForeColor = Color.FromArgb(192, 41, 66);
            tbxReply.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            tbxReply.Location = new Point(34, 29);
            tbxReply.Margin = new Padding(4, 5, 4, 5);
            tbxReply.Multiline = true;
            tbxReply.Name = "tbxReply";
            tbxReply.PasswordChar = '\0';
            tbxReply.PlaceholderForeColor = Color.FromArgb(255, 128, 100);
            tbxReply.PlaceholderText = "Reply here...";
            tbxReply.SelectedText = "";
            tbxReply.ShadowDecoration.CustomizableEdges = customizableEdges2;
            tbxReply.Size = new Size(766, 511);
            tbxReply.TabIndex = 8;
            tbxReply.TextOffset = new Point(15, 10);
            // 
            // btnSubmit
            // 
            btnSubmit.Anchor = AnchorStyles.Bottom;
            btnSubmit.Animated = true;
            btnSubmit.BackColor = Color.Transparent;
            btnSubmit.BorderColor = Color.FromArgb(224, 122, 90);
            btnSubmit.BorderRadius = 15;
            btnSubmit.BorderThickness = 2;
            btnSubmit.CustomizableEdges = customizableEdges3;
            btnSubmit.DisabledState.BorderColor = Color.DarkGray;
            btnSubmit.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSubmit.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSubmit.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSubmit.FillColor = Color.Transparent;
            btnSubmit.Font = new Font("Segoe UI", 9F);
            btnSubmit.ForeColor = Color.FromArgb(224, 122, 90);
            btnSubmit.HoverState.FillColor = Color.FromArgb(224, 122, 90);
            btnSubmit.HoverState.ForeColor = Color.FromArgb(255, 245, 237);
            btnSubmit.Location = new Point(261, 562);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnSubmit.Size = new Size(312, 43);
            btnSubmit.TabIndex = 7;
            btnSubmit.Text = "Submit";
            btnSubmit.Click += btnSubmit_Click;
            // 
            // RepliedSuggest
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(182, 224, 216);
            ClientSize = new Size(984, 702);
            Controls.Add(guna2ShadowPanel1);
            Name = "RepliedSuggest";
            Text = "RepliedSuggest";
            guna2ShadowPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Guna.UI2.WinForms.Guna2Button btnSubmit;
        private Guna.UI2.WinForms.Guna2TextBox tbxReply;
    }
}