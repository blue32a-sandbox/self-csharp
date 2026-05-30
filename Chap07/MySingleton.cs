namespace SelfCSharp.Chap07
{
    internal class MySingleton
    {
        private static MySingleton instance = new MySingleton();

        private MySingleton() { }

        public static MySingleton Instance
        {
            get
            {
                return instance;
            }
        }

        static void Main(string[] args)
        {
            var s1 = MySingleton.Instance;
            var s2 = MySingleton.Instance;
            Console.WriteLine(s1 == s2); // True
        }
    }
}
