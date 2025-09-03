using System;

namespace PRACTICALS.Lab_Tutorial_3
{
    internal class T3_Q1
    {
        class Car
        {
            private string brand;
            private string color;
            private int speed;

            public Car(string brand, string color, int speed)
            {
                this.brand = brand;
                this.color = color;
                this.speed = speed;
            }

            public void displayDetail()
            {
                Console.WriteLine("Car Brand : " + brand);
                Console.WriteLine("Car Color : " + color);
                Console.WriteLine("Car Speed : " + speed + " km/h");
                Console.WriteLine("----------------------------------");
            }
            public void accelerate(int increase)
            {
                speed += increase;
                Console.WriteLine($"{brand} accelerated! New Speed: {speed} km/h");
            }

            public void brake(int decrease)
            {
                speed -= decrease;
                if (speed < 0) speed = 0;
                Console.WriteLine($"{brand} applied brake! New Speed: {speed} km/h");
            }
        }

        class Demo
        {
            public static void Main(String[] args)
            {
                Console.WriteLine("Name : KALARIYA KRIS \nEnrollment No: 24SOECE13028\n");

                Car car1 = new Car("Tesla", "Red", 100);
                Car car2 = new Car("Toyota", "Blue", 80);

                // Calling methods using objects
                car1.displayDetail();
                car1.accelerate(20);
                car1.brake(50);

                car2.displayDetail();
                car2.accelerate(30);
                car2.brake(20);

                Console.Read();
            }
        }
    }
}
