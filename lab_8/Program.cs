using System;

public class ArrayEventArgs<T> : EventArgs
{
    public int Id { get; set; }
    public T Value { get; set; }
    public string Message { get; set; }
}

public delegate void ArrayHandler<T>(object sender, ArrayEventArgs<T> e);

public class CustomArray<T>
{
    private T[] array;
    private int startIndex;
    private int length;

    public event ArrayHandler<T> OnChangeElement;
    public event ArrayHandler<T> OnChangeEqualElement;

    public CustomArray(int length, int startIndex)
    {
        if (length <= 0)
            throw new ArgumentException("Length must be greater than zero.");

        this.array = new T[length];
        this.startIndex = startIndex;
        this.length = length;
    }

    public CustomArray(T[] initialValues, int startIndex)
    {
        if (initialValues == null)
            throw new ArgumentNullException(nameof(initialValues));

        this.array = initialValues;
        this.startIndex = startIndex;
        this.length = initialValues.Length;
    }

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
            
            if (array[index - startIndex].Equals(value))
                return; // No change, so don't raise events
            
            // Raise OnChangeElement event
            OnChangeElement?.Invoke(this, new ArrayEventArgs<T> { Id = index, Value = value, Message = "Element changed." });

            // Raise OnChangeEqualElement event if value equals index
            if (value.Equals(index))
                OnChangeEqualElement?.Invoke(this, new ArrayEventArgs<T> { Id = index, Value = value, Message = "Element value equals index." });

            array[index - startIndex] = value;
        }
    }

    private bool IsIndexInRange(int index)
    {
        return index >= startIndex && index < startIndex + length;
    }
}

class Program
{
    static void Main(string[] args)
    {
        CustomArray<int> intArray = new CustomArray<int>(10, 1);
        intArray.OnChangeElement += IntArray_OnChangeElement;
        intArray.OnChangeEqualElement += IntArray_OnChangeEqualElement;
        
        // Changing some elements
        intArray[1] = 10; // Raises OnChangeElement event
        intArray[2] = 2; // No event raised since old and new value are the same
        intArray[3] = 3; // Raises OnChangeElement and OnChangeEqualElement events since value equals index
    }

    private static void IntArray_OnChangeElement(object sender, ArrayEventArgs<int> e)
    {
        Console.WriteLine($"Element at index {e.Id} changed to {e.Value}. Message: {e.Message}");
    }

    private static void IntArray_OnChangeEqualElement(object sender, ArrayEventArgs<int> e)
    {
        Console.WriteLine($"Element value equals index at index {e.Id}. Message: {e.Message}");
    }
}
