using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week1assignment
{
    class Task : IComparable
    {
        string description; //for the task description

        public Task(string description) //constructor with one argument
        {
            this.description = description;
        }
        public string Description //get and set description
        {
            get { return description; }
            set { description = value; }
        }
        public override string ToString()
        {
            return description; 
        }
        public int CompareTo(Object obj) //implement IComparable
        {
            Task other = (Task)obj;
            return description.CompareTo(other.description);
        }
    }
}
