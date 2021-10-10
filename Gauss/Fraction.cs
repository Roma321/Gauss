using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gauss
{
    public class Fraction
    {
        public int Numerator { get; }
        public int Denominator { get; }

        public Fraction(int numeratorValue)
        {
            Numerator = numeratorValue;
            Denominator = 1;
        }

        public Fraction (int numeratorValue, int denominatorValue)
        {
            Numerator = numeratorValue;
            Denominator = denominatorValue;
        }

        public static Fraction operator +(Fraction f1, Fraction f2)
        {
            //новый знаменатель
            int newDenominator = NOK(Math.Abs(f1.Denominator), f2.Denominator);
            //новый числитель: домножение на коэффициент, потом сумма
            int newNumerator = f1.Numerator * newDenominator / f1.Denominator + f2.Numerator * newDenominator / f2.Denominator;
            if (newNumerator == 0)
                return new Fraction(0, 1);
            if (newDenominator < 0 && newNumerator < 0)
            {
                newDenominator = -newDenominator;
                newNumerator = -newNumerator;
            }
            int divisor = Nod(newDenominator, newNumerator);
            newDenominator /= divisor;
            newNumerator /= divisor;
            return new Fraction(newNumerator, newDenominator);

        }

        public static Fraction operator -(Fraction f1, Fraction f2)
        {
            return f1 + f2 * (-1);
        }

        public static Fraction operator *(Fraction f1, int a)
        {
            int newDenominator = f1.Denominator;
            //новый числитель
            int newNumerator = f1.Numerator * a;
            int divisor = Nod(newDenominator, newNumerator);
            if (newNumerator == 0)
                return new Fraction(0, 1);
            if (newDenominator < 0 && newNumerator < 0)
            {
                newDenominator = -newDenominator;
                newNumerator = -newNumerator;
            }
            newDenominator /= divisor;
            newNumerator /= divisor;
            return new Fraction(newNumerator, newDenominator);
        }

        public static Fraction operator *(int a, Fraction f1)
        {
            return f1 * a;
        }

        public static Fraction operator /(Fraction f1, int a)
        {
            int newDenominator = f1.Denominator * a;
            //новый числитель
            int newNumerator = f1.Numerator;
            int divisor = Nod(newDenominator, newNumerator);
            if (newNumerator == 0)
                return new Fraction(0, 1);
            if (newDenominator < 0 && newNumerator < 0)
            {
                newDenominator = -newDenominator;
                newNumerator = -newNumerator;
            }
            newDenominator /= divisor;
            newNumerator /= divisor;
            return new Fraction(newNumerator, newDenominator);
        }

        public static Fraction operator /(Fraction f1, Fraction f2)
        {
            return f1 * (new Fraction(f2.Denominator, f2.Numerator));
        }



        public static Fraction operator *(Fraction f1, Fraction f2)
        {
            //новый знаменатель
            int newDenominator = f1.Denominator*f2.Denominator;
            //новый числитель
            int newNumerator = f1.Numerator * f2.Numerator;
            if (newNumerator == 0)
                return new Fraction(0, 1);
            if (newDenominator<0&&newNumerator<0)
            {
                newDenominator = -newDenominator;
                newNumerator = -newNumerator;
            }
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