using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using test.YoutubeChannel_Folder.SECTION;

namespace test
{
    public partial class ItemVideo : UserControl
    {
        public ItemVideo()
        {
            InitializeComponent();
        }
        public string idVideo = "";
        public string _titlvideo = "";
        public string titleVideo
        {
            get { return _titlvideo; }
            set { _titlvideo = value; }
        }
        public void setImage(string url)
        {
            /*string imageUrl = url;
            int x = 100; // X-coordinate of the top-left corner of the portion of the image you want to display
            int y = 100; // Y-coordinate of the top-left corner of the portion of the image you want to display
            int width = 400; // Width of the portion of the image you want to display
            int height = 400; // Height of the portion of the image you want to display

            using (var webClient = new WebClient())
            {
                using (var stream = new MemoryStream(webClient.DownloadData(imageUrl)))
                {
                    Bitmap originalImage = (Bitmap)Bitmap.FromStream(stream);
                    Bitmap croppedImage = new Bitmap(width, height);

                    using (Graphics g = Graphics.FromImage(croppedImage))
                    {
                        g.DrawImage(originalImage, new Rectangle(0, 0, width, height), new Rectangle(x, y, width, height), GraphicsUnit.Pixel);
                    }
                    Image thumbnailImage = croppedImage.GetThumbnailImage(originalImage.Width, originalImage.Height, null, IntPtr.Zero);
                    pictureBox.Image = thumbnailImage;
                }
            }*/
            string imageUrl = url;

            // Download the image from the URL
            using (var webClient = new WebClient())
            {
                byte[] imageData = webClient.DownloadData(imageUrl);

                // Create an Image object from the downloaded data
                using (var stream = new System.IO.MemoryStream(imageData))
                {
                    Image image = Image.FromStream(stream);

                    // Assign the image to the PictureBox control
                    pictureBox.Image = image;
                }
            }
        }
        public void setImage1(string url)
        {
            string imageUrl = url;

            // Download the image from the URL
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

        private void ItemVideo_Load(object sender, EventArgs e)
        {
            string imageUrl = "https://i.ytimg.com/vi/XtVIW7TGaio/default.jpg";

            // Download the image from the URL
            using (var webClient = new WebClient())
            {
                byte[] imageData = webClient.DownloadData(imageUrl);

                // Create an Image object from the downloaded data
                using (var stream = new System.IO.MemoryStream(imageData))
                {
                    Image image = Image.FromStream(stream);

                    // Assign the image to the PictureBox control
                    pictureBox.Image = image;
                }
            }
        }
    }
}
