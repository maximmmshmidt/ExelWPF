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
using WpfApp1.Models;

namespace WpfApp1.Pages
{
    /// <summary>
    /// Логика взаимодействия для LogPage.xaml
    /// </summary>
    public partial class LogPage : Page
    {
        Core bd = new Core();
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
            try
            {

                //считаем количество записей в таблице с заданными параметрами (логин, пароль)
                Users users = bd.context.Users.Where(
                x => x.Login == login.Text && x.Password == password.Password
                ).FirstOrDefault();

                if (users == null)
                {
                    MessageBox.Show("Такой пользователь отсутствует!",
                    "Уведомление",
                    MessageBoxButton.OK,
                    MessageBoxImage.Information);

                }
                else

                {

                    switch (users.IdRole)
                    {

                        case 1:
                            this.NavigationService.Navigate(new HomePage());

                            break;
                        case 2:
                            this.NavigationService.Navigate(new StydentPage());

                            break;

                    }


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Критический сбор в работе приложения:" + ex.Message.ToString(),
                "Уведомление",
                MessageBoxButton.OK,
                MessageBoxImage.Warning);
            }
        }
    }
}
