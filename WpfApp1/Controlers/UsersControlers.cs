using System;
using System.Windows;
using WpfApp1.Models;
using System.Linq;
using WpfApp1.Pages;

namespace WpfApp1.Controlers
{
    public class UsersControlers
    {
        readonly static Core bd = new Core();
        public static bool Registrration(string login, string password, string passwordTwo)
        {
            if (!string.IsNullOrEmpty(login))
            {
                if (!string.IsNullOrEmpty(password) & !string.IsNullOrEmpty(passwordTwo))
                {
                    if (password == passwordTwo)
                    {
                        Users users = new Users()
                        {
                            Login = login,
                            Password = password

                        };

                        bd.context.Users.Add(users);
                        bd.context.SaveChanges();

                        MessageBox.Show("Добавление выполнено успешно !",
                        "Уведомление",
                        MessageBoxButton.OK,
                        MessageBoxImage.Information);
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        public static bool LogUsers(string login, string password )
        {
            try
            {

                //считаем количество записей в таблице с заданными параметрами (логин, пароль)
                Users users = bd.context.Users.Where(
                x => x.Login == login. && x.Password == password
                ).FirstOrDefault();

                if (users == null)
                {
                    MessageBox.Show("Такой пользователь отсутствует!",
                    "Уведомление",
                    MessageBoxButton.OK,
                    MessageBoxImage.Information);
                    return false;
                }
                else
                {

                    switch (users.IdRole)
                    {

                        case 1:
                            this.NavigationService.Navigate(new HomePage());
                            
                            break;
                        case 2:
                            this.NavigationService.Navigate(new LogPage());
                            ;
                            break;
                            
                    }

                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Критический сбор в работе приложения:" + ex.Message.ToString(),
                "Уведомление",
                MessageBoxButton.OK,
                MessageBoxImage.Warning);
                return false;
            }
        }
    }
}
