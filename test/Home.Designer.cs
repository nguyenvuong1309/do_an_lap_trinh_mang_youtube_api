namespace test
{
    partial class Home
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanelHome = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flowLayoutPanelHome
            // 
            this.flowLayoutPanelHome.AutoScroll = true;
            this.flowLayoutPanelHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelHome.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelHome.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelHome.Name = "flowLayoutPanelHome";
            this.flowLayoutPanelHome.Size = new System.Drawing.Size(813, 586);
            this.flowLayoutPanelHome.TabIndex = 0;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.flowLayoutPanelHome);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "Home";
            this.Size = new System.Drawing.Size(813, 586);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelHome;
    }
}
