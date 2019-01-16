/**
* Website: HackerRank
* Package: Interview Preparation Kit/ Warm up Challenge
* Problem:
John works at a clothing store. He has a large pile of socks that he must pair by color for sale. Given an array of integers representing the color of each sock, determine how many pairs of socks with matching colors there are.

For example, there are  socks with colors . There is one pair of color  and one of color . There are three odd socks left, one of each color. The number of pairs is .

Function Description

Complete the sockMerchant function in the editor below. It must return an integer representing the number of matching pairs of socks that are available.

sockMerchant has the following parameter(s):

n: the number of socks in the pile
ar: the colors of each sock
Input Format

The first line contains an integer , the number of socks represented in . 
The second line contains  space-separated integers describing the colors  of the socks in the pile.

Constraints

 where 
Output Format

Print the total number of matching pairs of socks that John can sell.

Sample Input

9
10 20 20 10 10 30 50 10 20
Sample Output

3
Explanation

sock.png

John can match three pairs of socks.

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

    // Complete the sockMerchant function below.
    static int sockMerchant(int n, int[] ar) {
    // key: sock colour number, value: 1 if odd, 0 if pair.
        Dictionary<int, int> socksOfColor = new Dictionary<int, int>();
        int pairs = 0;
        for(int i =0; i < n; i++)
        {
            if(!socksOfColor.ContainsKey(ar[i]))
            {
                socksOfColor[ar[i]] = 1;
            }
            else
            {
                pairs++;
                socksOfColor.Remove(ar[i]);
            }
        }
        
        return pairs;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());
        string values = Console.ReadLine();
        string[] arr = values.Split(' ');
        int[] ar =
            Array.ConvertAll(arr, int.Parse);
        
        int result = sockMerchant(n, ar);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
