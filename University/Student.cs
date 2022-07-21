using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    class Student
    {
        public string RegNo { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        private Department Department { get; set; }
        public Student()
        {
            Department = new Department();
        }

        public Student(string RegNo, string Name, string Email):this()
        {
            this.RegNo = RegNo;
            this.Name = Name;
            this.Email = Email;
        }

    }
}
