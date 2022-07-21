using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    class Department
    {

        private const int MaxNumberAdd = 15;
        public string Code { get; set; }
        public string Name { get; set; }

        private List<Student> students;

        public Department()
        {
           students = new List<Student>();
        }

        public Department(string code, string name):this()
        {
            Code = code;
            Name = name;
        }

        public bool AddStudent(Student student)
        {
            bool isStudentAdded = false;
            
            int d = students.Count;

            if (students.Count < MaxNumberAdd)
            {
                students.Add(student);
                isStudentAdded = true;
          
            }

            return isStudentAdded;
        }

        public string GetDetails()
        {
            string details = "";
            details += "Dept Id: " + Code + "Name: " + Name + Environment.NewLine;
            details += "Reg No \t Name \t Email" + Environment.NewLine;

            foreach(Student student in students)
            {
                details += student.RegNo + " \t" + student.Name + " \t" + " \t" + student.Email;
            }

            return details;
        }
    }
}
