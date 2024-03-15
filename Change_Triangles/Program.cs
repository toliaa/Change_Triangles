using System;

class Program
{
    static void Main()
    {
        Rectangle rect1 = new Rectangle(5, 3, 0, 0);
        Rectangle rect2 = new Rectangle(4, 2, 2, 1);
        

        // Moving rectangles
        rect1.Move(2, 3);
        Console.WriteLine($"Rectangle 1 new position: ({rect1.XCoordinate}, {rect1.YCoordinate})");

        // Resizing rectangles
        rect2.Resize(6, 4);
        Console.WriteLine($"Rectangle 2 new dimensions: ({rect2.Length}, {rect2.Width})");

        // Finding minimum enclosing rectangle
        Rectangle minEnclosingRect = Rectangle.GetMinimumEnclosingRectangle(rect1, rect2);
        Console.WriteLine($"Minimum enclosing rectangle dimensions: ({minEnclosingRect.Length}, {minEnclosingRect.Width})");

        // Finding intersection rectangle
        Rectangle intersectionRect = Rectangle.GetIntersection(rect1, rect2);
        Console.WriteLine($"Intersection rectangle dimensions: ({intersectionRect.Length}, {intersectionRect.Width})");
    }
}
