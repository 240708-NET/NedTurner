using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // // Read the second line which contains the N space-separated integers
        // int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        
        // // Calculate the sum of the squares of the integers
        // int sumOfSquares = numbers.Select(x => x * x).Sum();
        
        // // Print the result
        // Console.WriteLine(sumOfSquares);

        
        // Print the result
        Console.WriteLine(Console.ReadLine().Split(' ').Select(int.Parse).ToArray().Select(x => x * x).Sum());
    }
}