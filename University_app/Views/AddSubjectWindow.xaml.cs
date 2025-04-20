using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using University_app.Models;

namespace University_app.Views
{
    public partial class AddSubjectWindow : Window
    {

        private readonly University_app.ViewModels.Subject_Management _subject_management = new();


        private List<Program_Univ> Programs = new();
        private List<Level> Levels = new();

        public AddSubjectWindow()
        {

            InitializeComponent();
            
            LoadMockData();
            ProgramComboBox.ItemsSource = Programs;

        }

        private void LoadMockData()
        {
            Programs = _subject_management.LoadPrograms();

        }

        private void ProgramComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ProgramComboBox.SelectedItem is Program_Univ selectedProgram)
            {
                Levels = _subject_management
                    .LoadLevels()
                    .Where(l => l.ProgramId == selectedProgram.Id)
                    .ToList();

                LevelComboBox.ItemsSource = Levels;
                LevelComboBox.SelectedIndex = -1;
            }
        }


        private void LevelComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (LevelComboBox.SelectedItem is Level selectedLevel) { }
            
        }


        // Handle when the text box gets focus


        // Handle when the text box loses focus


        // Helper method to find the corresponding watermark TextBlock for each TextBox

        // Handle the Save button click event
        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NameTextBox.Text) ||
       string.IsNullOrWhiteSpace(CoefficientTextBox.Text) ||
       string.IsNullOrWhiteSpace(SemesterTextBox.Text) ||
       LevelComboBox.SelectedItem == null ||
       ProgramComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            Level level = LevelComboBox.SelectedItem as Level;
                Subject subject = new Subject
                { Name = NameTextBox.Text,
                    Coefficient = double.Parse(CoefficientTextBox.Text, CultureInfo.InvariantCulture),
                    Semester = int.Parse(SemesterTextBox.Text),
                LevelId= level.Id


                };
            _subject_management.AddSubject(subject);
            this.DialogResult = true;
            this.Close();


        }
        // Handle saving logic here
    }
    }

