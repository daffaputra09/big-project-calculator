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
    public partial class CalculatorGUI : Form
    {
        public CalculatorGUI()
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

        private void button5_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + button5.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + button4.Text;
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

        private void button0_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "0";
        }

        private void buttontitik_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + ".";
        }

        private void buttonplus_Click(object sender, EventArgs e)
        {
            if (display.Text.EndsWith("+") || display.Text.EndsWith("-") || display.Text.EndsWith("*") || display.Text.EndsWith("/"))
            {
                display.Text = display.Text.Remove(display.Text.Length - 1);
                display.Text = display.Text + "+";
            }
            else display.Text = display.Text + "+";
        }

        private void buttonmin_Click(object sender, EventArgs e)
        {
            if (display.Text.EndsWith("+") || display.Text.EndsWith("-") || display.Text.EndsWith("*") || display.Text.EndsWith("/"))
            {
                display.Text = display.Text.Remove(display.Text.Length - 1);
                display.Text = display.Text + "-";
            }
            else display.Text = display.Text + "-";
        }

        private void buttonkali_Click(object sender, EventArgs e)
        {
            if (display.Text.EndsWith("+") || display.Text.EndsWith("-") || display.Text.EndsWith("*") || display.Text.EndsWith("/"))
            {
                display.Text = display.Text.Remove(display.Text.Length - 1);
                display.Text = display.Text + "*";
            }
            else display.Text = display.Text + "*";
        }

        private void buttonbagi_Click(object sender, EventArgs e)
        {
            if (display.Text.EndsWith("+") || display.Text.EndsWith("-") || display.Text.EndsWith("*") || display.Text.EndsWith("/"))
            {
                display.Text = display.Text.Remove(display.Text.Length - 1);
                display.Text = display.Text + "/";
            }
            else display.Text = display.Text + "/";
        }

        private void buttonequals_Click(object sender, EventArgs e)
        {
            if (display.Text.EndsWith("+") || display.Text.EndsWith("-"))
            {
                display.Text = display.Text + "0";
            }
            else if (display.Text.EndsWith("*") || display.Text.EndsWith("/"))
            {
                display.Text = display.Text + "1";
            }
            string value = new DataTable().Compute(display.Text, null).ToString();
            display.Text = value;

            display.Text = display.Text.Replace(",0", "");
        }

        private void buttonclear_Click(object sender, EventArgs e)
        {
            display.Text = "";
        }

        private void buttonhapus_Click(object sender, EventArgs e)
        {
            if (display.Text.Length > 0)
            {
                display.Text = display.Text.Remove(display.Text.Length - 1);
            }
        }

        private void display_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
