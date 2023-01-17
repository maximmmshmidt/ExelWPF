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
using Exel = Microsoft.Office.Interop.Excel;

namespace WpfApp1.Pages
{
   
    public partial class StydentPage : Page
    {
        readonly Core db = new Core();
        public StydentPage()
        {
            InitializeComponent();
            DataGridStydent.ItemsSource = db.context.Students.ToList();
        }
        private void VivodButtonClick(object sender, RoutedEventArgs e)
        {
            List<ИмяТаблицы> имяМассива;

            /*создаем файл Excel*/

            var aplication = new Excel.Application();

            aplication.Visible = true;

            /*количество листов*/

            aplication.SheetsInNewWorkbook = 1;

            /*добавляем рабочую книгу*/

            Excel.Workbook workbook = aplication.Workbooks.Add(Type.Missing);

            /*создаем лист*/

            Excel.Worksheet worksheet = workbook.ActiveSheet;

            worksheet.Name = "ИмяЛиста"; //имя листа нужно вводить латинскими буквами

            /*заголовки вывод в Excel (в первую строку)*/

            worksheet.Cells[1][1] = "Заголовок1";

            worksheet.Cells[2][1] = "Заголовок2";

            ...

                /*вывод данных из массива в Excel*/

                int rowIndex = 2;  //номер строки для вывода данных из массива

            foreach (var item in имяМассива)

            {

                worksheet.Cells[1][rowIndex] = item.ИмяПоля;

                worksheet.Cells[2][rowIndex] = item.ИмяПоля;

                .....

                    rowIndex++;

            }
        }
    }
}
