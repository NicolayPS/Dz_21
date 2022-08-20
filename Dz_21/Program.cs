using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Dz_21
{
    class Program
    {
        const int n = 5;
        const int m = 5;
        static int[,] path;
        
        static void Main()
        {
            path = new int[n, m];
            Thread thread = new Thread(Gardner1);
            Thread thread2 = new Thread(Gardner2);

            thread.Start();
            thread2.Start();

            thread.Join();
            thread2.Join();

            
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{path[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }

        static void Gardner1()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (path[i, j] == 0)
                    {
                        path[i, j] = -1;
                    }
                    Thread.Sleep(1);
                }
            }
        }
        static void Gardner2()
        {
            for (int i = m - 1; i > 0; i--)
            {
                for (int j = n - 1; j > 0; j--)
                {
                    if (path[j, i] == 0)
                    {
                        path[j, i] = -2;
                    }
                    Thread.Sleep(1);
                }
            }
        }
    }
}
