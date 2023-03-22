using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using Gubskiy_CoctailSort;
using Gubskiy_GnomeSort;
using Gubskiy_InsertionSort;
using Gubskiy_QuickSort;
namespace Gubskiy_Ivan_4PCS18
{
    public partial class Form1 : Form
    {
        int n = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            int[] x = new int[n];
            if (x.Length > textBox3.TextLength)
            {
                int a = x.Length - textBox3.TextLength;
                while (a > 0)
                {
                    a--;
                    textBox3.Text = textBox3.Text + 0;
                }
            }
            else
            if (x.Length < textBox3.TextLength)
            {
                int a = textBox3.TextLength - x.Length;

                textBox3.Text = textBox3.Text.Remove(textBox3.Text.Length - a);
                a = 0;

            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            textBox3.Text = "";
            try
            {
                n = Convert.ToInt32(textBox1.Text);
            }
            catch
            {
                textBox1.Text = "";
                MessageBox.Show(
        "Неверный тип данных",
        "Ошибка",
        MessageBoxButtons.OK,
        MessageBoxIcon.Information,
        MessageBoxDefaultButton.Button1);

            }

            int[] x = new int[n];
            for (int i = 0; i < x.Length; i++)
            {
                textBox3.Text = textBox3.Text + x[i];
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var sw = new Stopwatch();
            sw.Start();
            string myArr = textBox3.Text;
            int[] result = myArr.ToString().Select(o => Convert.ToInt32(o) - 48).ToArray();
            string texter = string.Join("", QuickSort.SortArray(result));
            textBox5.Text = texter;
            sw.Stop();
            textBox6.Text = sw.Elapsed.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var sw = new Stopwatch();
            sw.Start();
            string myArr = textBox3.Text;
            int[] result = myArr.ToString().Select(o => Convert.ToInt32(o) - 48).ToArray();
            int resl = result.Length;
            string texter = string.Join("", InsertionSort.SortArray(result));
            sw.Stop();
            textBox2.Text = sw.Elapsed.ToString();
            textBox5.Text = texter;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var sw = new Stopwatch();
            sw.Start();
            string myArr = textBox3.Text;
            int[] result = myArr.ToString().Select(o => Convert.ToInt32(o) - 48).ToArray();
            string texter = string.Join("", CoctailSort.SortArray(result));
            textBox5.Text = texter;
            sw.Stop();
            textBox7.Text = sw.Elapsed.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var sw = new Stopwatch();
            sw.Start();
            string myArr = textBox3.Text;
            int[] result = myArr.ToString().Select(o => Convert.ToInt32(o) - 48).ToArray();
            int resl = result.Length;
            string texter = string.Join("", GnomeSort.SortArray(result));
            sw.Stop();
            textBox4.Text = sw.Elapsed.ToString();
            textBox5.Text = texter;
        }

      
    }
}
