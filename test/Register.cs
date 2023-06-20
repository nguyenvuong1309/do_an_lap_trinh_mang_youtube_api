using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class Register : UserControl
    {
        string KEY_STRING = "CE16A8E87AB2C9C7023DED4D69EEFECB838D51ECD4BDCE2B43B94923EF3CB2A9";
        string IV_STRING =  "FA22F0CF07B6F6A3000AA9A77CD7DA4E";
        Main MAIN = null;
        static HttpClient client = new HttpClient();
        public Register()
        {
            InitializeComponent();
        }
        public Register(Main main)
        {
            this.MAIN = main;
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }
        private void signup_Click(object sender, EventArgs e)
        {

            string plainText = "Hello, World!";
            byte[] key = Encoding.UTF8.GetBytes("0123456789abcdef"); // 16-byte key
            byte[] iv = new byte[16]; // Initialization Vector (16 bytes)


            if (rewritepassword.Text == passwordsignup.Text)
            {
                string Fullname = AES.Aes_cbc_128_Encrypt1(fullnamesignup.Text, key, iv);
                string Username = AES.Aes_cbc_128_Encrypt1(usernamesignup.Text, key, iv);
                string Password = AES.Aes_cbc_128_Encrypt1(passwordsignup.Text, key, iv);
                string Confirmpassword = AES.Aes_cbc_128_Encrypt1(rewritepassword.Text, key, iv);
                RegisterUser(Fullname, Username, Password, Confirmpassword);
            }
            else
            {
                clear();
                MessageBox.Show("Wrong uswername or password");
            }
        }
        public async void RegisterUser(string fullName, string username, string password, string confirmPassword)
        {
            var registerData = new
            {
                Fullname = fullName,
                Username = username,
                Password = password,
                Confirmpassword = confirmPassword
            };
            try
            {
                var content = JsonConvert.SerializeObject(registerData);
                var httpContent = new StringContent(content, Encoding.UTF8, "application/json");
                var response = await client.PostAsync(this.MAIN.URL_TO_LOGIN_SERVER +"/register", httpContent);


                var responseContent = response.Content.ReadAsStringAsync().Result;
            /*    mainform.USERNAMESIGNUP = usernamesignup.Text;
                mainform.PASSWORDSIGNUP = passwordsignup.Text;*/
                MessageBox.Show(responseContent);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void clear()
        {
            usernamesignup.Text = string.Empty;
            passwordsignup.Text = string.Empty;
            rewritepassword.Text = string.Empty;
        }
    }
}
