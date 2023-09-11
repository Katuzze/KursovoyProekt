using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace courseEssential
{
    class Solution
    {
        public double X1 { get; }
        public double X2 { get; }
        public resultMessage Result { get; }

        public Solution(double x1, double x2, resultMessage result)
        {
            X1 = x1;
            X2 = x2;
            Result = result;
        }

        public Solution(double x1, resultMessage result)
        {
            X1 = x1;
            Result = result;
        }

        public Solution(resultMessage result)
        {
            Result = result;
        }

        public override string ToString()
        {
            switch(Result)
            {
                case resultMessage.TwoResult:
                    return $"x₁ = {X1} \nx₂ = {X2}";
                case resultMessage.OneResult:
                    return $"x = {X1}";
                default:
                    return "Немає розв'язків";
            }
        }
    }
}
