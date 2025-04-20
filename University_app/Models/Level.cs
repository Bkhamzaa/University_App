using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_app.Models
{
    public class Level
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid ProgramId { get; set; }  // FK to Program



    }
}
