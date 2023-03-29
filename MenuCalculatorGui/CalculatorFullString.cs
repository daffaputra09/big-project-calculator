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

        private void display_TextChanged(object sender, EventArgs e)
        {   

        }
        private void buttonequals_Click(object sender, EventArgs e)
        {
            string hasil = new Programx().Mainx(display.Text);
            display.Text = hasil;
        }

    }
    class Programx
    {
       public string Mainx(string input)
        {

            int awal = input.IndexOf(' ');
            int akhir = input.LastIndexOf(' ');
            awal += 1;

            int length = akhir - awal;

            string pertama = input.Substring(0, (awal - 1));
            string KataOperator = input.Substring(awal, length);
            string kedua = input.Substring(akhir + 1);
            string operasi = KataOperator;
            switch (operasi)
            {
                case "ditambah":
                    int hasil = JadiInt(pertama) + JadiInt(kedua);
                    return JadiString(hasil);
                case "dikurangi":
                    hasil = JadiInt(pertama) - JadiInt(kedua);
                    return JadiString(hasil);
                case "dikali":
                    hasil = JadiInt(pertama) * JadiInt(kedua);
                    return JadiString(hasil);
                case "dibagi":
                    hasil = JadiInt(pertama) / JadiInt(kedua);
                    return JadiString(hasil);
                default: return null;
            }
        }
        static int JadiInt(string kalimat)
        {
            switch (kalimat)
            {
                case "nol":
                    return 0;
                case "satu":
                    return 1;
                case "dua":
                    return 2;
                case "tiga":
                    return 3;
                case "empat":
                    return 4;
                case "lima":
                    return 5;
                case "enam":
                    return 6;
                case "tujuh":
                    return 7;
                case "delapan":
                    return 8;
                case "sembilan":
                    return 9;
                default:
                    throw new ArgumentException("Hanya dapat menggunakan angka 0 sampai 9");
            }
        }
        static string JadiString(int hasil)
        {
            switch (hasil)
            {
                case 1:
                    return ("satu");

                case 2:
                    return ("dua");

                case 3:
                    return ("tiga");

                case 4:
                    return ("empat");

                case 5:
                    return ("lima");

                case 6:
                    return ("enam");

                case 7:
                    return ("tujuh");

                case 8:
                    return ("delapan");

                case 9:
                    return ("sembilan");

                default:
                    return ("perhitungan lebih dari sembilan");

            }
        }
    }
}
