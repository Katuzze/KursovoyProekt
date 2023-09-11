using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace courseEssential
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("квадратне рівняння");
            Console.WriteLine("ax² + bx + c = 0");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("━━━━━━━━━━━━━━━━━━━━━");
            Console.ResetColor();
            Console.Write("Введіть значення a: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введіть значення b: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введіть значення c: ");
            double num3 = Convert.ToDouble(Console.ReadLine());

            Condition condition = new Condition(num1, num2, num3);
            Solver solver = new Solver(condition);
            Solution solution = solver.Solve();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("━━━━━━━━━━━━━━━━━━━━━");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(solution);
            Console.ResetColor();

            Console.ReadLine();
        }
    }
}
