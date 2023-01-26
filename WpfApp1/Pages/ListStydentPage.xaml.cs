using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using WpfApp1.Models;
using Excel = Microsoft.Office.Interop.Excel;
using Word = Microsoft.Office.Interop.Word;

namespace WpfApp1.Pages
{
   
    public partial class StydentPage : Page
    {
        readonly Core db = new Core();
        public List<Students> mass;
        public StydentPage()
        {
            InitializeComponent();
            mass = db.context.Students.ToList();
            DataGridStydent.ItemsSource = mass;
            var arrGroups = new List<Groups>
                {
                    new Groups()
                    {
                        IdGroup = 0,
                        NameGroup = "Все группы"
                    }
                };
            arrGroups.AddRange(db.context.Groups.ToList());

            GrupsComboBox.ItemsSource = arrGroups;
           
           GrupsComboBox.DisplayMemberPath= "NameGroup";
           GrupsComboBox.SelectedValuePath = "IdGroup";

            //фильтрация

            

        }
       
        private void VivodButtonClick(object sender, RoutedEventArgs e)
        {
            /*создаем файл Excel*/

            var aplication = new Excel.Application
            {
                Visible = true,

                /*количество листов*/

                SheetsInNewWorkbook = 1
            };

            /*добавляем рабочую книгу*/

            Excel.Workbook workbook = aplication.Workbooks.Add(Type.Missing);

            /*создаем лист*/

            Excel.Worksheet worksheet = workbook.ActiveSheet;

            worksheet.Name = "Student"; //имя листа нужно вводить латинскими буквами

            /*заголовки вывод в Excel (в первую строку)*/

            worksheet.Cells[1][1] = "№ ";
            worksheet.Cells[2][1] = "Фамилиия";
            worksheet.Cells[3][1] = "Имя";
            worksheet.Cells[4][1] = "Отчество";
            worksheet.Cells[5][1] = "Профессия";
            worksheet.Cells[6][1] = "Группа";
            worksheet.Cells[7][1] = "Форма Обучения";
            worksheet.Cells[8][1] = "Год поступления";

            worksheet.Cells[8][1].font.bold = true;
            worksheet.Cells[7][1].font.bold = true;
            worksheet.Cells[6][1].font.bold = true;
            worksheet.Cells[5][1].font.bold = true;
            worksheet.Cells[4][1].font.bold = true;
            worksheet.Cells[3][1].font.bold = true;
            worksheet.Cells[2][1].font.bold = true;
            worksheet.Cells[1][1].font.bold = true;

            /*вывод данных из массива в Excel*/

            int rowIndex = 2;  //номер строки для вывода данных из массива

            foreach (var item in mass)
            {
                if (true)
                {
                    worksheet.Cells[1][rowIndex] = rowIndex-1;
                    worksheet.Cells[2][rowIndex] = item.FiestName;
                    worksheet.Cells[3][rowIndex] = item.LastName;
                    worksheet.Cells[4][rowIndex] = item.PatronomicName;
                    worksheet.Cells[5][rowIndex] = item.Professions.NameProfession;
                    worksheet.Cells[6][rowIndex] = item.Groups.NameGroup;
                    worksheet.Cells[7][rowIndex] = item.FormTime.Name;
                    worksheet.Cells[8][rowIndex] = item.YearAdd.Year;
                    rowIndex++;
                    worksheet.Columns.AutoFit();
                }
            }
        }

