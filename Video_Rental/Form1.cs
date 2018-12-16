using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Video_Rental
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //global variable to pass the value to the progressbar
        int y = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            //onload event to start timer so timer start automatically 
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // increment the value of the global variable so thus progressbar is filled by step by step
            if (y < 100)
            {
                y = y + 10;
                progressBar1.Value = y;
                //progressbar  getting the value from global variable 
            }
            else {
                //when the variable reach at the position of 100 then timer will stop and nxt form  will display automatically
                timer1.Stop();
                this.Hide();
                new FrmLogin().ShowDialog();
            }
        }
    }
}
