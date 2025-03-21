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
     * Complete the 'caesarCipher' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts following parameters:
     *  1. STRING s
     *  2. INTEGER k
     */

    public static string caesarCipher(string s, int k)
    {
        if(k == 0) return s;
        
        char[] convert = new char[s.Length];
        for(int i=0;i<s.Length;i++){
            char ch = s[i];
            if((s[i]>='a' && s[i]<='z')){
              ch = (char)(97+((s[i]-97+k)%26));  
            }
            
            if(s[i]>='A' && s[i]<='Z')
              ch = (char)(65+((s[i]-65+k)%26));
              
            convert[i]=ch;  
        }
        
        // char(97)  ans =  'a'
        // char(65)  ans =  'A'
  
        string result = new string(convert);
        return result;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        string s = Console.ReadLine();

        int k = Convert.ToInt32(Console.ReadLine().Trim());

        string result = Result.caesarCipher(s, k);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}

/**

Original alphabet:      abcdefghijklmnopqrstuvwxyz
Alphabet rotated +2:    cdefghijklmnopqrstuvwxyzab


Original alphabet: middle-Outz
Alphabet Rotaged +2: okffng-Qwvb


Test Case:

Input:
11
middle-Outz
2

Expected Output:
okffng-Qwvb

*/