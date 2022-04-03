class Program
{

    public class Rectangle
    {
        public double X { get; set; }
        public double Y { get; set; }
        public Rectangle(double x, double y) => (X, Y) = (x, y);
        public Rectangle() : this(0, 0) { }
        public double P() => 2 * Math.Abs(X) + 2 * Math.Abs(Y);
        public override string ToString() => $"X={X}   Y={Y}    P={P()}";
    }

    public class Nasl_c : Rectangle
    {

        public double C { get; set; }
        public Nasl_c(double c) => (C) = (c);
        public Nasl_c() : this(0) { }

        public double Enlarge() => (X * C) * (Y * C);
        public override string ToString() => $"C={C}   Enlarge={Enlarge()}";

    }
    public class Schet
    {
        static void Main(string[] args)
        {
            var rec = new Rectangle(7, 15);
            var nasl_c = new Nasl_c(5);
            Console.WriteLine(rec.ToString());
            Console.WriteLine(nasl_c.ToString());

        }
    }


}