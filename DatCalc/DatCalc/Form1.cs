﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace DatCalc
{
    public partial class Form1 : Form
    {
        string something;
        string n1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ".";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string number1 = textBox1.Text;
            n1 = number1;
            something = "divide";
            textBox1.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string number1 = textBox1.Text;
            n1 = number1;
            something = "multiply";
            textBox1.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string number1 = textBox1.Text;
            n1 = number1;
            something = "subtract";
            textBox1.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string number1 = textBox1.Text;
            n1 = number1;
            something = "add";
            textBox1.Clear();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            double result1;
            double result2;
            double result3;
            double result4;
            string final1;
            string final2;
            string final3;
            string final4;
            string n2 = textBox1.Text;
            if (something == "add")
            {
                result1 = (double)int.Parse(n1) + int.Parse(n2);
                final1 = result1.ToString();
                textBox1.Text = final1;
            }
                
            if (something == "subtract")
            {
                result2 = (double)int.Parse(n1) - int.Parse(n2);
                final2 = result2.ToString();
                textBox1.Text = final2;
            }
            if (something == "divide")
            {
                result3 = (double)int.Parse(n1) / int.Parse(n2);
                final3 = result3.ToString();
                textBox1.Text = final3;
            }
            if (something == "multiply")
            {
                result4 = (double)int.Parse(n1) * int.Parse(n2);
                final4 = result4.ToString();
                textBox1.Text = final4;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void gitHubToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/Dat-Dot/DatCalc");
        }

        private void issuesbugsPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/Dat-Dot/DatCalc/issues");
        }

        private void aboutWindowsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("C:\\Windows\\system32\\winver.exe");
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}
