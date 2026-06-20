namespace SelfCSharp.Chap08
{
    internal class FreeArray
    {
        private int _size;
        private int[] _list;

        public FreeArray(int size)
        {
            _size = size;
            _list = new int[size];
        }

        // インデクサー
        public int this[int index]
        {
            set
            {
                this._list[this.GetIndex(index)] = value;
            }

            get
            {
                return this._list[this.GetIndex(index)];
            }
        }

        private int GetIndex(int index)
        {
            if (index < 0)
            {
                return 0;
            }

            return index % this._size;
        }
    }

    internal class IndexerBasic
    {
        static void Main(string[] args)
        {
            var array = new FreeArray(5);
            array[0] = 1;
            array[1] = 10;
            array[2] = 15;
            array[3] = 30;
            array[4] = 60;

            Console.WriteLine(array[2]); // 15
            Console.WriteLine(array[-10]); // 1;
            Console.WriteLine(array[6]); // 10
        }
    }
}
