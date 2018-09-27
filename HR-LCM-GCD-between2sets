/***
You will be given two arrays of integers and asked to determine all integers that satisfy the following two conditions:

The elements of the first array are all factors of the integer being considered
The integer being considered is a factor of all elements of the second array
These numbers are referred to as being between the two arrays. You must determine how many such numbers exist.

For example, given the arrays  and , there are two numbers between them:  and . , ,  and  for the first value. Similarly, ,  and , .

Function Description

Complete the getTotalX function in the editor below. It should return the number of integers that are betwen the sets.

getTotalX has the following parameter(s):

a: an array of integers
b: an array of integers
Input Format

The first line contains two space-separated integers,  and , the number of elements in array  and the number of elements in array . 
The second line contains  distinct space-separated integers describing  where . 
The third line contains  distinct space-separated integers describing  where .

Constraints

Output Format

Print the number of integers that are considered to be between  and .

Sample Input

2 3
2 4
16 32 96
Sample Output

3
Explanation

2 and 4 divide evenly into 4, 8, 12 and 16. 
4, 8 and 16 divide evenly into 16, 32, 96.

4, 8 and 16 are the only three numbers for which each element of a is a factor and each is a factor of all elements of b.

*****

Editorial:
Though this problem can be solved with a brute force approach, there's a faster, easier way!

Observations
All numbers in  evenly divide  if and only if  is divisible by the Least Common Multiple (LCM) of all numbers in . Let's denote the LCM of  as .
 evenly divides all numbers in  if and only if  divides the Greatest Common Divisor (GCD) of all numbers in . Let's denote the GCD of  as .
Approach
Let's find the number of  values satisfying  and .

If  is not divisible by , no such  exists.
If some  exists, we can divide , , and  by  (i.e., , , and  are all true). Now we just need to find the number of divisors of , which we can do in  time (or faster), where  is the maximum number in sets  and .
Tips
Be sure to be careful in calculating , as this number can be quite large.
If  becomes greater than , then we need stop calculating and say that our answer is zero.

***/

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {

    /*
     * Complete the getTotalX function below.
     */
    static int getTotalX(int[] a, int[] b) {
        int aLcm = arrayLcm(a);
        int bGcd = arrayGcd(b);

        int i = 1, count = 0;
        while((aLcm * i) <= bGcd)
        {
            if(bGcd % (aLcm * i) == 0) count++;
            i++;
        }
        return count;
    }
    
    public static int arrayGcd(int[] arr)
    {
        int result = arr[0];
        for(int i = 1; i < arr.Length; i++)
        {
            int p = 0, q = 0;
            pqsetter(result, arr[i], out p, out q);
            result = gcd(p,q);
        }
        return result;
    }
    
    public static int arrayLcm(int[] arr)
    {
        int result = arr[0];
        for(int i = 1; i < arr.Length; i++)
        {
            int p = 0, q = 0;
            pqsetter(result, arr[i], out p, out q);
            int gcdVal = gcd(p,q);
            result = lcm(p,q, gcdVal);
        }
        return result;
    }
    
    public static void pqsetter(int a, int b, out int p, out int q)
    {
        int gcdVal = 0;
        if(a > b)
        {
            p = a;
            q = b;
        }
        else
        {
            p = b;
            q = a;
        }
    }
    
    public static int gcd(int p, int q)
    {
        if(q == 0) return p;
        if(p == q) return p;
        return gcd(q, p % q);
    }

    public static int lcm(int a, int b, int gcdVal)
    {
        return ((a * b) / gcdVal);
    }

    static void Main(string[] args) {
        TextWriter tw = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] nm = Console.ReadLine().Split(' ');

        int n = Convert.ToInt32(nm[0]);

        int m = Convert.ToInt32(nm[1]);

        int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp))
        ;

        int[] b = Array.ConvertAll(Console.ReadLine().Split(' '), bTemp => Convert.ToInt32(bTemp))
        ;
        int total = getTotalX(a, b);

        tw.WriteLine(total);

        tw.Flush();
        tw.Close();
    }
}

