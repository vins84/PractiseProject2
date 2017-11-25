using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiseProject
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arr = { 11, 35, 62, 555, 989 };
            int sum = 0;

            foreach (int x in arr)
            {
                sum += x;
            }
            Console.WriteLine(sum);
            //=============================================================
            Console.WriteLine("============================================");
            float[] brr = { 1, 4, 5 };
            float sum2 = 0;

            foreach (float x in brr)
	        {
		        sum2 += x/2;
	        }
            Console.WriteLine(sum2);
            //=============================================================
            Console.WriteLine("============================================");
            //int[,] chessBoard = new int[8,8];

            int[,] someNums = { { 2, 3 }, { 5, 6 }, { 4, 6 } };

            for (int k = 0; k < 3; k++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(someNums[k, j] + " ");
                }
                Console.WriteLine();
            }

            //=====================     JUGGED  ARRAYS   =========================
            Console.WriteLine("==============     JUGGED  ARRAYS   ===============");
            int[][] jaggedArr = new int[][] 
            {
                new int[ ] {1,8,2,7,9},
                new int[ ] {2,4,6},
                new int[ ] {33,42}
            };
            int m = jaggedArr[2][1];
            Console.WriteLine(m);

            //int[ ][,] a = new int[8][,];  // 8 two-dimentional array declaration
            
            //=======================   Array  Properties     =====================
            Console.WriteLine("==============     Array  Properties   ===============");
            int[] crr = { 2, 4, 7 };
            Console.WriteLine("Array Length : " + crr.Length);
            Console.WriteLine("Array Rank : " + crr.Rank);


            int[] drr = { 2, 4, 7 };
            for (int n = 0; n < drr.Length; n++)
            {
                Console.WriteLine(drr[n]);
            }

            //=======================   Array  Methods    =====================
            Console.WriteLine("=======================   Array  Methods    =====================");

            int[] err = { 2, 4, 7, 1 };
            Console.WriteLine("Max value of array is: " + err.Max());
            Console.WriteLine("Min value of array is: " + err.Min());
            Console.WriteLine("Sum of array is: " + err.Sum());

            int[] a = { 4, 6, 5, 2 };
            int z = a[0] + a.Min();
            Console.Write(z);


            //=======================   Arrays Pluralsight    =====================
            Console.WriteLine("\n=======================   Choosing the day of the week    =====================");
            string[] daysOfWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            Console.WriteLine("Select the index of the day to look up. NOTE Index starts from number zero");
            int day = int.Parse(Console.ReadLine());
            Console.WriteLine(daysOfWeek[day]);

            Console.WriteLine("\nforeach loop enumerates throgh the collection and prints them");
            daysOfWeek[5] = "Party day";                            //Replaces the item in the array
            foreach (var day1 in daysOfWeek)
            {
                Console.WriteLine(day1);
            }
            
            Console.WriteLine("\nfor loop enumerates throgh the collection and prints them");
            for (int i = 0; i < daysOfWeek.Length; i++)
            {
                Console.WriteLine(i);
            }

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < daysOfWeek.Length; i++)
            {
                sb.Append(daysOfWeek[i]);
                if (i < daysOfWeek.Length - 2)
                {
                    sb.Append(", ");
                }
                else if (i == daysOfWeek.Length - 2)
                {
                    sb.Append(" and ");
                }
            }
            Console.WriteLine(sb.ToString());

        }
    }
}
