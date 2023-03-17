using Aspose.Cells;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
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
using static System.Collections.Specialized.BitVector32;

namespace ATN
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // Загрузить файл Excel
        public  Workbook wb = new Workbook("C:\\Users\\m-dan\\Documents\\InfoATN.xlsx");
        // Получить рабочий лист, используя его индекс
        public Worksheet worksheet = wb.Worksheets[0];

        public static int N = 1000; public int[,] notes = { { 2000, N }, { 1000, N }, { 500, N }, { 100, N }, { 50, N } };


        private void Button_Want_Click(object sender, RoutedEventArgs e)
        {
            if (Button_Want.Content.ToString() == "Хочу")
            {
                Button_Want.Content = "Ну и хачи";
                Button_Want.FontSize = 14;
            }
            else if (Button_Want.Content.ToString() == "Ну и хачи")
            {
                Button_Want.Content = "Перехочешь";
            }
            else if (Button_Want.Content.ToString() == "Перехочешь")
            {
                Button_Want.Content = "Ниче не дадим";
            }
            else Button_Want.Content = "Вали отсюда";
        }

        private void Button_Money_Click(object sender, RoutedEventArgs e)
        {
            MoneyWindow moneyWindow = new MoneyWindow();
            moneyWindow.Action = "Снять";
            moneyWindow.Show();
            Hide();
        }

        private void Button_Card_Click(object sender, RoutedEventArgs e)
        {
            MoneyWindow moneyWindow = new MoneyWindow();
            moneyWindow.Action = "Внести";
            moneyWindow.Show();
            Hide();
        }

        private void Button_Mail_Click(object sender, RoutedEventArgs e)
        {
            MoneyWindow moneyWindow = new MoneyWindow();
            moneyWindow.Action = "Перевести";
            moneyWindow.Show();
            Hide();
        }

        private void Button_Computer_Click(object sender, RoutedEventArgs e)
        {
            MoneyWindow moneyWindow = new MoneyWindow();
            moneyWindow.Action = "Оплатить";
            moneyWindow.Show();
            Hide();
        }
        
        private void Create_User()
        {
            User[] user_mass = new User[25];
            for (int i = 0; i < user_mass.Length; i++)
            {
                Cell card_cell = worksheet.Cells[0, 1];
                user_mass[i].card = "";
            }
            
        }
        
    }
}
