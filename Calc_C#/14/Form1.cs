﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp2
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static class Globals
        {
            public static int num_operation = 0; 
        }

        private void button8_Click(object sender, EventArgs e) //сброс
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            label1.Text = "";
        }

        private void button7_Click(object sender, EventArgs e) //еще
        {
            textBox1.Text = textBox3.Text;
            textBox2.Text = "";
            textBox3.Text = "";
            label1.Text = "";
        }

        private void button6_Click(object sender, EventArgs e) //=
        {
            double a;
            double b;
            double c;

            switch (Globals.num_operation)
            {
                case 1: //+
                    a = double.Parse(textBox1.Text);
                    b = double.Parse(textBox2.Text);
                    c = a + b;
                    textBox3.Text = Convert.ToString(c);
                    break;
                case 2:  //-
                    a = double.Parse(textBox1.Text);
                    b = double.Parse(textBox2.Text);
                    c = a - b;
                    textBox3.Text = Convert.ToString(c);
                    break;
                case 3:  //*
                    a = double.Parse(textBox1.Text);
                    b = double.Parse(textBox2.Text);
                    c = a * b;
                    textBox3.Text = Convert.ToString(c);
                    break;
                case 4:  //del
                    a = double.Parse(textBox1.Text);
                    b = double.Parse(textBox2.Text);
                    c = a / b;
                    textBox3.Text = Convert.ToString(c);
                    break;
                case 5:  //^2
                    a = double.Parse(textBox1.Text);
                    c = a * a;
                    textBox3.Text = Convert.ToString(c);
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e) //+
        {
            label1.Text = "+";
            Globals.num_operation=1;
        }

        private void button2_Click(object sender, EventArgs e)  //-
        {
            label1.Text = "-";
            Globals.num_operation = 2;
        }

        private void button3_Click(object sender, EventArgs e) //*
        {
            label1.Text = "*";
            Globals.num_operation = 3;
        }

        private void button4_Click(object sender, EventArgs e) //деление
        {
            label1.Text = "/";
            Globals.num_operation = 4;
        }

        private void button5_Click(object sender, EventArgs e) // возведение в квадрат
        {
            label1.Text = "^2";
            textBox2.Text = "";
            Globals.num_operation = 5;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
