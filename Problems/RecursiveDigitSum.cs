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
     * For example, the super digit of  will be calculated as:
     * super_digit(9875)   	9+8+7+5 = 29 
     * super_digit(29) 	2 + 9 = 11
     * super_digit(11)		1 + 1 = 2
     * super_digit(2)		= 2
     *

     * Complete the 'superDigit' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. STRING n
     *  2. INTEGER k
     */

    public static int superDigit(string n, int k)
    {
        if(n.Length == 1) return int.Parse(n);
        
        n = (n.Sum(c => char.GetNumericValue(c))* k).ToString();
        return superDigit(n, 1);
        
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        string n = firstMultipleInput[0];

        int k = Convert.ToInt32(firstMultipleInput[1]);

        int result = Result.superDigit(n, k);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}

/**
Test Case

Input: 123 3
Expected Output: 9


Input: 9875 4
Expected Output: 8

*/