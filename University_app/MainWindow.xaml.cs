using System;
using System.Text;
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
using University_app.Views;

namespace University_app
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {
        public static MainWindow Instance { get; private set; }

        public MainWindow()
        {
            InitializeComponent();
            Instance = this;

            MainContentControl.Content = new Dashboard();

        }
        private void DashboardButton_Click(object sender, RoutedEventArgs e)
        {
            MainContentControl.Content = new Views.Dashboard();
        }

        private void SubjectManagementButton_Click(object sender, RoutedEventArgs e)
        {
            MainContentControl.Content = new Views.Subject_Management();
        }

        private void StudentManagementButton_Click(object sender, RoutedEventArgs e)
        {
            MainContentControl.Content = new Views.StudentManagement();
        }

        private void ExamManagementButton_Click(object sender, RoutedEventArgs e)
        {
           MainContentControl.Content = new Views.ExamManagement();
        }
        private void ImportStudentButton_Click(object sender, RoutedEventArgs e)
        {
            
        }




    }
}