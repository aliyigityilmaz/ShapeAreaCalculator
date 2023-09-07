Console.WriteLine("What shape would you like to calculate the area for? (C)ircle or (R)ectangle");
string shapeType = Console.ReadLine();
if (shapeType == "c")
{
    Console.WriteLine("What is the radius of the circle?");
    double radius = Convert.ToDouble(Console.ReadLine());
    double area = Math.PI * radius * radius;
    Console.WriteLine("Area of this circle is: " + area);
}
else if (shapeType == "r")
{
    Console.WriteLine("What is the length of the rectangle?");
    double length = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("What is the width of the rectangle?");
    double width = Convert.ToDouble(Console.ReadLine());
    double area = length * width;
    Console.WriteLine("Area of this rectangle is: " + area);
}
else
{
    Console.WriteLine("Invalid shape type");
}
