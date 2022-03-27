using System;
using System.Collections.Generic;
using System.Text;

namespace Practise_7
{
    internal class Group
    {
        public string No;
        public Student[] Students;
        public int StudentLimit;
        public int j = 0;
        public void AddStudent(Student student)
        {
            Students[j++] = student;
        }
        public void GetInfo(Student[] student)
        {
            foreach (var item in student)
            {
                Console.WriteLine($"Fullname:{item.FullName}\nGroupNo:{item.GroupNo}\nAvgPoint:{item.AvgPoints}\n");
            }
        }
        public void GetFiltered(string name)
        {
            foreach (var item in Students)
            {
                if(item.FullName==name)
                {
                    Console.WriteLine($"Fullname:{item.FullName}\nGroupNo:{item.GroupNo}\nAvgPoint:{item.AvgPoints}\n");
                }
            }
        }
    }
}
