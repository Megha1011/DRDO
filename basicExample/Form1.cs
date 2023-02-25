using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace basicExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lblHelloWorld.Text = "hello world";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("linux bye bye");
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("hello world");

        }
    }
}
