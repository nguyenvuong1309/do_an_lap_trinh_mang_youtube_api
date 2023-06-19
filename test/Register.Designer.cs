namespace test
{
    partial class Register
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
            this.panel = new System.Windows.Forms.Panel();
            this.fullnamesignup = new System.Windows.Forms.TextBox();
            this.rewritepassword = new System.Windows.Forms.TextBox();
            this.signup = new System.Windows.Forms.Button();
            this.passwordsignup = new System.Windows.Forms.TextBox();
            this.usernamesignup = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel.Controls.Add(this.fullnamesignup);
            this.panel.Controls.Add(this.rewritepassword);
            this.panel.Controls.Add(this.signup);
            this.panel.Controls.Add(this.passwordsignup);
            this.panel.Controls.Add(this.usernamesignup);
            this.panel.Controls.Add(this.label1);
            this.panel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel.Location = new System.Drawing.Point(261, 18);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(460, 503);
            this.panel.TabIndex = 4;
            // 
            // fullnamesignup
            // 
            this.fullnamesignup.Location = new System.Drawing.Point(32, 86);
            this.fullnamesignup.Multiline = true;
            this.fullnamesignup.Name = "fullnamesignup";
            this.fullnamesignup.Size = new System.Drawing.Size(393, 43);
            this.fullnamesignup.TabIndex = 5;
            // 
            // rewritepassword
            // 
            this.rewritepassword.Location = new System.Drawing.Point(32, 365);
            this.rewritepassword.Multiline = true;
            this.rewritepassword.Name = "rewritepassword";
            this.rewritepassword.Size = new System.Drawing.Size(393, 43);
            this.rewritepassword.TabIndex = 4;
            // 
            // signup
            // 
            this.signup.BackColor = System.Drawing.Color.Red;
            this.signup.FlatAppearance.BorderSize = 0;
            this.signup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signup.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup.Location = new System.Drawing.Point(140, 435);
            this.signup.Name = "signup";
            this.signup.Size = new System.Drawing.Size(173, 39);
            this.signup.TabIndex = 3;
            this.signup.Text = "Đăng Ký";
            this.signup.UseVisualStyleBackColor = false;
            this.signup.Click += new System.EventHandler(this.signup_Click);
            // 
            // passwordsignup
            // 
            this.passwordsignup.Location = new System.Drawing.Point(32, 274);
            this.passwordsignup.Multiline = true;
            this.passwordsignup.Name = "passwordsignup";
            this.passwordsignup.Size = new System.Drawing.Size(393, 43);
            this.passwordsignup.TabIndex = 2;
            // 
            // usernamesignup
            // 
            this.usernamesignup.Location = new System.Drawing.Point(32, 179);
            this.usernamesignup.Multiline = true;
            this.usernamesignup.Name = "usernamesignup";
            this.usernamesignup.Size = new System.Drawing.Size(393, 43);
            this.usernamesignup.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(109, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đăng Ký";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LawnGreen;
            this.Controls.Add(this.panel);
            this.Name = "Register";
            this.Size = new System.Drawing.Size(983, 539);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.TextBox fullnamesignup;
        private System.Windows.Forms.TextBox rewritepassword;
        private System.Windows.Forms.Button signup;
        private System.Windows.Forms.TextBox passwordsignup;
        private System.Windows.Forms.TextBox usernamesignup;
        private System.Windows.Forms.Label label1;
    }
}
