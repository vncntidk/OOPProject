namespace OOPProject
{
    partial class ViewRecipeHome
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
            panelFlow = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // panelFlow
            // 
            panelFlow.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelFlow.Location = new Point(56, 48);
            panelFlow.Name = "panelFlow";
            panelFlow.Size = new Size(1105, 839);
            panelFlow.TabIndex = 0;
            // 
            // ViewRecipeHome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 245, 237);
            ClientSize = new Size(1214, 936);
            Controls.Add(panelFlow);
            Name = "ViewRecipeHome";
            Text = "ViewRecipeHome";
            SizeChanged += ViewRecipeHome_SizeChanged;
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel panelFlow;
    }
}