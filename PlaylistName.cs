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
    public partial class PlaylistName : Form
    {
        

        public PlaylistName()
        {
            InitializeComponent();
        }

        public string PlayListNameFormValue;


        private void button1_Click(object sender, EventArgs e)
        {
            PlayListNameFormValue = PlayList.Text;
            this.Hide();
            
        }
 
    }
}
