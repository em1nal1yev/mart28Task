using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mart28Task
{
    class Student
    {
        public int id;
        public string fullName;
        public int point;

        public void StudentInfo()
        {
            Console.WriteLine($"idsi-{id}, fullName si-{fullName}, pointi-{point}");
        }
    }
}
