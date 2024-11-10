namespace Labb_3___Arv___Polymorphism
{
    internal class Square : Geometry
    {
        public double Side { get; set; }

        public Square()
        {
            Side = 5;
            Name = "square";
        }


        public override double Area()
        {
            return Side * Side;
        }
    }
}
