using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JWMSMediaPlayer
{
    public partial class HomeScreenForm : Form
    {
        public HomeScreenForm()
        {
            InitializeComponent();
        }

        private void videoPlayerButton_Click(object sender, EventArgs e)
        {
            base.Hide();
            VideoPlayerForm vpf = new VideoPlayerForm();
            vpf.Show();
        }

        private void musicPlayerButton_Click(object sender, EventArgs e)
        {
            base.Hide();
            MusicPlayerForm mpf = new MusicPlayerForm();
            mpf.Show();
        }
    }
}
