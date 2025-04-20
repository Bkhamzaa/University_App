using System;
using System.Collections.Generic;
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
        private readonly SubjectRepository _SubjectRepository;


        public Subject_Management()
        {
            var context = new University_appDbContext(); // create context
            _LevelRepository = new LevelRepository(context); // pass it to repo
            _ProgramRepository = new ProgramRepository(context);
            _SubjectRepository = new SubjectRepository(context);
        }

        public List<Level> LoadLevels()
        {
            return _LevelRepository.GetAllLevel();

        }
        public List<Program_Univ> LoadPrograms()
        {
            return _ProgramRepository.GetAllProgram();

        }

        public List<Subject> LoadSubjects()
        {
            
            return _SubjectRepository.GetAllSubject();

        }

        public void RemoveSubject(Subject subject)
        {

            _SubjectRepository.RemoveSubject(subject);


        }
        public void UpdateSubject(Subject subject)
        {
            _SubjectRepository.UpdateSubject(subject);
        }

        public void AddSubject(Subject subject)
        {

            _SubjectRepository.AddSubject(subject);
        }

    }
}


