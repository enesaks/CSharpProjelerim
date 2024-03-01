﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EkstraYapilar
{
    public partial class CaptchaOluşturma : Form
    {
        public CaptchaOluşturma()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] sembol1 = { "a", "b", "c" };
            string[] sembol2 = { "+",  "-", "*" };

            Random r = new Random();
            int s1, s2, s3;
            s1 = r.Next(0, sembol1.Length);
            s2 = r.Next(0, sembol2.Length);
            s3 = r.Next(0, 10);

            label1.Text = sembol1[s1].ToString() + sembol2[s2].ToString() + s3.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RandomKomutu randomKomutu = new RandomKomutu();
            randomKomutu.Show();
            this.Hide();
        }
    }
}
