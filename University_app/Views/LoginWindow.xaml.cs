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
using University_app.ViewModels;

namespace University_app.Views
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        private readonly AuthViewModel _viewModel;
        public User? AuthenticatedUser { get; private set; }

        public LoginWindow()
        {
            InitializeComponent();
            _viewModel = new AuthViewModel();
            DataContext = _viewModel;
        }

        private void PasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            _viewModel.SetPassword(((PasswordBox)sender).Password);
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            var user = _viewModel.Login();

            if (user != null)
            {
                AuthenticatedUser = user;

                var mainWindow = new MainWindow(AuthenticatedUser.Role); 
                mainWindow.Show();

                this.Close(); 
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Authentication Failed", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}
