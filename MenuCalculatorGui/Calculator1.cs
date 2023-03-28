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
    public partial class Calculator1 : Form
    {
        public Calculator1()
        {
            InitializeComponent();
        }



        private void button10_Click(object sender, EventArgs e)
        {
            simbol.Text = "+";
            button0.Enabled = true;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            buttontitik.Enabled = true;
            buttonhapus.Enabled = true;
            buttonequals.Enabled = true;
            button11.Enabled = false;
            button12.Enabled = false;
            button13.Enabled = false;
            buttonnext.Enabled = true;
        }
        private void button11_Click(object sender, EventArgs e)
        {
            simbol.Text = "-";
            button0.Enabled = true;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            buttontitik.Enabled = true;
            buttonhapus.Enabled = true;
            buttonequals.Enabled = true;
            button10.Enabled = false;
            button12.Enabled = false;
            button13.Enabled = false;
            buttonnext.Enabled = true;

        }
        private void button12_Click(object sender, EventArgs e)
        {
            simbol.Text = "*";
            button0.Enabled = true;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            buttontitik.Enabled = true;
            buttonhapus.Enabled = true;
            buttonequals.Enabled = true;
            button10.Enabled = false;
            button11.Enabled = false;
            button13.Enabled = false;
            buttonnext.Enabled = true;

        }
        private void button13_Click(object sender, EventArgs e)
        {
            simbol.Text = "/";
            button0.Enabled = true;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            buttontitik.Enabled = true;
            buttonhapus.Enabled = true;
            buttonequals.Enabled = true;
            button10.Enabled = false;
            button11.Enabled = false;
            button12.Enabled = false;
            buttonnext.Enabled = true;

        }
        private void buttonclear_Click(object sender, EventArgs e)
        {
            angka1.Text = "";
            simbol.Text = "";
            angka2.Text = "";
            jadi.Text = "";
            button0.Enabled = false;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            buttontitik.Enabled = false;
            buttonhapus.Enabled = false;
            buttonequals.Enabled = false;
            button10.Enabled = true;
            button11.Enabled = true;
            button12.Enabled = true;
            button13.Enabled = true;
            buttonnext.Enabled = false;
        }

        private void buttonhapus_Click(object sender, EventArgs e)
        {
            if(jadi.Text.Length == 0)
            { 
            if (buttonnext.Enabled == true)
            {
                if (angka1.Text.Length > 0)
                {
                    angka1.Text = angka1.Text.Remove(angka1.Text.Length - 1);
                }
            }
            else if (buttonnext.Enabled == false)
            {
                if (angka2.Text.Length > 0)
                {
                    angka2.Text = angka2.Text.Remove(angka2.Text.Length - 1);
                }
            }
            }
            else
            {
                angka1.Text = "";
                simbol.Text = "";
                angka2.Text = "";
                jadi.Text = "";
                button0.Enabled = false;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                buttontitik.Enabled = false;
                buttonhapus.Enabled = false;
                buttonequals.Enabled = false;
                button10.Enabled = true;
                button11.Enabled = true;
                button12.Enabled = true;
                button13.Enabled = true;
                buttonnext.Enabled = false;
            }
        }

        private void buttonnext_Click(object sender, EventArgs e)
        {
            buttonnext.Enabled = false;
        }
        private void button0_Click(object sender, EventArgs e)
        {
            if (buttonnext.Enabled == true)
            {
                angka1.Text = angka1.Text + "0";
            }
            else if (buttonnext.Enabled == false)
            {
                angka2.Text = angka2.Text + "0";
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (buttonnext.Enabled == true)
            {
                angka1.Text = angka1.Text + button1.Text;
            }
            else if (buttonnext.Enabled == false)
            {
                angka2.Text = angka2.Text + button1.Text;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (buttonnext.Enabled == true)
            {
                angka1.Text = angka1.Text + button2.Text;
            }
            else if (buttonnext.Enabled == false)
            {
                angka2.Text = angka2.Text + button2.Text;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (buttonnext.Enabled == true)
            {
                angka1.Text = angka1.Text + button3.Text;
            }
            else if (buttonnext.Enabled == false)
            {
                angka2.Text = angka2.Text + button3.Text;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (buttonnext.Enabled == true)
            {
                angka1.Text = angka1.Text + button4.Text;
            }
            else if (buttonnext.Enabled == false)
            {
                angka2.Text = angka2.Text + button4.Text;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (buttonnext.Enabled == true)
            {
                angka1.Text = angka1.Text + button5.Text;
            }
            else if (buttonnext.Enabled == false)
            {
                angka2.Text = angka2.Text + button5.Text;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (buttonnext.Enabled == true)
            {
                angka1.Text = angka1.Text + button6.Text;
            }
            else if (buttonnext.Enabled == false)
            {
                angka2.Text = angka2.Text + button6.Text;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (buttonnext.Enabled == true)
            {
                angka1.Text = angka1.Text + button7.Text;
            }
            else if (buttonnext.Enabled == false)
            {
                angka2.Text = angka2.Text + button7.Text;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (buttonnext.Enabled == true)
            {
                angka1.Text = angka1.Text + button8.Text;
            }
            else if (buttonnext.Enabled == false)
            {
                angka2.Text = angka2.Text + button8.Text;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (buttonnext.Enabled == true)
            {
                angka1.Text = angka1.Text + button9.Text;
            }
            else if (buttonnext.Enabled == false)
            {
                angka2.Text = angka2.Text + button9.Text;
            }
        }

        private void buttontitik_Click(object sender, EventArgs e)
        {
            if (buttonnext.Enabled == true)
            {
                angka1.Text = angka1.Text + ".";
            }
            else if (buttonnext.Enabled == false)
            {
                angka2.Text = angka2.Text + ".";
            }
        }

        private void buttonequals_Click(object sender, EventArgs e)
        {
            jadi.Text = angka1.Text + simbol.Text + angka2.Text;
            string value = new DataTable().Compute(jadi.Text, null).ToString();
            jadi.Text = value;

        }
        private void jadi_TextChanged(object sender, EventArgs e)
        {

        }
        private void angka2_TextChanged(object sender, EventArgs e)
        {

        }



        private void simbol_TextChanged(object sender, EventArgs e)
        {

        }

        private void Calculator1_Load(object sender, EventArgs e)
        {

        }
    }
}
