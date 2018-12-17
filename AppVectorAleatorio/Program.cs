using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppVectorAleatorio
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] x = new int[MAX];
            LeerVector(x);
            Console.WriteLine("\n ELEMENTOS DEL VECTOR");
        }

        public static void LeerVector(int[] x)
        {
            for (int i = 0;i<MAX; i++)
            {
                var randomNumber = new Random().Next(1, 5000);
                x[i] = randomNumber;
            }
        }

        public static void ImprimirVector (int[] x)
        {
            for (int i = 0; i < MAX; i++)
                Console.WriteLine("ELEMENTO {0}= {1}",)
        }
    }
}
