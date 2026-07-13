namespace SelfCSharp.Chap11
{
    internal class LockBasic
    {
        public int Count { get; private set; } = 0;
        object lockobj = new object();

        static void Main(string[] args)
        {
            const int TaskNum = 500000;
            var ts = new Task[TaskNum];
            var tb = new LockBasic();

            for (var i = 0; i < TaskNum; i++)
            {
                ts[i] = Task.Run(() => tb.Increment());
            }

            for (var i = 0; i < TaskNum; i++)
            {
                ts[i].Wait();
            }

            Console.WriteLine(tb.Count); // 500000
        }

        void Increment()
        {
            lock (lockobj)
            {
                this.Count++;
            }
        }
    }
}
