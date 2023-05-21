using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication10
{
    class circle
    {
        private double r;
        double pi = 3.14;
        public double R
        {
            get { return r; }
            set { if (value > 0)
                {
                    r = value;
                }
            }
        }
        public circle() { }
        public circle(double R)
        {
            r = R;
        }
        public double S()
        {
            return Math.Pow(r, 2) * pi;
        }
        public double A()
        {
            return 2 * r * pi;
        }
    }
    class Test { 
        static void Main(string[] args)
        {
            double r = Convert.ToDouble(Console.ReadLine());
            circle c1 = new circle(r);
            double s1 = c1.S();
            Console.WriteLine(s1);
            double a1 = c1.A();
            Console.WriteLine(a1);
            Console.ReadLine();
        }

    }
}
