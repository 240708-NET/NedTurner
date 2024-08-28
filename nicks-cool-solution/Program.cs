using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 **/
class Solution
{
    static void Main(string[] args)
    {
        int sum = Enumerable.Range(0,3).Sum(x => {
            int num = int.Parse(Console.ReadLine());
            return num%2 == 0 ? num : -num;
        });

        Console.WriteLine(sum);
    }
}