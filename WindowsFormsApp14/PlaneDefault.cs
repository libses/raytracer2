using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp14
{
    public class PlaneDefault
    {
        public double A;
        public double B;
        public double C;
        public double D;
        public Vector Normal { get
            {
                return new Vector(A, B, C);
            }
        }
        public Vector Reflect(Vector x)
        {
            return x - (2 * Normal * (Normal * x));
        }
    }
}
