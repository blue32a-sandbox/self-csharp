namespace SelfCSharp.Chap08.OverrideNg
{
    internal class Person
    {
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";

        public virtual string Show()
        {
            return $"名前は{this.LastName}{this.FirstName}です。";

        }
    }

    internal class BusinessPerson : Person
    {
        // sealed修飾子でオーバーライドを禁止
        public sealed override string Show()
        {
            return $"会社員の{this.LastName}{this.FirstName}です。";
        }
    }

    internal class EliteBusinessPerson : BusinessPerson
    {
        // エラー
        //public override string Show()
        //{
        //    return $"エリートな会社員の{this.LastName}{this.FirstName}です。";
        //}
    }

    internal class MethodNoOverride
    {
        static void Main(string[] args)
        {
            var ep = new EliteBusinessPerson
            {
                FirstName = "太郎",
                LastName = "山田"
            };
            Console.WriteLine(ep.Show());
        }
    }
}
