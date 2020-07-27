using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Security.Policy;

namespace GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Enter the name of the .exe file here.
            Process.Start("Game.exe");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            //Copy and paste the link to your website, or you can keep it empty if you don't have one.
            Process.Start("http://jahinhossain.000webhostapp.com/");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Insert the link to a report section of your website.
            Process.Start("");
        }
    }
}
