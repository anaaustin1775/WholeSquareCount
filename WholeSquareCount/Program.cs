using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WholeSquareCount
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();
            do
            {
                Console.Clear();
                var isValid = true;
                Console.Write("a = ");
                isValid = int.TryParse(Console.ReadLine(), out int a);
                if (!isValid) return;
                Console.Write("b = ");
                isValid = int.TryParse(Console.ReadLine(), out int b);
                if (!isValid) return;
                var result = solution.solution(a, b);
                Console.WriteLine(string.Join(", ", Array.ConvertAll(result,x => x.ToString())));
                Console.Write("Repeat? (y/n)");

            } while (ShouldRepeat());

        }

        static bool ShouldRepeat()
        {
            return Console.ReadKey(false).Key == ConsoleKey.Y;
        }
    }
}
