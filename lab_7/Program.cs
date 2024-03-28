using System;
using System.Collections;
using System.Collections.Generic;

public class CustomArray<T> : IEnumerable<T>
{
    private T[] array;
    private int startIndex;
    private int length;

    // Constructor to create an empty array
    public CustomArray(int length, int startIndex)
    {
        if (length <= 0)
            throw new ArgumentException("Length must be greater than zero.");
        
        this.array = new T[length];
        this.startIndex = startIndex;
        this.length = length;
    }

    // Constructor to create an array with initial values
    public CustomArray(T[] initialValues, int startIndex)
    {
        if (initialValues == null)
            throw new ArgumentNullException(nameof(initialValues));
        
        this.array = initialValues;
        this.startIndex = startIndex;
        this.length = initialValues.Length;
    }

    // Indexer to access array elements
    public T this[int index]
    {
        get
        {
            if (!IsIndexInRange(index))
                throw new IndexOutOfRangeException("Index is out of range.");
            return array[index - startIndex];
        }
        set
        {
            if (!IsIndexInRange(index))
                throw new IndexOutOfRangeException("Index is out of range.");
            array[index - startIndex] = value;
        }
    }

    // Method to get the first index
    public int GetFirstIndex()
    {
        return startIndex;
    }

    // Method to get the last index
    public int GetLastIndex()
    {
        return startIndex + length - 1;
    }

    // Method to get the length of the array
    public int GetLength()
    {
        return length;
    }

    // Method to get all elements as a standard array starting from index 0
    public T[] GetAllElements()
    {
        return array;
    }

    // Method to check if index is within range
    private bool IsIndexInRange(int index)
    {
        return index >= startIndex && index < startIndex + length;
    }

    // Implementation of IEnumerable<T> interface
    public IEnumerator<T> GetEnumerator()
    {
        return ((IEnumerable<T>)array).GetEnumerator();
    }

    // Implementation of IEnumerable interface
    IEnumerator IEnumerable.GetEnumerator()
    {
        return array.GetEnumerator();
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Example usage of CustomArray
        CustomArray<int> intArray = new CustomArray<int>(10, 1);
        for (int i = 1; i <= 10; i++)
        {
            intArray[i] = i;
        }

        Console.WriteLine("First index: " + intArray.GetFirstIndex());
        Console.WriteLine("Last index: " + intArray.GetLastIndex());
        Console.WriteLine("Array length: " + intArray.GetLength());
        Console.WriteLine("Elements:");
        foreach (int num in intArray)
        {
            Console.WriteLine(num);
        }
    }
}
