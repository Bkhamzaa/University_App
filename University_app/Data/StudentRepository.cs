using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University_app.Models;

namespace University_app.Data
{
    public class StudentRepository
    {

        private readonly University_appDbContext _context;

        public StudentRepository(University_appDbContext context)
        {
            _context = context;
        }




        public List<Student> GetAllStudent()
        {
            return _context.Students.ToList();
        }

        public void AddStudent(Student student) 
        { 
         _context.Students.Add(student);
         _context.SaveChanges();


        }

        public bool UpdateStudent(Student student)
        {
            try
            {
                _context.Students.Update(student);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool DeleteStudent(Student student)
        {
            try
            {
                _context.Students.Remove(student);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }


    }
}
