using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WpfApp1.Models;
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
                        throw new Exception("Критический сбор в работе приложения:");
                    }
                }
                else
                {
                    throw new Exception("Критический сбор в работе приложения:");
                }
            }
            else
            {
                throw new Exception("Критический сбор в работе приложения:");
            }
        }
    }
}
