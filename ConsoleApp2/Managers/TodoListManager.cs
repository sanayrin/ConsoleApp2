using ConsoleApp2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Managers
{
    internal class TodoListManager
    {
        private List<TodoItem> _todolist = new List<TodoItem>();

        public TodoListManager()
        {
            _todolist.Add(new TodoItem(1, "Buy clark puppet"));
            _todolist.Add(new TodoItem(1, "Buy willy puppet"));
            _todolist.Add(new TodoItem(1, "Buy benta puppet"));
        }
        public void DisplayTodoList()
        {
            Console.WriteLine("\n--- Your To-Do List ---");
            if (_todolist.Count == 0)
            {
                Console.WriteLine("Your list is empty!");
            }
            else
            {
                foreach (var item in _todolist)
                {
                    Console.WriteLine($"{item.Id}.{item.GetStatusDisplay()} {item.Description}");
                }
            }
            Console.WriteLine("-------------------");
        }
    }
}
