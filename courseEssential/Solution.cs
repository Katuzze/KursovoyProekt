using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace courseEssential
{
    class Solution
    {
        public readonly double X1;
        public readonly double X2;
        public ResultMessage Result;

        public Solution(double x1, double x2, ResultMessage result)
        {
            this.X1 = x1;
            this.X2 = x2;
            this.Result = result;
        }

        public Solution(double x1, ResultMessage result)
        {
            this.X1 = x1;
            this.Result = result;
        }

        public Solution(ResultMessage result)
        {
            this.Result = result;
        }

        public override string ToString()
        {
            switch(Result)
            {
                case ResultMessage.TwoResult:
                    return $"x₁ = {X1} \nx₂ = {X2}";
                case ResultMessage.OneResult:
                    return $"x = {X1}";
                default:
                    return "Немає розв'язків";
            }
        }
    }
}
