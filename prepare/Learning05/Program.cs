using System;

class Program
{
    static void Main(string[] args)
    {


        Square square = new Square();
        square.SetColor("red");
        square.SetSide(10);
        square.GetArea();

        Circle circle = new Circle();
        circle.SetColor("yellow");
        circle.SetRadius(20);
        //circle.GetArea();

        Rectangle rectangle = new Rectangle();
        rectangle.SetColor("green");
        rectangle.SetLenght(10);
        rectangle.SetWidth(20);



        List<Shape> shape = new List<Shape>();
        shape.Add(square);
        shape.Add(rectangle);
        shape.Add(circle);



        foreach (Shape item in shape)
        {
            Console.WriteLine(item.GetColor());
            Console.WriteLine(item.GetArea());
            Console.WriteLine($"The {item.GetColor()} shape has an area of {item.GetArea()}.");
            Console.WriteLine("");

        }
    }
}