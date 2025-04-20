using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using University_app.Data;
using University_app.Models;
using University_app.ViewModels;

namespace University_app.Views
{
    public partial class Subject_Management : UserControl
    {
        //private readonly University_app.ViewModels.Subject_Management _subject_management = new();


        //private List<Program_Univ> Programs = new();
       // private List<Level> Levels = new();
        //private List<Subject> Subjects = new();
       // private Subject _selectedSubject;


        public Subject_Management()
        {
            InitializeComponent();
          //  LoadMockData();
           // ProgramComboBox.ItemsSource = Programs;
           /// RefreshSubjectsGrid();
        }



        private void LoadMockData()
        {
          //  Programs = _subject_management.LoadPrograms();

           // Subjects = _subject_management.LoadSubjects();
        }

        private void ProgramComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           // if (ProgramComboBox.SelectedItem is Program_Univ selectedProgram)
           // {
             //   Levels = _subject_management
                  //  .LoadLevels()
                 //   .Where(l => l.ProgramId == selectedProgram.Id)
                   // .ToList();

              //  LevelComboBox.ItemsSource = Levels;
               // LevelComboBox.SelectedIndex = -1;
               // SubjectsDataGrid.ItemsSource = null;
           // }
        }

        private void LevelComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //if (LevelComboBox.SelectedItem is Level selectedLevel)
           // {
             //   var levelSubjects = Subjects.Where(s => s.LevelId == selectedLevel.Id).ToList();
              //  SubjectsDataGrid.ItemsSource = levelSubjects;
           // }
        }

        private void SubjectsDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           // _selectedSubject = SubjectsDataGrid.SelectedItem as Subject;
        }

        private void AddUpdateSubjectButton_Click(object sender, RoutedEventArgs e)
        {
            var subjectFormWindow = new AddSubjectWindow();
              subjectFormWindow.ShowDialog();

          
        }
     
        private void UpdateSubjectButton_Click(object sender, RoutedEventArgs e)
        {
            if (SubjectsDataGrid.SelectedItem is Subject selectedSubject)
            {
                var viewModel = DataContext as ViewModels.Subject_Management;
                var message = viewModel?.UpdateSubject(selectedSubject);
                MessageBox.Show(message);
            }
            else
            {
                MessageBox.Show("Please select a student to update.");
            }


            //if (SubjectsDataGrid.SelectedItem is  Subject) { 
            //    if (_selectedSubject.Name.IsNullOrEmpty() || _selectedSubject.Semester < 0 || _selectedSubject.Coefficient < 0)
            //{

            //    MessageBox.Show("There are fields that are not completed.", "Update", MessageBoxButton.OK, MessageBoxImage.Error);

            //}
            //else
            //{
            //    _subject_management.UpdateSubject(_selectedSubject);

            //    MessageBox.Show("Subjects updated successfully!", "Update", MessageBoxButton.OK, MessageBoxImage.Information);

            //}

            //RefreshSubjectsGrid();

            //}
        }
        private void DeleteSubjectButton_Click(object sender, RoutedEventArgs e)
        {

            if (SubjectsDataGrid.SelectedItem is Subject selectedSubject)
            {
                var result = MessageBox.Show($"Are you sure you want to delete {selectedSubject.Name} ?",
                                             "Confirm Delete",
                                             MessageBoxButton.YesNo,
                                             MessageBoxImage.Warning);

                if (result == MessageBoxResult.Yes)
                {
                    var viewModel = DataContext as ViewModels.Subject_Management;
                    var message = viewModel?.RemoveSubject(selectedSubject);
                    MessageBox.Show(message);
                }
            }
            else
            {
                MessageBox.Show("Please select a student to delete.");
            }


            //if (_selectedSubject == null)
            //{
            //    MessageBox.Show("Please select a subject to delete.", "Delete Subject", MessageBoxButton.OK, MessageBoxImage.Warning);
            //    return;
            //}

            //var result = MessageBox.Show($"Are you sure you want to delete the subject \"{_selectedSubject.Name}\"?",
            //                             "Confirm Delete",
            //                             MessageBoxButton.YesNo,
            //                             MessageBoxImage.Question);

            //if (result == MessageBoxResult.Yes)
            //{
            //    _subject_management.RemoveSubject(_selectedSubject);
            //    _selectedSubject = null;
            //    RefreshSubjectsGrid();
            //    MessageBox.Show("Subject deleted successfully.", "Deleted", MessageBoxButton.OK, MessageBoxImage.Information);
            //}
        }

        private void RefreshSubjectsGrid()
        {
          //  if (LevelComboBox.SelectedItem is Level selectedLevel)
           // {
              //  var levelSubjects = _subject_management.LoadSubjects().Where(s => s.LevelId == selectedLevel.Id).ToList();
              //  SubjectsDataGrid.ItemsSource = null;
              //  SubjectsDataGrid.ItemsSource = levelSubjects;
          //  }
        }
        private void StudentManagementButton_Click(object sender, RoutedEventArgs e)
        {
            // TODO: Navigate to Student Management view
            MessageBox.Show("Navigating to Student Management...");
        }

        private void DashboardButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Navigating to Dashboard...");
        }

        private void SubjectManagementButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Already in Subject Management.");
        }

        private void ExamManagementButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Navigating to Exam Management...");
        }

    }


}




