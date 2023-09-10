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
        public result Result;

        public Solution(double x1, double x2, result result)
        {
            this.x1 = x1;
            this.x2 = x2;
            this.Result = result;
        }

        public Solution(double x1, result result)
        {
            this.x1 = x1;
            this.Result = result;
        }

        public Solution(result result)
        {
            this.Result = result;
        }

        public override string ToString()
        {
            switch(Result)
            {
                case result.twoResult:
                    return $"x1 = {x1}, x2 = {x2}";
                case result.oneResult:
                    return $"x = {x1}";
                default:
                    return "Немає розв'язків";
            }
        }

        public enum result
        {
            oneResult,
            twoResult,
            noResult,
        }
    }
}
