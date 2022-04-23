using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class Achievments : Form
    {
        public Form1 mydaddy = null;

        public Achievments()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void Achievments_Load(object sender, EventArgs e)
        {

        }


     

        private void Achievments_Shown(object sender, EventArgs e)
        {
            if (Form1.BasicAC == 2)
            {
                checkBox1.Checked = true;
            }
            if (Form1.wtran == 1)
            {
                checkBox2.Checked = true;
            }
            if (Form1.ttp == 1)
            {
                checkBox3.Checked = true;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
