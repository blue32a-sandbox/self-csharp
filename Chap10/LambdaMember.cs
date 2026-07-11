namespace SelfCSharp.Chap10
{
    internal class LambdaMember
    {
        private int _value;

        // コンストラクター
        LambdaMember() => Console.WriteLine("constructor");

        // プロパティ
        public int Value
        {
            get => this._value;
            set => this._value = value;
        }

        // get-onlyプロパティ
        public DateTime Current => DateTime.Now;

        // インデクサー
        public int this[int index] => this.Value * index;

        // メソッド
        public int Calculate() => this.Value * this.Value;

        // 演算子
        public static bool operator true(LambdaMember e) => e.Value == 0;
        public static bool operator false(LambdaMember e) => e.Value != 0;

        static void Main(string[] args)
        {
            var lm = new LambdaMember
            {
                Value = 2
            }; // constructor
            Console.WriteLine(lm.Current); // YYYY/MM/DD HH:MM:SS
            Console.WriteLine(lm[3]); // 6
            Console.WriteLine(lm.Calculate()); // 4

            if (lm)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}
