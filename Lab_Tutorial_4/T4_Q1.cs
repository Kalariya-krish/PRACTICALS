using System;

namespace PRACTICALS.Lab_Tutorial_4
{
    class Employee
    {
        private int empCode;
        private string name;
        private string designation;
        private double basicPay;

        public Employee(int empCode, string name, string designation, double basicPay)
        {
            this.empCode = empCode;
            this.name = name;
            this.designation = designation;
            this.basicPay = basicPay;
        }

        public void CalculatePay()
        {
            double hra = 0.10 * basicPay;
            double da = 0.45 * basicPay;
            double totalPay = basicPay + hra + da;

            Console.WriteLine("\nEmployee Details:");
            Console.WriteLine($"Code        : {empCode}");
            Console.WriteLine($"Name        : {name}");
            Console.WriteLine($"Designation : {designation}");
            Console.WriteLine($"Basic Pay   : {basicPay}");
            Console.WriteLine($"HRA (10%)   : {hra}");
            Console.WriteLine($"DA (45%)    : {da}");
            Console.WriteLine($"Total Pay   : {totalPay}");
        }
    }

    internal class T4_Q1
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Name : KALARIYA KRIS \nEnrollment No: 24SOECE13028\n");

            Employee e1 = new Employee(101, "Rajesh Kumar", "Manager", 50000);
            Employee e2 = new Employee(102, "Anita Sharma", "Developer", 35000);
            Employee e3 = new Employee(103, "Vikram Singh", "Clerk", 20000);

            e1.CalculatePay();
            e2.CalculatePay();
            e3.CalculatePay();

            Console.Read();
        }
    }
}
