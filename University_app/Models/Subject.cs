using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_app.Models
{
    public class Subject
    {

        public Guid Id { get; set; }
        public string Name { get; set; }
        public double Coefficient { get; set; }
        public int Semester { get; set; }
        public Guid LevelId { get; set; }  // FK to Level



        public Subject() { }
        public Subject(string name, double coefficient, int semester, Guid levelId)
        {
            Name = name;
            Coefficient = coefficient;
            Semester = semester;
            LevelId = levelId;
        }
    }
}
