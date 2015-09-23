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
            string tmp;
            Truck truct = new Truck(Speed: 75, number_of_seats: 4, trailer: 2);
            tmp = truct.Show();
            tmp += "\r\n" + truct.Data();
            textBox1.Text = tmp;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string tmp;
            Car car = new Car(Speed: 180, number_of_seats: 5, car_roof: true);
            tmp = car.Show();
            tmp += "\r\n" + car.Data();
            textBox2.Text = tmp;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string tmp;
            Trolleybus troll = new Trolleybus(Speed: 60, number_of_seats: 30, Color: "Blue");
            tmp = troll.Show();
            tmp += "\r\n" + troll.Data();
            textBox3.Text = tmp;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }
    }
    public class Transport
    {
        public double Speed;
        public int number_of_seats;

        public string Data()
        {
            string tmp = "Speed = " + Speed + "\r\n" + "Num_Of_Seats = " + number_of_seats;
            return tmp;
        }
    }

    public class Trolleybus : Transport
    {
        public string Color;

        public Trolleybus(double Speed, int number_of_seats, string Color)
        {
            this.Speed = Speed;
            this.number_of_seats = number_of_seats;
            this.Color = Color;
        }

        public string Show()
        {
            string tmp = "Name - Trolleybas" + "\r\n" + "Color = " + Color;
            return tmp;
        }
    }

    public class Car : Transport
    {
        public bool car_roof;

        public Car(double Speed, int number_of_seats, bool car_roof)
        {
            this.Speed = Speed;
            this.number_of_seats = number_of_seats;
            this.car_roof = car_roof;
        }

        public string Show()
        {
            string tmp = "Name - Car" + "\r\n" + "Car roof = " + car_roof;
            return tmp;
        }
    }

    public class Truck : Transport
    {
        public int trailer;

        public Truck(double Speed, int number_of_seats, int trailer)
        {
            this.Speed = Speed;
            this.number_of_seats = number_of_seats;
            this.trailer = trailer;
        }

        public string Show()
        {
            string tmp = "Name - Truck" + "\r\n" + "Trailer = " + trailer;
            return tmp;
        }
    }

}
