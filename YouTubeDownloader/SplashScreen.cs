using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YouTubeDownloader
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }
        //Method to close splash screen once time has elapsed
        private void splashTimer_Tick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
