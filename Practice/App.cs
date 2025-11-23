using Practice.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class App
    {
        private StudentManager manager = new StudentManager();

        public void Run()
        {
            while (true)
            {
                Console.WriteLine("\n1) Add Student");
                Console.WriteLine("2) Show Students");
                Console.WriteLine("3) Exit");
                Console.Write("Choice: ");

                switch (Console.ReadLine())
                {
                    case "1": manager.AddStudent(); break;
                    case "2": manager.ShowStudents(); break;
                    case "3": return;
                    default: Console.WriteLine("Invalid"); break;
                }
            }
        }
    }
}