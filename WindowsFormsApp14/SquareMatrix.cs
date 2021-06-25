using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp14
{
    public class SquareMatrix : Matrix
    {
        public int Size { get; }
        public SquareMatrix(int x, int y) : base(x, y)
        {
            Size = x;
        }
        public SquareMatrix(int size)
        {
            Size = size;
            Content = new Matrix(size, size).Content;
        }
        public SquareMatrix GetMinor(int x, int y)
        {
            var result = new SquareMatrix(Size - 1);
            for (int xx = 0; xx < Size; xx++)
            {
                if (x == xx) continue;
                var plusX = 0;
                if (xx > x) plusX = xx - 1;
                else plusX = xx;
                for (int yy = 0; yy < Size; yy++)
                {
                    var plusY = 0;
                    if (y == yy) continue;
                    if (yy > y) plusY = yy - 1;
                    else plusY = yy;
                    result.Content[plusX, plusY] = Content[xx, yy];
                }
            }
            return result;
        }
        public double GetDeterminant()
        {
            if (Size == 1)
            {
                return this[0, 0];
            }
            var result = 0d;
            for (int x = 0; x < Size; x++)
            {
                var y = 0;
                if ((x + y) % 2 == 0)
                {
                    result = result + this[x, y] * GetMinor(x, y).GetDeterminant();
                }
                else
                {
                    result = result - this[x, y] * GetMinor(x, y).GetDeterminant();
                }
            }
            return result;
        }
    }
}
