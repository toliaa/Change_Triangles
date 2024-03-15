using System;

public class Rectangle
{
    public double Length { get; private set; }
    public double Width { get; private set; }
    public double XCoordinate { get; private set; }
    public double YCoordinate { get; private set; }

    public Rectangle(double length, double width, double xCoordinate, double yCoordinate)
    {
        Length = length;
        Width = width;
        XCoordinate = xCoordinate;
        YCoordinate = yCoordinate;
    }

    public void Move(double deltaX, double deltaY)
    {
        XCoordinate += deltaX;
        YCoordinate += deltaY;
    }

    public void Resize(double newLength, double newWidth)
    {
        Length = newLength;
        Width = newWidth;
    }

    public static Rectangle GetMinimumEnclosingRectangle(Rectangle rect1, Rectangle rect2)
    {
        double minX = Math.Min(rect1.XCoordinate, rect2.XCoordinate);
        double minY = Math.Min(rect1.YCoordinate, rect2.YCoordinate);
        double maxX = Math.Max(rect1.XCoordinate + rect1.Length, rect2.XCoordinate + rect2.Length);
        double maxY = Math.Max(rect1.YCoordinate + rect1.Width, rect2.YCoordinate + rect2.Width);

        double enclosingLength = maxX - minX;
        double enclosingWidth = maxY - minY;

        return new Rectangle(enclosingLength, enclosingWidth, minX, minY);
    }

    public static Rectangle GetIntersection(Rectangle rect1, Rectangle rect2)
    {
        double minX = Math.Max(rect1.XCoordinate, rect2.XCoordinate);
        double minY = Math.Max(rect1.YCoordinate, rect2.YCoordinate);
        double maxX = Math.Min(rect1.XCoordinate + rect1.Length, rect2.XCoordinate + rect2.Length);
        double maxY = Math.Min(rect1.YCoordinate + rect1.Width, rect2.YCoordinate + rect2.Width);

        double intersectionLength = Math.Max(0, maxX - minX);
        double intersectionWidth = Math.Max(0, maxY - minY);

        return new Rectangle(intersectionLength, intersectionWidth, minX, minY);
    }
}
