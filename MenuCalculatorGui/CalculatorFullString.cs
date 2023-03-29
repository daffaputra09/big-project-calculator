using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuCalculatorGui
{
    public partial class CalculatorFullString : Form
    {
        public CalculatorFullString()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + button1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + button3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + button4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + button5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + button6.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + button7.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + button8.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + button9.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + button10.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + button11.Text;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + button12.Text;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + button13.Text;
        }

        private void buttonclear_Click(object sender, EventArgs e)
        {
            display.Text = "";
        }
    }
}
