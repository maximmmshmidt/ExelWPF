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
    /// Логика взаимодействия для AddStudentPage.xaml
    /// </summary>
    public partial class AddStudentPage : Page
    {
        readonly Core bd = new Core();
        public AddStudentPage()
        {
            InitializeComponent();

            // Специальность
            SpecializationComboBox.ItemsSource = bd.context.Professions.ToList();
            SpecializationComboBox.DisplayMemberPath = "NameProfession";
            SpecializationComboBox.SelectedValuePath = "IdProfession";
            // Год постпуления
            YearOfAdmissionComboBox.ItemsSource = bd.context.YearAdd.ToList();
            YearOfAdmissionComboBox.DisplayMemberPath = "Year";
            YearOfAdmissionComboBox.SelectedValuePath = "idYear";
            // Форма Обучения
            FormOfTraining.ItemsSource = bd.context.FormTime.ToList();
            FormOfTraining.DisplayMemberPath = "Name";
            FormOfTraining.SelectedValuePath = "Id";
            // Группа
            NameGroupComboBox.ItemsSource = bd.context.Groups.ToList();
            NameGroupComboBox.DisplayMemberPath = "NameGroup";
            NameGroupComboBox.SelectedValuePath = "IdGroup";
        }

        private void AddStudentButton_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(FirstNTextBox.Text) && !string.IsNullOrEmpty(LastNTextBox.Text) && !string.IsNullOrEmpty(PatrNTextBox.Text))
            {
                if (SpecializationComboBox != null && YearOfAdmissionComboBox != null && FormOfTraining != null && NameGroupComboBox != null )
                {
                    try
                    {
                        int idProf = Convert.ToInt32(SpecializationComboBox.SelectedValue);
                        int idFromTime= Convert.ToInt32(FormOfTraining.SelectedValue);
                        int idYear= Convert.ToInt32(YearOfAdmissionComboBox.SelectedValue);
                        int idGroup = Convert.ToInt32(NameGroupComboBox.SelectedValue);
                        Students addstudents = new Students()
                        {
                            FiestName = FirstNTextBox.Text,
                            LastName = LastNTextBox.Text,
                            PatronomicName = PatrNTextBox.Text,
                            IdProfession = idProf,
                            IdFormTime = idFromTime,
                            IdGroup = idGroup,
                            IdYearAdd = idYear
                        };

                        bd.context.Students.Add(addstudents);
                        bd.context.SaveChanges();

                        MessageBox.Show("Добавление выполнено успешно !",
                        "Уведомление",
                        MessageBoxButton.OK,
                        MessageBoxImage.Information);


                    }
                    catch
                    {
                        MessageBox.Show("Критический сбор в работе приложения:", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Warning);
                    }
                }
            }
        }
    }
}
