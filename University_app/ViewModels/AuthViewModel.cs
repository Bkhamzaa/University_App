using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using University_app.Data;
using University_app.Models;
using University_app.Views;

namespace University_app.ViewModels
{
    public class AuthViewModel : ViewModelBase
    {
        private readonly UserRepository _userRepository;
        public string UserRole { get; private set; } 

        private string _username = string.Empty;
        private string _password = string.Empty;
        public string Username
        {
            get => _username;
            set { _username = value; OnPropertyChanged(nameof(Username)); }
        }



        public AuthViewModel()
        {
            var context = new University_appDbContext();

            _userRepository = new UserRepository(context);
        }

        public void SetPassword(string password)
        {
            _password = password;
        }



        public User? Login()
        {
            var user = _userRepository.Authenticate(Username, _password);
            return user;
        }




    }
}
