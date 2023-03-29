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
    public partial class PilihanMenu : UserControl
    {
        public PilihanMenu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }



        private void button1_Click(object sender, EventArgs e)
        {
            CalculatorMenu newform = new CalculatorMenu();
            newform.Show();
        }
        private void calculator6_Click(object sender, EventArgs e)
        {
            CalculatorGUI newform = new CalculatorGUI();
            newform.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CalculatorSymbol newform = new CalculatorSymbol();
            newform.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CalculatorFullString newform = new CalculatorFullString();
            newform.Show();
        }
    }
}
