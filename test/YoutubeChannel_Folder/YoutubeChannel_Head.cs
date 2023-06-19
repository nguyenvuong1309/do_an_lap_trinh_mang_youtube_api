using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using test.YoutubeChannel_Folder;
using test.YoutubeChannel_Folder.DATA;
using test.YoutubeChannel_Folder.SECTION;
using test.YoutubeChannel_Folder.SECTION.VIDEOS;

namespace test
{
    public partial class YoutubeChannel_Head : UserControl
    {
        public Main MAIN = null;
        public string IdYoutubeChannel = "";
        public YoutubeChannel YOUTUBE_CHANNEL= null;
        Data_Youtube_Channel.Rootobject data = null;
        public YoutubeChannel_Head()
        {
            InitializeComponent();
        }
        public YoutubeChannel_Head(Main main,YoutubeChannel y,string idYoutubeChannel)
        {
            InitializeComponent();
            this.MAIN = main;   
            this.IdYoutubeChannel = idYoutubeChannel;
            this.YOUTUBE_CHANNEL = y;
            DisplayInformation(idYoutubeChannel);
        }
        public void setImage(string url)
        {
            try
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
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static T ParseJson<T>(string json)
        {
            return JsonSerializer.Deserialize<T>(json, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });
        }
        /*public async void DisplayInformation(string idYoutubeChannel)
        {
            try
            {
                HttpClient client = new HttpClient();
                //string url = "https://www.googleapis.com/youtube/v3/channels?part=snippet,statistics&id=" + idYoutubeChannel + "&key=AIzaSyCu3vIqZAgehD28RyVwoCLCSXTefYAUCBs";
                string url = this.MAIN.URL_YOUTUBE_CHANNEL.firstPart + idYoutubeChannel + this.MAIN.URL_YOUTUBE_CHANNEL.seconndPart;
                HttpResponseMessage response = await client.GetAsync(url);

                // Kiểm tra xem request thành công hay không
                if (response.IsSuccessStatusCode)
                {
                    // Đọc nội dung JSON từ response
                    string json = await response.Content.ReadAsStringAsync();

                    // Xử lý dữ liệu JSON tại đây


                    data = ParseJson<Data_Youtube_Channel.Rootobject>(json);


                    this.setImage(data.items[0].snippet.thumbnails.high.url);
                    this.youtube_channel_title.Text = data.items[0].snippet.title;
                    this.youtube_channel_subscribers.Text = data.items[0].snippet.customUrl + " " + data.items[0].statistics.subscriberCount[0] + " M subscribers";//data.items[4].statistics.subscriberCount;
                    this.channel_youtube_description.Text = data.items[0].snippet.description;
            
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
        }*/
        public async void DisplayInformation(string idYoutubeChannel)
        {
            try
            {
                HttpClient client = new HttpClient();

                // Đặt JWT token vào header Authorization
                //string jwtToken = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1c2VybmFtZSI6InJheWluYXcifQ.ZVX8MQmMkmB9OmxUl3z-VGi-wKJlMjpcJ46HW3DaeYs";
                //string jwtToken = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1c2VybmFtZSI6Im1pbmhkdWMifQ.E5cpY_4elj2Z54dhdLhJQ7XYNXmxkm8sY2CFJdf6a6A";
                string jwtToken = this.MAIN.URL_YOUTUBE_CHANNEL.seconndPart;
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", jwtToken);

                // Gửi request GET đến API endpoint
                //string apiUrl = "https://efbb-14-161-12-88.ngrok-free.app/api/search?q=" + keyWord;
                //string apiUrl = "https://221e-203-205-32-177.ngrok-free.app/api/search?q=" + keyWord;
                string apiUrl = this.MAIN.URL_YOUTUBE_CHANNEL.firstPart + idYoutubeChannel;
                HttpResponseMessage response = await client.GetAsync(apiUrl);

                // Kiểm tra xem request thành công hay không
                if (response.IsSuccessStatusCode)
                {
                    // Đọc nội dung JSON từ response
                    string json = await response.Content.ReadAsStringAsync();

                    // Xử lý dữ liệu JSON tại đây



                    data = ParseJson<Data_Youtube_Channel.Rootobject>(json);

                    this.setImage(data.items[0].snippet.thumbnails.high.url);
                    this.YOUTUBE_CHANNEL.imageChannel = data.items[0].snippet.thumbnails.high.url;
                    this.youtube_channel_title.Text = data.items[0].snippet.title;
                    this.youtube_channel_subscribers.Text = data.items[0].snippet.customUrl + " " + data.items[0].statistics.subscriberCount[0] + " M subscribers";//data.items[4].statistics.subscriberCount;
                    this.channel_youtube_description.Text = data.items[0].snippet.description;
                }
                else
                {
                    MessageBox.Show("Request failed with status code: " + response.StatusCode);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private  void Videos_Click(object sender, EventArgs e)
        {
            YoutubeChannel_Body userControlToRemove = this.YOUTUBE_CHANNEL.flowLayoutPanelYoutubeChannel.Controls.OfType<YoutubeChannel_Body>().FirstOrDefault();
            if (userControlToRemove != null)
            {
                // Remove the control from the container
                this.YOUTUBE_CHANNEL.flowLayoutPanelYoutubeChannel.Controls.Remove(userControlToRemove);
            }

            WatchVideo userControlToRemove1 = this.YOUTUBE_CHANNEL.flowLayoutPanelYoutubeChannel.Controls.OfType<WatchVideo>().FirstOrDefault();
            if (userControlToRemove1 != null)
            {
                // Remove the control from the container
                this.YOUTUBE_CHANNEL.flowLayoutPanelYoutubeChannel.Controls.Remove(userControlToRemove1);
            }

            Display_Video_YoutubeChannel DISPLAY = new Display_Video_YoutubeChannel(this.MAIN,this.YOUTUBE_CHANNEL,this.IdYoutubeChannel);
        }
        private void About_Click(object sender, EventArgs e)
        {
            //this.YOUTUBE_CHANNEL.Controls.Remove(this.YOUTUBE_CHANNEL);
            YoutubeChannel_Body userControlToRemove = this.YOUTUBE_CHANNEL.flowLayoutPanelYoutubeChannel.Controls.OfType<YoutubeChannel_Body>().FirstOrDefault();
            if (userControlToRemove != null)
            {
                // Remove the control from the container
                this.YOUTUBE_CHANNEL.flowLayoutPanelYoutubeChannel.Controls.Remove(userControlToRemove);
                //userControlToRemove.Dispose(); // Optionally dispose the control if needed
            }

            WatchVideo userControlToRemove1 = this.YOUTUBE_CHANNEL.flowLayoutPanelYoutubeChannel.Controls.OfType<WatchVideo>().FirstOrDefault();
            if (userControlToRemove != null)
            {
                // Remove the control from the container
                this.YOUTUBE_CHANNEL.flowLayoutPanelYoutubeChannel.Controls.Remove(userControlToRemove1);
            }

            YoutubeChannel_Body YOUTUBECHANNEL_BODY = new YoutubeChannel_Body(this.MAIN);
            TextBox t = new TextBox();
            t.ForeColor = Color.White;
            t.BackColor = Color.Black;
            t.Multiline = true;
            t.Width = 2100;
            t.Height = 1500;
            t.ScrollBars = ScrollBars.Both;
            t.Text = data.items[0].snippet.description;
            YOUTUBECHANNEL_BODY.flowLayoutPanel1.Controls.Add(t);
            this.YOUTUBE_CHANNEL.flowLayoutPanelYoutubeChannel.Controls.Add(YOUTUBECHANNEL_BODY);
        }
    }
}
