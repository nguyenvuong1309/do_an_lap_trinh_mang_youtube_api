using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using test;
using test.WATCHVIDEO;
using test.YoutubeChannel_Folder;
using test.YoutubeChannel_Folder.DATA;
using WATCHVIDEO;

namespace test
{
    public partial class WatchVideo : UserControl
    {
        public URL URL = new URL();
        string ID_VIDEO = string.Empty;
        Main MAIN = null;
        public WatchVideo()
        {
            InitializeComponent();
        }
        public WatchVideo(string Id_Video)
        {
            InitializeComponent();
            this.ID_VIDEO = Id_Video;
            displayVideo(this.ID_VIDEO);
        }
        public WatchVideo(Main main,string iD_VIDEO)
        {
            InitializeComponent();
            MAIN = main;
            this.ID_VIDEO = iD_VIDEO;
            this.URL = this.MAIN.URLFind;
            //this.MAIN.MainForm.Controls.Clear();
            displayVideo(this.ID_VIDEO);
            displayListVideo(this.MAIN.KeyWord);
          
        }
        private async void displayVideo(string id)
        {
            try
            {
                HttpClient client = new HttpClient();
                //string url = "https://www.googleapis.com/youtube/v3/videos?part=snippet%2CcontentDetails%2Cstatistics&id=" + id + "&key=AIzaSyC0pPZ4zhfE_G3i21PZTX8smly7vIRXJIw";
                string url = this.MAIN.URL_YOUTUBE_VIDEO.firstPart + id + this.MAIN.URL_YOUTUBE_VIDEO.seconndPart;
                HttpResponseMessage response = await client.GetAsync(url);
                // Kiểm tra xem request thành công hay không
                if (response.IsSuccessStatusCode)
                {
                    // Đọc nội dung JSON từ response
                    string json = await response.Content.ReadAsStringAsync();

                    // Xử lý dữ liệu JSON tại đây


                    Data_Information_Video.Rootobject data = ParseJson<Data_Information_Video.Rootobject>(json);
                    string idYoutubeChannel = data.items[0].snippet.channelId;
                    string url_image = await Get_Video_Image.get_url_imageAsync(this.MAIN.URL_YOUTUBE_CHANNEL.firstPart + idYoutubeChannel + this.MAIN.URL_YOUTUBE_CHANNEL.seconndPart);
                    this.setImage(url_image);
                    this.Title.Text = data.items[0].snippet.title;
                    this.Channel_Title.Text = data.items[0].snippet.channelTitle;
                    this.pictureBox1.Click += (sender, e) => { OpenYoutubeChannel(sender, idYoutubeChannel); };
                }
                else
                {
                    MessageBox.Show("Error: Request failed with status code: " + response.StatusCode);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            this.webBrowser.Dock = DockStyle.Fill;  
            string html = "html head";
            html += "<meta content='IE=Edge' http-equiv='X-UA-Compatible'/>";
            html += "<iframe id='video' src='https://www.youtube.com/embed/{0}' width='600' height='300' frameborder='0' allowfullscreen></iframe>";
            html += "</head></html>";
            this.webBrowser.DocumentText = string.Format(html, id);
        }
        private void OpenYoutubeChannel(object sender, string id)
        {
            YoutubeChannel CHANNEL = new YoutubeChannel(this.MAIN, id);
            this.MAIN.MainForm.Controls.Clear();
            this.MAIN.MainForm.Controls.Add(CHANNEL);
        }
        public static T ParseJson<T>(string json)
        {
            return JsonSerializer.Deserialize<T>(json, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });
        }
        private async void displayListVideo(string keyWords)
        {
            try
            {
                HttpClient client = new HttpClient();
                //URL = "https://youtube.googleapis.com/youtube/v3/search?part=snippet&q=" + "news" + "&type=video&key=AIzaSyC0pPZ4zhfE_G3i21PZTX8smly7vIRXJIa&maxResults=20";
                //       https://youtube.googleapis.com/youtube/v3/search?part=snippet&q=news&type=video&key=AIzaSyC0pPZ4zhfE_G3i21PZTX8smly7vIRXJIw&maxResults=20
                string url = this.URL.firstPart + keyWords + this.URL.seconndPart;
                HttpResponseMessage response = await client.GetAsync(url);

                // Kiểm tra xem request thành công hay không
                if (response.IsSuccessStatusCode)
                {
                    // Đọc nội dung JSON từ response
                    string json = await response.Content.ReadAsStringAsync();

                    // Xử lý dữ liệu JSON tại đây


                    Data.Rootobject data = ParseJson<Data.Rootobject>(json);



                    /*List<Data.Item> data = JsonSerializer.Deserialize<List<Data.Item>>(json);
                    MessageBox.Show(data.ToString());*/
                    Item_In_WatchVideo[] list = new Item_In_WatchVideo[20];

                    for (int i = 0; i < list.Length; i++)
                    {
                        list[i] = new Item_In_WatchVideo();
                        list[i].idVideo = data.items[i].id.videoId.ToString();
                        list[i].Title.Text = data.items[i].snippet.title.ToString();
                        list[i].Channel_Title.Text = data.items[i].snippet.channelTitle.ToString();
                        list[i].Description.Text = data.items[i].snippet.description.ToString();
                        list[i].setImage(data.items[i].snippet.thumbnails.high.url);

                        string id = list[i].idVideo;
                        string idYoutubeChannel = data.items[i].snippet.channelId.ToString();

                        this.flowLayoutPanel2.Controls.Add(list[i]);
                        list[i].Click += (sender, e) => { MyButtonClickHandler(sender, id); };
                        list[i].pictureBox1.Click += (sender, e) => { MyButtonClickHandler(sender, id); };
                        list[i].Title.Click += (sender, e) => { MyButtonClickHandler(sender, id); };
                        list[i].Channel_Title.Click += (sender, e) => { MyButtonClickHandler(sender, id); };
                        list[i].Description.Click += (sender, e) => { MyButtonClickHandler(sender, id); };
                        list[i].panel2.Click += (sender, e) => { MyButtonClickHandler(sender, id); };
                    }
                }
                else
                {
                    MessageBox.Show("Error: Request failed with status code: " + response.StatusCode);
                }
            }
            catch (Exception ex)
            {
             
                MessageBox.Show(ex.Message);
            }
        }
        private void MyButtonClickHandler(object sender, string id)  // Hàm này được dùng để hiển thị video trên user control khác.
        {
            displayVideo(id);
        }
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
                    //this.flowLayoutPanel1.pictureBox1.Image = image;
                    this.pictureBox1.Image = image;
                }
            }
        }
    }
}
