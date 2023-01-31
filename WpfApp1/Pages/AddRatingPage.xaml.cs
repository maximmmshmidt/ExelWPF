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
using WpfApp1.Controlers;

namespace WpfApp1.Pages
{
    /// <summary>
    /// Логика взаимодействия для AddRatingPage.xaml
    /// </summary>
    public partial class AddRatingPage : Page
    {
        readonly Core bd = new Core();
        public int i = 0;
        List<Students> arrStudents;
        public AddRatingPage()
        {
            
            InitializeComponent();
            // Группа
            NameGrooupComboBox.ItemsSource = bd.context.Groups.ToList();
            NameGrooupComboBox.DisplayMemberPath = "NameGroup";
            NameGrooupComboBox.SelectedValuePath = "IdGroup";
            // Студент
            arrStudents=bd.context.Students.ToList();
            StudentComboBox.DisplayMemberPath = "FiestName";
            StudentComboBox.SelectedValuePath = "IdStudent";
            // Дисциплина
            DisciplineComboBox.ItemsSource = bd.context.Subjects.ToList();
            DisciplineComboBox.DisplayMemberPath = "NameSubject";
            DisciplineComboBox.SelectedValuePath = "IdSubject";

            
        }

        private void OneButton_Click(object sender, RoutedEventArgs e)
        {
            i = 0;
            i ++;
            OneButton.Background=Brushes.Green;
            TwoButton.Background = Brushes.Red;
            TreeButton.Background = Brushes.Red;
            ForButton.Background = Brushes.Red;
            FiveButton.Background = Brushes.Red;
        }

        private void TwoButton_Click(object sender, RoutedEventArgs e)
        {
            i = 0;
            i += 2;
            OneButton.Background = Brushes.Red;
            TwoButton.Background = Brushes.Green;
            TreeButton.Background = Brushes.Red;
            ForButton.Background = Brushes.Red;
            FiveButton.Background = Brushes.Red;
        }

        private void TreeButton_Click(object sender, RoutedEventArgs e)
        {
            i = 0;
            i += 3;
            OneButton.Background = Brushes.Red;
            TwoButton.Background = Brushes.Red;
            TreeButton.Background = Brushes.Green;
            ForButton.Background = Brushes.Red;
            FiveButton.Background = Brushes.Red;
        }

        private void ForButton_Click(object sender, RoutedEventArgs e)
        {
            i = 0;
            i += 4;
            OneButton.Background = Brushes.Red;
            TwoButton.Background = Brushes.Red;
            TreeButton.Background = Brushes.Red;
            ForButton.Background = Brushes.Green;
            FiveButton.Background = Brushes.Red;
        }

        private void FiveButton_Click(object sender, RoutedEventArgs e)
        {
            i = 0;
            i += 5;
            OneButton.Background = Brushes.Red;
            TwoButton.Background = Brushes.Red;
            TreeButton.Background = Brushes.Red;
            ForButton.Background = Brushes.Red;
            FiveButton.Background = Brushes.Green;
        }
        private void AddRatingButtonClick(object sender, RoutedEventArgs e)
        {
            JournalsControlers.AddRating(Convert.ToInt32(DisciplineComboBox.SelectedValue), Convert.ToInt32(StudentComboBox.SelectedValue), Convert.ToInt32(NameGrooupComboBox.SelectedValue), i);
        }

        private void NameGrooupComboBoxSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int idGroup= Convert.ToInt32(NameGrooupComboBox.SelectedValue);
            arrStudents = bd.context.Students.ToList();
            arrStudents = arrStudents.Where(x=>x.IdGroup==idGroup).ToList();
            StudentComboBox.ItemsSource = arrStudents;
            if (arrStudents.Count()>0)
            {
               StudentComboBox.IsEnabled = true;
            }
            else
            {  
                StudentComboBox.IsEnabled = false;
               
            }
        }
    }
}
