using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University_app.Models;

namespace University_app.Data
{
    public class UserRepository
    {
        private readonly University_appDbContext _context;

        public UserRepository(University_appDbContext context)
        {
            _context = context;
        }



        public User? Authenticate(string username, string password)
        {
            return _context.User_
                .FirstOrDefault(u => u.Username == username && u.Password == password);
        }



    }
}
