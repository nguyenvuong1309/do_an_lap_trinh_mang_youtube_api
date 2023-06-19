using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using test;

namespace test
{
    public partial class Main : Form
    {
        public URL URLFind = new URL();
        public URL URL_YOUTUBE_CHANNEL = new URL();
        public URL URL_YOUTUBE_VIDEO = new URL();   
        public URL URL_FIND_VIDEO_IN_YOUTUBE_CHANNEL = new URL();
        public string USERNAME = "";
        public string PASSWORD = "";
        public string KeyWord = "";
        public List<string> HISTORY_LIST = new List<string>();
        public Main()
        {
            InitializeComponent();
            this.MainForm.Controls.Clear();
            this.MainForm.Controls.Add(new Home(this));
        }
        private void find_Click(object sender, EventArgs e)
        {
            this.KeyWord = textBoxFind.Text;
            this.MainForm.Controls.Clear();
            this.MainForm.Controls.Add(new Home(this));
        }
        private void Login_Click(object sender, EventArgs e)
        {
            this.MainForm.Controls.Clear();
            this.MainForm.Controls.Add(new Login(this));
        }
        private void Home_Click(object sender, EventArgs e)
        {
            this.MainForm.Controls.Clear();
            this.MainForm.Controls.Add(new Home(this));
        }
        private void History_Click(object sender, EventArgs e)
        {

        }
        private void setting_Click(object sender, EventArgs e)
        {
            this.MainForm.Controls.Clear();
            this.MainForm.Controls.Add(new Setting(this));
        }
    }
}
