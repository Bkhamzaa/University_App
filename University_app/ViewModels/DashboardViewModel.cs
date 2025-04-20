using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University_app.Data;
using University_app.Models;

namespace University_app.ViewModels
{
    public class DashboardViewModel : ViewModelBase
    {
        private readonly StudentRepository _studentRepository;
        private readonly ProgramRepository _programRepository;
        private readonly LevelRepository _levelRepository;
        private readonly ExamRepository _examRepository;
        private readonly SubjectRepository _subjectRepository;

        public DashboardViewModel()
        {
            var context = new University_appDbContext();

            _studentRepository = new StudentRepository(context);
            _programRepository = new ProgramRepository(context);
            _levelRepository = new LevelRepository(context);
            _examRepository = new ExamRepository(context);
            _subjectRepository = new SubjectRepository(context);

            // Load data from repositories
            Programs = new ObservableCollection<Program_Univ>(_programRepository.GetAllProgram());
            Students = new ObservableCollection<Student>(_studentRepository.GetAllStudent());
            Levels = new ObservableCollection<Level>(_levelRepository.GetAllLevel());
            Subjects = new ObservableCollection<Subject>(_subjectRepository.GetAllSubject());
            Exams = new ObservableCollection<Exam>(_examRepository.GetAllExam());
        }

        // Dashboard Summary
        public string TotalStudents => $"👨‍🎓 Students: {Students.Count}";
        public string TotalExams => $"🧪 Exams: {Exams.Count}";
        public string TotalSubjects => $"📘 Subjects: {Subjects.Count}";
        public string TotalLevels => $"🏷️ Levels: {Levels.Count}";
        public string TotalPrograms => $"🏛️ Programs: {Programs.Count}";

        public string TopStudent
        {
            get
            {
                var top = Students
                    .Join(Exams, s => s.Cin_id, e => e.CinId, (s, e) => new { s, e })
                    .GroupBy(x => x.s)
                    .Select(g => new
                    {
                        Student = g.Key,
                        AvgScore = g.Average(x => ((x.e.Ds ?? 0) + (x.e.finalExam ?? 0)) / 2)
                    })
                    .OrderByDescending(x => x.AvgScore)
                    .FirstOrDefault();

                return top != null
                    ? $"🏆 Top Student: {top.Student.FirstName} {top.Student.LastName} ({top.AvgScore:F2})"
                    : "🏆 Top Student: N/A";
            }
        }

        // Observable Properties
        private ObservableCollection<Program_Univ> _programs = new();
        public ObservableCollection<Program_Univ> Programs
        {
            get => _programs;
            set
            {
                _programs = value;
                OnPropertyChanged(nameof(Programs));
            }
        }

        private ObservableCollection<Student> _students = new();
        public ObservableCollection<Student> Students
        {
            get => _students;
            set
            {
                _students = value;
                OnPropertyChanged(nameof(Students));
            }
        }

        private ObservableCollection<Level> _levels = new();
        public ObservableCollection<Level> Levels
        {
            get => _levels;
            set
            {
                _levels = value;
                OnPropertyChanged(nameof(Levels));
            }
        }

        private ObservableCollection<Subject> _subjects = new();
        public ObservableCollection<Subject> Subjects
        {
            get => _subjects;
            set
            {
                _subjects = value;
                OnPropertyChanged(nameof(Subjects));
            }
        }

        private ObservableCollection<Exam> _exams = new();
        public ObservableCollection<Exam> Exams
        {
            get => _exams;
            set
            {
                _exams = value;
                OnPropertyChanged(nameof(Exams));
            }
        }




        public string AverageScore =>
    Exams.Count > 0
        ? $"📈 Avg Score: {Exams.Average(e => ((e.Ds ?? 0) + (e.finalExam ?? 0)) / 2):F2}"
        : "📈 Avg Score: N/A";

        public string PassRate
        {
            get
            {
                if (Exams.Count == 0) return "✅ Pass Rate: N/A";

                int passed = Exams.Count(e => ((e.Ds ?? 0) + (e.finalExam ?? 0)) / 2 >= 10);
                return $"✅ Pass Rate: {((double)passed / Exams.Count * 100):F1}%";
            }
        }

        public string FailRate
        {
            get
            {
                if (Exams.Count == 0) return "❌ Fail Rate: N/A";

                int failed = Exams.Count(e => ((e.Ds ?? 0) + (e.finalExam ?? 0)) / 2 < 10);
                return $"❌ Fail Rate: {((double)failed / Exams.Count * 100):F1}%";
            }
        }






    }
}
