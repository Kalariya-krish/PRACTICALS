using System;

namespace PRACTICALS.Lab_Tutorial_3
{
    internal class T3_Q3
    {
        class Student
        {
            private int id;
            private string name;
            private int age;
            private double marks;

            public int Id
            {
                get { return id; }
                set { id = value; }
            }

            public string Name
            {
                get { return name; }
                set { name = value; }
            }

            public int Age
            {
                get { return age; }
                set
                {
                    if (value > 0) age = value;
                    else age = 18;
                }
            }

            public double Marks
            {
                get { return marks; }
                set
                {
                    if (value >= 0 && value <= 100) marks = value;
                    else marks = 0;
                }
            }

            public Student()
            {
                id = 0;
                name = "Unknown";
                age = 18;
                marks = 0;
            }

            public Student(int id, string name, int age, double marks)
            {
                this.Id = id;
                this.Name = name;
                this.Age = age;
                this.Marks = marks;
            }

            public void DisplayStudent()
            {
                Console.WriteLine($"ID: {Id}, Name: {Name}, Age: {Age}, Marks: {Marks}");
            }

            public void CheckResult()
            {
                if (Marks >= 40)
                    Console.WriteLine($"{Name} has Passed");
                else
                    Console.WriteLine($"{Name} has Failed");
            }
        }

        class TestStudent
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Name : KALARIYA KRIS \nEnrollment No: 24SOECE13028\n");

                Student s1 = new Student();
                Console.WriteLine("Student 1 (default):");
                s1.DisplayStudent();
                s1.CheckResult();

                Console.WriteLine();

                Student s2 = new Student(101, "Kris", 20, 85.5);
                Console.WriteLine("Student 2:");
                s2.DisplayStudent();
                s2.CheckResult();

                Console.WriteLine();

                s2.Marks = 35;
                Console.WriteLine("Student 2 after marks update:");
                s2.DisplayStudent();
                s2.CheckResult();

                Console.Read();
            }
        }
    }
}
