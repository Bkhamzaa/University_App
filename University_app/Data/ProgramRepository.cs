using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University_app.Models;

namespace University_app.Data
{
    public class ProgramRepository
    {

        private readonly University_appDbContext _context;

        public ProgramRepository(University_appDbContext context)
        {
            _context = context;
        }

        public List<Program_Univ> GetAllProgram()
        {

            return _context.Program_Univ.ToList();

    }
}
}

