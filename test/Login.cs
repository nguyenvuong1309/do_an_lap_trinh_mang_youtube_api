using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class Login : UserControl
    {
        Main MAIN = null;
        static HttpClient client = new HttpClient();
        public Login()
        {
            InitializeComponent();
        }
        public Login(Main main)
        {
            InitializeComponent();
            this.MAIN = main;
            this.Dock = DockStyle.Fill;
        }
        private void linkSignup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.MAIN.MainForm.Controls.Clear();
            this.MAIN.MainForm.Controls.Add(new Register(MAIN));
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string plainText = "Hello, World!";
            byte[] key = Encoding.UTF8.GetBytes("0123456789abcdef"); // 16-byte key
            byte[] iv = new byte[16]; // Initialization Vector (16 bytes)

            string Username = AES.Aes_cbc_128_Encrypt1(username.Text,key,iv);
            string Password = AES.Aes_cbc_128_Encrypt1(password.Text,key,iv);
            LoginUser(Username, Password);
        }
        public async void LoginUser(string username, string password)
        {
            var loginData = new
            {
                Username = username,
                Password = password,
            };
            try
            {
                
                var content = JsonConvert.SerializeObject(loginData);
                var httpContent = new StringContent(content, Encoding.UTF8, "application/json");
                var response = await client.PostAsync(this.MAIN.URL_TO_LOGIN_SERVER + "/login", httpContent);
               
                var responseContent = response.Content.ReadAsStringAsync().Result;
                var responseHeader = response.Headers.GetValues("Authorization").FirstOrDefault();
                // Xử lý JWT ở đây
                this.MAIN.URLFind.seconndPart = responseHeader.ToString();

                MessageBox.Show(responseHeader.ToString());
                MessageBox.Show("login");
                if (response.IsSuccessStatusCode)
                {
                    this.MAIN.MainForm.Controls.Clear();
                    this.MAIN.MainForm.Controls.Add(new Home(this.MAIN));
                    MessageBox.Show(responseContent);
                }
                else
                {
                    MessageBox.Show("Login failed");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
