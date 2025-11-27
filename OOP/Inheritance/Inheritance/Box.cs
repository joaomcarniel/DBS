namespace Inheritance
{
    internal class Box : Rectangle
    {
        public double Height { get; set; }
        public Box() { }
        public Box(double length, double width, double height)
                : base (length, width)
        {
            Height = height;
        }

        public double Volume()
        {
            return Length * Width * Height;
        }
    }
}
