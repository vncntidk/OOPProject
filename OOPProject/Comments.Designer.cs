namespace OOPProject
{
    partial class Comments
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
            panelling = new Panel();
            SuspendLayout();
            // 
            // panelling
            // 
            panelling.Dock = DockStyle.Top;
            panelling.Location = new Point(0, 0);
            panelling.Name = "panelling";
            panelling.Size = new Size(616, 1000);
            panelling.TabIndex = 2;
            // 
            // Comments
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 245, 237);
            ClientSize = new Size(616, 908);
            Controls.Add(panelling);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Comments";
            Text = "Comments";
            ResumeLayout(false);
        }

        #endregion
        private Panel panelling;
    }
}