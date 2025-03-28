using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mart28Task
{
    class Group
    {
        public int groupNo;
        private int studentLimit;
        Student[] students = new Student[0];

        public int StudentLimit
        {
            get
            {
                return studentLimit;
            }
            set
            {
                if(value>=5 && value < 19)
                {
                    studentLimit = value;
                }
            }
        }

        public bool CheckGropupNo(int groupNo)
        {
            if(this.groupNo == groupNo)
            {
                return true;
            }
            return false;
        }

        public void AddEmployee(Student e)
        {
            if (studentLimit > students.Length)
            {
                Student[] empp = new Student[students.Length + 1];
                for (int i = 0; i < students.Length; i++)
                {
                    empp[i] = students[i];
                }
                for (int i = 0; i <= empp.Length; i++)
                {
                    if (i == students.Length)
                    {
                        empp[i] = e;
                        students = empp;
                        empp = students;
                        break;
                    }

                }
            }
            else
            {
                Console.WriteLine($"qoymaqcun yer qalmadi!!");
            }
        }

        public void GetStudent(int id)
        {
            for(int i=0; i<students.Length; i++)
            {
                if(students[i].id == id)
                {
                    Console.WriteLine($"{students[id]}, {students[i].fullName}");
                }
            }
        }

        public void GetAllStudents()
        {
            for(int i = 0; i < students.Length; i++)
            {
                if (i == students.Length - 1)
                {
                    Console.WriteLine($"{students[i].id}, {students[i].fullName}, {students[i].point}.");
                }
                Console.Write($"{students[i].id}, {students[i].fullName}, {students[i].point} ;");
            }
        }

    }
}
