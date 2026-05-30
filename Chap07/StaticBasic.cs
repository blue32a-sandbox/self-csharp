namespace SelfCSharp.Chap07.MethodStatic
{
    internal class Figure
    {
        public static void GetTriangleArea(int width, int height)
        {
            Console.WriteLine($"三角形の面積は{width * height / 2}");
        }
    }

    internal class StaticBasic
    {
        static void Main(string[] args)
        {
            Figure.GetTriangleArea(10, 20); // 三角形の面積は100
        }
    }
}
