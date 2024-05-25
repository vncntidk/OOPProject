namespace OOPProject
{
    partial class ReportAdmin
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel1 = new Panel();
            lblFilter = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2ComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
            guna2TextBox2 = new Guna.UI2.WinForms.Guna2TextBox();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            dgvReport = new Guna.UI2.WinForms.Guna2DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReport).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(lblFilter);
            panel1.Controls.Add(guna2ComboBox1);
            panel1.Controls.Add(guna2TextBox2);
            panel1.Controls.Add(guna2Button1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1267, 114);
            panel1.TabIndex = 1;
            // 
            // lblFilter
            // 
            lblFilter.BackColor = Color.Transparent;
            lblFilter.Font = new Font("Palatino Linotype", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFilter.ForeColor = Color.FromArgb(224, 122, 90);
            lblFilter.Location = new Point(336, 42);
            lblFilter.Name = "lblFilter";
            lblFilter.Size = new Size(62, 33);
            lblFilter.TabIndex = 9;
            lblFilter.Text = "Filter:";
            // 
            // guna2ComboBox1
            // 
            guna2ComboBox1.BackColor = Color.Transparent;
            guna2ComboBox1.BorderColor = Color.FromArgb(0, 192, 0);
            guna2ComboBox1.BorderRadius = 10;
            guna2ComboBox1.BorderThickness = 2;
            guna2ComboBox1.CustomizableEdges = customizableEdges1;
            guna2ComboBox1.DrawMode = DrawMode.OwnerDrawFixed;
            guna2ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            guna2ComboBox1.FocusedColor = Color.FromArgb(94, 148, 255);
            guna2ComboBox1.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2ComboBox1.Font = new Font("Segoe UI", 10F);
            guna2ComboBox1.ForeColor = Color.FromArgb(68, 88, 112);
            guna2ComboBox1.ItemHeight = 30;
            guna2ComboBox1.Items.AddRange(new object[] { "Pending", "Replied", "Both" });
            guna2ComboBox1.Location = new Point(404, 42);
            guna2ComboBox1.Name = "guna2ComboBox1";
            guna2ComboBox1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2ComboBox1.Size = new Size(198, 36);
            guna2ComboBox1.TabIndex = 3;
            guna2ComboBox1.SelectedIndexChanged += guna2ComboBox1_SelectedIndexChanged;
            // 
            // guna2TextBox2
            // 
            guna2TextBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            guna2TextBox2.AutoRoundedCorners = true;
            guna2TextBox2.BorderColor = Color.FromArgb(0, 192, 0);
            guna2TextBox2.BorderRadius = 23;
            guna2TextBox2.BorderThickness = 2;
            guna2TextBox2.CustomizableEdges = customizableEdges3;
            guna2TextBox2.DefaultText = "";
            guna2TextBox2.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            guna2TextBox2.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            guna2TextBox2.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox2.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox2.FillColor = Color.FromArgb(255, 245, 237);
            guna2TextBox2.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox2.Font = new Font("Segoe UI", 9F);
            guna2TextBox2.ForeColor = Color.FromArgb(99, 191, 173);
            guna2TextBox2.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox2.IconLeft = Properties.Resources.search;
            guna2TextBox2.IconLeftOffset = new Point(20, 0);
            guna2TextBox2.Location = new Point(665, 37);
            guna2TextBox2.Margin = new Padding(3, 4, 3, 4);
            guna2TextBox2.Name = "guna2TextBox2";
            guna2TextBox2.PasswordChar = '\0';
            guna2TextBox2.PlaceholderForeColor = Color.FromArgb(99, 191, 173);
            guna2TextBox2.PlaceholderText = "Search Users";
            guna2TextBox2.SelectedText = "";
            guna2TextBox2.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2TextBox2.Size = new Size(571, 48);
            guna2TextBox2.TabIndex = 2;
            guna2TextBox2.TextOffset = new Point(15, 0);
            guna2TextBox2.TextChanged += guna2TextBox2_TextChanged;
            // 
            // guna2Button1
            // 
            guna2Button1.Animated = true;
            guna2Button1.BorderColor = Color.FromArgb(0, 192, 0);
            guna2Button1.BorderRadius = 20;
            guna2Button1.BorderThickness = 2;
            guna2Button1.CustomizableEdges = customizableEdges5;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.FromArgb(255, 245, 237);
            guna2Button1.Font = new Font("Segoe UI", 9F);
            guna2Button1.ForeColor = Color.FromArgb(99, 191, 173);
            guna2Button1.Location = new Point(38, 37);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2Button1.Size = new Size(225, 48);
            guna2Button1.TabIndex = 1;
            guna2Button1.Text = "Reply";
            guna2Button1.Click += guna2Button1_Click;
            // 
            // dgvReport
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(185, 226, 218);
            dgvReport.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvReport.BackgroundColor = Color.FromArgb(255, 245, 237);
            dgvReport.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(22, 160, 133);
            dataGridViewCellStyle2.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvReport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvReport.ColumnHeadersHeight = 50;
            dgvReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(208, 235, 230);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(99, 191, 173);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvReport.DefaultCellStyle = dataGridViewCellStyle3;
            dgvReport.Dock = DockStyle.Fill;
            dgvReport.GridColor = Color.FromArgb(182, 224, 216);
            dgvReport.Location = new Point(0, 114);
            dgvReport.Name = "dgvReport";
            dgvReport.RowHeadersVisible = false;
            dgvReport.RowHeadersWidth = 51;
            dgvReport.Size = new Size(1267, 575);
            dgvReport.TabIndex = 2;
            dgvReport.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.GreenSea;
            dgvReport.ThemeStyle.AlternatingRowsStyle.BackColor = Color.FromArgb(185, 226, 218);
            dgvReport.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvReport.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvReport.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvReport.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvReport.ThemeStyle.BackColor = Color.FromArgb(255, 245, 237);
            dgvReport.ThemeStyle.GridColor = Color.FromArgb(182, 224, 216);
            dgvReport.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(22, 160, 133);
            dgvReport.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvReport.ThemeStyle.HeaderStyle.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgvReport.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvReport.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvReport.ThemeStyle.HeaderStyle.Height = 50;
            dgvReport.ThemeStyle.ReadOnly = false;
            dgvReport.ThemeStyle.RowsStyle.BackColor = Color.FromArgb(208, 235, 230);
            dgvReport.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvReport.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dgvReport.ThemeStyle.RowsStyle.ForeColor = Color.Black;
            dgvReport.ThemeStyle.RowsStyle.Height = 29;
            dgvReport.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(99, 191, 173);
            dgvReport.ThemeStyle.RowsStyle.SelectionForeColor = Color.Black;
            dgvReport.CellContentClick += dgvReport_CellContentClick;
            // 
            // ReportAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 245, 237);
            ClientSize = new Size(1267, 689);
            Controls.Add(dgvReport);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ReportAdmin";
            Text = "ReportAdmin";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReport).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox2;
        private Guna.UI2.WinForms.Guna2DataGridView dgvReport;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblFilter;
    }
}