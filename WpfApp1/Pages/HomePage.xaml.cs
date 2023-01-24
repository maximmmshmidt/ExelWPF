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

namespace WpfApp1.Pages
{
    /// <summary>
    /// Логика взаимодействия для HomePage.xaml
    /// </summary>
    public partial class HomePage : Page
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void ListStydentButtonClick(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new StydentPage());
        }

        private void AddStudentButtonClick(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new AddStudentPage());
        }

        private void AddOcenkaButtonClick(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new AddRatingPage());
        }

        private void EddingOcenkaButtonClick(object sender, RoutedEventArgs e)
        {

        }

        private void DeleteStydentButtonClick(object sender, RoutedEventArgs e)
        {

        }
    }
}
