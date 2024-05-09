using System;
using System.Collections.Generic;

namespace ToDoApp
{
    class Program
    {
        static List<TaskItem> tasks = new List<TaskItem>();
        static int nextId = 1;

        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("\nTo-Do List Application:");
                Console.WriteLine("1. Add a Task");
                Console.WriteLine("2. View Alls Tasks");
                Console.WriteLine("3. Mark Task as Completed");
                Console.WriteLine("4. Remove a Task");
                Console.WriteLine("5. Exit");
                var input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        AddTask();
                        break;
                    case "2":
                        ViewTasks();
                        break;
                    case "3":
                        MarkTaskAsCompleted();
                        break;
                    case "4":
                        RemoveTask();
                        break;
                    case "5":
                        return;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }

        static void AddTask()
        {
            Console.Write("\nEnter task title: ");
            string title = Console.ReadLine();
            Console.Write("\nEnter task category: ");
            string category = Console.ReadLine();
            Console.Write("\nEnter task priority: ");
            string priority = Console.ReadLine();
            TaskItem newTask = new TaskItem(nextId++, title, category, priority);
            tasks.Add(newTask);
            Console.WriteLine("Task added successfully.");
        }
        
        static void ViewTasks()
        {
            if (tasks.Count == 0)
            {
                Console.WriteLine("No tasks available");
            }
            else
            {
                Console.WriteLine("\nCurrent Tasks:");
                foreach(var task in tasks)
                {
                    Console.WriteLine(task);
                }
            }
        }

        static void MarkTaskAsCompleted()
        {
            Console.Write("Enter task ID to mark as completed: ");
            if (int.TryParse(Console.ReadLine(), out int id))
            {
                var task = tasks.Find(t => t.Id == id);
                if (task != null)
                {
                    task.IsCompleted = true;
                    Console.WriteLine("Task marked as completed");
                }
                else
                {
                    Console.WriteLine("Task not found");
                }
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }

        static void RemoveTask()
        {
            Console.Write("Enter task ID to remove: ");
            if (int.TryParse(Console.ReadLine(), out int id))
            {
                var task = tasks.Find(t => t.Id == id);
                if(task != null)
                {
                    tasks.Remove(task);
                    Console.WriteLine("Task removed successfully");
                }
                else
                {
                    Console.WriteLine("Task not found");
                }
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }
    }
}