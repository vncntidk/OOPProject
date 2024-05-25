namespace OOPProject
{
    partial class Users
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel1 = new Panel();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            dgvUsers = new Guna.UI2.WinForms.Guna2DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(guna2Button1);
            panel1.Controls.Add(guna2TextBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1285, 114);
            panel1.TabIndex = 0;
            // 
            // guna2Button1
            // 
            guna2Button1.Animated = true;
            guna2Button1.BorderColor = Color.FromArgb(0, 192, 0);
            guna2Button1.BorderRadius = 20;
            guna2Button1.BorderThickness = 2;
            guna2Button1.CustomizableEdges = customizableEdges1;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.FromArgb(255, 245, 237);
            guna2Button1.Font = new Font("Segoe UI", 9F);
            guna2Button1.ForeColor = Color.FromArgb(99, 191, 173);
            guna2Button1.Location = new Point(38, 37);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Button1.Size = new Size(225, 48);
            guna2Button1.TabIndex = 1;
            guna2Button1.Text = "View Profile";
            guna2Button1.Click += guna2Button1_Click;
            // 
            // guna2TextBox1
            // 
            guna2TextBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            guna2TextBox1.AutoRoundedCorners = true;
            guna2TextBox1.BorderColor = Color.FromArgb(0, 192, 0);
            guna2TextBox1.BorderRadius = 23;
            guna2TextBox1.BorderThickness = 2;
            guna2TextBox1.CustomizableEdges = customizableEdges3;
            guna2TextBox1.DefaultText = "";
            guna2TextBox1.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            guna2TextBox1.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            guna2TextBox1.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox1.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox1.FillColor = Color.FromArgb(255, 245, 237);
            guna2TextBox1.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox1.Font = new Font("Segoe UI", 9F);
            guna2TextBox1.ForeColor = Color.FromArgb(99, 191, 173);
            guna2TextBox1.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox1.IconLeft = Properties.Resources.search;
            guna2TextBox1.IconLeftOffset = new Point(20, 0);
            guna2TextBox1.Location = new Point(543, 37);
            guna2TextBox1.Margin = new Padding(3, 4, 3, 4);
            guna2TextBox1.Name = "guna2TextBox1";
            guna2TextBox1.PasswordChar = '\0';
            guna2TextBox1.PlaceholderForeColor = Color.FromArgb(99, 191, 173);
            guna2TextBox1.PlaceholderText = "Search Users";
            guna2TextBox1.SelectedText = "";
            guna2TextBox1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2TextBox1.Size = new Size(690, 48);
            guna2TextBox1.TabIndex = 0;
            guna2TextBox1.TextOffset = new Point(15, 0);
            guna2TextBox1.TextChanged += guna2TextBox1_TextChanged;
            // 
            // dgvUsers
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(185, 226, 218);
            dgvUsers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvUsers.BackgroundColor = Color.FromArgb(255, 245, 237);
            dgvUsers.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(22, 160, 133);
            dataGridViewCellStyle2.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvUsers.ColumnHeadersHeight = 50;
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(208, 235, 230);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(99, 191, 173);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvUsers.DefaultCellStyle = dataGridViewCellStyle3;
            dgvUsers.Dock = DockStyle.Fill;
            dgvUsers.GridColor = Color.FromArgb(182, 224, 216);
            dgvUsers.Location = new Point(0, 114);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.RowHeadersVisible = false;
            dgvUsers.RowHeadersWidth = 51;
            dgvUsers.Size = new Size(1285, 622);
            dgvUsers.TabIndex = 1;
            dgvUsers.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.GreenSea;
            dgvUsers.ThemeStyle.AlternatingRowsStyle.BackColor = Color.FromArgb(185, 226, 218);
            dgvUsers.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvUsers.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvUsers.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvUsers.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvUsers.ThemeStyle.BackColor = Color.FromArgb(255, 245, 237);
            dgvUsers.ThemeStyle.GridColor = Color.FromArgb(182, 224, 216);
            dgvUsers.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(22, 160, 133);
            dgvUsers.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvUsers.ThemeStyle.HeaderStyle.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgvUsers.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvUsers.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvUsers.ThemeStyle.HeaderStyle.Height = 50;
            dgvUsers.ThemeStyle.ReadOnly = false;
            dgvUsers.ThemeStyle.RowsStyle.BackColor = Color.FromArgb(208, 235, 230);
            dgvUsers.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvUsers.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dgvUsers.ThemeStyle.RowsStyle.ForeColor = Color.Black;
            dgvUsers.ThemeStyle.RowsStyle.Height = 29;
            dgvUsers.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(99, 191, 173);
            dgvUsers.ThemeStyle.RowsStyle.SelectionForeColor = Color.Black;
            dgvUsers.CellContentClick += dgvUsers_CellContentClick;
            // 
            // Users
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 245, 237);
            ClientSize = new Size(1285, 736);
            Controls.Add(dgvUsers);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Users";
            Text = "Users";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvUsers;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}