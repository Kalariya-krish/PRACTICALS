using System;

namespace PRACTICALS.Lab_Tutorial_4
{
    // Base class (Parent) -> Person
    class Person
    {
        // Private data member (not accessible outside this class)
        private int age;

        // Protected data member (accessible in derived class)
        protected string name;

        // Public data member (accessible everywhere)
        public string address;

        // Public method to set private + protected members
        public void SetPersonDetails(string name, int age, string address)
        {
            this.name = name;
            this.age = age;
            this.address = address;
        }

        // Public method to display details
        public void ShowPersonDetails()
        {
            Console.WriteLine($"Name: {name}, Age: {age}, Address: {address}");
        }
    }

    // Derived class (Child) -> Student inherits from Person
    class Student : Person
    {
        // Private data member
        private int rollNo;

        // Protected data member
        protected string course;

        // Public data member
        public double percentage;

        // Public method to set student details
        public void SetStudentDetails(int rollNo, string course, double percentage)
        {
            this.rollNo = rollNo;
            this.course = course;
            this.percentage = percentage;
        }

        // Public method to display student details
        public void ShowStudentDetails()
        {
            Console.WriteLine($"Roll No: {rollNo}, Course: {course}, Percentage: {percentage}%");
        }
    }

    // Driver class (Task 7)
    internal class T4_Q3
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Name : KALARIYA KRIS \nEnrollment No: 24SOECE13028\n");

            // Creating first object of Student
            Student s1 = new Student();
            s1.SetPersonDetails("Rajesh Kumar", 21, "Rajkot");
            s1.SetStudentDetails(101, "Computer Engineering", 85.5);

            // Creating second object of Student
            Student s2 = new Student();
            s2.SetPersonDetails("Anita Sharma", 20, "Ahmedabad");
            s2.SetStudentDetails(102, "Information Technology", 90.0);

            // Display details of both students
            Console.WriteLine("Student 1 Details:");
            s1.ShowPersonDetails();
            s1.ShowStudentDetails();

            Console.WriteLine("\nStudent 2 Details:");
            s2.ShowPersonDetails();
            s2.ShowStudentDetails();

            Console.Read();
        }
    }
}
