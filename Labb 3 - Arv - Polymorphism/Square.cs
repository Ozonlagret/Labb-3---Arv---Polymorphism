namespace Labb_3___Arv___Polymorphism
{
    internal class Square : Geometry
    {
        public double Side { get; set; }

        public Square()
        {
            Side = 5;
            // Slipper göra en ny ToString override på varje form för att det hanterades i huvudklassen
            Name = "square";
        }


        public override double Area()
        {
            return Side * Side;
        }
    }
}
