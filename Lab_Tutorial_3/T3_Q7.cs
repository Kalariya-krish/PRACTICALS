using System;

namespace PRACTICALS.Lab_Tutorial_3
{
    internal class T3_Q7
    {
        class Student
        {
            private string enrolmentNo;
            private string name;

            public string EnrolmentNo
            {
                get { return enrolmentNo; }
                set { enrolmentNo = value; }
            }

            public string Name
            {
                get { return name; }
                set { name = value; }
            }

            public Student()
            {
                enrolmentNo = "N/A";
                name = "Unknown";
            }

            public Student(string enrolmentNo, string name)
            {
                this.EnrolmentNo = enrolmentNo;
                this.Name = name;
            }

            public void DisplayStudent()
            {
                Console.WriteLine($"Enrolment No: {EnrolmentNo}, Name: {Name}");
            }
        }

        class TestStudent
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Name : KALARIYA KRIS \nEnrollment No: 24SOECE13028\n");

                Student s1 = new Student();
                Console.WriteLine("Student 1:");
                s1.DisplayStudent();

                Console.WriteLine();

                Student s2 = new Student("24SOECE13028", "Kris");
                Console.WriteLine("Student 2:");
                s2.DisplayStudent();

                Console.WriteLine();

                s2.EnrolmentNo = "24SOECE99999";
                s2.Name = "Updated Kris";
                Console.WriteLine("Student 2 (After Update using Properties):");
                s2.DisplayStudent();

                Console.ReadKey();
            }
        }
    }
}
