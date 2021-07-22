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
        public double X;
        public double Y;
        public double Z;
        public Vector(int size)
        {
            Size = size;
            Content = new Matrix(size, 1).Content;
        }
        public Vector(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
            Size = 3;
            Content = new double[3, 1];
            Content[0, 0] = x;
            Content[1, 0] = y;
            Content[2, 0] = z;
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
        public static Vector operator *(double n, Vector v)
        {
            return new Vector(v.X * n, v.Y * n, v.Z * n);
        }
        public static Vector operator *(Vector v, double n)
        {
            return new Vector(v.X * n, v.Y * n, v.Z * n);
        }
        public static Vector operator -(Vector p, Vector v)
        {
            return new Vector(p.X - v.X, p.Y - v.Y, p.Z - v.Z);
        }
        public static Vector operator +(Vector p, Vector v)
        {
            return new Vector(p.X + v.X, p.Y + v.Y, p.Z + v.Z);
        }
    }
}
