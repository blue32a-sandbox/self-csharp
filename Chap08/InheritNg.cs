namespace SelfCSharp.Chap08.Inherit
{
    internal sealed class Person
    {
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";

        public string Show()
        {
            return $"名前は{this.LastName}{this.FirstName}です。";
        }
    }

    // エラー
    //internal class BusinessPerson : Person { }

    internal class InheritNg
    {
        static void Main(string[] args)
        {
            var p = new Person()
            {
                FirstName = "太郎",
                LastName = "山田"
            };
            Console.WriteLine(p.Show());
        }
    }
}
