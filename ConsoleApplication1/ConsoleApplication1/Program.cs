using System;
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 0;
            int counter1 = 0;
            int counter2 = 0;
            int[,] myarr = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            Console.Write("enter first number... ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter seconde number... ");
            b = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (a == myarr[j, i])
                    {
                        counter1++;
                    }
                    else
                    {
                        if (b == myarr[j, i])
                        {
                            counter2++;
                        }
                    }
                }

            }
            Console.WriteLine("Counter1 = " + counter1);
            Console.WriteLine("Counter1 =  " + counter2);

        }
    }
}
