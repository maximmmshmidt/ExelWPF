using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using WpfApp1.Models;
using Word = Microsoft.Office.Interop.Word;

namespace WpfApp1.Pages
{
    /// <summary>
    /// Логика взаимодействия для ProfilStudentPage.xaml
    /// </summary>
    public partial class ProfilStudentPage : Page
    {
        public List<Journals> mass;
        Students currentStudent;
        public ProfilStudentPage(Students activeStudent)
        {
            InitializeComponent();
            // Информация о студенте 
            FIOTextBlock.Text = activeStudent.FiestName + " " + activeStudent.LastName + " " + activeStudent.PatronomicName;
            ProfesiaTextBlock.Text = activeStudent.Professions.NameProfession;
            GroupsTextBlock.Text = activeStudent.Groups.NameGroup;
            FormTrainingTextBlock.Text = activeStudent.FormTime.Name;
            YearTrainingTextBlock.Text = activeStudent.YearAdd.Year.ToString();
            currentStudent = activeStudent;
            mass = activeStudent.Journals.ToList(); 
            DataGridJournals.ItemsSource = mass;
        }
        private void DiplomButtonClick(object sender, RoutedEventArgs e)
        {
            Word.Application application = new Word.Application();
            string file = $"{Directory.GetCurrentDirectory()}\\Docs\\Диплом.doc";
            if (File.Exists(file))
            {
                Word.Document doc = application.Documents.Open(file);
                doc.Activate();
                doc.Bookmarks["FIO"].Range.Text = FIOTextBlock.Text;
                doc.Bookmarks["Profession"].Range.Text = ProfesiaTextBlock.Text;
                application.Visible = true;
                doc.SaveAs($"{Directory.GetCurrentDirectory()}\\Docs\\{currentStudent.FiestName}Диплом.doc");
            }
        }
    }
}
