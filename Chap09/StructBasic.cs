namespace SelfCSharp.Chap09
{
    struct Coordinates
    {
        public double Latitude;
        public double Longitude;

        public override string ToString()
        {
            return $"緯度: {this.Latitude}／経度: {this.Longitude}";
        }
    }

    internal class StructBasic
    {
        static void Main(string[] args)
        {
            var c = new Coordinates();
            c.Latitude = 35.681167;
            c.Longitude = 139.767052;
            Console.WriteLine(c); // 緯度: 35.681167／経度: 139.767052
        }
    }
}
