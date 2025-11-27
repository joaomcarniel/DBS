namespace Inheritance
{
    internal class Rectangle
    {
        // auto-implemented properties
        public double Length { get; set; }
        public double Width { get; set; }
        //primary constructor
        public Rectangle() { }

        //parameterised constructor
        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }
    }
}
