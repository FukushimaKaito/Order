using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 注文
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int total = 0;//合計金額を表示するための変数
            if (checkBox1.Checked)
                total += 100;
            if (checkBox2.Checked)
                total += 120;
            if (checkBox3.Checked)
                total += 150;
            if (checkBox4.Checked)
                total += 200;
            label1.Text = total.ToString();//合計金額を表示
        }
    }
}
