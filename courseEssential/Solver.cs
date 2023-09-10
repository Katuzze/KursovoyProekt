using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace courseEssential
{
    class Solver
    {
        private Task task;

        public Solver(Task task)
        {
            this.task = task;
        }

        private double CalculateDiscriminant()
        {
            return Math.Pow(task.B, 2) - 4 * task.A * task.C;
        }

        public Solution Solve()
        {
            double discriminant = CalculateDiscriminant();

            if (discriminant > 0)
            {
                double x1 = (-task.B + Math.Sqrt(discriminant)) / (2 * task.A);
                double x2 = (-task.B - Math.Sqrt(discriminant)) / (2 * task.A);
                return new Solution(x1, x2, Result.twoResult);
            }
            else if (discriminant == 0)
            {
                double x1 = -task.B / (2 * task.A);
                return new Solution(x1, Result.oneResult);
            }
            else
            {
                return new Solution(Result.noResult);
            }
        }
    }
}
