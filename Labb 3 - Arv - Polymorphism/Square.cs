namespace Labb_3___Arv___Polymorphism
{
    internal class Square : Geometry
    {
        public double Side { get; set; }

        public Square()
        {
            Side = 5;
            // Slipper göra en ny ToString override på varje form för att det hanterades i huvudklassen
            Name = "square"; //exempel på polymorfism, Name får ett nytt värde i denna subklass, och får andra namn i de andra klasserna.  
        }

        // Samma area metod som i Geometry, men nu använder den en ny ekvation
        public override double Area()
        {
            return Side * Side;
        }
    }
}
