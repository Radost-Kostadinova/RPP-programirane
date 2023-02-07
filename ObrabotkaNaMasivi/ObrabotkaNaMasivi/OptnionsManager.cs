﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObrabotkaNaMasivi
{
    public static class OptnionsManager
    {
        public static int CountLess100(int[] arr)
        {
            return arr.Count(x => x < 100);
        }

        public static int MaxNum(int[] arr)
        {
            return arr.Max();
        }
        public static int[] ReverseArr(int[] arr)
        {
            return arr.Reverse().ToArray();

        }
        public static  void PrintArr(int[]arr)
        {
            Console.WriteLine(String.Join(",",arr));
        }

        
    }
}
