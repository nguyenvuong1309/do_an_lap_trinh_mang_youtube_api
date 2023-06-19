using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace test
{
    public partial class Setting : UserControl
    {
        Main MAIN = null;
        public Setting()
        {
            InitializeComponent();
            this.url_firstPart_textbox.Text = "https://youtube.googleapis.com/youtube/v3/search?part=snippet&q=";
            this.url_secondPart_textbox.Text = "&type=video&key=AIzaSyCu3vIqZAgehD28RyVwoCLCSXTefYAUCBs&maxResults=20";
        }
        public Setting(Main main)
        {
            this.MAIN = main;
            InitializeComponent();
            this.url_firstPart_textbox.Text = "https://youtube.googleapis.com/youtube/v3/search?part=snippet&q=";
            this.url_secondPart_textbox.Text = "&type=video&key=AIzaSyCu3vIqZAgehD28RyVwoCLCSXTefYAUCBs&maxResults=20";
          /*  url_firstPart_textbox.Text = this.MAIN.URLFind.firstPart;
            url_secondPart_textbox.Text = this.MAIN.URLFind.seconndPart;*/
        }

        private void change_Click(object sender, EventArgs e)
        {
            this.MAIN.URLFind.firstPart = this.url_firstPart_textbox.Text;
            this.MAIN.URLFind.seconndPart = this.url_secondPart_textbox.Text;

            this.MAIN.URL_YOUTUBE_CHANNEL.firstPart = this.textBox1.Text;
            this.MAIN.URL_YOUTUBE_CHANNEL.seconndPart= this.textBox2.Text;

            this.MAIN.URL_YOUTUBE_VIDEO.firstPart = this.textBox5.Text;
            this.MAIN.URL_YOUTUBE_VIDEO.seconndPart = this.textBox6.Text;

            this.MAIN.URL_FIND_VIDEO_IN_YOUTUBE_CHANNEL.firstPart = this.textBox8.Text;
            this.MAIN.URL_FIND_VIDEO_IN_YOUTUBE_CHANNEL.seconndPart = this.textBox9.Text;
        }
    }
}
