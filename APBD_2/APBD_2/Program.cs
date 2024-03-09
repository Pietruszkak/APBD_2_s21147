using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APBD_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            Console.WriteLine("Modyfikacja 2");
            Console.WriteLine("Modyfikacja 3");
            Console.WriteLine(GetAvg([1, 2, 3, 4, 5]));
            Console.WriteLine(GetMax([1, 333, 3, 214, 5]));
            Console.WriteLine("Zad 5 main change");
            Console.WriteLine("Feature-new");


            static double GetAvg(int[] arr) {
                int sum=0;
                for (int i = 0; i < arr.Length; i++)
                {
                    sum=sum+arr[i];
                }
                return sum/arr.Length;
            }
            static int GetMax(int[] arr)
            {
                int max = arr[0];
                for (int i = 1; i < arr.Length; i++)
                {
                    if (arr[i]> max)
                    {
                        max = arr[i];
                    }
                }
                return max;
            }
        }
    }
}