        private void VivodWordButtonClick(object sender, RoutedEventArgs e)
        {
            
            // открытие
             Word.Application application = new Word.Application();
            //создание
             Word.Document document = application.Documents.Add();
            //визуализация
             application.Visible = true;
            // 1 строка
             Word.Paragraph titleParagraph = document.Paragraphs.Add();
             Word.Range titleRange = titleParagraph.Range;
            
            titleRange.Text = "МИНИСТЕРСТВО ОБРАЗОВАНИЯ И МОЛОДЕЖНОЙ ПОЛИТИКИ СВЕРДЛОВСКОЙ ОБЛАСТИ";
            titleRange.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
            //перенос строки
            titleRange.InsertParagraphAfter();
            // 2 строка

             titleRange = titleParagraph.Range;
             titleRange.Text = "ГОСУДАРСТВЕННОЕ АВТОНОМНОЕ ПРОФЕССИОНАЛЬНОЕ ОБРАЗОВАТЕЛЬНОЕ УЧРЕЖДЕНИЕ";
            titleRange.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
            titleRange.InsertParagraphAfter();
            // 3 строка

            titleRange = titleParagraph.Range;
             titleRange.Text = "СВЕРДЛОВСКОЙ ОБЛАСТИ";
            titleRange.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
            titleRange.InsertParagraphAfter();
            // 4 строка

            titleRange = titleParagraph.Range;
             titleRange.Text = "«ЕКАТЕРИНБУРГСКИЙ МОНТАЖНЫЙ КОЛЛЕДЖ»";
            titleRange.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
            titleRange.InsertParagraphAfter();
            //перенос строки
            
            // 5 строка

             titleRange = titleParagraph.Range;
             titleRange.Text = "ВЕДОМОСТЬ итоговой аттестации";
            titleRange.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
            titleRange.InsertParagraphAfter();

            //6 строка таблица

            Word.Paragraph tableParagraph = document.Paragraphs.Add();
            Word.Range tableRange = tableParagraph.Range;
            application.Visible = true;
            Word.Table titleTable = document.Tables.Add(tableRange, 1, 3);
            Word.Range cellRange;
            cellRange = titleTable.Cell(1, 1).Range;
            cellRange.Text = "«_____» _________ 20_____ Г.";
            cellRange = titleTable.Cell(1, 3).Range;
            cellRange.Text = "№__________________________";
            application.Visible = true;


            //7 строка
            titleRange = titleParagraph.Range;
             titleRange.Text = "Группа №: ";
            titleRange.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;
            titleRange.InsertParagraphAfter();


            //8 строка
            titleRange = titleParagraph.Range;
            titleRange.Text = "Преподаватель:";
            titleRange.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;
            titleRange.InsertParagraphAfter();

            //9 строка таблица

            Word.Paragraph tableParagraph1 = document.Paragraphs.Add();
            Word.Range studentRange = tableParagraph1.Range;
            Word.Table studentTable = document.Tables.Add(studentRange, mass.Count()+1, 3);
            studentTable.Rows[1].Range.Bold = 1;
            studentTable.Borders.InsideLineStyle = studentTable.Borders.OutsideLineStyle = Word.WdLineStyle.wdLineStyleSingle;
            Word.Range cellStudent;

            //9.1.1
            cellStudent = studentTable.Cell(1, 1).Range;
            cellStudent.Text = "№ п/п";
            //9.1.2
            cellStudent = studentTable.Cell(1, 2).Range;
            cellStudent.Text = "Фамилия, имя, отчество слушателя";
            //9.1.3
            cellStudent = studentTable.Cell(1, 3).Range;
            cellStudent.Text = "Результат аттестации";
            int rowIndex = 1;
            foreach (var item in mass)
            {
                if (true)
                {
                    cellStudent = studentTable.Cell(rowIndex+1, 2).Range;
                    cellStudent.Text = $"{item.FiestName} {item.LastName} {item.PatronomicName}";

                    cellStudent = studentTable.Cell(rowIndex+1 , 1).Range;
                    cellStudent.Text = $"{rowIndex}";

                    rowIndex++;
                    studentTable.Columns.AutoFit();
                }
            }




            application.Visible = true;
            //сохранение
            document.SaveAs2($"{Directory.GetCurrentDirectory()}\\Docs\\test.docx");
            document.SaveAs2($"{Directory.GetCurrentDirectory()}\\Docs\\test.docx", Word.WdExportFormat.wdExportFormatPDF);
        }
        private void GrupsComboBoxSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int idGroups = Convert.ToInt32(GrupsComboBox.SelectedValue);
            if (GrupsComboBox.SelectedIndex == 0)
            {
                mass = db.context.Students.ToList();
            }
            else
            {
                mass = db.context.Students.Where(x => x.IdGroup == idGroups).ToList();
            }
            DataGridStydent.ItemsSource = mass;
        }
        private void ProfilButtonClick(object sender, RoutedEventArgs e)
        {
            //Students activeStudent = ((Button)sender).DataContext as Students;
            Button activeButton =sender as Button;
            Students activeStudent = activeButton.DataContext as Students;
            if (activeStudent != null)
            {
                this.NavigationService.Navigate(new ProfilStudentPage(activeStudent));
            }
        }
    }
}

