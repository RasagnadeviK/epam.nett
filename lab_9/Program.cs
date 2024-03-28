using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main(string[] args)
    {
        // TASK 1
        char C = 'C';
        List<string> stringList1 = new List<string> { "Candy", "Apple", "Cat", "Dog", "Car" };
        var result1 = stringList1.Where(s => s.Length > 1 && s.StartsWith(C) && s.EndsWith(C));
        Console.WriteLine("Task 1 Result:");
        foreach (var str in result1)
        {
            Console.WriteLine(str);
        }

        // TASK 2
        List<string> stringList2 = new List<string> { "Candy", "Apple", "Cat", "Dog", "Car" };
        var result2 = stringList2.Select(s => s.Length).OrderBy(len => len);
        Console.WriteLine("\nTask 2 Result:");
        foreach (var len in result2)
        {
            Console.WriteLine(len);
        }

        // TASK 3
        List<string> stringList3 = new List<string> { "Candy", "Apple", "Cat", "Dog", "Car" };
        var result3 = stringList3.Select(s => $"{s[0]}{s[^1]}");
        Console.WriteLine("\nTask 3 Result:");
        foreach (var str in result3)
        {
            Console.WriteLine(str);
        }

        // TASK 4
        int K = 3;
        List<string> stringList4 = new List<string> { "ABC1", "DEF2", "GHI3", "JKL4", "MNO5", "PQR6" };
        var result4 = stringList4.Where(s => s.Length == K && char.IsDigit(s[^1])).OrderBy(s => s);
        Console.WriteLine("\nTask 4 Result:");
        foreach (var str in result4)
        {
            Console.WriteLine(str);
        }

        // TASK 5
        List<int> integerList = new List<int> { 3, 7, 2, 5, 8, 4, 1, 6 };
        var result5 = integerList.Where(num => num % 2 != 0).OrderBy(num => num).Select(num => num.ToString());
        Console.WriteLine("\nTask 5 Result:");
        foreach (var str in result5)
        {
            Console.WriteLine(str);
        }
    }
}
