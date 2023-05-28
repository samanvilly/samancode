using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication13
{
    class Rectangle
    {
        private int x;
        private int y;
        public int X
        {
            get { return x; }
            set { x = value; }
        }
        public int Y
        {
            get { return y; }
            set { y = value; }
        }

        public Rectangle() { }
        public Rectangle (int X, int Y)
        {
            x = X;
            y = Y;
        }
        public int mohit()
        {
            return (x + y) * 2;
        }
        public int masahat()
        {
            return x * y;
        }
    }
    class Circle
    {
        private double x;
        private double pi = 3.14;


        public double X
        {
            get { return x; }
            set { x = value; }
        }

        public Circle() { }
        public Circle(double X)
        {
            x = X;
        }
        public double mohit()
        {
            return Math.Pow(x,2) * pi;
        }
        public double masahat()
        {
            return (x * 2 * pi);
        }
    }
    class test
    {
        static void Main(string[] args)
        {
            Console.WriteLine("for circle 1 , for rectangle 2");
            int input = Convert.ToInt32(Console.ReadLine());
            switch (input)
            {
                case 1:
                    Console.WriteLine("enter radious of circle");
                    double num1 = Convert.ToDouble(Console.ReadLine());
                    Circle temp = new Circle(num1);
                    double res = temp.mohit();
                    double res1 = temp.masahat();
                    Console.WriteLine("mohit of circle is: {0}", res);
                    Console.WriteLine("masahat is {0}", res1);
                    Console.ReadLine();
                    
                    break;
                case 2:
                    Console.WriteLine("enter x & y for rectangel");
                    int num2 = Convert.ToInt32(Console.ReadLine());
                    int num3 = Convert.ToInt32(Console.ReadLine());
                    Rectangle temp1 = new Rectangle(num2, num3);
                    int res2 = temp1.mohit();
                    int res3 = temp1.masahat();
                    Console.WriteLine("mohit of rectangle is: {0}",res2);
                    Console.WriteLine("masaht of rectangle is: {0}",res3);
                    Console.ReadLine();
                    break;
            }
            
            
        }
    }
}
