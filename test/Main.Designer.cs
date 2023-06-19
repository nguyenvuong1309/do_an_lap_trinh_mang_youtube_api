namespace test
{
    partial class Main
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
            this.MainForm = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.setting = new System.Windows.Forms.Button();
            this.History = new System.Windows.Forms.Button();
            this.Home = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Login = new System.Windows.Forms.Button();
            this.find = new System.Windows.Forms.Button();
            this.textBoxFind = new System.Windows.Forms.TextBox();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainForm
            // 
            this.MainForm.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.MainForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainForm.Location = new System.Drawing.Point(243, 92);
            this.MainForm.Name = "MainForm";
            this.MainForm.Size = new System.Drawing.Size(972, 513);
            this.MainForm.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel3.Controls.Add(this.setting);
            this.panel3.Controls.Add(this.History);
            this.panel3.Controls.Add(this.Home);
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 92);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(243, 513);
            this.panel3.TabIndex = 2;
            // 
            // setting
            // 
            this.setting.Dock = System.Windows.Forms.DockStyle.Top;
            this.setting.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setting.Location = new System.Drawing.Point(0, 216);
            this.setting.Name = "setting";
            this.setting.Size = new System.Drawing.Size(243, 68);
            this.setting.TabIndex = 0;
            this.setting.Text = "Setting";
            this.setting.UseVisualStyleBackColor = true;
            this.setting.Click += new System.EventHandler(this.setting_Click);
            // 
            // History
            // 
            this.History.Dock = System.Windows.Forms.DockStyle.Top;
            this.History.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.History.Location = new System.Drawing.Point(0, 148);
            this.History.Name = "History";
            this.History.Size = new System.Drawing.Size(243, 68);
            this.History.TabIndex = 0;
            this.History.Text = "History";
            this.History.UseVisualStyleBackColor = true;
            this.History.Click += new System.EventHandler(this.History_Click);
            // 
            // Home
            // 
            this.Home.Dock = System.Windows.Forms.DockStyle.Top;
            this.Home.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Home.Location = new System.Drawing.Point(0, 80);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(243, 68);
            this.Home.TabIndex = 1;
            this.Home.Text = "home";
            this.Home.UseVisualStyleBackColor = true;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // panel7
            // 
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(243, 80);
            this.panel7.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Coral;
            this.panel4.Controls.Add(this.Login);
            this.panel4.Controls.Add(this.find);
            this.panel4.Controls.Add(this.textBoxFind);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1215, 92);
            this.panel4.TabIndex = 3;
            // 
            // Login
            // 
            this.Login.Dock = System.Windows.Forms.DockStyle.Left;
            this.Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login.Location = new System.Drawing.Point(0, 0);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(124, 92);
            this.Login.TabIndex = 2;
            this.Login.Text = "Login";
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // find
            // 
            this.find.Location = new System.Drawing.Point(845, 32);
            this.find.Name = "find";
            this.find.Size = new System.Drawing.Size(37, 36);
            this.find.TabIndex = 1;
            this.find.Text = "O";
            this.find.UseVisualStyleBackColor = true;
            this.find.Click += new System.EventHandler(this.find_Click);
            // 
            // textBoxFind
            // 
            this.textBoxFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFind.Location = new System.Drawing.Point(344, 32);
            this.textBoxFind.Multiline = true;
            this.textBoxFind.Name = "textBoxFind";
            this.textBoxFind.Size = new System.Drawing.Size(481, 30);
            this.textBoxFind.TabIndex = 0;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 605);
            this.Controls.Add(this.MainForm);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Name = "Main";
            this.Text = "Main";
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel MainForm;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button setting;
        private System.Windows.Forms.Button History;
        private System.Windows.Forms.Button Home;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.Button find;
        private System.Windows.Forms.TextBox textBoxFind;
    }
}