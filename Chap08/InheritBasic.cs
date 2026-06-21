using SelfCSharp.Chap08.Prop;

namespace SelfCSharp.Chap08
{
    internal class BusinessPerson : Person
    {
        public string Work()
        {
            return $"{this.LastName}{this.FirstName}は、働きます。";
        }

        public new string Show()
        {
            return $"会社員の{this.LastName}{this.FirstName}です。";
        }
    }

    internal class InheritBasic
    {
        static void Main(string[] args)
        {
            var bp = new BusinessPerson
            {
                FirstName = "太郎",
                LastName = "山田"
            };
            Console.WriteLine(bp.Work()); // 山田太郎は、働きます。
            Console.WriteLine(bp.Show()); // 名前は山田太郎です。
        }
    }
}
