/**
https://www.hackerrank.com/challenges/luck-balance/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=greedy-algorithms
**/
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

class Solution {

    // Complete the luckBalance function below.
    static int luckBalance(int k, int[][] contests) {
        int ret = 0;
        List<int> ones = new List<int>();
        for(int i = 0; i < contests.Length; i++)
        {
            if(contests[i][1] == 0) ret += contests[i][0];
            else ones.Add(contests[i][0]);
        }      
        //Sort in Descending order 
        ones.Sort((a, b) => -1* a.CompareTo(b));
        foreach(var dig in ones)
        {
            if(k > 0)
            {
                ret += dig;
                k--;
            }
            else
            {
                ret -= dig;
            }
        }

        return ret;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] nk = Console.ReadLine().Split(' ');

        int n = Convert.ToInt32(nk[0]);

        int k = Convert.ToInt32(nk[1]);

        int[][] contests = new int[n][];

        for (int i = 0; i < n; i++) {
            contests[i] = Array.ConvertAll(Console.ReadLine().Split(' '), contestsTemp => Convert.ToInt32(contestsTemp));
        }

        int result = luckBalance(k, contests);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
