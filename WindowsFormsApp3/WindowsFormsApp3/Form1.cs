﻿using System;
using System.Windows.Forms;
using static System.Math;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_raschot_Click(object sender, EventArgs e)
        { 
            double result;
            double a,b,c;
            /*a = Pow(((2.7 - 0.8) * Pow(7.0 / 3d, 0.5)) / ((5.2 - 1.4) / (3.0/7d)), 0.2);
            b =  (Pow((((97.0/11d)- (((95 + (7.0 / (Pow(((30 - (1679.0 / 18d)) * (-1)), 0.2) * (-1)))) * 2.25) / (Pow(2, 1.2))))*(-1)), 0.333)*(-1));
            c = Pow(PI, 0.167);
            result=a+b+c;*/
            result = Pow(((2.7 - 0.8) * Pow(7.0 / 3d, 0.5)) / ((5.2 - 1.4) / (3.0/7d)), 0.2) + (Pow((((97.0/11d)- (((95 + (7.0 / (Pow(((30 - (1679.0 / 18d)) * (-1)), 0.2) * (-1)))) * 2.25) / (Pow(2, 1.2))))*(-1)), 0.333)*(-1)) + Pow(PI, 0.167);//
            txt_result.Text = (Convert.ToString (result));
        }

        private void txt_result_TextChanged(object sender, EventArgs e)
        {
          
        }
    }
}
