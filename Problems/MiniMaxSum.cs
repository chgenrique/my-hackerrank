using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Given five positive integers, find the minimum and maximum values that can 
     * be calculated by summing exactly four of the five integers.
     * 
     * Complete the 'miniMaxSum' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void miniMaxSum(List<long> arr)
    {
        arr.Sort();
        long s = arr.Sum();
        long minSumValue =  s - arr[arr.Count-1];
        long maxSumValue = s - arr[0];
        
        Console.WriteLine($"{minSumValue} {maxSumValue}");
    }

}

class Solution
{
    public static void Main(string[] args)
    {

        List<long> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt64(arrTemp)).ToList();

        Result.miniMaxSum(arr);
    }

    /**
    Test Case: 
    Input: 1 2 3 4 5
    Expected Output: 10 14
    */
}