using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuadraticEquationHW
{
    public class RootCounter
    {
        double a { get; set; }
        double b { get; set; }
        double c { get; set; }

        public RootCounter(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public Result Count(Label label)
        {
            Result result = new Result();
            result.c = Math.Pow(b, 2) - 4 * a * c;
            if (result.c > 0)
            {
                label.Text = "The discriminant is greater than zero, result has two roots";
                result.a = (-b + Math.Sqrt(result.c)) / (2 * a);
                result.b = (-b - Math.Sqrt(result.c)) / (2 * a);
                Console.WriteLine("x1= {0}\n x2= {1}", result.a, result.b);
                return result;
            }
            if (result.c == 0)
            {
                label.Text = "The discriminant is zero";
                result.a = (-b / (2 * a));
                return result;
            }
            else
            {
                Console.WriteLine("The discriminant is less than zero. There are no roots.");
                label.Text = "The discriminant is less than zero. There are no roots.";
                return result;
            }
        }
    }
    public class Result
    {
        public double a;
        public double b;
        public double c;
    }
}
