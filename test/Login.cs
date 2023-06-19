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
            string Username = username.Text;
            string Password = password.Text;
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
                var response = await client.PostAsync("http://172.20.10.2:8080/login", httpContent);
               
                var responseContent = response.Content.ReadAsStringAsync().Result;
                var responseHeader = response.Headers.ProxyAuthenticate;
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
