using System.Globalization;
using AtividadeAbstrata.Entities;

namespace Area
{
    class Program
    {
        static void Main (string [] args)
        {
            List<Shape> list = new List<Shape>();
            Console.Write("Enter the number of shapes: ");
            int number = int.Parse(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                System.Console.WriteLine("Shape #" + i + " data: ");
                Console.Write("Rectangle or Circle (r/c): ");
                char letter = char.Parse(Console.ReadLine());
                Console.Write("Color (Black/Blue/Red) ");
                Color color = Enum.Parse<Color>(Console.ReadLine());
                if (letter == 'r')
                {
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    list.Add(new Rectangle (width, height, color));
                }
                else
                {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Circle(radius, color));
                }
            }
            foreach (Shape shap in list)
            {
                Console.WriteLine("Radius: " + shap.Area().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}