using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_app.Models
{
    [Table("Student")]

    public class Student
    {

        public Guid Id { get; set; } = Guid.NewGuid();  
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string CinId { get; set; }

        public Guid ProgramId { get; set; }
        public Program_Univ Program { get; set; }

        public Guid LevelId { get; set; }
        public Level Level { get; set; }


    }
}
