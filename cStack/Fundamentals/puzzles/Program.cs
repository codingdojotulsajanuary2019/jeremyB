using System;

namespace puzzles
{
    class Program
    {
        static void Main(string[] args)
        {
          Puzzle.rand();
          Puzzle.flip();
          Puzzle.multiFlip(50);
          Puzzle.names();
        }
    }
}
