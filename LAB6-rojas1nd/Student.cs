using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB6_rojas1nd
{
    class Student : Person
    {
        private int homework;
        public int HomeWork
        {
            get
            {
                return homework;
            }
            set
            {
                homework = value;
            }
        }



        public override void DoWork()
        {
            homework--;
        }

        public Student(int homework, int id)
        {
            this.homework = homework;
            this.id = id;
        }
    }
}
