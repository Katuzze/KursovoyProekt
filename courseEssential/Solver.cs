using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace courseEssential
{
    class Solver
    {
        private readonly Condition condition;

        public Solver(Condition condition)
        {
            this.condition = condition;
        }

        private double CalculateDiscriminant()
        {
            return Math.Pow(condition.B, 2) - 4 * condition.A * condition.C;
        }

        public Solution Solve()
        {
            double discriminant = CalculateDiscriminant();

            if (discriminant > 0)
            {
                double x1 = (-condition.B + Math.Sqrt(discriminant)) / (2 * condition.A);
                double x2 = (-condition.B - Math.Sqrt(discriminant)) / (2 * condition.A);
                return new Solution(x1, x2, resultMessage.TwoResult);
            }
            else if (discriminant == 0)
            {
                double x1 = -condition.B / (2 * condition.A);
                return new Solution(x1, resultMessage.OneResult);
            }
            else
            {
                return new Solution(resultMessage.NoResult);
            }
        }
    }
}
