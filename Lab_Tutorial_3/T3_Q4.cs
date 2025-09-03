using System;

namespace PRACTICALS.Lab_Tutorial_3
{
    internal class T3_Q4
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

                Student s1 = new Student(101, "Kris", 20, 85.5);
                Student s2 = new Student(102, "Aarav", 19, 72.0);
                Student s3 = new Student(103, "Neha", 21, 39.5);
                Student s4 = new Student(104, "Priya", 20, 55.0);
                Student s5 = new Student(105, "Rohan", 22, 25.0);

                Student[] students = { s1, s2, s3, s4, s5 };

                Console.WriteLine("===== Student Records =====\n");

                int count = 1;
                foreach (Student s in students)
                {
                    Console.WriteLine($"Student {count}:");
                    s.DisplayStudent();
                    s.CheckResult();
                    Console.WriteLine();
                    count++;
                }

                Console.Read();
            }
        }
    }
}
