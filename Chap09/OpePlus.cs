namespace SelfCSharp.Chap09.Operator
{
    internal class Coordinate
    {
        public int X { get; set; }
        public int Y { get; set; }

        public static Coordinate operator +(Coordinate c1, Coordinate c2)
        {
            return new Coordinate {
                X = c1.X + c2.X,
                Y = c1.Y + c2.Y
            };
        }

        public static Coordinate operator +(Coordinate c1, int x)
        {
            return new Coordinate
            {
                X = c1.X + x,
                Y = c1.Y
            };
        }
    }

    internal class OpePlus
    {
        static void Main(string[] args)
        {
            var c1 = new Coordinate { X = 10, Y = 20 };
            var c2 = new Coordinate { X = 15, Y = 25 };
            var c3 = c1 + c2;
            Console.WriteLine(c3.X); // 25
            Console.WriteLine(c3.Y); // 45

            var c4 = c1 + 5;
            Console.WriteLine(c4.X); // 15
            Console.WriteLine(c4.Y); // 20
        }
    }
}
