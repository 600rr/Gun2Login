using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void topla_Click(object sender, EventArgs e)
        {
            double n1 = Convert.ToDouble(sayi1.Text);
            double n2 = Convert.ToDouble(sayi2.Text);
            double toplam = n1+n2;
            MessageBox.Show(Convert.ToString(toplam));
            
        }
        private void sayi1_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(sayi1.Text, "[^0-9]"))
            {
                MessageBox.Show("Sadece sayı giriniz!");
                sayi1.Text = sayi1.Text.Remove(sayi1.Text.Length - 1);
            }
        }

        private void sayi2_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(sayi2.Text, "[^0-9]"))
            {
                MessageBox.Show("Sadece sayı giriniz!");
                sayi2.Text = sayi2.Text.Remove(sayi2.Text.Length - 1);
            }
        }

        private void decide1_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(decide1.Text, "[^0-9]"))
            {
                MessageBox.Show("Sadece sayı giriniz!");
                decide1.Text = decide1.Text.Remove(decide1.Text.Length - 1);
            }
        }

        private void decide2_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(decide2.Text, "[^0-9]"))
            {
                MessageBox.Show("Sadece sayı giriniz!");
                decide2.Text = decide2.Text.Remove(decide2.Text.Length - 1);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int d1 = Convert.ToInt32(decide1.Text);
            int d2 = Convert.ToInt32(decide2.Text);

            //<,>,==,<=,>=,!=

            if(d1>d2)
            {
                MessageBox.Show("D1 büyüktür D2'den");
            }
            if (d2 > d1)
            {
                decide.BackColor = Color.Red;
            }
            if (d2 == d1)
            {
                decide.Left = decide.Left + 50;
            }
        }
    }
}
