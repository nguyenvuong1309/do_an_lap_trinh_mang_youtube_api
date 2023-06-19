using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using test.YoutubeChannel_Folder.DATA;

namespace test.YoutubeChannel_Folder.SECTION.VIDEOS
{
    public class Display_Video_YoutubeChannel
    {
        YoutubeChannel YOUTUBE_CHANNEL = null;
        public string ID_YOUTUBE_CHANNEL;
        public YoutubeChannel_Body YOUTUBECHANNEL_BODY = null;
        public Main MAIN = null;
        public Display_Video_YoutubeChannel(Main main,YoutubeChannel y,string idYoutubeChannel) 
        {
            this.MAIN = main;
            this.YOUTUBE_CHANNEL = y;
            this.ID_YOUTUBE_CHANNEL = idYoutubeChannel;
            Display();
        }
        public static T ParseJson<T>(string json)
        {
            return JsonSerializer.Deserialize<T>(json, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });
        }
        /*public async void Display()
        {
            YoutubeChannel_Body userControlToRemove = this.YOUTUBE_CHANNEL.flowLayoutPanelYoutubeChannel.Controls.OfType<YoutubeChannel_Body>().FirstOrDefault();
            if (userControlToRemove != null)
            {
                // Remove the control from the container
                this.YOUTUBE_CHANNEL.flowLayoutPanelYoutubeChannel.Controls.Remove(userControlToRemove);

            }
            try
            {
                HttpClient client = new HttpClient();
                //string url = "https://www.googleapis.com/youtube/v3/search?part=snippet&channelId=" + this.ID_YOUTUBE_CHANNEL + "&maxResults=50&order=date&type=video&key=AIzaSyAARRGJir9sAUGFcAStqTHxfz14GsCNDWo";
                string url = this.MAIN.URL_FIND_VIDEO_IN_YOUTUBE_CHANNEL.firstPart + this.ID_YOUTUBE_CHANNEL + this.MAIN.URL_FIND_VIDEO_IN_YOUTUBE_CHANNEL.seconndPart;
                HttpResponseMessage response = await client.GetAsync(url);
                YOUTUBECHANNEL_BODY = new YoutubeChannel_Body(this.MAIN);

                // Kiểm tra xem request thành công hay không
                if (response.IsSuccessStatusCode)
                {
                    // Đọc nội dung JSON từ response
                    string json = await response.Content.ReadAsStringAsync();

                    // Xử lý dữ liệu JSON tại đây


                    Data_Videos.Rootobject data = ParseJson<Data_Videos.Rootobject>(json);



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

                        YOUTUBECHANNEL_BODY.flowLayoutPanel1.Controls.Add(list[i]);
                        list[i].Click += (sender, e) => { MyButtonClickHandler(sender, id); };
                        list[i].title.Click += (sender, e) => { MyButtonClickHandler(sender, id); };
                        list[i].pictureBox.Click += (sender, e) => { MyButtonClickHandler(sender, id); };
                        list[i].ChannelTitle.Click += (sender, e) => { MyButtonClickHandler(sender, id); };
                        list[i].information.Click += (sender, e) => { MyButtonClickHandler(sender, id); };
                    }
                }
                else
                {
                    MessageBox.Show("Error: Request failed with status code: " + response.StatusCode);
                }
            this.YOUTUBE_CHANNEL.flowLayoutPanelYoutubeChannel.Controls.Add(YOUTUBECHANNEL_BODY);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }*/

