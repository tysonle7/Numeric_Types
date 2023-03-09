using System;

namespace Numeric_Types
{
    class Program
    {
        static void Main ()
        {
            
        Console.WriteLine("Length of rectangle: ");
        double length = double.Parse(Console.ReadLine());

        Console.WriteLine("Width of rectangle: ");
        double width = double.Parse(Console.ReadLine());

        double area = length * width;
        Console.WriteLine("The area of rectangle is {0}", area);
        }
    }
}