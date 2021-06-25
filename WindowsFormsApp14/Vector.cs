using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp14
{
    public class Vector : Matrix
    {
        public int Size { get; }
        public Vector(int size)
        {
            Size = size;
            Content = new Matrix(size, 1).Content;
        }
        public double this[int i]
        {
            get
            {
                return this[i, 0];
            }
            set
            {
                this[i, 0] = value;
            }
        }
        public static double operator *(Vector a, Vector b)
        {
            var aM = (Matrix)a;
            var bM = b.Transpose();
            return (aM * bM)[0,0];
        }
    }
}
