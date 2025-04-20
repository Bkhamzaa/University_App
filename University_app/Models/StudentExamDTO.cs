using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_app.Models
{
    public class StudentExamDTO
    {


        public string CinId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SubjectName { get; set; }
        public Guid levelid { get; set; }
        public double? Ds { get; set; }
        public double? Exam { get; set; }
        public string Email { get; set; }
    }
}
