namespace SelfCSharp.Chap10
{
    internal class DelegateLambda
    {
        void ArrayWalk(string[] data, Func<string, string> output)
        {
            foreach (var value in data)
            {
                Console.WriteLine(output(value));
            }
        }

        static void Main(string[] args)
        {
            var data = new[] { "あかまきがみ", "あおまきがみ", "きまきがみ" };

            var dl = new DelegateLambda();
            dl.ArrayWalk(data, (string d) =>
            {
                return $"[{d}]";
            });
        }
    }
}
