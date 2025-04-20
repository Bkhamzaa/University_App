using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University_app.Models;

namespace University_app.Data
{
    public class LevelRepository
    {
        private readonly University_appDbContext _context;



        public LevelRepository(University_appDbContext context)
        {
            _context = context;
        }


        public List<Level> GetAllLevel()
        {
            return _context.Levels.ToList();
        }


    }
}
