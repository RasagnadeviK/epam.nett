using System;

class Program
{
    static void Main(string[] args)
    {
        // Tasks on Looping Statements
        // Task 1
        int n1 = 1234;
        Console.WriteLine($"Task 1: Sum of odd digits in {n1}: {CalculateSumOfOddDigits(n1)}");

        int n2 = 246;
        Console.WriteLine($"Task 1: Sum of odd digits in {n2}: {CalculateSumOfOddDigits(n2)}");

        // Task 2
        int n3 = 14;
        Console.WriteLine($"Task 2: Number of 1s in binary representation of {n3}: {CountOnesInBinary(n3)}");

        int n4 = 128;
        Console.WriteLine($"Task 2: Number of 1s in binary representation of {n4}: {CountOnesInBinary(n4)}");

        // Task 3
        int n5 = 8;
        Console.WriteLine($"Task 3: Sum of first {n5} Fibonacci numbers: {CalculateFibonacciSum(n5)}");

        int n6 = 11;
        Console.WriteLine($"Task 3: Sum of first {n6} Fibonacci numbers: {CalculateFibonacciSum(n6)}");

        // Tasks on Arrays
        // Task 1
        int[] arr1 = { 10, 5, 3, 4 };
        SwapEvenElements(arr1);
        Console.WriteLine($"Task 1: Swapped array: [{string.Join(", ", arr1)}]");

        int[] arr2 = { 100, 2, 3, 4, 5 };
        SwapEvenElements(arr2);
        Console.WriteLine($"Task 1: Swapped array: [{string.Join(", ", arr2)}]");

        int[] arr3 = { 100, 2, 3, 45, 33, 8, 4, 54 };
        SwapEvenElements(arr3);
        Console.WriteLine($"Task 1: Swapped array: [{string.Join(", ", arr3)}]");

        // Task 2
        int[] arr4 = { 4, 100, 3, 4 };
        Console.WriteLine($"Task 2: Distance between first and last max value: {CalculateMaxDistance(arr4)}");

        int[] arr5 = { 5, 50, 50, 4, 5 };
        Console.WriteLine($"Task 2: Distance between first and last max value: {CalculateMaxDistance(arr5)}");

        int[] arr6 = { 5, 350, 350, 4, 350 };
        Console.WriteLine($"Task 2: Distance between first and last max value: {CalculateMaxDistance(arr6)}");

        // Task 3
        int[,] matrix = {
            {2, 4, 3, 3},
            {5, 7, 8, 5},
            {2, 4, 3, 3},
            {5, 7, 8, 5}
        };
        ModifyMatrix(matrix);
        Console.WriteLine("Task 3: Modified matrix:");
        PrintMatrix(matrix);

        // Post-Lab
        // Constructing and accessing an array with dissimilar items
        object[] mixedArray = { "Hello", 10, 3.14, true };
        Console.WriteLine("Mixed Array:");
        foreach (var item in mixedArray)
        {
            Console.WriteLine(item);
        }
    }

    // Task 1: Looping Statements
    static int CalculateSumOfOddDigits(int n)
    {
        int sum = 0;
        while (n > 0)
        {
            int digit = n % 10;
            if (digit % 2 != 0)
            {
                sum += digit;
            }
            n /= 10;
        }
        return sum;
    }

    static int CountOnesInBinary(int n)
    {
        int count = 0;
        while (n > 0)
        {
            if (n % 2 == 1)
            {
                count++;
            }
            n /= 2;
        }
        return count;
    }

    static int CalculateFibonacciSum(int n)
    {
        int a = 0, b = 1, sum = 0;
        for (int i = 0; i < n; i++)
        {
            sum += a;
            int temp = a;
            a = b;
            b = temp + b;
        }
        return sum;
    }

    // Task 2: Arrays
    static void SwapEvenElements(int[] nums)
    {
        for (int i = 0; i < nums.Length / 2; i++)
        {
            if (nums[i] % 2 == 0 && nums[nums.Length - 1 - i] % 2 == 0)
            {
                int temp = nums[i];
                nums[i] = nums[nums.Length - 1 - i];
                nums[nums.Length - 1 - i] = temp;
            }
        }
    }

    static int CalculateMaxDistance(int[] nums)
    {
        int max = int.MinValue;
        int firstIndex = -1;
        int lastIndex = -1;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] > max)
            {
                max = nums[i];
                firstIndex = i;
                lastIndex = i;
            }
            else if (nums[i] == max)
            {
                lastIndex = i;
            }
        }

        return lastIndex - firstIndex;
    }

    static void ModifyMatrix(int[,] matrix)
    {
        int n = matrix.GetLength(0);
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (j < i)
                    matrix[i, j] = 0;
                else if (j > i)
                    matrix[i, j] = 1;
            }
        }
    }

    static void PrintMatrix(int[,] matrix)
    {
        int n = matrix.GetLength(0);
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write($"{matrix[i, j]} ");
            }
            Console.WriteLine();
        }
    }

    // Post-Lab
    // Analysis of tasks and usage of looping statements, arrays, and functions can be provided here.
}
