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
    public partial class Register : UserControl
    {
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
            if (rewritepassword.Text == passwordsignup.Text)
            {
                string Username = usernamesignup.Text;
                string Password = passwordsignup.Text;
                string Fullname = fullnamesignup.Text;
                string Confirmpassword = rewritepassword.Text;
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
                var response = await client.PostAsync("https://4aa6-171-245-165-167.ngrok-free.app/register", httpContent);


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
