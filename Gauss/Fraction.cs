using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gauss
{
    class Fraction
    {
        private int numerator;
        private int denominator;
        Fraction(int numeratorValue)
        {
            numerator = numeratorValue;
            denominator = 1;
        }

        Fraction (int numeratorValue, int denominatorValue)
        {
            numerator = numeratorValue;
            denominator = denominatorValue;
        }

        public static Fraction operator +(Fraction f1, Fraction f2)
        {
            //новый знаменатель
            int newDenominator = NOK(Math.Abs(f1.denominator), f2.denominator);
            if (newDenominator == 1)
                throw new Exception();
            //новый числитель: домножение на коэффициент, потом сумма
            int newNumerator = f1.numerator * newDenominator / f1.denominator + f2.numerator * newDenominator / f2.denominator;
            int divisor = Nod(newDenominator, newNumerator);
            newDenominator /= divisor;
            newNumerator /= divisor;
            return new Fraction(newNumerator, newDenominator);

        }
        /// <summary>
        /// Наименьшее общее кратное
        /// </summary>
        /// <param name="m"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        private static int NOK(int m, int n)
        {
          

            for (int i = Math.Max(n,m); i < (n * m + 1); i++)
            {
                if (i % m == 0 && i % n == 0)
                {
                    if (i != 0)
                    {
                        return i;
                    }
                }
            }
            return -1;
        }
        /// <summary>
        /// Наибольший общий делитель
        /// </summary>
        /// <param name="n"></param>
        /// <param name="d"></param>
        /// <returns></returns>
        private static int Nod(int n, int d)
        {
            n = Math.Abs(n);
            d = Math.Abs(d);
            while (d != 0 && n != 0)
            {
                if (n % d > 0)
                {
                    var temp = n;
                    n = d;
                    d = temp % d;
                }
                else break;
            }
            if (d != 0 && n != 0) return d;
            return -1;
        }
    }
}
