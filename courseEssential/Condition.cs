using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace courseEssential
{
    struct Condition
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public Condition(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }
    }
}
