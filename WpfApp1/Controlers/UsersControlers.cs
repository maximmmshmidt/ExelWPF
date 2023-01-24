using System;
using System.Windows;
using WpfApp1.Models;

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
        public static bool AddRating(string discipline, string student, string nameGroup, int ocenka)
        {
            
            if (!string.IsNullOrEmpty(discipline) && !string.IsNullOrEmpty(student) && !string.IsNullOrEmpty(nameGroup))
            {
                if (ocenka != 0)
                {
                    //Students addstudents = new Students()
                    //{

                    //};
                    //bd.context.Students.Add(addstudents);
                    //bd.context.SaveChanges();
                    MessageBox.Show("Оценка добавлена");
                }
                else
                {
                    MessageBox.Show("Выберите оценку");
                }
            }
            else
            {
                MessageBox.Show("Заполните все поля");
            }
            return false;
        }
    }
}
