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
    public partial class Mines : Form
    {
        public Form1 mydaddy = null;
         
        public static int currentmines;
        public static int coal = 0;
        public static int update;
        public Mines()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (Form1.Money > 1000 && currentmines == 0)
            {
                Form1.Money -= 1000;
                pictureBox1.Visible = true;
                timer1.Enabled = true;
                ++update;
                button1.Text = "Coal Miners (2000$)";

                currentmines++;
            }
            if (Form1.Money > 2000 && currentmines == 1)
            {
                Form1.Money -= 2000;
                pictureBox2.Visible = true;
                ++update;
                button1.Text = "Coal Miners (4000$)";
                currentmines++;
            }
            if (Form1.Money > 4000 && currentmines == 2)
            {
                Form1.Money -= 4000;
                pictureBox3.Visible = true;
                button1.Visible = false;
                currentmines++;
                ++update;
                


            }
        }
        private void timer1_interval(object sender, EventArgs e)
        {
            if (currentmines == 1)
            {
                coal++;
                label3.Text = coal.ToString();
            }
            if (currentmines == 2)
            {
                coal++;
                coal++;
                label3.Text = coal.ToString();
            }
            if (currentmines == 3)
            {
                coal++;
                coal++;
                coal++;
                label3.Text = coal.ToString();
            }
            


        }
        private void button2_Click(object sender, EventArgs e)
        {
            
                Form1.Money = Form1.Money + coal * 1000;
                coal = coal - coal;
                label3.Text = coal.ToString();



        }



        private void Mines_Load(object sender, EventArgs e)
        {
            label3.Text = coal.ToString();
            if (Form1.currentM == 1)
            {
               
                pictureBox1.Visible = true;
                timer1.Enabled = true;
                
                button1.Text = "Coal Miners (2000$)";
            }
            if (Form1.currentM == 2)
            {
              
                pictureBox2.Visible = true;
               
                button1.Text = "Coal Miners (4000$)";
              
            }
            if (Form1.currentM == 3)
            {
                pictureBox3.Visible = true;
                button1.Visible = false;
                
            }


        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
