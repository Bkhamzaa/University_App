using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_app.Models.map
{
    public class ExamMap : ClassMap<Exam>
    {
        public ExamMap()
        {
            // Mapping CSV headers to model properties
            Map(m => m.CinId).Name("CinId");
            Map(m => m.SubjectId).Name("IdSubject");
            Map(m => m.DS).Name("Ds");
            Map(m => m.FinalExam).Name("finalExam");
        }
    }
}
