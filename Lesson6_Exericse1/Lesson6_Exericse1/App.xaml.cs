using Lesson6_Exericse1.View_Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Lesson6_Exericse1
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            Lesson6_Exericse1.View.MainPage window = new Lesson6_Exericse1.View.MainPage();
            UserViewModel VM = new UserViewModel();
            window.DataContext = VM;
            window.Show();
        }
    }
}
