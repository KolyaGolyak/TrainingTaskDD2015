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
    public partial class Task2 : Form
    {
        public Task2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowData(new Truck(2), textBox1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ShowData(new Trolleybus("grey"), textBox2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ShowData(new Car(true), textBox3); 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }
        
        public void ShowData (Transport t, TextBox text)
        {

            text.Text = t.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

    }
    public class Transport
    {
        public double getSpeed {get { return speed;} }
        public double get_number_of_seats { get {return numb;} }

        private double speed;
        private double numb;

        public Transport (double speeds, double numbers)
        {
            speed = speeds;
            numb = numbers;
        }
        public override string ToString()
        {
            return ("Speed = " + speed + Environment.NewLine + "Num_Of_Seats = " + numb + "\r\n");
        }
    }

    public class Trolleybus : Transport
    {
        public string getColor { get { return color;}}

        private string color;

        public Trolleybus(string Blue):base(50,20)
        {
            color = Blue;
        }
        
        public override string ToString()
        {
            return ("Name - Trolleybas" + Environment.NewLine + base.ToString() + "Color = " + color);
        }
    }

    public class Car : Transport
    {
        public bool get_car_roof { get { return roof; } }

        private bool roof;

        public Car(bool ro):base(120, 4)
        {
            roof = ro;
        }

        public override string ToString()
        {
            return ("Name - Car" + Environment.NewLine + base.ToString() + "Car roof = " + roof);
        }
    }

    public class Truck : Transport
    {
        public int get_trailer { get { return trailer; }  }
        private int trailer;

        public Truck(int trail):base(75,3)
        {
            trailer = trail;
        }

        public override string ToString()
        {
            return ("Name - Truck" + Environment.NewLine + base.ToString() + "Trailer = " + trailer);
        }
    }

}
