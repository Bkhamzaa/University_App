using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University_app.Models;

namespace University_app.Data
{
    public class University_appDbContext : DbContext
    {
        public DbSet<Level> Levels { get; set; }
        public DbSet<Program_Univ> Program_Univ { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Exam> Exam { get; set; }




        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Hamza\\Documents\\UnuversityDb.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True";
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
