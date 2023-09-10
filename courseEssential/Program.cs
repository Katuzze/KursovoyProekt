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

            Console.WriteLine("квадратне рівняння: ax² + bx + c = 0");
            Console.WriteLine("Введіть значення a");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введіть значення b");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введіть значення c");
            double num3 = Convert.ToDouble(Console.ReadLine());

            Task task = new Task(num1, num2, num3);
            Solver solver = new Solver(task);
            Solution solution = solver.Solve();
            Console.WriteLine(solution);

            Console.ReadKey();
        }
    }
}
