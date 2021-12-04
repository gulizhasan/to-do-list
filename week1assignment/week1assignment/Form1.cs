using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace week1assignment
{
    public partial class Form1 : Form
    {
        //create a queue called tasks
        private TaskQueue tasks;
       
        public Form1()
        {
            //initialise the queue
            tasks = new TaskQueue();

            InitializeComponent();
        }

        private void addTask_Click(object sender, EventArgs e)
        {
            //create a new task and assign it to the text box for user input
            Task myTask = new Task(taskBox.Text);

            //add the user input to the queue using enqueue
            tasks.Enqueue(myTask);

            //display the amount of tasks in the queue
            taskCountLabel.Text = "Number of tasks: " + tasks.Count();
        }
        private void removeTask_Click(object sender, EventArgs e)
        {
            //remove first task from the queue
            Task myTask = tasks.Dequeue();

            //display the removed task in a text box
            removedTaskBox.Text = myTask.ToString();

            //display the amount of tasks in the queue
            taskCountLabel.Text = "Number of tasks: " + tasks.Count();
        }

        private void firstBox_Click(object sender, EventArgs e)
        {
            //get the first task in the queue using First method
            Task myTask = tasks.First();

            //display the result from the First method in a text box
            firstTaskBox.Text = myTask.ToString();
        }
    }
}
