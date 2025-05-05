using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_app.Models
{
    public class Program_Univ
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }

        // Navigation
        public ICollection<Level> Levels { get; set; }
        public ICollection<Student> Students { get; set; }

    }
}
