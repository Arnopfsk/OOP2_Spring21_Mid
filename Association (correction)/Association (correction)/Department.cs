using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Association__correction_
{
    class Department
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
        private Student[] student;
        private int studentCount;
        public int StudentCount
        {
            get { return studentCount; }
            set { studentCount = value; }
        }
        public Department()
        {
            student = new Student[60];
        }
        public Department(string name, string id)
        {
            this.name = name;
            this.id = id;
            student = new Student[60];
        }
        
        public void AllStudents()
        {
            for (int i = 0; i < studentCount; i++)
            {
                student[i].ShowInfo();
            }
        }
        public Student GetStudent(string id)
        {
            return null;
        }
        public void ShowInfo()
        {
            Console.WriteLine("Name:" + name);
            Console.WriteLine("Id:" + id);
        }
    }
}
