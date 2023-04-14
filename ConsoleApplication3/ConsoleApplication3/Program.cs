using System;
namespace ConsoleApplication3
{
    class Program
    {
        static int BMM(int a, int b)
        {
            if (b == 0)
            {
                return a;
            }
            else
            {
                return BMM(b, a % b);
            }    
        }
        static int KMM(int a, int b)
        {
            return (a / BMM(a, b)) * b;

        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter firs digit");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter second digit");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int kmm = KMM(num1, num2);
            int bmm = BMM(num1, num2);
            Console.WriteLine("KMM is: {0} " , kmm);
            Console.WriteLine("BMM is: {0} " , bmm);
            Console.ReadLine();
        }

    }
}
