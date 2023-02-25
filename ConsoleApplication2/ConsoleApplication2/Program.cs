using System;
 class program
{
    public static void Main()
    {
        int i, j;
        int[,] myarray = new int[3, 3];
        int deter = 0;
        for (i = 0; i < 3; i++)
        {
            for (j = 0; j < 3; j++)
            {
                Console.Write("[{0}],[{1}] : ", i, j);
                myarray[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        Console.WriteLine("The matrix is :");
        for (i = 0; i < 3; i++)
        {
            for (j = 0; j < 3; j++)
                Console.Write("  " + myarray[i, j]);
            Console.WriteLine();
        }

        for (i = 0; i < 3; i++)
            deter = deter + (myarray[0, i] * (myarray[1, (i + 1) % 3] * myarray[2, (i + 2) % 3] - myarray[1, (i + 2) % 3] * myarray[2, (i + 1) % 3]));

        Console.WriteLine("The result is: {0}", deter);
    }
}