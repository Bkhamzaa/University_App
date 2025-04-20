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
using System.Windows.Shapes;
using University_app.Models;

namespace University_app.Views
{
    /// <summary>
    /// Interaction logic for AddStudentWindow.xaml
    /// </summary>
    public partial class AddStudentWindow : Window
    {

        private readonly University_app.ViewModels.Subject_Management _subject_management = new();
        private readonly University_app.ViewModels.Student_Management _student_management = new();



        private List<Program_Univ> Programs = new();

        private List<Level> Levels = new();
        public AddStudentWindow()
        {
            InitializeComponent();
            //LoadMockData();
            ProgramComboBox.ItemsSource = _student_management.Programs;

        }

       

        private void ProgramComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ProgramComboBox.SelectedItem is Program_Univ selectedProgram)
            {
                //var test = ProgramComboBox.SelectedItem;
                _student_management.SelectedProgram = ProgramComboBox.SelectedItem as Program_Univ;
                LevelComboBox.ItemsSource = _student_management.Levels;
                LevelComboBox.SelectedIndex = -1;
            }
        }


        private void LevelComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           // if (LevelComboBox.SelectedItem is Level selectedLevel) { }

        }
        private void FirstNameTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }


        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {

            if (string.IsNullOrWhiteSpace(FirstNameTextBox.Text) || string.IsNullOrWhiteSpace(LastNameTextBox.Text )|| string.IsNullOrWhiteSpace(EmailTextBox.Text)  || LevelComboBox.SelectedItem == null ||
       ProgramComboBox.SelectedItem == null || string.IsNullOrWhiteSpace(CinIDTextBox.Text))
            {
                MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;


            }


            Level level = LevelComboBox.SelectedItem as Level;
            Program_Univ pro = ProgramComboBox.SelectedItem as Program_Univ;

            Student student = new() { 
            FirstName = FirstNameTextBox.Text, LastName = LastNameTextBox.Text, Email = EmailTextBox.Text,ProgramId= pro.Id,LevelId= level.Id
            ,Cin_id= CinIDTextBox.Text
            };

            _student_management.AddStudent(student);
            MessageBox.Show("Student ADD successfully.", "ADD", MessageBoxButton.OK, MessageBoxImage.Information);

            this.DialogResult = true;
            this.Close();












        }
    }
    }
