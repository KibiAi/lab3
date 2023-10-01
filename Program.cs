using lab3;
using System.Drawing;


class Program
{
    static void Main ()
    {
        Console.WriteLine("Введіть довжину першої сторони прямокутника:");
        double side1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введіть довжину другої сторони прямокутника:");
        double side2 = Convert.ToDouble(Console.ReadLine());

        lab3.Rectangle rectangle = new lab3.Rectangle(side1, side2);

        Console.WriteLine($"Площа прямокутника: {rectangle.Area}");
        Console.WriteLine($"Периметр прямокутника: {rectangle.Perimeter}");

        Console.ReadLine();

        lab3.Point point1 = new lab3.Point(0, 0, "A");
        lab3.Point point2 = new lab3.Point(0, 4, "B");
        lab3.Point point3 = new lab3.Point(3, 0, "C");

        Figure triangle = new Figure(point1, point2, point3);
        triangle.CalculatePerimeter();

        lab3.Point point4 = new lab3.Point(0, 0, "A");
        lab3.Point point5 = new lab3.Point(0, 4, "B");
        lab3.Point point6 = new lab3.Point(3, 4, "C");
        lab3.Point point7 = new lab3.Point(3, 0, "D");

        Figure quadrilateral = new Figure(point4, point5, point6, point7);
        quadrilateral.CalculatePerimeter();

        Console.ReadLine();
    }
}

