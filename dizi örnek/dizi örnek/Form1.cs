using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dizi_örnek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] ad = new string[5];
        int[] not = new int[5];
        int i = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            ad[i] = textBox1.Text;
            not[i] = Convert.ToInt32(textBox2.Text);
            i++;
            textBox1.Clear();
            textBox2.Clear();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < ad.Length; i++)
            {
                listBox1.Items.Add(ad[i] + " -> " + not[i]);
            }
        }
    }
}