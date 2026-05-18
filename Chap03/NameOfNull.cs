namespace SelfCSharp.Chap03
{
    internal class NameOfNull
    {
        static void Main(string[] args)
        {
            new NameOfNull().Hoge(null);
        }

        public void Hoge(string? str)
        {
            if (str == null)
            {
                throw new ArgumentNullException(nameof(str));
            }
            Console.WriteLine(str);
        }
    }
}
