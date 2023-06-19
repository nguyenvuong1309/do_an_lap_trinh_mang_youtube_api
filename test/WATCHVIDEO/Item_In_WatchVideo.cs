using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test.WATCHVIDEO
{
    public partial class Item_In_WatchVideo : UserControl
    {
        public Item_In_WatchVideo()
        {
            InitializeComponent();
        }
        public Item_In_WatchVideo(string title,string channel_title,string descripton)
        { 
            InitializeComponent();
        }
        public string idVideo = "";
        public void setImage(string url)
        {
            string imageUrl = url;
            using (var webClient = new WebClient())
            {
                byte[] imageData = webClient.DownloadData(imageUrl);

                // Create an Image object from the downloaded data
                using (var stream = new System.IO.MemoryStream(imageData))
                {
                    Image image = Image.FromStream(stream);

                    // Assign the image to the PictureBox control
                    pictureBox1.Image = image;
                }
            }
        }
    }
}
