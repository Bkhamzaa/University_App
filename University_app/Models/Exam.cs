using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_app.Models
{
    public class Exam
    {
       public  Guid Id { get; set; }

       public required string  CinId { get; set; }
        public Guid IdSubject { get; set; }
        public double? Ds { get; set; }
        public double? finalExam { get; set; }





    }
}
