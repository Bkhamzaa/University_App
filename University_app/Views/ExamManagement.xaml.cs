using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Formats.Asn1;
using System.Globalization;
using System.IO;
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
    /// Interaction logic for ExamManagement.xaml
    /// </summary>
    public partial class ExamManagement : UserControl
    {
        public ExamManagement()
        {
            InitializeComponent();
          
           


        }
        private void ImportCsvButton_Click(object sender, RoutedEventArgs e)
        {
            var openFileDialog = new OpenFileDialog
            {
                Filter = "CSV files (*.csv)|*.csv",
                Title = "Select a CSV File"
            };

            if (openFileDialog.ShowDialog() == true)
            {
                var viewModel = DataContext as University_app.ViewModels.ExamManagement;
                 viewModel?.ImportExamFromCsv(openFileDialog.FileName);
            }
        }

        private void SubjectComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void SubjectComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ExamDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            if (DataContext is University_app.ViewModels.ExamManagement vm)
            {
                vm.SelectedExams = new ObservableCollection<StudentExamDTO>(ExamDataGrid.SelectedItems.Cast<StudentExamDTO>());
            }
        }

        private void SendEmailButton_Click(object sender, RoutedEventArgs e)
        {

            var vm = DataContext as University_app.ViewModels.ExamManagement;
            if (vm != null)
            {
                // Send selected items
                vm.SendExamEmail(vm.SelectedExams.Any() ? vm.SelectedExams : new[] { vm.SelectedExam! });
            }
        }


    }
}
