using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops1q2
{

        
        class TaskItem
        {
            private string _description;
            private bool _iscompleted;

            public string Description
            {
                get { return _description; }
                set
                {
                    if (string.IsNullOrEmpty(value))
                    {
                        throw new ArgumentException("description can't be empty");
                    }

                    _description = value;
                }
            }
            public bool Iscompleted
            {
                get { return _iscompleted; }
            }

            public TaskItem(string description) {
                if (string.IsNullOrEmpty(description))
                {
                    throw new ArgumentException("description can't be empty");
                }
                _description = description;
                _iscompleted = false;
            }
            public void MarkCompleted()
            {
                _iscompleted = true;
            }

        }
        class ToDoList
        {
            private List<TaskItem> _tasks;
            public ToDoList()
            {
                _tasks = new List<TaskItem>();
            }

            public void AddTaskItem(string description)
            {

                if (string.IsNullOrEmpty(description))
                {
                    throw new ArgumentException("description can't be empty");
                }

                TaskItem task = new TaskItem(description);
                _tasks.Add(task);

            }
        public void ViewTasks()
        {
            if (_tasks.Count == 0)
            {
                Console.WriteLine("list is empty");
                return;
            }
            for (int i = 0; i < _tasks.Count; i++)
            {
                Console.WriteLine("task:\n");
                Console.WriteLine(_tasks[i].Description);
                if (_tasks[i].Iscompleted)
                {
                    Console.WriteLine("Completed");
                }
                else
                {
                    Console.WriteLine("Pending");
                }
            }
        }


                public void MarkTaskAsCompleted(int taskNumber)
            {
                if (_tasks.Count == 0)
                {
                    Console.WriteLine("list is empty");
                    return;
                }

                if (taskNumber < 1 || taskNumber > _tasks.Count)
                {
                    throw new ArgumentException("invalid task number");
                }

                if (_tasks[taskNumber - 1].Iscompleted)
                {
                    Console.WriteLine("task is already completed");
                    return;
                }

                _tasks[taskNumber - 1].MarkCompleted();

                Console.WriteLine("task marked as completed");
            }
            public void RemoveTask(int taskNumber)
            {
                if (_tasks.Count == 0)
                {
                    Console.WriteLine("list is empty");
                    return;
                }

                if (taskNumber < 1 || taskNumber > _tasks.Count)
                {
                    throw new ArgumentException("invalid task number");
                }

                _tasks.RemoveAt(taskNumber - 1);
            }



            }
    internal class Program
    {
        static void Main(string[] args)
        {
            ToDoList todoList = new ToDoList();
            while (true)
            {
                Console.WriteLine("1.add Task");
                Console.WriteLine("2.view Tasks");
                Console.WriteLine("3.mark task as completed");
                Console.WriteLine("4.remove task");
                Console.WriteLine("5.exit");
                Console.Write("Choose an option: ");
                string input = Console.ReadLine();
                if (!int.TryParse(input, out int option))
                {
                    Console.WriteLine("invalid input, enter a number");
                    continue;
                }
                switch (option)
                {
                    case 1:
                        Console.Write("enter task description: ");
                        string description = Console.ReadLine();
                        todoList.AddTaskItem(description);
                        Console.WriteLine("task added successfully");
                        break;

                    case 2:
                        todoList.ViewTasks();
                        break;
                    case 3:
                        Console.Write("enter task number to mark as completed: ");
                        string completeinput = Console.ReadLine();
                        if (!int.TryParse(completeinput, out int completenumber))
                        {
                            Console.WriteLine("invalid task number");
                            break;
                        }
                        todoList.MarkTaskAsCompleted(completenumber);
                        break;

                    case 4:
                        Console.Write("enter task number to remove: ");

                        string removeInput = Console.ReadLine();

                        if (!int.TryParse(removeInput, out int removeNumber))
                        {
                            Console.WriteLine("Invalid task number.");
                            break;
                        }

                        todoList.RemoveTask(removeNumber);
                        break;
                    case 5:
                        Console.WriteLine("exit done");
                        return;

                    default:
                        Console.WriteLine("invalid option. please choose between 1 and 5");
                        break;
                }
            }

        }
    }
}

