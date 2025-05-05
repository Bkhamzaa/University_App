using System.Configuration;
using System.Data;
using System.Windows;
using University_app.Views;

namespace University_app
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            var login = new LoginWindow();
            if (login.ShowDialog() == true)
            {
                Shutdown();
            }
           
        }

    }

}