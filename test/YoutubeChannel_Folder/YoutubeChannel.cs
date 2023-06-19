using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using test.YoutubeChannel_Folder;

namespace test
{
    public partial class YoutubeChannel : UserControl
    {
        public Main MAIN = null;
        string IdYoutubeChannel = "";
        public YoutubeChannel_Body YOUTUBECHANNEL_BODY = null;


        public YoutubeChannel()
        {
            InitializeComponent();
        }
        public YoutubeChannel(Main main,string idYoutubeChannel)
        {
            InitializeComponent();
            this.MAIN = main;
            this.Dock = DockStyle.Fill;
            this.IdYoutubeChannel = idYoutubeChannel;
            _ = displayVideoAsync(this.IdYoutubeChannel);
        }
        public static T ParseJson<T>(string json)
        {
            return JsonSerializer.Deserialize<T>(json, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });
        }
        public async Task displayVideoAsync(string idYoutubeChannel)
        {
            YoutubeChannel_Head YOUTUBECHANNEL_HEAD = new YoutubeChannel_Head(this.MAIN, this, idYoutubeChannel);
            flowLayoutPanelYoutubeChannel.Controls.Add(YOUTUBECHANNEL_HEAD);
          /*  try
            {
                HttpClient client = new HttpClient();
                //string url = "https://youtube.googleapis.com/youtube/v3/search?part=snippet&q=" + "news" + "&type=video&key=AIzaSyAp_IOoDFm7qQgNMfpokc7qetc-VGiUMnE&maxResults=20";
                //string url = "https://www.googleapis.com/youtube/v3/channels?part=snippet,statistics&id=UCeY0bbntWzzVIaj2z3QigXg&key=AIzaSyC0pPZ4zhfE_G3i21PZTX8smly7vIRXJIw";
                string url = "";
                HttpResponseMessage response = await client.GetAsync(url);
                 
                // Kiểm tra xem request thành công hay không
                if (response.IsSuccessStatusCode)
                {
                    // Đọc nội dung JSON từ response
                    string json = await response.Content.ReadAsStringAsync();

                    Data_Youtube_Channel.Rootobject data = ParseJson<Data_Youtube_Channel.Rootobject>(json);

                    YOUTUBECHANNEL_HEAD = new YoutubeChannel_Head(this.MAIN,this,idYoutubeChannel);
                    flowLayoutPanelYoutubeChannel.Controls.Add(YOUTUBECHANNEL_HEAD);
                }
                else
                { 
                    MessageBox.Show("Request failed with status code: " + response.StatusCode);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }*/
        }
    }
}
