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
    /// Логика взаимодействия для ProfilStudentPage.xaml
    /// </summary>
    public partial class ProfilStudentPage : Page
    {
        public List<Journals> mass;
        public ProfilStudentPage(Students activeStudent)
        {
            InitializeComponent();
            // Информация о студенте 
            FIOTextBlock.Text = activeStudent.LastName + " " + activeStudent.FiestName + " " + activeStudent.PatronomicName;
            ProfesiaTextBlock.Text = activeStudent.Professions.NameProfession;
            GroupsTextBlock.Text = activeStudent.Groups.NameGroup;
            FormTrainingTextBlock.Text = activeStudent.FormTime.Name;
            YearTrainingTextBlock.Text = activeStudent.YearAdd.Year.ToString();
            //
            mass = activeStudent.Journals.ToList(); 
            DataGridJournals.ItemsSource = mass;
        }
    }
}
