using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using WpfApp1.Models;
using Excel = Microsoft.Office.Interop.Excel;

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
            DataGridStydent.ItemsSource = db.context.Students.ToList();
            GrupsComboBox.ItemsSource = db.context.Groups.ToList();
            GrupsComboBox.DisplayMemberPath= "NameGroup";
           
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

            worksheet.Cells[1][1] = "Id студента";
            worksheet.Cells[2][1] = "Фамилиия";
            worksheet.Cells[3][1] = "Имя";
            worksheet.Cells[4][1] = "Отчество";
            worksheet.Cells[5][1] = "Профессия";
            worksheet.Cells[6][1] = "Группа";
            worksheet.Cells[7][1] = "Форма Обучения";
            worksheet.Cells[8][1] = "Год поступления";
            worksheet.Cells[1][1].font.bold = true;

            /*вывод данных из массива в Excel*/

            int rowIndex = 2;  //номер строки для вывода данных из массива

            foreach (var item in mass)

            {
                worksheet.Cells[1][rowIndex] = item.IdStudent;
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
}
