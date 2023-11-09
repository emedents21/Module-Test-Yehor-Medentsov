using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Module_Test_Yehor_Medentsov
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var n = Convert.ToInt32(textBox1.Text);
            var a = new Volier[n * 3];
            for (int i = 0; i < a.Length; i += 3) 
            {
                a[i] = new ZhvacniTV();
                a[i + 1] = new PlavajuchiTV();
                a[i + 2] = new Ekzoticni(); 
            }
            var summa = 0.0;
            var sum1 = 0.0;
            var sum2 = 0.0;
            var sum3 = 0.0;
            listBox1.Items.Clear();
            for (int i = 0; i < a.Length; i++)
            {
                listBox1.Items.Add(a[i].Show());
                summa += a[i].Plosha();
                if (a[i].name == "Вольер для жвачних тварин")
                {
                    sum1 += a[i].Plosha();
                }
                else if (a[i].name == "Вольер для плаваючих тварин")
                {
                    sum2 += a[i].Plosha();
                }
                else
                {
                    sum3 += a[i].Plosha();
                }
            }

            label5.Text = summa.ToString();
            label1.Text = sum1.ToString();
            label6.Text = sum2.ToString();
            label7.Text = sum3.ToString();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
