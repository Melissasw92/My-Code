
using System;
using System.Collections.Generic;

namespace ToDo
{


    public class Task
    {

        public string? Description { get; set; }
        public bool IsCompleted { get; set; }


    }

    public class TaskList
    {
        private List<Task> tasks = new List<Task>();
        public void AddTask(string description)
        {
            tasks.Add(new Task { Description = description, IsCompleted = false });
        }

        public static void Main()
        {


            Console.WriteLine("Add task or mark a task complete: ");
            string userInput = Console.ReadLine();
        }



        void ListTasks()
        {

             TaskList todoList = new TaskList();
            todoList.AddTask("Do laundry");
            todoList.AddTask("Clean kitchen");
            todoList.AddTask("Take out trash");
            todoList.AddTask("Do dishes");
            todoList.AddTask("Send email to boss");

            todoList.ListTasks();

            for (int i = 0; i < tasks.Count; i++)
            {
                Console.WriteLine($"{i = 1}. {tasks[i].Description} - {(tasks[i].IsCompleted ? "Completed" : "Incomplete")}");
            }

           
        }
    }
}





