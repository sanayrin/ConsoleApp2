using System;
using ConsoleApp2.Models;
using ConsoleApp2.Managers;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the To-Do List Application!");
            var todoManager = new TodoListManager();
            todoManager.DisplayTodoList();
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}