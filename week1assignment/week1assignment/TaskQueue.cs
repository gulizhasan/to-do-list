using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week1assignment
{
    class TaskQueue //to contain the queue methods
    {
        private const int maxsize = 20; //to use as the size of the array
        private int top = 0; //head of the queue
        private int bottom = 0; //tail of the queue
        private int numItems; //value for the count

        //craete an array that has the maximum size maxsize
        private Task[] array = new Task[maxsize];

        public void Enqueue(Task value) //method to queue tasks, uses the value of Task
        {
            numItems++; //increase the count 
            array[bottom] = value; //set the tail to value of Task

            //check if the array size reached the maximum size
            if (++bottom == maxsize)
            {
                bottom = 0; //if so, assign tail value to 0
            }
        }

        public Task Dequeue() //method to remove task from the queue
        {
            Task headItem; //create a variable of type Task
            numItems--; //decrease the count
            headItem = array[top]; //assign headItem to head of the array

            //check if the array size reached the maximum size
            if (++top == maxsize)
            {
                top = 0; //if so, assign head value to 0
            }
            return headItem; //returns the head value
        }

        public int Count() //method to count the number of items in queue
        {
            return numItems; //returns the count
        }
        
        public Task First() //method to get the first task in the queue
        {
            return array[top]; //returns the head value
        }
    }
}
