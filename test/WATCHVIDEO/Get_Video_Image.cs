using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.ServiceModel;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using test;
using test.LIBARARIES;
using test.YoutubeChannel_Folder;

namespace WATCHVIDEO
{
    public  class Get_Video_Image
    {
        public string ID_VIDEO = "";
        public Main MAIN = null;
        public Get_Video_Image()
        {

        }
        public Get_Video_Image(Main main,string idVideo)
        {
            this.MAIN = main;
            this.ID_VIDEO = idVideo;    
        }
        //  public static async Task<string> get_url_imageAsync(string idYoutubeChannel)
        /*public static async Task<string> get_url_imageAsync(string url_and_idYoutubeChannel)
        {
            //string url = "https://www.googleapis.com/youtube/v3/channels?part=snippet&id=" + idYoutubeChannel+ "&key=AIzaSyC0pPZ4zhfE_G3i21PZTX8smly7vIRXJIw";
            string url = url_and_idYoutubeChannel;  
            try
            {
                HttpClient client = new HttpClient();
              
                HttpResponseMessage response = await client.GetAsync(url);

                // Kiểm tra xem request thành công hay không
                if (response.IsSuccessStatusCode)
                {
                    // Đọc nội dung JSON từ response
                    string json = await response.Content.ReadAsStringAsync();

                    // Xử lý dữ liệu JSON tại đây


                    Data_Youtube_Channel.Rootobject data = PARSE_JSON.ParseJson<Data_Youtube_Channel.Rootobject>(json);
                    url = data.items[0].snippet.thumbnails.high.url.ToString();
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
            return url;
        }*/
        public static async Task<string> get_url_imageAsync(string url_and_idYoutubeChannel,string token)
        {
            //string url = "https://www.googleapis.com/youtube/v3/channels?part=snippet&id=" + idYoutubeChannel+ "&key=AIzaSyC0pPZ4zhfE_G3i21PZTX8smly7vIRXJIw";
            string url = url_and_idYoutubeChannel;
            try
            {
                HttpClient client = new HttpClient();

                // Đặt JWT token vào header Authorization
                //string jwtToken = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1c2VybmFtZSI6InJheWluYXcifQ.ZVX8MQmMkmB9OmxUl3z-VGi-wKJlMjpcJ46HW3DaeYs";
                //string jwtToken = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1c2VybmFtZSI6Im1pbmhkdWMifQ.E5cpY_4elj2Z54dhdLhJQ7XYNXmxkm8sY2CFJdf6a6A";
                string jwtToken = token;
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", jwtToken);

                // Gửi request GET đến API endpoint
                //string apiUrl = "https://efbb-14-161-12-88.ngrok-free.app/api/search?q=" + keyWord;
                //string apiUrl = "https://221e-203-205-32-177.ngrok-free.app/api/search?q=" + keyWord;
                string apiUrl = url;
                HttpResponseMessage response = await client.GetAsync(apiUrl);

                // Kiểm tra xem request thành công hay không
                if (response.IsSuccessStatusCode)
                {
                    // Đọc nội dung JSON từ response
                    string json = await response.Content.ReadAsStringAsync();

                    // Xử lý dữ liệu JSON tại đây



                    Data_Youtube_Channel_NGROk.Rootobject data = JsonConvert.DeserializeObject<Data_Youtube_Channel_NGROk.Rootobject>(json);
                    url = data.items[0].snippet.thumbnails.high.url.ToString();
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
            return url;
        }
    }
}
