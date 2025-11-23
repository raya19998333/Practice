using Practice.Context;
using Practice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Services
{
    public class StudentManager

    {
        private readonly ApplicationDbContext _context = new ApplicationDbContext();

        public void AddStudent()
        {
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Major: ");
            string major = Console.ReadLine();

            Console.Write("Join Date: ");
            string joinDate = Console.ReadLine();

            Student s = new Student
            {
                Name = name,
                Major = major,
                JoinDate = joinDate
            };

            _context.Students.Add(s);
            _context.SaveChanges();

            Console.WriteLine("\n✓ Student added!");
        }

        public void ShowStudents()
        {
            var list = _context.Students.ToList();

            Console.WriteLine("\n--- Students ---");
            foreach (var s in list)
            {
                Console.WriteLine($"{s.Id} - {s.Name} - {s.Major} - {s.JoinDate}");
            }
        }
    }
}