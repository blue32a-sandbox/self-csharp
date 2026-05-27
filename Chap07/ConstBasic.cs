namespace SelfCSharp.Chap07.ClassConst
{
    internal class Person
    {
        public string fristName;
        public string lastName;

        public Person(string fristName, string lastName)
        {
            this.fristName = fristName;
            this.lastName = lastName;
        }

        public string Show()
        {
            return $"名前は{this.lastName}{this.fristName}です。";
        }
    }

    internal class ConstBasic
    {
        static void Main(string[] args)
        {
            var p = new Person("太郎", "山田");
            Console.WriteLine(p.Show()); // 名前は山田太郎です。
        }
    }
}
