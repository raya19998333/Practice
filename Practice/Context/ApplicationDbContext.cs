using Microsoft.EntityFrameworkCore;
using Practice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Context
{
    public class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string con = "server=localhost\\MSSQLSERVER08;" +
                         "database=StudentDb;" +
                         "Integrated Security=True;" +
                         "TrustServerCertificate=True;";

            optionsBuilder.UseSqlServer(con);
        }

        public DbSet<Student> Students { get; set; }


    }
}
