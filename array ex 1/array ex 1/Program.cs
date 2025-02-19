using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_ex_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Sum = 0;
            int[] arr = new int[7];
            arr[0] = 100;
            arr[1] = 200;
            arr[3] = 300;
            arr[4] = 500;
            arr[5] = 600;
            arr[6] = 400;
            Sum = arr[0] + arr[1] + arr[2] + arr[3] + arr[4] + arr[5] + arr[6];
            Console.WriteLine("The Sum is : " + Sum);
            Console.ReadKey();
        }
    }
}
