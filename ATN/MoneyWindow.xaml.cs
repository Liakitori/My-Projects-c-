using Aspose.Cells;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
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
    public partial class MoneyWindow : Window
    {
        
        public MoneyWindow()
        {
            InitializeComponent();
        }

        private MainWindow mainWindow = new MainWindow();

        private string move = "card_number";
        public string card_number;
        private string pincode = "";
        private string sum = "";
        private string dump_txt;
        private int sumint;
        public Cell id_cell, card_cell, pin_cell, name_cell, sum_cell, operation1_cell, operation2_cell, operation3_cell;

        public string Action { get; internal set; }

        void Number_Button_Click(string n)
        {
            if (move == "card_number")
            {
                dump_txt = myTextBlock.Text;
                if (myTextBlock.Text == "Введите номер карты") myTextBlock.Text = n;
                else if (myTextBlock.Text == "Такой карты не существует. Попробуйте снова") myTextBlock.Text = n;
                else if (dump_txt.Length == 4 | dump_txt.Length == 9 | dump_txt.Length == 14) myTextBlock.Text += $" {n}";
                else if (dump_txt.Length >= 19) myTextBlock.Text += "";
                else myTextBlock.Text += n;
                card_number = myTextBlock.Text;
            }
            else if (move == "pincode")
            {
                dump_txt = myTextBlock.Text;
                if (myTextBlock.Text == "Введите пинкод" |
                    myTextBlock.Text == "Пинкод введен неверно. Попробуйте снова")
                {
                    myTextBlock.Text = "*";
                    pincode += n;
                }
                else if (dump_txt.Length >= 4)
                {
                    myTextBlock.Text += "";
                    pincode += "";
                }
                else
                {
                    myTextBlock.Text += "*";
                    pincode += n;
                }
            }
            else
            {
                dump_txt = myTextBlock.Text;
                if (myTextBlock.Text == "Какую сумму Вы хотели бы снять?" | myTextBlock.Text == "Введите сумму, кратную 50")
                {
                    myTextBlock.Text = n;
                    sum = n;
                }
                else if (dump_txt.Length >= 9)
                {
                    myTextBlock.Text += "";
                    sum += "";
                }
                else
                {
                    myTextBlock.Text += n;
                    sum += n;
                }
            }
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            string n = "1";
            Number_Button_Click(n);

        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            string n = "2";
            Number_Button_Click(n);
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            string n = "3";
            Number_Button_Click(n);
        }

        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            string n = "4";
            Number_Button_Click(n);
        }

        private void Button5_Click(object sender, RoutedEventArgs e)
        {
            string n = "5";
            Number_Button_Click(n);
        }

        private void Button6_Click(object sender, RoutedEventArgs e)
        {
            string n = "6";
            Number_Button_Click(n);
        }

        private void Button7_Click(object sender, RoutedEventArgs e)
        {
            string n = "7";
            Number_Button_Click(n);
        }

        private void Button8_Click(object sender, RoutedEventArgs e)
        {
            string n = "8";
            Number_Button_Click(n);
        }

        private void Button9_Click(object sender, RoutedEventArgs e)
        {
            string n = "9";
            Number_Button_Click(n);
        }

        private void Button0_Click(object sender, RoutedEventArgs e)
        {
            string n = "0";
            Number_Button_Click(n);
        }

        private void Button_Leave_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Hide();
        }

        private void Button_Backspace_Click(object sender, RoutedEventArgs e)
        {
            dump_txt = myTextBlock.Text;
            switch (move) 
            {
                case "card_number":
                    if (myTextBlock.Text == "Введите номер карты" |
                    myTextBlock.Text == "Такой карты не существует. Попробуйте снова" |
                    myTextBlock.Text == "Какую сумму Вы хотели бы снять?" |
                    myTextBlock.Text == "Отлично") myTextBlock.Text += "";
                    else if (dump_txt.Length == 6 | dump_txt.Length == 11 | dump_txt.Length == 16)
                    {
                        myTextBlock.Text = dump_txt.Remove(dump_txt.Length - 2);
                    }
                    else if (dump_txt.Length == 1)
                    {
                        myTextBlock.Text = "Введите номер карты";
                    }
                    else
                    {
                        myTextBlock.Text = dump_txt.Remove(dump_txt.Length - 1);
                    }
                    break;
                case "pincode":
                    if (myTextBlock.Text == "Введите пинкод" |
                    myTextBlock.Text == "Пинкод введен неверно. Попробуйте снова")
                    {
                        myTextBlock.Text += "";
                    }
                    else if (dump_txt.Length == 1)
                    {
                        myTextBlock.Text = "Введите пинкод";
                    }
                    else
                    {
                        myTextBlock.Text = dump_txt.Remove(dump_txt.Length - 1);
                        pincode = pincode.Remove(pincode.Length - 1);
                    }
                    break;
                case "sum":
                    if (myTextBlock.Text == "Какую сумму Вы хотели бы снять?" |
                    myTextBlock.Text == "Введите сумму, кратную 50" |
                    myTextBlock.Text == "В банкомате не хватает купюр, воспользуйтесь другим банкоматом")
                    {
                        myTextBlock.Text += "";
                    }
                    else if (dump_txt.Length == 1)
                    {
                        myTextBlock.Text = "Какую сумму Вы хотели бы снять?";
                    }
                    else
                    {
                        myTextBlock.Text = dump_txt.Remove(dump_txt.Length - 1);
                        sum = sum.Remove(sum.Length - 1);
                    }
                    break;
            }
        }
        
        private void Button_Continue_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine(Action);
            switch (move)
            {
                case "card_number":
                    if (card_number.Length == 19)
                    {
                        card_number = card_number.Replace(" ", "");
                        card_cell = mainWindow.worksheet.Cells.Find(card_number, null);
                        if (card_cell != null)
                        {
                            id_cell = mainWindow.worksheet.Cells[card_cell.Row, card_cell.Column - 1];
                            pin_cell = mainWindow.worksheet.Cells[card_cell.Row, card_cell.Column + 1];
                            name_cell = mainWindow.worksheet.Cells[card_cell.Row, card_cell.Column + 2];
                            sum_cell = mainWindow.worksheet.Cells[card_cell.Row, card_cell.Column + 3];
                            operation1_cell = mainWindow.worksheet.Cells[card_cell.Row, card_cell.Column + 4];
                            operation2_cell = mainWindow.worksheet.Cells[card_cell.Row, card_cell.Column + 5];
                            operation3_cell = mainWindow.worksheet.Cells[card_cell.Row, card_cell.Column + 6];
                            move = "pincode";
                            myTextBlock.Text = "Введите пинкод";
                        }
                        else
                        {
                            myTextBlock.Text = "Такой карты не существует. Попробуйте снова";
                        }
                    }
                    else myTextBlock.Text = "Такой карты не существует. Попробуйте снова";
                    break;
                case "pincode":
                    if (pincode == pin_cell.StringValue)
                    {
                        if (Action == "Снять")
                        {
                            myTextBlock.Text = "Какую сумму Вы хотели бы снять?";
                            move = Action;
                        }
                        else if (Action == "Внести")
                        {
                            InputWindow inputWindow = new InputWindow();
                            inputWindow.Show();
                            Hide();
                        }
                    }
                    else
                    {
                        myTextBlock.Text = "Пинкод введен неверно. Попробуйте снова";
                        pincode = "";
                    }
                    break;
                case "Снять":
                    sumint = int.Parse(sum);
                    sum_cell = mainWindow.worksheet.Cells[card_cell.Row, card_cell.Column + 3];
                    if (sumint % 50 != 0)
                    {
                        myTextBlock.Text = "Введите сумму, кратную 50";
                        sum = "";
                    }
                    else if (sumint > sum_cell.IntValue)
                    {
                        myTextBlock.Text = "У вас недостаточно средств";
                        sum = "";
                    }
                    else
                    {
                        ATC atc = new ATC();
                        if (atc.MoneyDealerBool(sumint))
                        {
                            atc.MoneyDealer(sumint);
                            mainWindow.worksheet.Cells[sum_cell.Row, sum_cell.Column].PutValue(sum_cell.IntValue - sumint);
                            mainWindow.worksheet.Cells[sum_cell.Row, sum_cell.Column + 1].PutValue($"Снято {sumint} рублей");
                            mainWindow.Workbook.Save("C:\\Users\\m-dan\\Documents\\InfoATN.xlsx", SaveFormat.Xlsx);
                            atc.OutputMass(atc.GivenMoney);
                            GivenMoney givenMoney = new GivenMoney();
                            givenMoney.TextBlock2000.Text = "x " + atc.GivenMoney[0, 1].ToString();
                            givenMoney.TextBlock1000.Text = "x " + atc.GivenMoney[1, 1].ToString();
                            givenMoney.TextBlock500.Text = "x " + atc.GivenMoney[2, 1].ToString();
                            givenMoney.TextBlock100.Text = "x " + atc.GivenMoney[3, 1].ToString();
                            givenMoney.TextBlock50.Text = "x " + atc.GivenMoney[4, 1].ToString();
                            givenMoney.TextBlockSum.Text = sum + "р";
                            givenMoney.Show();
                            Hide();
                        }
                        else
                        {
                            myTextBlock.FontSize = 20;
                            myTextBlock.Text = "Не хватает купюр, воспользуйтес другим банкоматом";
                        }
                    }
                    break;
                case "Внести":
                    
                    break;
                case "Перевести":

                    break;
                case "Оплатить":

                    break;
            }
        }
    }
}
