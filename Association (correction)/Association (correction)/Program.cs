using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Association__correction_
{
    class Program
    {
        static void Main(string[] args)
        {
            Department d1 = new Department("Computer Science", "CS");
            Student s1 = new Student("ARNOP", "19-39906-1", 3.63f);
            d1.AllStudents();
            s1.Department = d1;
            s1.ShowInfo();

        }
    }
}
