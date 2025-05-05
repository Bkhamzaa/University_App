using CsvHelper;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using University_app.Data;
using University_app.Models;
using System.Net;
using System.Net.Mail;
using CsvHelper.Configuration;
using University_app.Models.map;

namespace University_app.ViewModels
{
    public class ExamManagement : ViewModelBase
    {

        private readonly StudentRepository _studentRepository;
        private readonly ProgramRepository _programRepository;
        private readonly LevelRepository _levelRepository;
        private readonly ExamRepository _examRepository;
        private readonly SubjectRepository _subjectRepository;
        public ExamManagement()
        {

            var context = new University_appDbContext();

            _studentRepository = new StudentRepository(context);
            _programRepository = new ProgramRepository(context);
            _levelRepository = new LevelRepository(context);
            _examRepository = new ExamRepository (context);
            _subjectRepository = new SubjectRepository(context);


            Programs = new ObservableCollection<Program_Univ>(_programRepository.GetAllProgram());
            Students = new ObservableCollection<Student>(_studentRepository.GetAllStudent()); // Load all students initially
              // Initialize Exams data

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

        // Programs list
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

        // Levels list
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

        private ObservableCollection<StudentExamDTO> _Exams =new();
        public ObservableCollection<StudentExamDTO> Exams
        {
            get => _Exams;

            set
            {
                _Exams = value;
                OnPropertyChanged(nameof(Exams));
            }
        }

        // Selected Program
        private Program_Univ? _selectedProgram;

        public Program_Univ? SelectedProgram
        {
            get => _selectedProgram;
            set
            {
                _selectedProgram = value;
                OnPropertyChanged(nameof(SelectedProgram));
                LoadLevelsForProgram();
                FilterStudents();  // Filter students when selected program changes
               
            }
        }


        private Subject? _selectedSubject;

        public Subject? SelectedSubject
        {
            get => _selectedSubject;
            set
            {
                _selectedSubject = value;
                OnPropertyChanged(nameof(SelectedSubject));
                FilterStudents();  

            }
        }

        // Selected Level
        private Level? _selectedLevel;
        public Level? SelectedLevel
        {
            get => _selectedLevel;
            set
            {
                _selectedLevel = value;
                OnPropertyChanged(nameof(SelectedLevel));
                FilterStudents();  // Filter students when selected level changes
                LoadSubjectsForLevels();
            }
        }



        public void LoadLevelsForProgram()
        {
            if (SelectedProgram == null) return;

            var levels = _levelRepository.GetAllLevel()
                            .Where(l => l.ProgramId == SelectedProgram.Id)
                            .ToList();

            Levels = new ObservableCollection<Level>(levels);
            SelectedLevel = null;  // Reset the selected level when program changes
        }
        public void LoadSubjectsForLevels()
        {
            if (SelectedLevel == null) return;

            var subjects = _subjectRepository.GetAllSubject().Where(l => l.LevelId == SelectedLevel.Id)
                            .ToList();


            Subjects = new ObservableCollection<Subject>(subjects);
            SelectedSubject = null;  // Reset the selected level when program changes
        }



        private void FilterStudents()
        {
            var students = _studentRepository.GetAllStudent().AsQueryable();

            if (SelectedProgram != null)
                students = students.Where(s => s.ProgramId == SelectedProgram.Id);

            if (SelectedLevel != null) {
                students = students.Where(s => s.LevelId == SelectedLevel.Id);
                Students = new ObservableCollection<Student>(students.ToList());

                Exams = new ObservableCollection<StudentExamDTO>(LoadStudentExams());
                
            }

            if (SelectedSubject != null)
            {
                var filteredExams = Exams.Where(t => t.SubjectName == SelectedSubject.Name).ToList();
                Exams = new ObservableCollection<StudentExamDTO>(filteredExams);

            }




        }




        private List<StudentExamDTO> LoadStudentExams()
        {
            
                var studentExams = from exam in _examRepository.GetAllExam()
                               join student in Students on exam.CinId equals student.CinId 
                               join subject in _subjectRepository.GetAllSubject() on exam.SubjectId equals subject.Id
                      
                                

                               select new StudentExamDTO
                               {
                                   CinId = student.CinId,
                                   FirstName = student.FirstName,
                                   LastName = student.LastName,
                                   SubjectName = subject.Name,
                                   Ds = exam.DS,
                                   Exam = exam.FinalExam,
                                   Email = student.Email
                               };

            

            return studentExams.ToList();


                    
        }

        public void ImportExamFromCsv(string filePath)
        {
            try
            {
                var config = new CsvConfiguration(CultureInfo.InvariantCulture)
                {
                    HeaderValidated = null,  
                    MissingFieldFound = null 
                };

                using var reader = new StreamReader(filePath);
                using var csv = new CsvReader(reader, config);

                
                csv.Context.RegisterClassMap<ExamMap>();

                
                var exams = csv.GetRecords<Exam>().ToList();

                
                foreach (var exam in exams)
                {
                    if (exam != null)
                    {
                        
                        _examRepository.AddExam(exam);
                    }
                }

                
                FilterStudents();

                MessageBox.Show("Students imported successfully!");
            }
            catch (Exception ex)
            {
                
                MessageBox.Show($"Error importing Exam: {ex.Message}");
            }
        }

        // Single selected item (for individual row selection)
        private StudentExamDTO? _selectedExam;
        public StudentExamDTO? SelectedExam
        {
            get => _selectedExam;
            set
            {
                _selectedExam = value;
                OnPropertyChanged(nameof(SelectedExam));
            }
        }

        // Multiple selected items (for selecting multiple rows)
        private ObservableCollection<StudentExamDTO> _selectedExams = new();
        public ObservableCollection<StudentExamDTO> SelectedExams
        {
            get => _selectedExams;
            set
            {
                _selectedExams = value;
                OnPropertyChanged(nameof(SelectedExams));
            }
        }


        public void SendExamEmail(IEnumerable<StudentExamDTO> selectedStudents)
        {
            foreach (var student in selectedStudents)
            {
                try
                {
                    var mail = new MailMessage();
                    mail.From = new MailAddress("hboubaker59@gmail.com");
                    mail.To.Add(student.Email);
                    mail.Subject = "Exam Results Notification (Test Email Send For App)";
                    mail.Body = $"Dear {student.FirstName} {student.LastName},\n\n" +
                                $"{student.SubjectName},\n\n" +
                                $"Your DS grade: {student.Ds}\n" +
                                $"Your Exam grade: {student.Exam}\n\n" +
                                "Best regards,\nUniversity Staff";

                    var smtpServer = new SmtpClient("smtp.gmail.com");
                    smtpServer.Port = 587; // or 25 / 465 depending on your server
                    smtpServer.Credentials = new NetworkCredential("hboubaker59@gmail.com", "sopk mqlu inkx whgl\r\n");
                    smtpServer.EnableSsl = true;

                    smtpServer.Send(mail);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Failed to send email to {student.Email}: {ex.Message}");
                }
            }

            MessageBox.Show("Emails sent successfully!");
        }




    }
}
