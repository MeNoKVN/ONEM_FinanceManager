using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ONEM_FinanceManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int leftTabIndex = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            userControl11.Hide();
            userControl21.Hide();
            userControl31.Hide();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            leftTabIndex = 1;
            userControl21.Hide();
            userControl31.Hide();

            userControl11.Show();
            userControl11.BringToFront();


        }
        private void button2_Click(object sender, EventArgs e)
        {
            leftTabIndex = 2;
            userControl11.Hide();
            userControl31.Hide();

            userControl21.Show();
            userControl21.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            leftTabIndex = 0;
            userControl11.Hide();
            userControl21.Hide();


            userControl31.Show();
            userControl31.BringToFront();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        
    }
}
