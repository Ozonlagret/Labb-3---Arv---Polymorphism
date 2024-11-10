namespace Labb_3___Arv___Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            // Här används Geometry för att initiera olika klasser som har arvt från den
            // Fråga: Har det någon betydelse 
            Geometry square = new Square();
            Geometry circle = new Circle();
            Geometry rectangle = new Rectangle();

            Geometry[] shapes = { square, circle, rectangle };

            foreach (Geometry shape in shapes)
            {
                Console.WriteLine("The area of the " + shape + " is " + shape.Area());
            }
        }
    }
}
    



