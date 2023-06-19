using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class Register : UserControl
    {
        Main MAIN = null;
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

        }
    }
}
