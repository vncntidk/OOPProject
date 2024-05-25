namespace OOPProject
{
    partial class SpecRecipes
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblRecipe = new Guna.UI2.WinForms.Guna2HtmlLabel();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel1.Controls.Add(flowLayoutPanel2);
            flowLayoutPanel1.Location = new Point(69, 103);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1098, 784);
            flowLayoutPanel1.TabIndex = 0;
            flowLayoutPanel1.SizeChanged += flowLayoutPanel1_SizeChanged;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Location = new Point(3, 3);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(8, 8);
            flowLayoutPanel2.TabIndex = 0;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Palatino Linotype", 19.8000011F, FontStyle.Bold);
            guna2HtmlLabel1.ForeColor = Color.FromArgb(192, 41, 66);
            guna2HtmlLabel1.Location = new Point(30, 23);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(167, 47);
            guna2HtmlLabel1.TabIndex = 19;
            guna2HtmlLabel1.Text = "Recipes in:";
            // 
            // lblRecipe
            // 
            lblRecipe.BackColor = Color.Transparent;
            lblRecipe.Font = new Font("Palatino Linotype", 19.8000011F, FontStyle.Bold);
            lblRecipe.ForeColor = Color.FromArgb(192, 41, 66);
            lblRecipe.Location = new Point(203, 23);
            lblRecipe.Name = "lblRecipe";
            lblRecipe.Size = new Size(119, 47);
            lblRecipe.TabIndex = 20;
            lblRecipe.Text = "Filipino";
            // 
            // SpecRecipes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(255, 245, 237);
            ClientSize = new Size(1232, 983);
            Controls.Add(lblRecipe);
            Controls.Add(guna2HtmlLabel1);
            Controls.Add(flowLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SpecRecipes";
            Text = "SpecRecipes";
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private FlowLayoutPanel flowLayoutPanel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblRecipe;
    }
}