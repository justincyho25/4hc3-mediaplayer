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
    public partial class RemoveForm : Form
    {
        public RemoveForm()
        {
            InitializeComponent();
        }

        public string optionValue;


        private void button1_Click(object sender, EventArgs e)
        {
            if (rmML.Checked==true && rmMLC.Checked==true)
            {
                optionValue = "MLC";
            }
            else if (rmMLC.Checked==true)
            {
                optionValue = "MLC";
            }
            else if (rmML.Checked==true)
            {
                optionValue = "ML";
            }
            this.Hide();
        }
    }
}
