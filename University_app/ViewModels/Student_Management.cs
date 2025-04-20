using Microsoft.EntityFrameworkCore.Migrations.Operations;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using University_app.Data;
using University_app.Models;

namespace University_app.ViewModels
{
    public class Student_Management : ViewModelBase
    {
        private readonly StudentRepository _studentRepository;
        private readonly ProgramRepository _programRepository;
        private readonly LevelRepository _levelRepository;

        public Student_Management()
        {
            var context = new University_appDbContext();

            _studentRepository = new StudentRepository(context);
            _programRepository = new ProgramRepository(context);
            _levelRepository = new LevelRepository(context);

            Programs = new ObservableCollection<Program_Univ>(_programRepository.GetAllProgram());
            Students = new ObservableCollection<Student>(_studentRepository.GetAllStudent()); // Load all students initially
        }
        private string _searchQuery = string.Empty;
        public string SearchQuery
        {
            get => _searchQuery;
            set
            {
                _searchQuery = value;
                OnPropertyChanged(nameof(SearchQuery));
                FilterStudents(); // Trigger filtering
            }
        }

        // Students list
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

        private void FilterStudents()
        {
            var students = _studentRepository.GetAllStudent().AsQueryable();

            if (SelectedProgram != null)
                students = students.Where(s => s.ProgramId == SelectedProgram.Id);

            if (SelectedLevel != null)
                students = students.Where(s => s.LevelId == SelectedLevel.Id);

            if (!string.IsNullOrWhiteSpace(SearchQuery))
            {
                string query = SearchQuery.ToLower();
                students = students.Where(s =>
                    (!string.IsNullOrEmpty(s.FirstName) && s.FirstName.ToLower().Contains(query)) ||
                    (!string.IsNullOrEmpty(s.LastName) && s.LastName.ToLower().Contains(query)) ||
                    (!string.IsNullOrEmpty(s.Email) && s.Email.ToLower().Contains(query)));
            }

            Students = new ObservableCollection<Student>(students.ToList());
        }



     public void AddStudent (Student student)
        {
            _studentRepository.AddStudent(student);
        }



        public string UpdateStudent(Student student)
        {
            if (string.IsNullOrWhiteSpace(student.FirstName) || string.IsNullOrWhiteSpace(student.LastName) || string.IsNullOrWhiteSpace(student.Email))
            {
                return "Error: All fields are required.";
            }

            var success = _studentRepository.UpdateStudent(student);
            return success ? "Student updated successfully." : "Error updating student.";
        }


        public string DeleteStudent(Student student)
        {
            if (student == null)
                return "Error: No student selected.";

            var success = _studentRepository.DeleteStudent(student);
            if (success)
            {
                Students.Remove(student); // Update UI
                return "Student deleted successfully.";
            }
            return "Error deleting student.";
        }


    }
}
