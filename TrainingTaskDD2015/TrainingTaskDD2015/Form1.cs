using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrainingTaskDD2015
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //button1.Left = this.Width / 2 - button1.Width / 2;
            //button1.Top = this.Height / 2 - button1.Height / 2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Task1 t1 = new Task1();
            t1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Task2 t2 = new Task2();
            t2.ShowDialog();
        }
    }
}
