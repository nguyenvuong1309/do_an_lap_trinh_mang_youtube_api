using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using test;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace test
{
    public partial class Home : UserControl
    {
        URL URL = new URL();
        Main MAIN = null;
        WatchVideo WATCH_VIDEO_FORM = null;
        //this.Dock = DockStyle.Fill;
        public Home()
        {
            InitializeComponent();
            _ = displayVideoAsync("news");
            this.Dock = DockStyle.Fill;
        }
        public Home(Main main)
        {
            InitializeComponent();
            this.MAIN = main;
            this.URL = main.URLFind;
            _ = displayVideoAsync(this.MAIN.KeyWord);
            this.Dock = DockStyle.Fill;
        }
        public static T ParseJson<T>(string json)
        {
            return JsonSerializer.Deserialize<T>(json, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });
        }
        public async Task displayVideoAsync(string keyWords)
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
                    ItemVideo[] list = new ItemVideo[20];
                    for (int i = 0; i < list.Length; i++)
                    {
                        list[i] = new ItemVideo();
                        list[i].idVideo = data.items[i].id.videoId.ToString();
                        list[i].setImage(data.items[i].snippet.thumbnails.high.url);
                        list[i].ChannelTitle.Text = data.items[i].snippet.channelTitle.ToString();
                        list[i].title.Text = data.items[i].snippet.title.ToString();

                        string id = list[i].idVideo;
                        string idYoutubeChannel = data.items[i].snippet.channelId.ToString();

                      
                        list[i].Click += (sender, e) => { MyButtonClickHandler(sender, id); };
                        list[i].title.Click += (sender, e) => { MyButtonClickHandler(sender, id); };
                        list[i].pictureBox.Click += (sender, e) => { MyButtonClickHandler(sender, id); };
                        list[i].ChannelTitle.Click += (sender, e) => { MyButtonClickHandler(sender, id); };
                        list[i].information.Click += (sender, e) => { MyButtonClickHandler(sender, id); };
                        list[i].pictureBox1.Click += (sender, e) => { OpenYoutubeChannel(sender, idYoutubeChannel); };

                        flowLayoutPanelHome.Controls.Add(list[i]);
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
            WATCH_VIDEO_FORM = new WatchVideo(this.MAIN,id);
            this.MAIN.MainForm.Controls.Add(WATCH_VIDEO_FORM);
        }
        private void OpenYoutubeChannel(object sender, string id)  
        {
            YoutubeChannel CHANNEL = new YoutubeChannel(this.MAIN,id);
            this.MAIN.MainForm.Controls.Clear();
            this.MAIN.MainForm.Controls.Add(CHANNEL);
        }
    }
}
