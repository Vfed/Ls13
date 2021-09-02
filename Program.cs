using System;

namespace Ls13
{
    class Program
    {
        int[,] mas = new int[5, 5];
        static void Main(string[] args)
        {
            int[,] mas = new int[5, 5];
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    mas[i, j] = (i+1) *(j+1);
                }
            }
            Console.WriteLine();
            //1
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    Console.Write(mas[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            //2
            int a = 0;
            foreach (var item in mas)
            {
                a++;
                if (a % mas.GetLength(1) != 0)
                {
                    Console.Write(item + " ");
                }
                else
                {
                    Console.WriteLine(item + " ");
                }
            }
            Console.WriteLine();
            int s = 0;
            int k = 0;
            //3
            do {
                Console.Write(mas[s,k] + " ");
                k++;
                if (k == mas.GetLength(1)) 
                {
                    k = 0;
                    s++;
                Console.WriteLine();
                }
            } while (s < mas.GetLength(0));
            //4
            

        }
    }

}
