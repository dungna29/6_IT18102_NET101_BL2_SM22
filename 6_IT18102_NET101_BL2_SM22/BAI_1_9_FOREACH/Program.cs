﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_1_9_FOREACH
{
    internal class Program
    {
        /*
        * Vòng lặp foreach
        * Cách gõ: fore + tab
        *
        * Công thức:
        *  foreach (var VARIABLE in COLLECTION)
           {
           }
           var: Kiểu dữ liệu đã học ở bài khai báo biến
           VARIABLE: tên biến có thể đặt tùy ý và nó đại diện cho kiểu dữ liệu.
           COLLECTION//Array: Phải là 1 tập hợp nhiều giá trị.
        */

        private static void Main(string[] args)
        {
            int[] arrNumbers = { 1, 2, 3, 4, 5, 6 };
            //Cách 1: In mảng ra với for
            for (int i = 0; i < arrNumbers.Length; i++)
            {
                Console.Write(arrNumbers[i] + " ");
            }

            Console.WriteLine();
            //Cách 2: fore + tab
            foreach (var x in arrNumbers)
            {
                Console.Write(x + " ");
            }
        }
    }
}