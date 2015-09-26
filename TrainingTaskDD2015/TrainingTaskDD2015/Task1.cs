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
    public partial class Task1 : Form
    {
        public Task1()
        {
            InitializeComponent();
            Draw();
        }

        void Draw()
        {
            Pen p = new Pen(Color.Black);
            Graphics G = this.CreateGraphics();
            G.DrawLine(p, new Point(this.Width / 4, this.Height / 3 * 2 - 25), new Point(this.Width / 4 * 3, this.Height / 3 * 2-25));
            G.DrawEllipse(p, new Rectangle(this.Width / 4 - 2, this.Height / 3 - 15, 4, 4));
            G.DrawEllipse(p, new Rectangle(this.Width / 4 * 3 - 2, this.Height / 3 - 15, 4, 4));
            p.Dispose();
            G.Dispose();
        }

        private void Task1_Paint(object sender, PaintEventArgs e)
        {
            Draw();
        }
    }
}
