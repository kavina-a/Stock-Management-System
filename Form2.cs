﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STgui
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void addnewstckbtn_Click(object sender, EventArgs e)
        {
                Form3 f3 = new Form3();
                f3.Show();
                this.Hide();
            }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.Show();
            this.Hide();
        }

        private void transactionlogbtn_Click_Click(object sender, EventArgs e)
        {
             Form4 f4 = new Form4();
             f4.Show();
            this.Hide();
        }

     
    }
    }
