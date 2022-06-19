using System;

namespace Game84
{
    class Program
    {
        static void Main(string[] args)
        {
            Game84 a = new Game84();

            for (int i = 1; i <= 84; i++)
                Console.WriteLine("Game: " + a._84[i-1]);
        }
    }

    class Game84
    {
        public int[] _84 = new int[84];

        public Game84()
        {
            for (int i = 1; i <= 84; i++)
            {
                _84[i - 1] = i;
            }
        }
    }
}
