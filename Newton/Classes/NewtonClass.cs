using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Newton.Classes
{
    class NewtonClass
    {
        private static double Pow(double x, double n)
        {
            double result = 1;
            for (int i = 0; i < n; i++)
            {
                result *= x;
            }
            return result;
        }

        public static double FindRadical(string radicand, string index, string accuracy)
        {
            if (double.TryParse(radicand, out double radic) && double.TryParse(index, out double ind) && double.TryParse(accuracy, out double epsil))
            {
                double x0 = 1;
                double x1 = (1 / ind) * ((ind - 1) * x0 + radic / Pow(x0, ind - 1));

                while (Math.Abs(x1 - x0) > epsil)
                {
                    x0 = x1;
                    x1 = (1 / ind) * ((ind - 1) * x0 + radic / Pow(x0, ind - 1));
                }

                return x1;
            }
            else
            {
                MainWindow.ShowMessage("Данные введены неверно");
                return 0;
            }

        }

    }
}
