﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_app.Models
{
    public class Subject
    {

        public Guid Id { get; set; } = Guid.NewGuid();  
        public string Name { get; set; }
        public float Coefficient { get; set; }
        public string Semester { get; set; }

        public Guid? LevelId { get; set; }
        public Level Level { get; set; }



        public Subject() { }
       
    }
}
