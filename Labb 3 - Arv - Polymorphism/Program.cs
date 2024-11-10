namespace Labb_3___Arv___Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            // Här används Geometry för att initiera olika klasser som har arvt från den
            // Fråga: Har det någon betydelse om man sätter Geometry istället för respektive underklass först?
            Geometry square = new Square();
            Geometry circle = new Circle();
            Geometry rectangle = new Rectangle();

            Geometry[] shapes = { square, circle, rectangle };

            // Får ut flera värden med en simpel loop för att klasserna har gemensamma objekt med olika värden
            foreach (Geometry shape in shapes)
            {
                Console.WriteLine("The area of the " + shape + " is " + shape.Area());
            }
        }
    }
}
    



