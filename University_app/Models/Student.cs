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
        public string Cin_id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public Guid ProgramId { get; set; }
        public Guid LevelId { get; set; }


    }
}
