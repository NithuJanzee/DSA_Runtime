﻿using System;
using System.Diagnostics;
using DSA_Runtime.Easy;

namespace DSA_Runtime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();


            // Mehtords are Here 

            //TwoSum twoSum = new TwoSum();
            //Console.WriteLine(twoSum.TwoSumQuetion(new int[] { 2, 7, 5, 1 }, 9));
            //int[] result = twoSum.TwoSumQuetion(new int[] { 2, 7, 5, 1 }, 9);
            //Console.WriteLine(string.Join(",", result));

            //Palindrome_Number number = new Palindrome_Number();
            //Console.WriteLine(number.IsPalindrom(1221));

            //RomanToInt romanToInt = new RomanToInt();
            //Console.WriteLine(romanToInt.RomanToIntQ("LVIII"));

            //LongestCommenPrefix longestCommen = new LongestCommenPrefix();
            //string[] test = new string[] { "flower", "flow", "flight" };
            //Console.WriteLine(longestCommen.LongestCommonPrefix(test));

            //A_Guy_WIth_a_Mental_Problem a_Guy_WIth_A_Mental_Problem = new A_Guy_WIth_a_Mental_Problem();
            //int[] input1 = new int[] { 2, 1, 2 };
            //int[] input2 = new int[] { 3, 2, 1 };
            //Console.WriteLine(a_Guy_WIth_A_Mental_Problem.FindMinimumTIme(input1, input2));



            RemoveDuplicateFromSortedArray removeDuplicateFromSorted = new RemoveDuplicateFromSortedArray();
            int[] nums = { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };

            int k = removeDuplicateFromSorted.RemoveDuplicates(nums);

            Console.WriteLine(k);
            Console.Write("Modified array: ");
            for (int i = 0; i < k; i++)
            {
                Console.Write(nums[i] + " ");
            }


            stopwatch.Stop();
            Console.WriteLine($"Time is {stopwatch.ElapsedMilliseconds} ms");
            Console.ReadLine();
        }
    }

}
