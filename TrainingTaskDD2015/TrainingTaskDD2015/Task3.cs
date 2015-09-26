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
    interface DrawRectangle
    {
        void Draw();
        string getInfoAboutThisFigure();
    }


    public partial class Task3 : Form
    {
        List<DrawRectangle> DR;
        int leftBorder,downBorder;
        int topBorder;//not sure, but maybe it change position
        public Task3()
        {
            InitializeComponent();

            DR = new List<DrawRectangle>();
            leftBorder = ClientSize.Width;
            downBorder = ClientSize.Height;
            topBorder = menuStrip1.Height;


            //для вывода информации
            MessageBox.Show("ТУТ МОГЛА БЫТЬ ВАША РеКЛАМА!!!");
        }

        private void Draw()
        {
            try
            {
                foreach (var item in DR)
                {
                    item.Draw();
                }
            }
            catch(Exception e)
            {
                throw new Exception("I dont know how you come in\r\n" + e.ToString());
                //Nothing happening here
                //Just say about defence from idiots
            }
        }

        private void Task3_Click(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void Task3_Paint(object sender, PaintEventArgs e)
        {
            Draw();
        }

        private void someShitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string str="";
            for (int i = 0; i < DR.Count; i++)
            {
                str+=String.Format("count = {0}  info about figure is {1}",i+1,DR[i].getInfoAboutThisFigure());
            }
            if(str!="")MessageBox.Show(str);
        }

        private void createRectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Task3_2_ForRect T=new Task3_2_ForRect();
            if (T.ShowDialog()==DialogResult.OK)
            {
                //use T.Value or add in task3_2_forrect more variable and use it to create rect in pos
                if (T.Value!=null)
                {
                    
                }
                else { }
            }
            
        }
    }

    enum Squire 
    { 
        UpLeft,UpRight,DownLeft,DownRight
    }
}










#region CodeOnStart
//namespace TrainingTaskDD2015
//{
//    interface DrawRectangle
//    {
//        void Draw();
//        string getInfoAboutThisFigure();
//    }


//    public partial class Task3 : Form
//    {
//        List<DrawRectangle> DR;
//        int leftBorder, downBorder;
//        int topBorder;//not sure, but maybe it change position
//        public Task3()
//        {
//            InitializeComponent();

//            DR = new List<DrawRectangle>();
//            leftBorder = ClientSize.Width;
//            downBorder = ClientSize.Height;
//            topBorder = menuStrip1.Height;


//            //для вывода информации
//            MessageBox.Show("ТУТ МОГЛА БЫТЬ ВАША РеКЛАМА!!!");
//        }

//        private void Draw()
//        {
//            try
//            {
//                foreach (var item in DR)
//                {
//                    item.Draw();
//                }
//            }
//            catch (Exception e)
//            {
//                throw new Exception("I dont know how you come in\r\n" + e.ToString());
//                //Nothing happening here
//                //Just say about defence from idiots
//            }
//        }

//        private void Task3_Click(object sender, EventArgs e)
//        {
//            Invalidate();
//        }

//        private void Task3_Paint(object sender, PaintEventArgs e)
//        {
//            Draw();
//        }

//        private void someShitToolStripMenuItem_Click(object sender, EventArgs e)
//        {
//            string str = "";
//            for (int i = 0; i < DR.Count; i++)
//            {
//                str += String.Format("count = {0}  info about figure is {1}", i + 1, DR[i].getInfoAboutThisFigure());
//            }
//            if (str != "") MessageBox.Show(str);
//        }

//        private void createRectToolStripMenuItem_Click(object sender, EventArgs e)
//        {
//            Task3_2_ForRect T = new Task3_2_ForRect();
//            if (T.ShowDialog() == DialogResult.OK)
//            {
//                //use T.Value or add in task3_2_forrect more variable and use it to create rect in pos
//                if (T.Value != null)
//                {

//                }
//                else { }
//            }

//        }
//    }

//    enum Squire
//    {
//        UpLeft, UpRight, DownLeft, DownRight
//    }
//}
#endregion