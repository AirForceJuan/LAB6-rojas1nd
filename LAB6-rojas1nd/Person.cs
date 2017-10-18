using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB6_rojas1nd
{
    /// <summary>
    /// Person Class that sets a Name and ID 
    /// </summary>
    class Person : IComparable<Person>
    {
        public Person() { }

        /// <summary>
        /// Name that is Protected so it is available to all subclasses directly 
        /// </summary>
        protected string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        /// <summary>
        /// ID that is protected
        /// </summary>
        protected int id;
        public int ID
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        /// <summary>
        /// override for the Less than operator
        /// </summary>
        /// <param name="IDA">var ID being compared</param>
        /// <param name="IDB">var for ID being compared</param>
        /// <returns>Method returns true if IDA is smaller than IDB</returns>
        public static bool operator <(Person IDA,Person IDB)
        {
            if(IDA.ID < IDB.ID)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        
        /// <summary>
        /// override for the greater than operator
        /// </summary>
        /// <param name="IDA">var of ID being compared</param>
        /// <param name="IDB">var of ID being compared</param>
        /// <returns></returns>
        public static bool operator >(Person IDA,Person IDB)
        {
            if(IDA.ID < IDB.ID)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Method that compares ID's of Person's
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int CompareTo(Person obj)
        {
            Person Temp = obj;
            if(this.ID < Temp.ID)
            {
                return 1;
            }
            if (this.ID > Temp.ID)
            {
                return -1;
            }
            else return 0;
        }


        /// <summary>
        /// Method that overrides ToString() and changes the format of the output
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Format("{0} : {1}", this.name, this.ID);
        }

        public virtual void DoWork()
        {

        }





    }
}
