using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Association__correction_
{
    class Student
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string id;
        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        private float cg;
        public float CG
        {
            get { return cg; }
            set { cg = value; }
        }
        Department department;
        public Department Department
        {
            get { return department; }
            set { department = value; }
        }
        public Student() { }
        public Student(string name, string id, float cg)
        {
            this.name = name;
            this.id = id;
            this.cg = cg;
        }
        public void ShowInfo()
        {
            Console.WriteLine("Name:" + name);
            Console.WriteLine("Id:" + id);
            Console.WriteLine("CG:" + CG);
        }
    }
}
