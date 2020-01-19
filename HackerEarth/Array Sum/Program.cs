﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Sum
{
    //https://www.hackerearth.com/practice/basic-programming/implementation/basics-of-implementation/practice-problems/algorithm/array-sum-2-725368ac/
    public class Program
    {
        public static void Main(String[] args)
        {
            //Int32 n = Int32.Parse(Console.ReadLine());
            //Int64[] array = Console.ReadLine().Split(new Char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            //                               .Select(a => Int64.Parse(a)).ToArray<Int64>();
            //Console.WriteLine(array.Sum());

            int [] array = {2,2,1,1,1,2,2 };
            int p = array.GroupBy(a => a).Select(a => new { Key = a.Key, count = a.Count() }).Max(a => a.count);
            Console.ReadLine();
        }
    }
}
