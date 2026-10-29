using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_10_2026
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("nhap vao so tu nhien n:");
            int n = Convert.ToInt32(Console.ReadLine());
            int h = 0, k = 0;
            int[] A = new int[n];
            int[] B = new int[n];
            int[] C = new int[n];
            int TG = 0;


            for (int i = 0; i < n; i++)
            {
                Console.Write("A[" + i.ToString() + "]=");
                A[i] = Convert.ToInt32(Console.ReadLine());
            }
            //for (int i = 0; i < n; i++)
            //{
            //    if (A[i] > 0)
            //    {
            //        B[h] = A[i];
            //        h = h + 1;
            //    }
            //    else
            //    {
            //        C[k] = A[i];
            //        k = k + 1;
            //    }
            //}
            //Console.WriteLine("KET QUA");
            //Console.Write("DAY B CAC SO LON HON 0: ");
            //if (h == 0)
            //{
            //    Console.WriteLine("KHONG CO SO NAO > 0");
            //}
            //else
            //{
            //    for (int i = 0; i < h; i++)
            //    {
            //        Console.Write(B[i] + " ");
            //    }
            //    Console.WriteLine();
            //}
            //Console.Write("DAY C CAC SO NHO HON 0: ");
            //if (k == 0)
            //{
            //    Console.WriteLine("KHONG CO SO NAO < 0");
            //}
            //else
            //{
            //    for (int i = 0; i < k; i++)
            //    {
            //        Console.Write(C[i] + " ");
            //    }
            //    Console.WriteLine();
            //}
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (A[i] > A[j])
                    {
                        TG = A[i];
                        A[i] = A[j];
                        A[j] = TG;
                    }
                }
            }
            //mang sau khi da sap xep
            for (int i = 0; i < n; i++)
            {
                Console.Write(A[i] + "");
            }

        }
    }
}
