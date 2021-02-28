using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assosiation
{
    class Student
    {
        private string name;
        private string Name
        {
            set { name = value; }
            get { return name; }

        }
        private string id;
        private string ID
        {
            set { id = value; }
            get { return id; }

        }
        private float cg;
        private float CG
        {
            set { cg = value; }
            get { return cg; }

        }
        public Student() { }
        public Student(string name, string id, float cg)
        {
            this.name = name;
            this.id = id;
            this.cg = cg;
        }
        Depertment depertment;
        public Depertment Depertment
        {
            set { depertment = value; }
            get { return depertment; }
        }
        public void show()
        {
            Console.WriteLine("Name : " + name);
            Console.WriteLine("ID : " + id);
            Console.WriteLine("CG : " + cg);
        }
    }
}