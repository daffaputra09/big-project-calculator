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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void pilihanMenu2_Load(object sender, EventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void About_Click(object sender, EventArgs e)
        {

        }

        private void Menu_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void CobaCalculatorMenu_Click(object sender, EventArgs e)
        {
            CalculatorMenu newform = new CalculatorMenu();
            newform.Show();
        }

        private void CobaCalculatorSymbol_Click(object sender, EventArgs e)
        {
            CalculatorSymbol newform = new CalculatorSymbol();
            newform.Show();
        }

        private void CobaCalculatorFullString_Click(object sender, EventArgs e)
        {
            CalculatorFullString newform = new CalculatorFullString();
            newform.Show();
        }

        private void CobaCalculatorGui_Click(object sender, EventArgs e)
        {
            CalculatorGUI newform = new CalculatorGUI();
            newform.Show();
        }
    }
}
