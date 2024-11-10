namespace Labb_3___Arv___Polymorphism
{
    internal class Rectangle : Geometry
    {
        public double Width { get; set; }
        public double Length { get; set; }

        public Rectangle()
        {
            Width = 5;
            Length = 10;
            Name = "rectangle";
        }

        public override double Area()
        {
            return Width * Length;
        }
    }
}
