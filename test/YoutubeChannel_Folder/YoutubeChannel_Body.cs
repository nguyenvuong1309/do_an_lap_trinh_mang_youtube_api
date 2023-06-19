using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test.YoutubeChannel_Folder
{
    public partial class YoutubeChannel_Body : UserControl
    {
        public Main MAIN = null;
        public YoutubeChannel_Body()
        {
            InitializeComponent();
        }
        public YoutubeChannel_Body(Main main)
       {
            InitializeComponent();
            this.MAIN = main;
        }
    }
}
