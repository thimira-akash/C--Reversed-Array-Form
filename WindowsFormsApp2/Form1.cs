using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //Array declaration
        double[] numbers = new double[5];
        double[] new_numbers = new double[5];
        int i = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
            {
                switch (i)
                {
                    case 0:
                        label2.Text = "Enter the Second Number";
                        break;
                    case 1:
                        label2.Text = "Enter the Third Number";
                        break;
                    case 2:
                        label2.Text = "Enter the Fourth Number";
                        break;
                    case 3:
                        label2.Text = "Enter the Fifth Number";
                        break;
                    default:
                        label2.Text = "Hit Enter to get the reverse order!";
                        break;

                }
                numbers[i] = double.Parse(textBox1.Text);
                i++;
                progressBar1.Value = progressBar1.Value + 20;
                label4.Text= progressBar1.Value + "%";
                textBox1.Text = "";
                if(i ==5)
                {
                    textBox1.Visible = false;
                }
            }
            else
            {
                int k = 0;
                label3.Text = "Answer is: ";

                for (int j=4; j >= 0; j--) {
                    new_numbers[k] = numbers[j];
                    label3.Text = label3.Text +  new_numbers[k] + " ,";
                    k++;
                }
            }
        }
    }
}