        public async void Display()
        {
            YoutubeChannel_Body userControlToRemove = this.YOUTUBE_CHANNEL.flowLayoutPanelYoutubeChannel.Controls.OfType<YoutubeChannel_Body>().FirstOrDefault();
            if (userControlToRemove != null)
            {
                // Remove the control from the container
                this.YOUTUBE_CHANNEL.flowLayoutPanelYoutubeChannel.Controls.Remove(userControlToRemove);

            }
            try
            {
                HttpClient client = new HttpClient();

                // Đặt JWT token vào header Authorization
                //string jwtToken = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1c2VybmFtZSI6InJheWluYXcifQ.ZVX8MQmMkmB9OmxUl3z-VGi-wKJlMjpcJ46HW3DaeYs";
                //string jwtToken = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1c2VybmFtZSI6Im1pbmhkdWMifQ.E5cpY_4elj2Z54dhdLhJQ7XYNXmxkm8sY2CFJdf6a6A";
                string jwtToken = this.MAIN.URLFind.seconndPart;
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", jwtToken);

                // Gửi request GET đến API endpoint
                //string apiUrl = "https://efbb-14-161-12-88.ngrok-free.app/api/search?q=" + keyWord;
                //string apiUrl = "https://221e-203-205-32-177.ngrok-free.app/api/search?q=" + keyWord;
                string apiUrl = this.MAIN.URL_FIND_VIDEO_IN_YOUTUBE_CHANNEL.firstPart + this.ID_YOUTUBE_CHANNEL;
                HttpResponseMessage response = await client.GetAsync(apiUrl);
                YOUTUBECHANNEL_BODY = new YoutubeChannel_Body(this.MAIN);

                // Kiểm tra xem request thành công hay không
                if (response.IsSuccessStatusCode)
                {
                    // Đọc nội dung JSON từ response
                    string json = await response.Content.ReadAsStringAsync();

                    // Xử lý dữ liệu JSON tại đây


                    Data_Videos_NGROK.Rootobject data = ParseJson<Data_Videos_NGROK.Rootobject>(json);



                    ItemVideo[] list = new ItemVideo[20];
                    for (int i = 0; i < list.Length; i++)
                    {
                        list[i] = new ItemVideo();
                        list[i].idVideo = data.items[i].id.videoId.ToString();
                        list[i].setImage(data.items[i].snippet.thumbnails.high.url);
                        list[i].setImage1(this.YOUTUBE_CHANNEL.imageChannel);
                        list[i].ChannelTitle.Text = data.items[i].snippet.channelTitle.ToString();
                        list[i].title.Text = data.items[i].snippet.title.ToString();

                        string id = list[i].idVideo;
                        string idYoutubeChannel = data.items[i].snippet.channelId.ToString();

                        YOUTUBECHANNEL_BODY.flowLayoutPanel1.Controls.Add(list[i]);
                        list[i].Click += (sender, e) => { MyButtonClickHandler(sender, id); };
                        list[i].title.Click += (sender, e) => { MyButtonClickHandler(sender, id); };
                        list[i].pictureBox.Click += (sender, e) => { MyButtonClickHandler(sender, id); };
                        list[i].ChannelTitle.Click += (sender, e) => { MyButtonClickHandler(sender, id); };
                        list[i].information.Click += (sender, e) => { MyButtonClickHandler(sender, id); };
                    }
                }
                else
                {
                    MessageBox.Show("Request failed with status code: " + response.StatusCode);
                }
                this.YOUTUBE_CHANNEL.flowLayoutPanelYoutubeChannel.Controls.Add(YOUTUBECHANNEL_BODY);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void MyButtonClickHandler(object sender, string id)  // Hàm này được dùng để hiển thị video trên user control khác.
        {
            WatchVideo WATCH_VIDEO = new WatchVideo(this.MAIN,id);

            YoutubeChannel_Body userControlToRemove = this.YOUTUBE_CHANNEL.flowLayoutPanelYoutubeChannel.Controls.OfType<YoutubeChannel_Body>().FirstOrDefault();
            if (userControlToRemove != null)
            {
                // Remove the control from the container
                this.YOUTUBE_CHANNEL.flowLayoutPanelYoutubeChannel.Controls.Remove(userControlToRemove);
            }


            this.YOUTUBE_CHANNEL.flowLayoutPanelYoutubeChannel.Controls.Add(WATCH_VIDEO);
        }
    }
}
