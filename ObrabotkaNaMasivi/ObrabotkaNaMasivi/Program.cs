using System;

namespace ObrabotkaNaMasivi
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i=0;i<n;i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(OptnionsManager.CountLess100(arr));
            Console.WriteLine(OptnionsManager.MaxNum(arr));
            arr = OptnionsManager.ReverseArr(arr);
            OptnionsManager.PrintArr(arr);


        }
    }
}
