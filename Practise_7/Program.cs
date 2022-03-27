using System;

namespace Practise_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Grup nomresini ve Student limitini teyin edin:");
            string no = Console.ReadLine();
            int studentlimit = Convert.ToInt32(Console.ReadLine());
            while(!(no.Length==5 && char.IsUpper(no[0])==true && char.IsUpper(no[1])==true && char.IsDigit(no[2])==true && char.IsDigit(no[3])==true && char.IsDigit(no[4])==true))
            {
                Console.WriteLine("Grup nomresi 2 boyuk herf ve 3 reqemden ibaretdi ardicil olaraq");
                no = Console.ReadLine();
            }
            while(studentlimit<=0 || studentlimit>=20)
            {
                Console.WriteLine("Student limiti 0-dan kicik 20-den boyuk ola bilmez");
                studentlimit = Convert.ToInt32(Console.ReadLine());
            }
            Group group = new Group();
            group.Students=new Student[studentlimit];
            bool check = true;
            while(check)
            {
                Console.WriteLine("1-Telebe elave et \n2-Butun telebelere bax\n3-Telebeler uzre axtaris et\n0-Proqrami bitir");
                int answer = Convert.ToInt32(Console.ReadLine());
                if (answer == 1)
                {
                    Array.Resize(ref group.Students, studentlimit);
                    while (1+group.j<studentlimit)
                    {

                        Console.WriteLine("Telebenin Fullname-mi:");
                        string fullname = Console.ReadLine();
                        Console.WriteLine("Telebenin ortalama bali:");
                        double avgpoint = Convert.ToDouble(Console.ReadLine());
                        Student student = new Student(fullname)
                        {
                            GroupNo = no,
                            AvgPoints = avgpoint
                        };
                        group.AddStudent(student);
                        break;
                    }
                }
                else if(answer == 2)
                {
                    Array.Resize(ref group.Students, group.j);
                    group.GetInfo(group.Students);
                }
                else if(answer == 3)
                {
                    Array.Resize(ref group.Students, group.j);
                    Console.WriteLine("Filter olunacaq FullName-i yazin:");
                    string name = Console.ReadLine();   
                    group.GetFiltered(name);
                }
                else if(answer == 0)
                {
                    check = false;
                }
                else
                    Console.WriteLine("1 ,2,3, ve ya 0 seciniz!");
            }
          
        }
    }
}
