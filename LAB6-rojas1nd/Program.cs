using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB6_rojas1nd
{
    class Program
    {
        static void Main(string[] args)
        {
            Person Joe = new Person();
            Person James = new Person();


            

            Joe.ID = 1001;
            Joe.Name = "Joe";

            James.ID = 1002;
            James.Name = "James";


            Instructor GoodMan = new Instructor(1003);
            Instructor BadMan = new Instructor(1004);

            GoodMan.Name = "bob";
            BadMan.Name = "bill";

            Student dick = new Student(10, 1005);
            Student dan = new Student(10, 1006);

            dick.Name = "Dick";
            dan.Name = "Dan";



            Console.WriteLine(dick > GoodMan);
            Console.WriteLine(James < dick);
            Console.WriteLine(dan.CompareTo(James));
            Console.WriteLine(Joe.ToString());
            Console.WriteLine(dan.ToString());
            Console.WriteLine(dan.HomeWork.ToString());
            dan.DoWork();
            Console.WriteLine(dan.HomeWork.ToString());
            BadMan.DoWork();

            Console.ReadLine();


        }
    }
}
