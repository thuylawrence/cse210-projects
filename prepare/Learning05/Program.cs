using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning05 World!");

        List<Shape> shapes = new List<Shape>();
        Square square = new Square("Orange", 2);
        shapes.Add(square);

        Rectangle rectangle = new Rectangle("Pink", 3, 4);
        shapes.Add(rectangle);

        Circle circle = new Circle("Purple", 5);
        shapes.Add(circle);

        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();

            double area = shape.GetArea();
            Console.WriteLine($"The {color} shape has an area of {area}. ");
        }

    }
}