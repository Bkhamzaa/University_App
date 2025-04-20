using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using University_app.Models;

namespace University_app.Data
{
    public class SubjectRepository
    {
        private readonly University_appDbContext _context;

        public SubjectRepository(University_appDbContext context)
        {
            _context = context;
        }

        public List<Subject> GetAllSubject()
        {   var test = _context.Subjects.ToList();
            return _context.Subjects.ToList();
        }


        public void RemoveSubject(Subject subject)
        { 


            _context.Subjects.Remove(subject);
            _context.SaveChanges();

        }

        public void UpdateSubject(Subject subject)
        {
            _context.Subjects.Update(subject);
            _context.SaveChanges(); 


        }

        public void AddSubject(Subject subject) { 
        
        _context.Add(subject);
            _context.SaveChanges();

        }

    }
}
