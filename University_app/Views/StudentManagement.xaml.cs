using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using University_app.Models;
using University_app.ViewModels;

namespace University_app.Views
{
    /// <summary>
    /// Interaction logic for StudentManagement.xaml
    /// </summary>
    public partial class StudentManagement : UserControl
    {
       
        public StudentManagement()
        {
            InitializeComponent();
            this.DataContext = new Student_Management();


        }


     

        private void ProgramComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }


        private void LevelComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void AddStudentButton_Click(object sender, RoutedEventArgs e)
        {
            AddStudentWindow addStudentWindow = new AddStudentWindow();
            addStudentWindow.ShowDialog(); 

        }

        private void UpdateStudentButton_Click(object sender, RoutedEventArgs e)
        {
            if (StudentDataGrid.SelectedItem is Student selectedStudent)
            {
                var viewModel = DataContext as Student_Management;
                var message = viewModel?.UpdateStudent(selectedStudent);
                MessageBox.Show(message);
            }
            else
            {
                MessageBox.Show("Please select a student to update.");
            }
        }

        private void DeleteStudentButton_Click(object sender, RoutedEventArgs e)
        {
            if (StudentDataGrid.SelectedItem is Student selectedStudent)
            {
                var result = MessageBox.Show($"Are you sure you want to delete {selectedStudent.FirstName} {selectedStudent.LastName}?",
                                             "Confirm Delete",
                                             MessageBoxButton.YesNo,
                                             MessageBoxImage.Warning);

                if (result == MessageBoxResult.Yes)
                {
                    var viewModel = DataContext as Student_Management;
                    var message = viewModel?.DeleteStudent(selectedStudent);
                    MessageBox.Show(message);
                }
            }
            else
            {
                MessageBox.Show("Please select a student to delete.");
            }
        }


    }
}
