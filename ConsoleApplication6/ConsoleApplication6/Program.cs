using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[,] matris = new int[10, 10];
            for (int i = 0; i < matris.GetLength(0); i++)
            {
                for (int j = 0; j < matris.GetLength(1); j++)
                {
                    matris[i, j] = random.Next(1, 10);
                }
            }
            for (int i=0; i < matris.GetLength(0); i++)
            {
                for (int j = 0; j < matris.GetLength(1); j++)
                {
                    Console.Write(matris[i, j] + " ");

                }
                Console.WriteLine();
            }
            Console.WriteLine("*******************");
            myfunc(matris);
            Console.ReadLine();
        }
        private static void myfunc (int[,] func_matris)
        {
            for (int i = 1; i < func_matris.GetLength(0) - 1;i+=3){
                for (int j = 1; j < func_matris.GetLength(1) - 1; j += 3)
                {
                    int sum = 0;
                    for (int ii = i - 1; ii <= i + 1; ii++)
                    {
                        for (int jj = j - 1; jj <= j + 1; jj++)
                        {
                            if (ii == i && jj == j)
                            {
                                continue;
                            }
                            else
                            {
                                sum += func_matris[ii, jj];
                            }
                        }
                    }
                    int miane = sum / 8;// برای محاسبه میانه 9 عتصر اگر درست حساب کرده باشم جمع 8 عنصر کناری تقسیم بر 8 محسابه میشد و جای عنصر وسطی قرار میگرفت
                    func_matris[i, j] = miane;
                }
            }
            for (int i = 0; i < func_matris.GetLength(0); i++)
            {
                for (int j = 0; j < func_matris.GetLength(1); j++)
                {
                    Console.Write(func_matris[i, j] + " ");

                }
                Console.WriteLine();
            }
        }
    }
}
