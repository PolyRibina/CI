using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class1
    {
        public static double[] Mathing(int a, int b, int c, out string error)
        {
            error = "";
            if (a == 0)
            {
                if (b == 0)
                {
                    if (c == 0)
                    {
                        error = "R";
                        return new double[0];
                    }
                    else
                    {
                        error = "Нет корней. Ошибка";
                        return new double[0];
                    }

                }
                else
                {
                    return new double[1] { (double)-c / b };
                }
            }
            else
            {
                double d = b * b - 4 * a * c;
                if (d > 0) return new double[]
                {
                    ((-b+Math.Sqrt(d))/2*a),
                ((-b - Math.Sqrt(d)) / 2 * a)
                };
                else if (d < 0.00000000001)
                {
                    error = "Нет корней";
                    return new double[0];
                }
                else return new double[1] { ((-b + Math.Sqrt(d)) / 2 * a) };
            }
        }
    }
}
