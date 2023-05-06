using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] main_arr = new int[10];
            for (int j = 0; j < main_arr.Length; j++)
            {
                main_arr[j] = random.Next(1, 10);
            }
           
            foreach(int temp in main_arr)
            {
                Console.Write(temp + " ");
            }
            Console.WriteLine();
            double[] result = myfunc(main_arr);
            foreach (double temp1 in result)
            {
                Console.Write(temp1.ToString("0.00") + " ");
            }
            Console.ReadLine();
        }
           
        private static double[] myfunc(int[] func_arr)
        {
            double[] result = new double[10];

            for (int i = 0; i < func_arr.Length; i++)
            {
                if (i == 0 || i== 9)
                {
                    result[i] = Convert.ToDouble(func_arr[i]);

                }
                else
                {
                    result[i] = Convert.ToDouble((func_arr[i - 1] + func_arr[i] + func_arr[i + 1]) / 3);
                }
            }
            return result;

          }
                       
    }
}
