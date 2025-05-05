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
    public class Subject_Management : ViewModelBase
    {
        private readonly LevelRepository _LevelRepository;
        private readonly ProgramRepository _ProgramRepository;
        /// <summary>
        private readonly SubjectRepository _SubjectRepository;
        /// </summary>


        public Subject_Management()
        {
            var context = new University_appDbContext(); // create context
            _LevelRepository = new LevelRepository(context); // pass it to repo
            _ProgramRepository = new ProgramRepository(context);
            _SubjectRepository = new SubjectRepository(context);
            Programs = new ObservableCollection<Program_Univ>(_ProgramRepository.GetAllProgram());

            Subjects = new ObservableCollection<Subject>();

            //Subjects = new ObservableCollection<Subject>(_SubjectRepository.GetAllSubject());

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
                FilterSubjects();  // Filter Subjects when selected program changes
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
                FilterSubjects();  
            }
        }


        public void LoadLevelsForProgram()
        {
            if (SelectedProgram == null) return;

            var levels = _LevelRepository.GetAllLevel()
                            .Where(l => l.ProgramId == SelectedProgram.Id)
                            .ToList();

            Levels = new ObservableCollection<Level>(levels);
            SelectedLevel = null;  // Reset the selected level when program changes
        }

        private void FilterSubjects()
        {
            var subjects = _SubjectRepository.GetAllSubject().AsQueryable();


         

            if (SelectedLevel != null) {
                subjects = subjects.Where(s => s.LevelId == SelectedLevel.Id);
            }

            Subjects = new ObservableCollection<Subject>(subjects.ToList());

        }








        public List<Level> LoadLevels()
        {
            return _LevelRepository.GetAllLevel();

        }
        public List<Program_Univ> LoadPrograms()
        {
            return _ProgramRepository.GetAllProgram();

        }

       // public List<Subject> LoadSubjects()
      //  {
            
           // return _SubjectRepository.GetAllSubject();

      //  }

        public string RemoveSubject(Subject subject)
        {
            if (subject == null)
                return "Error: No subject selected.";

            var success = _SubjectRepository.RemoveSubject(subject);
            if (success)
            {
                Subjects.Remove(subject); // Update UI
                return "Subject deleted successfully.";
            }
            return "Error deleting Subject.";
           


        }
        

        public string UpdateSubject(Subject subject)
        {

            if (string.IsNullOrWhiteSpace(subject.Name) || subject.Coefficient== null || subject.Semester == null)
            {
                return "Error: All fields are required.";
            }

            var success = _SubjectRepository.UpdateSubject(subject);

            return success ? "Subject updated successfully." : "Error updating subject.";

            //_SubjectRepository.UpdateSubject(subject);
        }

        public void AddSubject(Subject subject)
        {

           _SubjectRepository.AddSubject(subject);
        }

    }
}


