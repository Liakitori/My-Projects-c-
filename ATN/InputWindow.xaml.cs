using Aspose.Cells;
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
using System.Windows.Shapes;
using static System.Collections.Specialized.BitVector32;

namespace ATN
{
    public partial class InputWindow : Window
    {
        public InputWindow()
        {
            InitializeComponent();
        }
        // Загрузить файл Excel
        static Workbook wb = new Workbook("C:\\Users\\m-dan\\Documents\\InfoATN.xlsx");
        // Получить рабочий лист, используя его индекс
        public Worksheet worksheet = wb.Worksheets[0];
        MoneyWindow moneyWindow = new MoneyWindow();
        int dump50to2000;
        int sum;

        public void count()
        {
            sum = Int32.Parse(TextBlock2000.Text.Replace("x ", "")) * 2000
                + Int32.Parse(TextBlock1000.Text.Replace("x ", "")) * 1000
                + Int32.Parse(TextBlock500.Text.Replace("x ", "")) * 500
                + Int32.Parse(TextBlock100.Text.Replace("x ", "")) * 100
                + Int32.Parse(TextBlock50.Text.Replace("x ", "")) * 50;
            TextBlockSum.Text = sum.ToString() + "р";
        }
        private void Balance2000(int n)
        {
            dump50to2000 = Int32.Parse(TextBlock2000.Text.Replace("x ", ""));
            if (n < 0)
            {
                if (dump50to2000 >= -n) dump50to2000 += n;
            }
            else dump50to2000 += n;
            TextBlock2000.Text = "x " + dump50to2000.ToString();
            count();
        }
        private void Balance1000(int n)
        {
            dump50to2000 = Int32.Parse(TextBlock1000.Text.Replace("x ", ""));
            if (n < 0)
            {
                if (dump50to2000 >= -n) dump50to2000 += n;
            }
            else dump50to2000 += n;
            TextBlock1000.Text = "x " + dump50to2000.ToString();
            count();
        }
        private void Balance500(int n)
        {
            dump50to2000 = Int32.Parse(TextBlock500.Text.Replace("x ", ""));
            if (n < 0)
            {
                if (dump50to2000 >= -n) dump50to2000 += n;
            }
            else dump50to2000 += n;
            TextBlock500.Text = "x " + dump50to2000.ToString();
            count();
        }
        private void Balance100(int n)
        {
            dump50to2000 = Int32.Parse(TextBlock100.Text.Replace("x ", ""));
            if (n < 0)
            {
                if (dump50to2000 >= -n) dump50to2000 += n;
            }
            else dump50to2000 += n;
            TextBlock100.Text = "x " + dump50to2000.ToString();
            count();
        }
        private void Balance50(int n)
        {
            dump50to2000 = Int32.Parse(TextBlock50.Text.Replace("x ", ""));
            if (n < 0)
            {
                if (dump50to2000 >= -n) dump50to2000 += n;
            }
            else dump50to2000 += n;
            TextBlock50.Text = "x " + dump50to2000.ToString();
            count();
        }

        private void Button2000min10(object sender, RoutedEventArgs e)
        {
            int n = -10;
            Balance2000(n);
        }

        private void Button1000min10(object sender, RoutedEventArgs e)
        {
            int n = -10;
            Balance1000(n);
        }

        private void Button500min10(object sender, RoutedEventArgs e)
        {
            int n = -10;
            Balance500(n);
        }

        private void Button100min10(object sender, RoutedEventArgs e)
        {
            int n = -10;
            Balance100(n);
        }

        private void Button50min10(object sender, RoutedEventArgs e)
        {
            int n = -10;
            Balance50(n);
        }

        private void Button2000min1(object sender, RoutedEventArgs e)
        {
            int n = -1;
            Balance2000(n);
        }

        private void Button1000min1(object sender, RoutedEventArgs e)
        {
            int n = -1;
            Balance1000(n);
        }

        private void Button500min1(object sender, RoutedEventArgs e)
        {
            int n = -1;
            Balance500(n);
        }

        private void Button100min1(object sender, RoutedEventArgs e)
        {
            int n = -1;
            Balance100(n);
        }

        private void Button50min1(object sender, RoutedEventArgs e)
        {
            int n = -1;
            Balance50(n);
        }

        private void Button2000plus1(object sender, RoutedEventArgs e)
        {
            int n = 1;
            Balance2000(n);
        }

        private void Button1000plus1(object sender, RoutedEventArgs e)
        {
            int n = 1;
            Balance1000(n);
        }

        private void Button500plus1(object sender, RoutedEventArgs e)
        {
            int n = 1;
            Balance500(n);
        }

        private void Button100plus1(object sender, RoutedEventArgs e)
        {
            int n = 1;
            Balance100(n);
        }

        private void Button50plus1(object sender, RoutedEventArgs e)
        {
            int n = 1;
            Balance50(n);
        }

        private void Button2000plus10(object sender, RoutedEventArgs e)
        {
            int n = 10;
            Balance2000(n);
        }

        private void Button1000plus10(object sender, RoutedEventArgs e)
        {
            int n = 10;
            Balance1000(n);
        }

        private void Button500plus10(object sender, RoutedEventArgs e)
        {
            int n = 10;
            Balance500(n);
        }

        private void Button100plus10(object sender, RoutedEventArgs e)
        {
            int n = 10;
            Balance100(n);
        }

        private void Button50plus10(object sender, RoutedEventArgs e)
        {
            int n = 10;
            Balance50(n);
        }

        private void Button_Back_Click(object sender, RoutedEventArgs e)
        {
            {
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                Hide();
            }
        }

        private void Button_Continue_Click(object sender, RoutedEventArgs e)
        {
            count();
            worksheet.Cells[moneyWindow.sum_cell.Row, moneyWindow.sum_cell.Column].PutValue(moneyWindow.sum_cell.IntValue + sum);
        }
    }
}
