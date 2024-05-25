namespace OOPProject
{
    partial class ViewCuisines
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
            panelView = new Panel();
            SuspendLayout();
            // 
            // panelView
            // 
            panelView.Dock = DockStyle.Top;
            panelView.Location = new Point(0, 0);
            panelView.Name = "panelView";
            panelView.Size = new Size(1232, 984);
            panelView.TabIndex = 0;
            // 
            // ViewCuisines
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 245, 237);
            ClientSize = new Size(1232, 983);
            Controls.Add(panelView);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.None;
            Name = "ViewCuisines";
            Text = "ViewCuisines";
            Load += ViewCuisines_Load;
            ResumeLayout(false);
        }

        #endregion

        private Panel panelView;
    }
}