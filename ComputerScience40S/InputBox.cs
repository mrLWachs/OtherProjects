﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerScience40S
{
    public partial class InputBox : Form
    {
        public InputBox(string text)
        {
            InitializeComponent();
            label1.Text = text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Storage.data = textBox1.Text;
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
