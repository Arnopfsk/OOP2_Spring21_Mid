using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assosiation
{
    class Program
    {
        static void Main(string[] args)
        {
            Depertment d1 = new Depertment("Computer Science", "CSE");
            Depertment d2 = new Depertment("Business Admin.", "BBA");
            Student s1 = new Student("ARNOP", "555", 2.5f);
            Student s2 = new Student("FAHIM", "666", 5.35f);
            s1.Depertment = d1;
            s2.Depertment = d2;
            s1.show();
            s2.show();


        }
    }
}