using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication11
{
    class MyDist
    {
        private int x1;
        private int y1;
        private int x2;
        private int y2;
        public int X1
        {
            get { return x1; }
            set { x1 = value; }
        }
        public int Y1
        {
            get { return y1; }
            set { y1 = value; }
        }
        public int X2
        {
            get { return x2; }
            set { x2 = value; }
        }
        public int Y2
        {
            get { return y2; }
            set { y2 = value; }
        }
        public MyDist() { }
        public MyDist(int X1, int Y1, int X2, int Y2)
        {
            x1 = X1;
            y1 = Y1;
            x2 = X2;
            y2 = Y2;
        }
        public double calc()
        {
            return Math.Sqrt((Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)));
        }
    }
    class test { 
        static void Main(string[] args)
        {
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int num3 = Convert.ToInt32(Console.ReadLine());
            int num4 = Convert.ToInt32(Console.ReadLine());
            MyDist temp = new MyDist(num1, num2, num3, num4);
            double res = temp.calc();
            Console.WriteLine(res);
            Console.ReadLine();
        }
    }
}
