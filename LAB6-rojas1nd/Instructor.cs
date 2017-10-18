using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB6_rojas1nd
{
    class Instructor : Person
    {
        public Instructor(int id)
        {
            this.id = id;
        }


        public override void DoWork()
        {
            Console.WriteLine("I am doing something");
        }
    }
}
