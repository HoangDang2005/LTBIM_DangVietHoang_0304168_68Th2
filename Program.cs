using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vong_lap_for
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Double T = 0;
            //Console.Write("nhap vao so tu nhien n:");
            //int n = Convert.ToInt32(Console.ReadLine());

            //for (int i = 1; i <= n; i++)
            //{
            //    T = 0;
            //    Console.WriteLine("i = "+i);
            //    for (int j = 1; j < n; j++)
            //    {
            //        Console.WriteLine("j="+ j.ToString());
            //        T=T+j;
            //    }
            //}
            //Console.WriteLine();
            //Console.WriteLine("Tong = " + T);
            //Console.ReadLine();
            Console.Write("nhap vao so tu nhien n:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("nhap vao so tu nhien n:");
            int m = Convert.ToInt32(Console.ReadLine());
            int[,] A = new int[n, m];
            double T = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write("A[" + i + "," + j + "]=");
                    A[i, j] = Convert.ToInt32(Console.ReadLine());
                    //    //if(A[i,j] > 0)
                    //    //{
                    //    //    T=T+ A[i,j];
                    //    //}
                    //    //else
                    //    //{
                    //    //    T = 0;
                    //    //}
                    //    //T = T + A[i];
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(A[i, j] + " ");
                }
                Console.WriteLine(" ");
            }

            //Console.Write("T=" + T);
            Console.ReadLine();


        }
    }
}


