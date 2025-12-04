namespace Task1
{
    public class Rectangle
    {
        public double Length { get; set; }
        public double Breadth { get; set; }

        public double Area => Length * Breadth;

        public Rectangle(double length, double breadth) =>
            (Length, Breadth) = (length, breadth);

        public double Perimeter() => 2 * (Length + Breadth);

        public void Resize(double newLength, double newBreadth) =>
            (Length, Breadth) = (newLength, newBreadth);
    }
}
