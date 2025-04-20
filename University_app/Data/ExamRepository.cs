using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University_app.Models;

namespace University_app.Data
{
    public class ExamRepository
    {
        private readonly University_appDbContext _context;

        public ExamRepository(University_appDbContext context)
        {
            _context = context;
        }


        public List<Exam> GetAllExam()
        {


            return _context.Exam.ToList(); 
        }

        public void AddExam(Exam exam)
        {

            _context.Add(exam);
            _context.SaveChanges();

        }
    }
}
