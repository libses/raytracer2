using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp14
{
    public class Matrix
    {
        public Matrix() { }
        public override bool Equals(object obj)
        {
            var m = (Matrix)obj;
            for (int x = 0; x < xSize; x++)
            {
                for (int y = 0; y < ySize; y++)
                {
                    if (Math.Abs(this[x,y] - m[x,y]) > 0.0000001)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public override string ToString()
        {
            var sb = new StringBuilder();
            for (int y = 0; y < xSize; y++)
            {
                for (int x = 0; x < ySize; x++)
                {
                    sb.Append(this[x, y] + "\t");
                }
                sb.Append("\n");
            }
            return sb.ToString();
        }
        public int xSize { get { return Content.GetLength(0); } }
        public int ySize { get { return Content.GetLength(1); } }

        public double[,] Content;
        public Matrix(int x, int y)
        {
            Content = new double[x, y];
        }
        public double this[int x, int y]
        {
            get { return this.Content[x, y]; }
            set { this.Content[x, y] = value; }
        }
        public static Matrix operator +(Matrix that, Matrix other)
        {
            var xSize = other.xSize;
            var ySize = other.ySize;
            if (that.xSize != xSize || that.ySize != ySize) throw new Exception();
            var result = new Matrix(xSize, ySize);
            for (int x = 0; x < xSize; x++)
            {
                for (int y = 0; y < ySize; y++)
                {
                    result[x, y] = that[x, y] + other[x, y];
                }
            }
            return result;
        }
        public static Matrix operator -(Matrix that, Matrix other)
        {
            var xSize = other.xSize;
            var ySize = other.ySize;
            if (that.xSize != xSize || that.ySize != ySize) throw new Exception();
            var result = new Matrix(xSize, ySize);
            for (int x = 0; x < xSize; x++)
            {
                for (int y = 0; y < ySize; y++)
                {
                    result[x, y] = that[x, y] - other[x, y];
                }
            }
            return result;
        }
        public static Matrix operator *(Matrix that, Matrix other)
        {
            if (that.xSize != other.ySize) { throw new Exception(); }
            var result = new Matrix(other.xSize, that.ySize);
            for (int x = 0; x < other.xSize; x++)
            {
                for (int y = 0; y < that.ySize; y++)
                {
                    for (int i = 0; i < other.ySize; i++)
                    {
                        result[x, y] += that[i, y] * other[x, i];
                    }
                }
            }
            return result;
        }

        public Matrix Transpose()
        {
            var result = new Matrix(ySize, xSize);
            for (int x = 0; x < xSize; x++)
            {
                for (int y = 0; y < ySize; y++)
                {
                    result[y, x] = this[x, y];
                }
            }
            return result;
        }
    }

    public class MatrixTests
    {
        [Test]
        public void Multiply2on2()
        {
            var m1 = new Matrix(1, 1);
            var m2 = new Matrix(1, 1);
            m1[0, 0] = 2;
            m2[0, 0] = 2;
            var m3 = m1 * m2;
            var check = new Matrix(1, 1);
            check[0, 0] = 4;
            Assert.AreEqual(check, m3);
        }
        [Test]
        public void MultipleEonE()
        {
            var e1 = new Matrix(3, 3);
            e1[0, 0] = 1;
            e1[1, 1] = 1;
            e1[2, 2] = 1;
            Assert.AreEqual(e1 * e1, e1);
        }
        [Test]
        public void DifferentSize()
        {
            var first = new Matrix(3, 2);
            var second = new Matrix(1, 3);
            first[0, 0] = 2;
            first[1, 0] = 1;
            first[1, 1] = 1;
            second[0, 0] = 3;
            second[0, 1] = 4;
            second[0, 2] = 5;
            var result = new Matrix(1, 2);
            result[0, 0] = 10;
            result[0, 1] = 4;
            Assert.AreEqual(result, first * second);
        }
    }
}
