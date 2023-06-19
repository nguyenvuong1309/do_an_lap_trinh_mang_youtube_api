namespace test
{
    partial class YoutubeChannel_Head
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YoutubeChannel_Head));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.youtube_channel_title = new System.Windows.Forms.TextBox();
            this.youtube_channel_subscribers = new System.Windows.Forms.TextBox();
            this.channel_youtube_description = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.About = new System.Windows.Forms.Button();
            this.Videos = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(183, 181);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // youtube_channel_title
            // 
            this.youtube_channel_title.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.youtube_channel_title.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.youtube_channel_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.youtube_channel_title.Location = new System.Drawing.Point(205, 28);
            this.youtube_channel_title.Name = "youtube_channel_title";
            this.youtube_channel_title.Size = new System.Drawing.Size(260, 27);
            this.youtube_channel_title.TabIndex = 1;
            this.youtube_channel_title.Text = "NBC News";
            // 
            // youtube_channel_subscribers
            // 
            this.youtube_channel_subscribers.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.youtube_channel_subscribers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.youtube_channel_subscribers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.youtube_channel_subscribers.Location = new System.Drawing.Point(205, 89);
            this.youtube_channel_subscribers.Name = "youtube_channel_subscribers";
            this.youtube_channel_subscribers.Size = new System.Drawing.Size(417, 20);
            this.youtube_channel_subscribers.TabIndex = 2;
            this.youtube_channel_subscribers.Text = "@NBCNews8M subscribers52K videos";
            // 
            // channel_youtube_description
            // 
            this.channel_youtube_description.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.channel_youtube_description.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.channel_youtube_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.channel_youtube_description.Location = new System.Drawing.Point(205, 153);
            this.channel_youtube_description.Name = "channel_youtube_description";
            this.channel_youtube_description.Size = new System.Drawing.Size(991, 20);
            this.channel_youtube_description.TabIndex = 3;
            this.channel_youtube_description.Text = resources.GetString("channel_youtube_description.Text");
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.About);
            this.panel1.Controls.Add(this.Videos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 181);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2100, 69);
            this.panel1.TabIndex = 4;
            // 
            // About
            // 
            this.About.AutoSize = true;
            this.About.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.About.Location = new System.Drawing.Point(205, 34);
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(88, 32);
            this.About.TabIndex = 7;
            this.About.Text = "ABOUT";
            this.About.UseVisualStyleBackColor = true;
            this.About.Click += new System.EventHandler(this.About_Click);
            // 
            // Videos
            // 
            this.Videos.AutoSize = true;
            this.Videos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Videos.Location = new System.Drawing.Point(48, 34);
            this.Videos.Name = "Videos";
            this.Videos.Size = new System.Drawing.Size(93, 32);
            this.Videos.TabIndex = 4;
            this.Videos.Text = "VIDEOS";
            this.Videos.UseVisualStyleBackColor = true;
            this.Videos.Click += new System.EventHandler(this.Videos_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.youtube_channel_title);
            this.panel2.Controls.Add(this.youtube_channel_subscribers);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.channel_youtube_description);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2100, 181);
            this.panel2.TabIndex = 0;
            // 
            // YoutubeChannel_Head
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "YoutubeChannel_Head";
            this.Size = new System.Drawing.Size(2100, 250);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox youtube_channel_title;
        private System.Windows.Forms.TextBox youtube_channel_subscribers;
        private System.Windows.Forms.TextBox channel_youtube_description;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button About;
        private System.Windows.Forms.Button Videos;
    }
}
