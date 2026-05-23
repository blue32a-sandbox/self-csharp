namespace SelfCSharp.Chap06
{
    internal class DicBasic
    {
        static void Main(string[] args)
        {
            var dic = new Dictionary<string, string>()
            {
                ["Rose"] = "バラ",
                ["Sunflower"] = "ひまわり",
                ["Moring Glory"] = "あさがお",
            };

            Console.WriteLine(dic.Count); // 3
            Console.WriteLine(dic.ContainsKey("Rose")); // True
            Console.WriteLine(dic.ContainsValue("バラ")); // True

            dic.TryGetValue("Rose", out var name);
            Console.WriteLine(name); // バラ

            dic.Add("Tulip", "チューリップ");
            dic["Sunflower"] = "向日葵";

            foreach (var key in dic.Keys)
            {
                Console.WriteLine($"{key}: {dic[key]}");
            }

            foreach (var d in dic.Values)
            {
                Console.WriteLine(d);
            }

            dic.Remove("Rose");

            foreach (var m in dic)
            {
                Console.WriteLine($"{m.Key}: {m.Value}");
            }
        }
    }
}
