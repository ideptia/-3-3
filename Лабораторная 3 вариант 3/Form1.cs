using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лабораторная_3_вариант_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = "aga";

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Получение исходных данных из TextBox 
                double x = Convert.ToDouble(textBox2.Text);
                double y = Convert.ToDouble(textBox1.Text);

                double z = Convert.ToDouble(textBox3.Text);
                // Ввод исходных данных в окно результатов 
                textBox4.Text = "Результаты работы программы " +
                "ст. Давыдюка А.С., вариант 3 " +
                Environment.NewLine;
                textBox4.Text += "При X = " + textBox2.Text +
                Environment.NewLine;
                textBox4.Text += "При Y = " + textBox1.Text +
                Environment.NewLine;
                textBox4.Text += "При Z = " + textBox3.Text +
                Environment.NewLine;
                // Вычисление выражения 
                double v = x * x;
                double c;
                if (radioButton1.Checked == true || radioButton2.Checked == true || radioButton3.Checked == true)
                {
                    if (radioButton1.Checked == true)
                        v = Math.Sinh(x);
                    else if (radioButton2.Checked == true)
                        v = x * x;
                    else if (radioButton3.Checked == true)
                        v = Math.Exp(x);

                }

                if (x - y == 0)
                {
                    c = Math.Pow(v, 2) + y * y + Math.Sin(y);
                }
                else
                    if (x - y > 0)
                {
                    c = Math.Pow(v - y, 2) + Math.Cos(y);
                }
                else
                    c = Math.Pow(y - v, 2) + Math.Tan(y);
                // Вывод результата 
                textBox4.Text += "C = " + c.ToString() +
                Environment.NewLine;
            }
            catch(Exception ex)
            {
                textBox4.Text = "Что-то пошло нет так";
            }
            
        }


        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.Text = "Sh(x)";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox4.Text = "";
            textBox3.Text = "";
            textBox2.Text = "";
            textBox1.Text = "";
        }
    }
}
