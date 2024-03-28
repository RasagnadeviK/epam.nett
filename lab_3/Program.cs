using System;

// Task 1: Rectangle class
class Rectangle
{
    private double sideA;
    private double sideB;

    // Constructor with two real parameters a and b
    public Rectangle(double a, double b)
    {
        sideA = a;
        sideB = b;
    }

    // Constructor with a real parameter a (side B is always equal to 5)
    public Rectangle(double a)
    {
        sideA = a;
        sideB = 5;
    }

    // Constructor without parameters (side A = 4, side B = 3)
    public Rectangle()
    {
        sideA = 4;
        sideB = 3;
    }

    // Method to get side A
    public double GetSideA()
    {
        return sideA;
    }

    // Method to get side B
    public double GetSideB()
    {
        return sideB;
    }

    // Method to calculate area
    public double Area()
    {
        return sideA * sideB;
    }

    // Method to calculate perimeter
    public double Perimeter()
    {
        return 2 * (sideA + sideB);
    }

    // Method to check if rectangle is square
    public bool IsSquare()
    {
        return sideA == sideB;
    }

    // Method to replace sides of the rectangle
    public void ReplaceSides()
    {
        double temp = sideA;
        sideA = sideB;
        sideB = temp;
    }
}

// Task 2: ArrayRectangles class
class ArrayRectangles
{
    private Rectangle[] rectangleArray;

    // Constructor creating an empty array of rectangles with length n
    public ArrayRectangles(int n)
    {
        rectangleArray = new Rectangle[n];
    }

    // Constructor that receives an arbitrary amount of Rectangle objects or an array of Rectangle objects
    public ArrayRectangles(params Rectangle[] rectangles)
    {
        rectangleArray = rectangles;
    }

    // Method to add a rectangle to the array
    public bool AddRectangle(Rectangle rectangle)
    {
        for (int i = 0; i < rectangleArray.Length; i++)
        {
            if (rectangleArray[i] == null)
            {
                rectangleArray[i] = rectangle;
                return true;
            }
        }
        return false; // No free space
    }

    // Method to find the order number of the rectangle with the maximum area
    public int NumberMaxArea()
    {
        double maxArea = 0;
        int index = -1;

        for (int i = 0; i < rectangleArray.Length; i++)
        {
            if (rectangleArray[i] != null && rectangleArray[i].Area() > maxArea)
            {
                maxArea = rectangleArray[i].Area();
                index = i;
            }
        }

        return index;
    }

    // Method to find the order number of the rectangle with the minimum perimeter
    public int NumberMinPerimeter()
    {
        double minPerimeter = double.MaxValue;
        int index = -1;

        for (int i = 0; i < rectangleArray.Length; i++)
        {
            if (rectangleArray[i] != null && rectangleArray[i].Perimeter() < minPerimeter)
            {
                minPerimeter = rectangleArray[i].Perimeter();
                index = i;
            }
        }

        return index;
    }

    // Method to count the number of squares in the array
    public int NumberSquare()
    {
        int count = 0;
        foreach (Rectangle rectangle in rectangleArray)
        {
            if (rectangle != null && rectangle.IsSquare())
            {
                count++;
            }
        }
        return count;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Test Task 1: Rectangle class
        Rectangle rect1 = new Rectangle(4, 5);
        Console.WriteLine($"Area: {rect1.Area()}, Perimeter: {rect1.Perimeter()}, Is Square: {rect1.IsSquare()}");

        // Test Task 2: ArrayRectangles class
        ArrayRectangles arrayRectangles = new ArrayRectangles(5);
        arrayRectangles.AddRectangle(new Rectangle(3, 4));
        arrayRectangles.AddRectangle(new Rectangle(5));
        arrayRectangles.AddRectangle(new Rectangle());
        Console.WriteLine($"Max Area Rectangle Index: {arrayRectangles.NumberMaxArea()}");
        Console.WriteLine($"Min Perimeter Rectangle Index: {arrayRectangles.NumberMinPerimeter()}");
        Console.WriteLine($"Number of Squares: {arrayRectangles.NumberSquare()}");
    }
}
