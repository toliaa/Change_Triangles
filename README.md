## Change Triangles
This C# project demonstrates the implementation of a Rectangle class, which allows for operations such as moving rectangles on a plane, resizing them, finding the minimum enclosing rectangle containing two specified rectangles, and finding the intersection of two rectangles.

## File Structure
Rectangle.cs: Contains the implementation of the Rectangle class with properties and methods for manipulating rectangles.
Program.cs: Contains the main program logic demonstrating the usage of the Rectangle class.
Rectangle Class
The Rectangle class has the following properties:

Length: Represents the length of the rectangle.
Width: Represents the width of the rectangle.
XCoordinate: Represents the x-coordinate of the rectangle's top-left corner.
YCoordinate: Represents the y-coordinate of the rectangle's top-left corner.
And the following methods:

Move(deltaX, deltaY): Moves the rectangle by the specified amount in the x and y directions.
Resize(newLength, newWidth): Changes the dimensions of the rectangle to the specified length and width.
GetMinimumEnclosingRectangle(rect1, rect2): Returns the minimum enclosing rectangle that contains two specified rectangles.
GetIntersection(rect1, rect2): Returns the rectangle that represents the intersection of two specified rectangles.

## Usage
To use the Rectangle class, create instances of Rectangle and call its methods as needed. See the Program.cs file for examples of how to use the Rectangle class to perform various operations on rectangles.

## How to Run
Clone the repository to your local machine.
Open the project in Visual Studio or your preferred C# IDE.
Compile and run the program to see the output.
