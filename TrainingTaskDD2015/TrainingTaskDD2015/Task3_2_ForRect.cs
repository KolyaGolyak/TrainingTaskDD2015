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
    public partial class Task3_2_ForRect : Form
    {
        public int Value;
        public Task3_2_ForRect()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Value = Convert.ToInt32(textBox1.Text);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
