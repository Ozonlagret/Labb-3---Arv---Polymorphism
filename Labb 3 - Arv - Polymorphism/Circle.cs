namespace Labb_3___Arv___Polymorphism
{
    internal class Circle : Geometry
    {
        public double Radius { get; set; }

        public Circle()
        {
            Radius = 20;
            Name = "circle";
        }

        public override double Area()
        {
            return Radius * Radius * Math.PI;
        }
    }
}
