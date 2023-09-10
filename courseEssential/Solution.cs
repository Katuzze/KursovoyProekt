using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace courseEssential
{
    class Solution
    {
        public double x1;
        public double x2;
        public Result Result;

        public Solution(double x1, double x2, Result result)
        {
            this.x1 = x1;
            this.x2 = x2;
            this.Result = result;
        }

        public Solution(double x1, Result result)
        {
            this.x1 = x1;
            this.Result = result;
        }

        public Solution(Result result)
        {
            this.Result = result;
        }

        public override string ToString()
        {
            switch(Result)
            {
                case Result.twoResult:
                    return $"x₁ = {x1} \nx₂ = {x2}";
                case Result.oneResult:
                    return $"x = {x1}";
                default:
                    return "Немає розв'язків";
            }
        }
    }
}
