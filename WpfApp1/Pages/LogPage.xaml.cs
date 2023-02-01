using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using WpfApp1.Models;
using WpfApp1.Controlers;

namespace WpfApp1.Pages
{
    /// <summary>
    /// Логика взаимодействия для LogPage.xaml
    /// </summary>
    public partial class LogPage : Page
    {
        readonly Core bd = new Core();
        public LogPage()
        {
            InitializeComponent();
        }

        private void reign_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new RegPage());
        }

        private void LogUserButtonClick(object sender, RoutedEventArgs e)
        {
            UsersControlers.LogUsers();
        }
    }
}
