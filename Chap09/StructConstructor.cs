namespace SelfCSharp.Chap09.Struct
{
    struct Coordinates
    {
        public double Latitude;
        public double Longitude;

        public Coordinates(double latitude, double longitude)
        {
            this.Latitude = latitude;
            this.Longitude = longitude;
        }

        public override string ToString()
        {
            return $"緯度: {this.Latitude}／経度: {this.Longitude}";
        }
    }

    internal class StructConstructor
    {
        static void Main(string[] args)
        {
            var c = new Coordinates(35.681167, 139.767052);
            Console.WriteLine(c); // 緯度: 35.681167／経度: 139.767052
        }
    }
}
