namespace OOPProject
{
    partial class Report
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label1 = new Label();
            guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            cbxReason = new Guna.UI2.WinForms.Guna2ComboBox();
            lblSortOrder = new Guna.UI2.WinForms.Guna2HtmlLabel();
            btnSubmit = new Guna.UI2.WinForms.Guna2Button();
            tbxReport = new Guna.UI2.WinForms.Guna2TextBox();
            guna2ShadowPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Palatino Linotype", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(255, 128, 0);
            label1.Location = new Point(307, 26);
            label1.Name = "label1";
            label1.Size = new Size(600, 55);
            label1.TabIndex = 20;
            label1.Text = "BUG REPORT / SUGGESTION";
            // 
            // guna2ShadowPanel1
            // 
            guna2ShadowPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            guna2ShadowPanel1.BackColor = Color.Transparent;
            guna2ShadowPanel1.Controls.Add(cbxReason);
            guna2ShadowPanel1.Controls.Add(lblSortOrder);
            guna2ShadowPanel1.Controls.Add(btnSubmit);
            guna2ShadowPanel1.Controls.Add(tbxReport);
            guna2ShadowPanel1.FillColor = Color.AntiqueWhite;
            guna2ShadowPanel1.Location = new Point(69, 106);
            guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            guna2ShadowPanel1.ShadowColor = Color.Black;
            guna2ShadowPanel1.Size = new Size(1050, 608);
            guna2ShadowPanel1.TabIndex = 21;
            // 
            // cbxReason
            // 
            cbxReason.AutoRoundedCorners = true;
            cbxReason.BackColor = Color.Transparent;
            cbxReason.BorderColor = Color.FromArgb(224, 122, 90);
            cbxReason.BorderRadius = 17;
            cbxReason.CustomizableEdges = customizableEdges1;
            cbxReason.DrawMode = DrawMode.OwnerDrawFixed;
            cbxReason.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxReason.FillColor = Color.FromArgb(255, 245, 237);
            cbxReason.FocusedColor = Color.FromArgb(94, 148, 255);
            cbxReason.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cbxReason.Font = new Font("Palatino Linotype", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbxReason.ForeColor = Color.FromArgb(224, 122, 90);
            cbxReason.ItemHeight = 30;
            cbxReason.Items.AddRange(new object[] { "Bug Report", "Suggestion" });
            cbxReason.Location = new Point(150, 26);
            cbxReason.Name = "cbxReason";
            cbxReason.ShadowDecoration.CustomizableEdges = customizableEdges2;
            cbxReason.Size = new Size(219, 36);
            cbxReason.TabIndex = 9;
            // 
            // lblSortOrder
            // 
            lblSortOrder.BackColor = Color.Transparent;
            lblSortOrder.Font = new Font("Palatino Linotype", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSortOrder.ForeColor = Color.FromArgb(224, 122, 90);
            lblSortOrder.Location = new Point(40, 23);
            lblSortOrder.Name = "lblSortOrder";
            lblSortOrder.Size = new Size(94, 39);
            lblSortOrder.TabIndex = 8;
            lblSortOrder.Text = "Reason";
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
            btnSubmit.Location = new Point(370, 549);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnSubmit.Size = new Size(312, 43);
            btnSubmit.TabIndex = 7;
            btnSubmit.Text = "Submit";
            btnSubmit.Click += btnSubmit_Click;
            // 
            // tbxReport
            // 
            tbxReport.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbxReport.BorderRadius = 20;
            tbxReport.CustomizableEdges = customizableEdges5;
            tbxReport.DefaultText = "";
            tbxReport.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            tbxReport.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            tbxReport.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            tbxReport.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            tbxReport.FillColor = Color.FromArgb(255, 245, 237);
            tbxReport.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            tbxReport.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxReport.ForeColor = Color.FromArgb(255, 128, 100);
            tbxReport.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            tbxReport.Location = new Point(40, 81);
            tbxReport.Margin = new Padding(4, 5, 4, 5);
            tbxReport.Multiline = true;
            tbxReport.Name = "tbxReport";
            tbxReport.PasswordChar = '\0';
            tbxReport.PlaceholderForeColor = Color.FromArgb(255, 128, 100);
            tbxReport.PlaceholderText = "Write your report/suggestions here...";
            tbxReport.SelectedText = "";
            tbxReport.ShadowDecoration.CustomizableEdges = customizableEdges6;
            tbxReport.Size = new Size(971, 445);
            tbxReport.TabIndex = 0;
            tbxReport.TextOffset = new Point(15, 10);
            // 
            // Report
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 245, 237);
            ClientSize = new Size(1196, 767);
            Controls.Add(guna2ShadowPanel1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Report";
            Text = "Report";
            guna2ShadowPanel1.ResumeLayout(false);
            guna2ShadowPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Guna.UI2.WinForms.Guna2TextBox tbxReport;
        private Guna.UI2.WinForms.Guna2Button btnSubmit;
        private Guna.UI2.WinForms.Guna2ComboBox cbxReason;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblSortOrder;
    }
}