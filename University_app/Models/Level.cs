using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_app.Models
{
    public class Level
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }

        public Guid ProgramId { get; set; }
        public Program_Univ Program { get; set; }

        // Navigation properties
        public ICollection<Student> Students { get; set; }
        public ICollection<Subject> Subjects { get; set; }
    }

}
