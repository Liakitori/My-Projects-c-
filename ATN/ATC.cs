using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATN
{
    public class ATC
    {
        private MoneyWindow moneyWindow = new MoneyWindow();

        private MainWindow mainWindow = new MainWindow();
        public void MoneyDealer(int sum)
        {
            Console.Write($"Введенная сумма: {sum}; ");
            int s = sum;
            for (int i = 0; i < 5; i++) GivenMoney[i, 1] = 0;
            float[] dump = new float[5];
            for (int i = 0, k; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    dump[j] = mainWindow.notes[j, 1];
                }
                if ((dump[0] / dump[1] <= 0.97 && i == 0) | (dump[3] / dump[4] <= 0.97 && i == 3)) i++;
                if (dump[1] / dump[2] <= 0.97 && i == 1) i++;
                k = s / GivenMoney[i, 0];
                if (k <= mainWindow.notes[i, 1])
                {
                    GivenMoney[i, 1] += k;
                    s -= k * GivenMoney[i, 0];
                }
                else
                {
                    GivenMoney[i, 1] += mainWindow.notes[i, 1];
                    s -= mainWindow.notes[i, 1] * GivenMoney[i, 0];
                }
            }
            s = 0;
            for (int i = 0; i < 5; i++)
            {
                s += GivenMoney[i, 1] * GivenMoney[i, 0];
            }
            for (int i = 0; i < 5; i++)
            {
                mainWindow.notes[i, 1] -= GivenMoney[i, 1];
            }
            OutputMass(mainWindow.notes);
        }

        public bool MoneyDealerBool(int sum)
        {
            int s = sum;
            for (int i = 0; i < 5; i++) GivenMoney[i, 1] = 0;
            float[] dump = new float[5];
            for (int i = 0, k; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    dump[j] = mainWindow.notes[j, 1];
                }
                if ((dump[0] / dump[1] <= 0.97 && i == 0) | (dump[3] / dump[4] <= 0.97 && i == 3)) i++;
                if (dump[1] / dump[2] <= 0.97 && i == 1) i++;
                k = s / GivenMoney[i, 0];
                if (k <= mainWindow.notes[i, 1])
                {
                    GivenMoney[i, 1] += k;
                    s -= k * GivenMoney[i, 0];
                }
                else
                {
                    GivenMoney[i, 1] += mainWindow.notes[i, 1];
                    s -= mainWindow.notes[i, 1] * GivenMoney[i, 0];
                }
            }
            s = 0;
            for (int i = 0; i < 5; i++)
            {
                s += GivenMoney[i, 1] * GivenMoney[i, 0];
            }
            Console.WriteLine($"Сумма на выдачу: {s} - не хватает.");
            if (s == sum)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void OutputMass(int[,] banknotes)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    if (j == 0) Console.Write($"{banknotes[i, j]}:");
                    else Console.Write($"{banknotes[i, j]}");

                }
                if (i < 4) Console.Write("   ");
                else Console.WriteLine();
            }
        }
        public int[,] GivenMoney = { { 2000, 0 }, { 1000, 0 }, { 500, 0 }, { 100, 0 }, { 50, 0 } };
    }
}
