using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {
        public static void Main(string[] args)
        {
            Random radnom = new Random();
            /* سوال فاکتوریل*/
            Console.WriteLine("enter the number");
            int a = Convert.ToInt32(Console.ReadLine());
            int res = facto(a);
            Console.WriteLine("the factorial of {0} is {1}", a, res);
            /*سوال مثلث  */
            Console.WriteLine("enter three digits");
            double aa = Convert.ToDouble(Console.ReadLine());
            double bb = Convert.ToDouble(Console.ReadLine());
            double cc = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(triangle(aa, bb, cc));
            /* سوال محاسبه شعاع*/
            Console.WriteLine("enter the radious");
            double dd = Convert.ToDouble(Console.ReadLine());
            radious(dd);
            /* سوال آرایه*/
            Console.WriteLine("the array avg");
            int[] myarr = new int[20];
            for (int i = 0; i < myarr.Length; i++)
            {
                myarr[i] = radnom.Next(0, 9);
            }
            foreach (int temp1 in myarr)
            {
                Console.WriteLine(temp1);
            }
            int counter = 0;
            double temp = myarray(myarr);
            for (int i = 0; i < myarr.Length; i++)
            {
                if ((double)myarr[i] >temp ) 
                {
                    counter++;
                }
            }
            Console.WriteLine(" the avg is {0} and there are {1} numbers greater than avg",temp, counter);
            Console.ReadLine();
        }
            private static int facto (int num)
        {
            if (num == 0)
            {
                return 1;
            }
            else
            {

                return num * facto(num - 1);
            }
            
        }
        private static string triangle(double num1, double num2, double num3)
        {
            if (num1 + num2 <= num3 || num1 + num3 <=num2 || num2 + num3 <= num1)
            {
                return "not triangle";
            }else if( num1 == num2 && num2 == num3)
            {
                return "motasavio al azla";
            }else if(num1== num2 || num2==num3|| num1 == num3)
            {
                return "motasavio al saghain";
            }else if(Math.Pow(num1,2) + Math.Pow(num2,2) == Math.Pow(num3,2) || Math.Pow(num1,2) + Math.Pow(num3,2) == Math.Pow(num2,2) || Math.Pow(num2,2)+ Math.Pow(num3,2)==Math.Pow(num1,2))
            {
                return "ghameo al zavieh";
            }
            else
            {
                return "normal";
            }
        }

        private static void radious (double r)
        {
            Console.WriteLine("shoaa");
            Console.WriteLine((Math.PI * Math.Pow(r, 3)) * 4 / 3);
            Console.WriteLine("mohit");
            Console.WriteLine(Math.PI * Math.Pow(r, 2) * 4);
        }

        private static double myarray(int[] arr)
        {
            double avg=0;
            for (int i = 0; i < arr.Length; i++)
            {
                avg += arr[i];
            }
            avg = avg / arr.Length;
            return avg;
        }
        }
    }

