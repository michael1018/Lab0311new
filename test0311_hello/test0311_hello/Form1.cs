﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test0311_hello
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = "Hello";
            //master
            //button2 branch 
            //both keep
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Text = DateTime.Now.ToString();
            //update comment button2
            //edit on Master branch....
        }
    }
}
