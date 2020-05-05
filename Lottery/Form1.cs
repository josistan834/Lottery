using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lottery
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int num1, num2, num3, num4, num5, num6;
        Random rand = new Random();

        private void genButton_Click(object sender, EventArgs e)
        {
            num1 = rand.Next(1, 50);
            do
            {
                num2 = rand.Next(1, 50);
            }
            while (num2 == num1);
            do
            {
                num3 = rand.Next(1, 50);
            }
            while (num3 == num1 || num3 == num2);
            do
            {
                num4 = rand.Next(1, 50);
            }
            while (num4 == num1 || num4 == num2 || num4 == num3);
            do
            {
                num5 = rand.Next(1, 50);
            }
            while (num5 == num1 || num5 == num2 || num5 == num3 || num5 == num4);
            do
            {
                num6 = rand.Next(1, 50);
            }
            while (num6 == num1 || num6 == num2 || num6 == num3 || num6 == num4 || num6 == num5);
            outputLable.Text = $"{num1}, {num2}, {num3}, {num4}, {num5}, {num6}";
        }
    }
}
