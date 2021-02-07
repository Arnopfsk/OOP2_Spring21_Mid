using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesigningClasses
{
    class Student
    {
        private string name;
        private string id;
        private string department;
        private float cgpa;

        public Student() { }

        public string Name
        {
            set
            { name = value; }

            get
            { return name; }
        }
        public string ID
        {
            set
            { id = value; }

            get
            { return id; }
           
        }
        public string Department
        {
            set
            { department = value; }

            get
            { return department; }
            
        }

        public float Cgpa
        {
            set
            { cgpa = value; }

            get
            { return cgpa; }
            
        }

        public void showinfo()
        {
            Console.WriteLine("NAME: " + Name);
            Console.WriteLine("ID: " + ID);
            Console.WriteLine("DEPARTMENT: " + Department);
            Console.WriteLine("CGPA: " + Cgpa);
        }
    }

    class Triangle
    {
        private int x;
        private int y;
        private int z;

        public Triangle() { }

        public int X
        {
            set
            { x = value; }

            get
            { return x; }
            
        }

        public int Y
        {
            set
            { y = value; }

            get
            { return y; }
            
        }

        public int Z
        {
            set
            { z = value; }

            get
            { return z; }
            
        }

        public void showinfo()
        {
            Console.WriteLine("1st Side X: " + x);
            Console.WriteLine("2nd Side Y: " + y);
            Console.WriteLine("3rd Side Z: " + z);
        }
        public void testTriangle()
        {
            if (x == y && x == z)
            {
                Console.WriteLine("Equilateral");
            }
            else if (x == y && x != z || y == z && y != x || z == x && x != y)
            {
                Console.WriteLine("Isoscale");
            }
            else
            {
                Console.WriteLine("Scalane");
            }

        }

    }

    class Account
    {
        private string accName;
        private string acid;
        private int balance;

        public Account() { }

        public string AccName
        {
            set
            { accName = value; }

            get
            { return accName; }
            
        }

        public string Acid
        {
            set
            { acid = value; }

            get
            { return acid; }
            
        }

        public int Balance
        {
            set
            { balance = value; }

            get
            { return balance; }
            
        }

        public void Deposit(int ammount)
        {
            balance = balance + ammount;
            Console.WriteLine("Deposited : " + ammount);

        }

        public void Withdraw(int ammount)
        {

            balance = balance - ammount;
            Console.WriteLine("Withdrawn : " + ammount);
        }
    }

    class Course
    {
        private String courseName;
        private String courseCode;
        private int courseCredit;

        public String CourseName
        {
            set
            { courseName = value; }

            get
            { return courseName; }
            
        }

        public String CourseCode
        {
            set
            { courseCode = value; }

            get
            { return courseCode; }
            
        }

        public int CourseCredit
        {
            set
            { courseCredit = value; }

            get
            { return courseCredit; }
            
        }

        public void showCourseInfo()
        {
            Console.WriteLine("Course Name: " + courseName);
            Console.WriteLine("Course Code: " + courseCode);
            Console.WriteLine("Course Credit: " + courseCredit);
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.Name = "Fahim";
            s.ID = "555";
            s.Department = "CSE";
            s.Cgpa = 5.5F;
            s.showinfo();

            Console.WriteLine();

            Triangle t = new Triangle();
            t.X = 5;
            t.Y = 5;
            t.Z = 5;
            t.showinfo();
            t.testTriangle();

            Console.WriteLine();

            Account a = new Account();
            a.AccName = "Arnop";
            a.Acid = "555";
            a.Balance = 555;
            Console.WriteLine("CurrBalance: " + a.Balance);
            a.Deposit(55);
            Console.WriteLine("CurrBalance: " + a.Balance);
            a.Withdraw(555);
            Console.WriteLine("CurrBalance: " + a.Balance);

            Console.WriteLine();

            Course c = new Course();
            c.CourseName = "ABC";
            c.CourseCode = "555";
            c.CourseCredit = 5;
            c.showCourseInfo();


        }
    }
}
